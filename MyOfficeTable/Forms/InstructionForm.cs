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
            try
            {
                _instructionForm = this;
                webBrowser.Navigate(Path.Combine(Directory.GetCurrentDirectory(), "Guide", "Guide.html"));
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
            Hide();
        }
    }
}
