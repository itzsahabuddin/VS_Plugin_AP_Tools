using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace AgilePointTools_VSPackage.APTools
{
    public static class ToolHelper
    {
        public static Dictionary<string, int> statusTracker = null;
        private static string ConfigFilePath = string.Empty;
        static ToolHelper()
        {
            string asseblyDir = Path.GetDirectoryName(typeof(ToolHelper).Assembly.Location);
            ConfigFilePath = Path.Combine(asseblyDir, "Configuration.xml");
            statusTracker = new Dictionary<string, int>();
            statusTracker.Add(Status.TOTALFILES, 0);
            statusTracker.Add(Status.SUCCEEDED, 0);
            statusTracker.Add(Status.FAILED, 0);
        }

        public static void ResetStatusTracker()
        {
            statusTracker[Status.TOTALFILES] = 0;
            statusTracker[Status.SUCCEEDED] = 0;
            statusTracker[Status.FAILED] = 0;
        }

        public static string GetSeletctedFilePath(string prevSelectedFile)
        {
            string selectedFile = prevSelectedFile;
            OpenFileDialog fileDialog = new OpenFileDialog();
            DialogResult dr = fileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                selectedFile = fileDialog.FileName;
            }
            return selectedFile;
        }

        public static string GetSeletctedFolderPath(string prevSelectedDir)
        {
            string selectedDir = prevSelectedDir;
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.SelectedPath = selectedDir;
            DialogResult dr = folderDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                selectedDir = folderDialog.SelectedPath;
            }
            return selectedDir;
        }

        public static void SetFilesAttributeAsNormal(string dirPath)
        {
            foreach (string filePath in Directory.GetFiles(dirPath, "*", SearchOption.AllDirectories))
                File.SetAttributes(filePath, FileAttributes.Normal);
        }

        public static Dictionary<string, string> LoadConfiguration(string xPath)
        {            
            Dictionary<string, string> configs = new Dictionary<string, string>();
            try
            {
                if (File.Exists(ConfigFilePath))
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load(ConfigFilePath);
                    foreach (XmlNode node in xmlDoc.SelectNodes(xPath))
                    {
                        foreach (XmlNode childNode in node.ChildNodes)
                        {
                            configs.Add(childNode.Name, childNode.InnerText);
                        }
                    }
                }
            }
            catch (Exception) { }
            return configs;
        }
        public static void UpdateConfiguration(string xPath, Dictionary<string, string> configs)
        {
            try
            {
                if (File.Exists(ConfigFilePath))
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load(ConfigFilePath);
                    foreach (XmlNode node in xmlDoc.SelectNodes(xPath))
                    {
                        foreach (XmlNode childNode in node.ChildNodes)
                        {
                            childNode.InnerText = configs.ContainsKey(childNode.Name) ? configs[childNode.Name] : "";
                        }
                    }
                    xmlDoc.Save(ConfigFilePath);
                }
            }
            catch (Exception) { }
        }

    }

    public static class ToolsName
    {
        public const string GENERATEHTMLASSETS = "Generate HTML Assets";
        public const string GENERATESHAPEPROPERTIES = "Generate Shape Properties";

    }

    public static class Status
    {
        public const string TOTALFILES = "TotalFiles";
        public const string SUCCEEDED = "Succeeded";
        public const string FAILED = "Failed";
    }

    public static class ToolConfiguration
    {
        //Generate HTML Assets
        public const string HTMLASSETS = "//HTMLAssets";
        public const string SOURCEXML = "SourceXML";
        public const string HTMLSOURCE = "HTMLSource";
        public const string HTMLASSETSDESTINATION = "HTMLAssetsDestination";

        //Generate Shape Properties
        public const string SHAPEPROPERTIES = "//ShapeProperties";
        public const string SOURCE = "Source";
        public const string ARCHIVEDIRECTORY = "ArchiveDirectory";
    }
}
