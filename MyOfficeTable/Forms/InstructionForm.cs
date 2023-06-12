using Microsoft.Web.WebView2.Core;
using MyOfficeTable.Forms;
using MyOfficeTable.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyOfficeTable.Forms
{
    public partial class InstructionForm : StyleForm
    {
        public static InstructionForm _instructionForm;
        public InstructionForm()
        {
            InitializeComponent();
            _instructionForm = this;
            InitialWebView();
        }

        private async void InitialWebView()
        {
            try
            {
                var environment = await CoreWebView2Environment.CreateAsync(null, Program.TempFolder);
                await webBrowser.EnsureCoreWebView2Async(environment);
                webBrowser.CoreWebView2.Navigate($"{Directory.GetCurrentDirectory()}/Guide/Guide.html");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangeWindowBoxButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (changeWindowBoxButton.Tag == "Fullscreen")
                {
                    this.WindowState = FormWindowState.Maximized;
                    changeWindowBoxButton.Tag = "NormalScreen";
                    changeWindowBoxButton.Image = Resources.NormalScreen;
                }
                else
                {
                    this.WindowState = FormWindowState.Normal;
                    changeWindowBoxButton.Tag = "Fullscreen";
                    changeWindowBoxButton.Image = Resources.Fullscreen;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void СloseButton_Click(object sender, EventArgs e)
        {
            try
            {
                var webViewProcessId = Convert.ToInt32(webBrowser.CoreWebView2.BrowserProcessId);
                var webViewProcess = Process.GetProcessById(webViewProcessId);
                webBrowser.Dispose();
                webViewProcess.WaitForExit(3000);
                Directory.Delete(Program.TempFolder, true);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
