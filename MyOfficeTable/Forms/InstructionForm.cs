using MyOfficeTable.Forms;
using MyOfficeTable.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                await webBrowser.EnsureCoreWebView2Async(null);
                webBrowser.CoreWebView2.Navigate($"{Directory.GetCurrentDirectory()}/Guide/Guide.html");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangeWindowBoxButton_Click(object sender, EventArgs e)
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

        private void СloseButton_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
