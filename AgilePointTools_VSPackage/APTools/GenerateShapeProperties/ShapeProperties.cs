using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgilePointTools_VSPackage.APTools;
using AgilePointTools_VSPackage;
using System.IO;

namespace AgilePointTools.APTools.GenerateShapeProperties
{
    public partial class ShapeProperties : UserControl
    {
        BackgroundWorker backGrndWorker;
        Dictionary<string, string> Configs = null;
        public ShapeProperties()
        {
            InitializeComponent();
            InitializeBackgroundWorker();
        }

        public void InitializeBackgroundWorker()
        {
            backGrndWorker = new BackgroundWorker();
            backGrndWorker.DoWork += backGrndWorker_DoWork;
            backGrndWorker.RunWorkerCompleted += backGrndWorker_RunWorkerCompleted;
        }

        private void ShapeProperties_Load(object sender, EventArgs e)
        {
            ToolHelper.ResetStatusTracker();
            Configs = ToolHelper.LoadConfiguration(ToolConfiguration.SHAPEPROPERTIES);
            txtSource.Text = Configs.ContainsKey(ToolConfiguration.SOURCE) ? Configs[ToolConfiguration.SOURCE] : "";
            txtArchiveDirectory.Text = Configs.ContainsKey(ToolConfiguration.ARCHIVEDIRECTORY) ? Configs[ToolConfiguration.ARCHIVEDIRECTORY] : "";            
        }

        private void PerformOpearion()
        {
            string SourceToot = txtSource.Text.Trim();                          //@"D:\TFS_Source\Main\Src\";
            string archiveDirectory = txtArchiveDirectory.Text.Trim();          //@"D:\TFS_Source\Main\Src\Common\Scripts\ShapeProperties";

            string[] SourceSubfolders = new string[] { "CEAI", "NXCore\\AgileExtender", "NXCore\\AgileParts", "NXCore\\AgileWorks" };
            if (!string.IsNullOrEmpty(SourceToot) && !string.IsNullOrEmpty(archiveDirectory))
            {
                if (Directory.Exists(archiveDirectory))
                {
                    ToolHelper.SetFilesAttributeAsNormal(archiveDirectory);
                    Directory.Delete(archiveDirectory, true);
                }
                Directory.CreateDirectory(archiveDirectory);

                foreach (string folder in SourceSubfolders)
                {
                    string ShapeProperties = Path.Combine(SourceToot, folder);
                    List<string> allFiles = new List<string>();
                    if (Directory.Exists(ShapeProperties))
                        allFiles = Directory.GetFiles(ShapeProperties, "*.xml", SearchOption.AllDirectories).ToList();

                    foreach (string currentFile in allFiles)
                    {
                        if (Path.GetFileName(Path.GetDirectoryName(currentFile)).ToLower() == "shapeproperties")
                        {
                            string fileName = Path.GetFileName(currentFile);
                            if (fileName == "7E6448C5846B4DBC9E92E341B7DB8D59_XML_AzureMachineLearning.xml")
                            {

                            }
                            //if(File.Exists(Path.Combine(archiveDirectory, fileName)))
                            //{
                            //    FileInfo fileinfo = new FileInfo(Path.Combine(archiveDirectory, fileName));
                            //    fileinfo.Attributes = FileAttributes.Normal;
                            //    File.Delete(Path.Combine(archiveDirectory, fileName));
                            //}
                            try
                            {
                                string fileToCopy = Path.Combine(archiveDirectory, fileName);
                                ToolHelper.statusTracker[Status.TOTALFILES] += 1;
                                File.Copy(currentFile, fileToCopy , true);
                                APToolsCommand.showOutputConsole(string.Format("{0} -----------------------------------------", fileToCopy));
                                ToolHelper.statusTracker[Status.SUCCEEDED] += 1;
                            }
                            catch (Exception ex)
                            {
                                ToolHelper.statusTracker[Status.FAILED] += 1;
                                APToolsCommand.showOutputConsole(ex.Message);
                            }
                        }
                    }
                }
            }
        }

        private void btnGenerateShapeProps_Click(object sender, EventArgs e)
        {
            btnGenerateShapeProps.Enabled = false;
            btnReset.Enabled = false;
            SaveConfiguration();
            backGrndWorker.RunWorkerAsync();
        }

        private void SaveConfiguration()
        {
            //if (Configs.ContainsKey(ToolConfiguration.SOURCEXML))
            //    Configs[ToolConfiguration.SOURCEXML] = txtSourceXML.Text.Trim();
            //if (Configs.ContainsKey(ToolConfiguration.HTMLSOURCE))
            //    Configs[ToolConfiguration.HTMLSOURCE] = txtHTMLSource.Text.Trim();
            //if (Configs.ContainsKey(ToolConfiguration.HTMLASSETSDESTINATION))
            //    Configs[ToolConfiguration.HTMLASSETSDESTINATION] = txtHTMLDestination.Text.Trim();
            ToolHelper.UpdateConfiguration(ToolConfiguration.HTMLASSETS, Configs);
        }

        private void backGrndWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                PerformOpearion();
            }
            catch (Exception ex)
            {
                ToolHelper.statusTracker[Status.FAILED] += 1;
                APToolsCommand.showOutputConsole(ex.Message);
            }
        }

        private void backGrndWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnGenerateShapeProps.Enabled = true;
            btnReset.Enabled = true;
            if (ToolHelper.statusTracker != null)
            {
                string msg = string.Format("\n========== {0} Total Files, {1} succeeded, {2} failed ==========",
                    ToolHelper.statusTracker[Status.TOTALFILES], ToolHelper.statusTracker[Status.SUCCEEDED], ToolHelper.statusTracker[Status.FAILED]);
                APToolsCommand.showOutputConsole(msg);
            }
            ToolHelper.ResetStatusTracker();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSource.Text = "";
            txtArchiveDirectory.Text = "";
        }

        private void picBoxFolderDialog_Source_Click(object sender, EventArgs e)
        {
            txtSource.Text = ToolHelper.GetSeletctedFolderPath(txtSource.Text.Trim());
        }

        private void picBoxFolderDialog_ArchiveDir_Click(object sender, EventArgs e)
        {
            txtArchiveDirectory.Text = ToolHelper.GetSeletctedFolderPath(txtArchiveDirectory.Text.Trim());
        }

    }
}
