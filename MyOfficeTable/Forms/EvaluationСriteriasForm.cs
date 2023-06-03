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

namespace MyOfficeTable
{
    public partial class EvaluationСriteriasForm : Form
    {
        string file = "";
        int num = 0;
        bool loadForm = true;

        public EvaluationСriteriasForm(int numberOfQuestions = 0, string fileName = "")
        {
            InitializeComponent();

            num = numberOfQuestions;

            file = fileName;

            if (Settings.Default.goFromTheory)
                goToTestButton.Visible = goBackButton.Visible = true;
            else
                goToTestButton.Visible = goBackButton.Visible = false;

            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(minimizeButton, "Свернуть");
            toolTip.SetToolTip(cancelButton, "Закрыть");
            webBrowser.Navigate(Directory.GetCurrentDirectory() + @"\Tests\EvaulationCriterias.html");
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (!Settings.Default.goFromTheory)
                Close();
            else
                GoToForm(new MainForm());
        }

        private void GoToTestButton_Click(object sender, EventArgs e)
        {
            if (file != "")
                GoToForm(new TestForm(file, num));
        }

        void GoToForm(Form form)
        {
            Hide();
            form.ShowDialog();
            Close();
        }

        private void EvaluationСriteriasForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.goFromTheory = false;
            Settings.Default.Save();
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            GoToForm(new TheoryForm($@"{Directory.GetCurrentDirectory()}\Lections\{Path.GetFileNameWithoutExtension(file)}.html"));
        }
    }
}
