//------------------------------------------------------------------------------
// <copyright file="APToolsCommand.cs" company="Company">
//     Copyright (c) Company.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel.Design;
using System.Globalization;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using AgilePointTools_VSPackage.APTools.GenerateHTMLAssets;
using EnvDTE80;
using EnvDTE;
using System.Diagnostics;
using AgilePointTools_VSPackage.APTools;
using AgilePointTools.APTools.GenerateShapeProperties;

namespace AgilePointTools_VSPackage
{
    /// <summary>
    /// Command handler
    /// </summary>
    internal sealed class APToolsCommand
    {
        /// <summary>
        /// Command ID.
        /// </summary>
        public const int AP_TOOLS_CMD_GEN_HTML = 0x0300;
        public const int AP_TOOLS_CMD_GEN_SHAPE_PROPS = 0x0301;

        /// <summary>
        /// Command menu group (command set GUID).
        /// </summary>
        public static readonly Guid AP_TOOLS_CMDSET = new Guid("eb112e9c-b5f6-4ba9-b1a7-27b6312295fb");

        /// <summary>
        /// VS Package that provides this command, not null.
        /// </summary>
        private readonly Package package;

        private static DTE2 m_ApplicationObject;

        private static Window window = null;
        private static OutputWindowPane outputWindowPane = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="APToolsCommand"/> class.
        /// Adds our command handlers for menu (commands must exist in the command table file)
        /// </summary>
        /// <param name="package">Owner package, not null.</param>
        private APToolsCommand(Package package, DTE2 applicationObject)
        {
            if (package == null)
            {
                throw new ArgumentNullException("package");
            }

            this.package = package;
            m_ApplicationObject = applicationObject;

            OleMenuCommandService commandService = this.ServiceProvider.GetService(typeof(IMenuCommandService)) as OleMenuCommandService;
            if (commandService != null)
            {
                var genHTMLMenuCommand = new CommandID(AP_TOOLS_CMDSET, AP_TOOLS_CMD_GEN_HTML);
                var genHTMLMenuItem = new MenuCommand(this.GenerateHTMLAssetsCallback, genHTMLMenuCommand);
                commandService.AddCommand(genHTMLMenuItem);

                var genShapePropsMenuCommand = new CommandID(AP_TOOLS_CMDSET, AP_TOOLS_CMD_GEN_SHAPE_PROPS);
                var genShapePropsMenuItem = new MenuCommand(this.GenerateShapePropsCallback, genShapePropsMenuCommand);
                commandService.AddCommand(genShapePropsMenuItem);
            }
        }

        /// <summary>
        /// Gets the instance of the command.
        /// </summary>
        public static APToolsCommand Instance
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the service provider from the owner package.
        /// </summary>
        private IServiceProvider ServiceProvider
        {
            get
            {
                return this.package;
            }
        }

        /// <summary>
        /// Initializes the singleton instance of the command.
        /// </summary>
        /// <param name="package">Owner package, not null.</param>
        public static void Initialize(Package package, DTE2 applicationObject)
        {
            Instance = new APToolsCommand(package, applicationObject);
        }

        /// <summary>
        /// This function is the callback used to execute the command when the menu item is clicked.
        /// See the constructor to see how the menu item is associated with this function using
        /// OleMenuCommandService service and MenuCommand class.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event args.</param>
        private void GenerateHTMLAssetsCallback(object sender, EventArgs e)
        {            
            IVsWindowFrame windowFrame = CreateToolWindow(ToolsName.GENERATEHTMLASSETS, Guid.NewGuid().ToString(), new HTMLAssetsUC());
            windowFrame.Show();
            InitializeOutputWindoPane(ToolsName.GENERATEHTMLASSETS);
            outputWindowPane.Clear();
            //string message = string.Format(CultureInfo.CurrentCulture, "Inside {0}.MenuItemCallback()", this.GetType().FullName);
            //string title = "APToolsCommand";

            /*
            // Show a message box to prove we were here
            VsShellUtilities.ShowMessageBox(
                this.ServiceProvider,
                message,
                title,
                OLEMSGICON.OLEMSGICON_INFO,
                OLEMSGBUTTON.OLEMSGBUTTON_OK,
                OLEMSGDEFBUTTON.OLEMSGDEFBUTTON_FIRST);
                */
        }

        /// <summary>
        /// This function is the callback used to execute the command when the menu item is clicked.
        /// See the constructor to see how the menu item is associated with this function using
        /// OleMenuCommandService service and MenuCommand class.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event args.</param>
        private void GenerateShapePropsCallback(object sender, EventArgs e)
        {
            IVsWindowFrame windowFrame = CreateToolWindow(ToolsName.GENERATESHAPEPROPERTIES, Guid.NewGuid().ToString(), new ShapeProperties());
            windowFrame.Show();
            InitializeOutputWindoPane(ToolsName.GENERATESHAPEPROPERTIES);
            outputWindowPane.Clear();
            //string message = string.Format(CultureInfo.CurrentCulture, "Inside {0}.MenuItemCallback()", this.GetType().FullName);
            //string title = "APToolsCommand";

            /*
            // Show a message box to prove we were here
            VsShellUtilities.ShowMessageBox(
                this.ServiceProvider,
                message,
                title,
                OLEMSGICON.OLEMSGICON_INFO,
                OLEMSGBUTTON.OLEMSGBUTTON_OK,
                OLEMSGDEFBUTTON.OLEMSGDEFBUTTON_FIRST);
                */
        }

        private IVsWindowFrame CreateToolWindow(string caption, string guid, System.Windows.Forms.UserControl userControl)
        {
            const int TOOL_WINDOW_INSTANCE_ID = 0; // Single-instance toolwindow

            IVsWindowFrame windowFrame = null;
            IVsUIShell uiShell = (IVsUIShell)this.ServiceProvider.GetService(typeof(SVsUIShell)); ;

            Guid guidNull = Guid.Empty;
            Guid toolWindowPersistenceGuid = new Guid(guid);

            int result;
            int[] position = new int[1];

            result = uiShell.CreateToolWindow((uint)__VSCREATETOOLWIN.CTW_fInitNew,
                  TOOL_WINDOW_INSTANCE_ID, userControl, ref guidNull, ref toolWindowPersistenceGuid,
                  ref guidNull, null, caption, position, out windowFrame);

            Microsoft.VisualStudio.ErrorHandler.ThrowOnFailure(result);
            windowFrame.SetProperty((int)__VSFPROPID.VSFPROPID_FrameMode, VSFRAMEMODE.VSFM_MdiChild);// dock the stencil window;
            return windowFrame;
        }

        private void InitializeOutputWindoPane(string outputWindowPaneName)
        {
            window = m_ApplicationObject.Windows.Item(EnvDTE.Constants.vsWindowKindOutput);
            OutputWindow outputWindow = (OutputWindow)window.Object;

            foreach (OutputWindowPane opwp in outputWindow.OutputWindowPanes)
            {
                if (opwp.Name == outputWindowPaneName)
                {
                    outputWindowPane = opwp;
                }
            }
            outputWindowPane = (outputWindowPane == null) ? outputWindow.OutputWindowPanes.Add(outputWindowPaneName) : outputWindowPane;
        }

        public static void showOutputConsole(string response)
        {
            outputWindowPane.Activate();
            outputWindowPane.OutputString(Environment.NewLine + response);
            window.Activate();
        }
    }
}
