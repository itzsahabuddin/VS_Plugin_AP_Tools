using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using EnvDTE;

namespace AgilePointTools_VSPackage.APTools.GenerateHTMLAssets
{
    public partial class HTMLAssetsUC : UserControl
    {
        BackgroundWorker backGrndWorker;
        string response = string.Empty;
        Dictionary<string, string> Configs = null;
        public HTMLAssetsUC()
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

        private void HTMLAssetsUC_Load(object sender, EventArgs e)
        {
            ToolHelper.ResetStatusTracker();
            Configs = ToolHelper.LoadConfiguration(ToolConfiguration.HTMLASSETS);
            txtSourceXML.Text = Configs.ContainsKey(ToolConfiguration.SOURCEXML) ? Configs[ToolConfiguration.SOURCEXML] : "";
            txtHTMLSource.Text = Configs.ContainsKey(ToolConfiguration.HTMLSOURCE) ? Configs[ToolConfiguration.HTMLSOURCE] : "";
            txtHTMLDestination.Text = Configs.ContainsKey(ToolConfiguration.HTMLASSETSDESTINATION) ? Configs[ToolConfiguration.HTMLASSETSDESTINATION] : "";
        }

        private void btnGenerateHTMLAssets_Click(object sender, EventArgs e)
        {
            btnGenerateHTMLAssets.Enabled = false;
            btnReset.Enabled = false;
            SaveConfiguration();      
            backGrndWorker.RunWorkerAsync();
        }

        private void SaveConfiguration()
        {
            if (Configs.ContainsKey(ToolConfiguration.SOURCEXML))
                Configs[ToolConfiguration.SOURCEXML] = txtSourceXML.Text.Trim();
            if (Configs.ContainsKey(ToolConfiguration.HTMLSOURCE))
                Configs[ToolConfiguration.HTMLSOURCE] = txtHTMLSource.Text.Trim();
            if (Configs.ContainsKey(ToolConfiguration.HTMLASSETSDESTINATION))
                Configs[ToolConfiguration.HTMLASSETSDESTINATION] = txtHTMLDestination.Text.Trim();
            ToolHelper.UpdateConfiguration(ToolConfiguration.HTMLASSETS, Configs);
        }

        private void backGrndWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string sourceXML = txtSourceXML.Text.Trim();
            string source = txtHTMLSource.Text.Trim();
            string destination = txtHTMLDestination.Text.Trim();
            try
            {
                if (Directory.Exists(destination))
                {
                    ToolHelper.SetFilesAttributeAsNormal(destination);
                    Directory.Delete(destination, true);
                }

                Directory.CreateDirectory(destination);

                Util.GenerateHTMLAssets(sourceXML, source, destination);
            }
            catch (Exception ex)
            {
                APToolsCommand.showOutputConsole(ex.Message);
            }
        }

        private void backGrndWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnGenerateHTMLAssets.Enabled = true;
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
            txtSourceXML.Text = "";
            txtHTMLSource.Text = "";
            txtHTMLDestination.Text = "";
        }

        private void picBoxFileDialog_Click(object sender, EventArgs e)
        {
            txtSourceXML.Text = ToolHelper.GetSeletctedFilePath(txtSourceXML.Text.Trim());
        }

        private void picBoxFolderDialog_HTMLSource_Click(object sender, EventArgs e)
        {
            txtHTMLSource.Text = ToolHelper.GetSeletctedFolderPath(txtHTMLSource.Text.Trim());
        }

        private void picBox_HTMLAssestsDesti_Click(object sender, EventArgs e)
        {
            txtHTMLDestination.Text = ToolHelper.GetSeletctedFolderPath(txtHTMLDestination.Text.Trim());
        }
    }
}
