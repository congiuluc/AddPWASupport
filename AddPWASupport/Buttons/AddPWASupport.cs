using AddPWASupport.Models;
using AddPWASupport.Shared;
using EnvDTE;
using Microsoft.VisualStudio.Shell;
using Newtonsoft.Json;
using System;
using System.ComponentModel.Design;
using System.IO;
using Task = System.Threading.Tasks.Task;

namespace AddPWASupport
{
    /// <summary>
    /// Command handler
    /// </summary>
    internal sealed class AddPWASupport
    {
        /// <summary>
        /// Command ID.
        /// </summary>
        public const int CommandId = 0x0100;

        /// <summary>
        /// Command menu group (command set GUID).
        /// </summary>
        public static readonly Guid CommandSet = new Guid("2b1b1edc-374e-45b1-a0df-7550537cee89");

        /// <summary>
        /// VS Package that provides this command, not null.
        /// </summary>
        private readonly AsyncPackage package;
        private Project _project;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddPWASupport"/> class.
        /// Adds our command handlers for menu (commands must exist in the command table file)
        /// </summary>
        /// <param name="package">Owner package, not null.</param>
        /// <param name="commandService">Command service to add command to, not null.</param>
        private AddPWASupport(AsyncPackage package, OleMenuCommandService commandService)
        {
            this.package = package ?? throw new ArgumentNullException(nameof(package));
            commandService = commandService ?? throw new ArgumentNullException(nameof(commandService));

            var menuCommandID = new CommandID(CommandSet, CommandId);
            var menuItem = new OleMenuCommand(this.Execute, menuCommandID);
            menuItem.BeforeQueryStatus += BeforeQueryStatus;
            commandService.AddCommand(menuItem);
        }


        private void BeforeQueryStatus(object sender, EventArgs e)
        {
            var button = (OleMenuCommand)sender;
            button.Enabled = button.Visible = false;

            _project = VsHelpers.DTE.SelectedItems.Item(1)?.Project;

            if (_project != null && VsHelpers.IsWebProject(_project))
            {
                string webroot = _project?.GetWebRootFolder();

                if (string.IsNullOrEmpty(webroot))
                    return;

                string templateFile = Path.Combine(webroot, "manifest.json");
                string serviceWorkerFile = Path.Combine(webroot, "sw.js");

                button.Enabled = button.Visible = (!File.Exists(templateFile) || !File.Exists(serviceWorkerFile));
            }
        }

        /// <summary>
        /// Gets the instance of the command.
        /// </summary>
        public static AddPWASupport Instance
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the service provider from the owner package.
        /// </summary>
        private Microsoft.VisualStudio.Shell.IAsyncServiceProvider ServiceProvider
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
        public static async Task InitializeAsync(AsyncPackage package)
        {
            // Switch to the main thread - the call to AddCommand in AddPWASupport's constructor requires
            // the UI thread.
            await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync(package.DisposalToken);

            OleMenuCommandService commandService = await package.GetServiceAsync((typeof(IMenuCommandService))) as OleMenuCommandService;
            Instance = new AddPWASupport(package, commandService);
        }

        /// <summary>
        /// This function is the callback used to execute the command when the menu item is clicked.
        /// See the constructor to see how the menu item is associated with this function using
        /// OleMenuCommandService service and MenuCommand class.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event args.</param>
        private void Execute(object sender, EventArgs e)
        {
            ThreadHelper.ThrowIfNotOnUIThread();
            PWAManifest manifest = new PWAManifest()
            {
                name = _project.Name,
                short_name = "PWA APP",
                background_color = "#3367D6",
                theme_color = "#3367D6",
                display = "standalone",
                start_url = "/",
                scope = "/"
            };
            manifest.SetDeafultIcons();
            // string json = Newtonsoft.Json.JsonConvert.SerializeObject(manifest);
            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.NullValueHandling = NullValueHandling.Ignore;
            var json = JsonConvert.SerializeObject(manifest, settings);


            if (string.IsNullOrEmpty(json))
            {
                System.Diagnostics.Debug.Write("Could not generate the template");
                return;
            }

            string root = _project.GetRootFolder();
            string webroot = _project.GetWebRootFolder();

            string templateFile = Path.Combine(webroot, "manifest.json");
            string folder = Path.GetDirectoryName(templateFile);

            Directory.CreateDirectory(folder);
            File.WriteAllText(templateFile, json);

            string layoutRazorPages = Path.Combine(root, "Pages\\Shared\\_layout.cshtml");
            string layoutMvcPages = Path.Combine(root, "Views\\Shared\\_layout.cshtml");
            string layout = Path.Combine(root, "index.html");
            string script = System.IO.File.ReadAllText(VsHelpers.GetFileInVsix($"Resources\\script.js"));
            string html="";
            string masterPage="";
            if (System.IO.File.Exists(layoutRazorPages))
            {
                masterPage = layoutRazorPages;
            }
            else if (System.IO.File.Exists(layoutMvcPages))
            {
                masterPage = layoutMvcPages;
            }
            else if (System.IO.File.Exists(layout))
            {
                masterPage = layout;
            }

            if (!string.IsNullOrWhiteSpace(masterPage)) {

                html = System.IO.File.ReadAllText(masterPage);
                if (html.IndexOf("navigator.serviceWorker.register('sw.js',") == -1)
                {
                    html = html.Replace("</head>", string.Format("<script>{0}</script></head>", script));
                }

                if (html.IndexOf("<link rel=\"manifest\" href=\"/manifest.json\">") == -1)
                {
                    html = html.Replace("</head>", "<link rel=\"manifest\" href=\"/manifest.json\"></head>");
                }
                if (html.IndexOf("<meta name=\"theme-color\" content=\"#317EFB\">") == -1)
                {
                    html = html.Replace("</head>", "<meta name=\"theme-color\" content=\"#317EFB\"></head>");
                }
                System.IO.File.WriteAllText(masterPage, html);
            }


            //service worker
            if (!File.Exists(Path.Combine(webroot, "sw.js"))) {
                string source = VsHelpers.GetFileInVsix($"Resources\\sw.js");
                System.IO.File.Copy(source, Path.Combine(webroot, "sw.js"));
            }

            VsHelpers.OpenFileAndRefresh(templateFile);

        }
    }
}
