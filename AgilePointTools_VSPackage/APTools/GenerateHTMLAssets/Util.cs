using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace AgilePointTools_VSPackage.APTools.GenerateHTMLAssets
{
    public static class Util
    {
        static string response = string.Empty;
        public static void GenerateHTMLAssets(string sourceXML, string source, string destination)
        {
            response = string.Empty;
            if (File.Exists(sourceXML))
            {
                #region getXMLMAppings
                Assets assets = new Assets();
                List<HTMLAsset> ListXMLMappings = new List<HTMLAsset>();
                XmlSerializer xmlSerializer = new XmlSerializer(assets.GetType());
                try
                {
                    using (StreamReader sr = new StreamReader(sourceXML, true))
                    {
                        XDocument xdoc = XDocument.Load(sr);

                        using (TextReader reader = new StringReader(xdoc.ToString()))
                        {
                            assets = (Assets)xmlSerializer.Deserialize(reader);
                        }
                    }
                    ListXMLMappings = assets.HTMLAsset;
                }
                catch (Exception ex)
                {
                    //response = "Something went wrong with the Source XML " + sourceXML + " file please have a look at the XML" + ex;
                    throw new Exception("Something went wrong with the Source XML " + sourceXML + " file please have a look at the XML" + ex);
                }

                #endregion getXMLMAppings          

                string[] AllFolders = Directory.GetDirectories(source);
                foreach (string folder in AllFolders)
                {
                    ToolHelper.statusTracker[Status.TOTALFILES] += Directory.GetFiles(folder, "*", SearchOption.AllDirectories).Length;
                    response = GenerateRecursive(folder, ListXMLMappings, destination);
                    if (!string.IsNullOrEmpty(response))
                        APToolsCommand.showOutputConsole(response);
                }

            }           
        }

        public static string GenerateRecursive(string srcfolder, List<HTMLAsset> ListXMLMappings, string destination)
        {
            try
            {
                string fodlerUpper = new DirectoryInfo(srcfolder).Name.ToUpper();
                if (fodlerUpper == "HTML" || fodlerUpper == "SCRIPTS" || fodlerUpper == "LOCALE")
                {
                    //TODO
                    if (fodlerUpper == "HTML")
                    {
                        response = GenerateHTMLFiles(srcfolder, ListXMLMappings, destination, response);
                    }
                    else if (fodlerUpper == "SCRIPTS")
                    {
                        response = GenerateScriptFiles(srcfolder, ListXMLMappings, destination, response);
                    }
                    else if (fodlerUpper == "LOCALE")
                    {
                        response = GenerateLocaleFiles(srcfolder, ListXMLMappings, destination, response);
                    }
                }
                else
                {
                    string[] AllFolders = Directory.GetDirectories(srcfolder);
                    foreach (string SUBfolder in AllFolders)
                    {
                        response = GenerateRecursive(SUBfolder, ListXMLMappings, destination);
                    }
                }
            }
            catch (Exception ex)
            {
                response = "Something went wrong " + ex;
            }
            return response;
        }

        public static string GenerateHTMLFiles(string folder, List<HTMLAsset> ListXMLMappings, string destination, string response)
        {
            try
            {

                string[] files = Directory.GetFiles(folder);

                foreach (string file in files)
                {
                    string fileName = Path.GetFileName(file).ToLower();
                    bool fileCreated = false;
                    foreach (HTMLAsset asset in ListXMLMappings)
                    {
                        if (fileName == asset.HTMLFileName.ToLower().Replace("shared_", string.Empty))
                        {
                            System.IO.File.Copy(file, Path.Combine(destination, asset.Element_ID + "_" + asset.HTMLFileName), true);
                            fileCreated = true;
                            ToolHelper.statusTracker[Status.SUCCEEDED] += 1;
                            break;
                        }
                    }
                    if (!fileCreated)
                    {
                        ToolHelper.statusTracker[Status.FAILED] += 1;
                        response += "File name and XML mapping not matched " + file;
                        response += "---------------------------------------\n";
                    }
                }
            }
            catch (Exception ex)
            {
                ToolHelper.statusTracker[Status.FAILED] += 1;
                response = "Something went wrong " + ex;
            }
            return response;
        }

        public static string GenerateScriptFiles(string folder, List<HTMLAsset> ListXMLMappings, string destination, string response)
        {
            try
            {

                string[] files = Directory.GetFiles(folder);

                foreach (string file in files)
                {
                    string fileName = Path.GetFileName(file).ToLower();
                    bool fileCreated = false;
                    foreach (HTMLAsset asset in ListXMLMappings)
                    {

                        if (fileName == asset.JSFileName.ToLower())
                        {
                            System.IO.File.Copy(file, Path.Combine(destination, asset.Element_ID + "_" + asset.JSFileName), true);
                            fileCreated = true;
                            ToolHelper.statusTracker[Status.SUCCEEDED] += 1;
                            break;
                        }
                    }
                    if (!fileCreated)
                    {
                        ToolHelper.statusTracker[Status.FAILED] += 1;
                        response += "File name and XML mapping not matched " + file;
                        response += "---------------------------------------\n";
                    }
                }
            }
            catch (Exception ex)
            {
                ToolHelper.statusTracker[Status.FAILED] += 1;
                response = "Something went wrong " + ex;
            }
            return response;
        }

        public static string GenerateLocaleFiles(string folder, List<HTMLAsset> ListXMLMappings, string destination, string response)
        {
            try
            {

                string[] AllLocaleFolders = Directory.GetDirectories(folder);
                foreach (string localefolder in AllLocaleFolders)
                {
                    string[] files = Directory.GetFiles(localefolder);

                    #region ja-JP creation
                    if (new DirectoryInfo(localefolder).Name.ToLower() == "ja")
                    {
                        //prepare ja-JP also there is no ja-JP files as of now in source folder

                        foreach (string file in files)
                        {
                            string fileName = Path.GetFileNameWithoutExtension(file).ToLower().Replace("translation", ".ja-JP.json");
                            if (fileName.ToLower().EndsWith(".ja"))
                                fileName = fileName.ToLower().Replace(".ja", ".ja-JP.json");
                            bool fileCreated = false;
                            foreach (HTMLAsset asset in ListXMLMappings)
                            {
                                foreach (string tempfile in asset.Localization.FileName)
                                {
                                    if (fileName.ToLower() == tempfile.ToLower())
                                    {
                                        try
                                        {
                                            System.IO.File.Copy(file, Path.Combine(destination, asset.Element_ID + "_" + tempfile), true);
                                            fileCreated = true;
                                            ToolHelper.statusTracker[Status.SUCCEEDED] += 1;
                                            break;
                                        }
                                        catch (Exception ex)
                                        {
                                            response += "Exception on ---- copy file " + file + Path.Combine(destination, asset.Element_ID + "_" + tempfile) + ex;
                                        }
                                    }
                                }
                            }
                            if (!fileCreated)
                            {
                                ToolHelper.statusTracker[Status.FAILED] += 1;
                                response += "File name and XML mapping not matched " + file;
                                response += "---------------------------------------\n";
                            }
                        }

                    }
                    #endregion
                    else
                    {
                        foreach (string file in files)
                        {
                            string fileName = string.Empty;
                            if (Path.GetFileNameWithoutExtension(file).ToLower().EndsWith("translation"))
                                fileName = Path.GetFileNameWithoutExtension(file).ToLower().Replace("translation", "." + new DirectoryInfo(localefolder).Name) + ".json".ToLower();
                            else if (Path.GetFileName(file).ToLower().EndsWith(new DirectoryInfo(localefolder).Name.ToLower() + ".json"))
                                fileName = Path.GetFileName(file).ToLower();
                            else
                                fileName = Path.GetFileName(file).ToLower().Replace(".json", new DirectoryInfo(localefolder).Name.ToLower() + ".json");
                            bool fileCreated = false;
                            foreach (HTMLAsset asset in ListXMLMappings)
                            {
                                foreach (string tempfile in asset.Localization.FileName)
                                {
                                    if (fileName.ToLower() == tempfile.ToLower())
                                    {
                                        try
                                        {
                                            System.IO.File.Copy(file, Path.Combine(destination, asset.Element_ID + "_" + tempfile), true);
                                            fileCreated = true;
                                            ToolHelper.statusTracker[Status.SUCCEEDED] += 1;
                                            break;
                                        }
                                        catch (Exception ex)
                                        {
                                            response += "Exception on ---- copy file " + file + Path.Combine(destination, asset.Element_ID + "_" + tempfile) + ex;
                                        }
                                    }
                                }
                            }
                            if (!fileCreated)
                            {
                                ToolHelper.statusTracker[Status.FAILED] += 1;
                                response += "File name and XML mapping not matched " + file;
                                response += "---------------------------------------\n";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ToolHelper.statusTracker[Status.FAILED] += 1;
                response = "Something went wrong " + ex;
            }
            return response;
        }

    }

    [XmlRoot("Assets")]
    public sealed class Assets
    {
        [XmlElement("HTMLAsset", Type = typeof(HTMLAsset))]
        public List<HTMLAsset> HTMLAsset { get; set; }
        public Assets()
        {
            HTMLAsset = new List<HTMLAsset>();
        }
    }

    public class HTMLAsset
    {
        [XmlElement("WebID")]
        public string Element_ID { get; set; }

        [XmlElement("HTMLFileName")]
        public string HTMLFileName { get; set; }

        [XmlElement("JSFileName")]
        public string JSFileName { get; set; }

        [XmlElement(ElementName = "Localization")]
        public Localization Localization { get; set; }

    }

    public class Localization
    {
        [XmlElement(ElementName = "FileName")]
        public List<string> FileName { get; set; }
    }
}
