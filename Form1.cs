using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.JSInterop;

namespace SteamWishlistJSONToMarkdownBlazor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var services = new ServiceCollection();
            services.AddWindowsFormsBlazorWebView();
            blazorWebView1.HostPage = "wwwroot\\index.html";
            blazorWebView1.Services = services.BuildServiceProvider();
            blazorWebView1.RootComponents.Add<Index>("#app");
        }

        public string ShowSaveFileDialog(string defaultExt, string filter)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.DefaultExt = defaultExt;
                saveFileDialog.Filter = filter;
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return saveFileDialog.FileName;
                }

                return null;
            }
        }

        [JSInvokable]
        public static string ShowSaveFileDialogStatic(string defaultExt, string filter)
        {
            return ((Form1)Application.OpenForms[0]).ShowSaveFileDialog(defaultExt, filter);
        }
    }
}
