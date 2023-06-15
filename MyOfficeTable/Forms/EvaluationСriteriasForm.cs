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
    public partial class EvaluationСriteriasForm : StyleForm
    {
        public static EvaluationСriteriasForm _evaluationСriteriasForm;
        string fileOfTest = "";
        int num = 0;
        bool themeWithTest;

        public EvaluationСriteriasForm(int numberOfQuestions = 0, bool withTest = true, string themeOfTest = null)
        {
            InitializeComponent();
            try
            {
                themeWithTest = withTest;
                _evaluationСriteriasForm = this;

                num = numberOfQuestions;

                fileOfTest = themeOfTest;

                if (Settings.Default.goFromTheory)
                    goToTestButton.Visible = goBackButton.Visible = true;
                else
                    goToTestButton.Visible = goBackButton.Visible = false;

                ToolTip toolTip = new ToolTip();
                toolTip.SetToolTip(minimizeButton, "Свернуть");
                toolTip.SetToolTip(cancelButton, "Закрыть");
                webBrowser.Navigate(Directory.GetCurrentDirectory() + @"\Tests\EvaulationCriterias.html");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void GoToForm(Form form)
        {
            try
            {
                form.Show();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            if (!Settings.Default.goFromTheory)
                Close();
            else
            {
                MainForm._mainForm.Show();
                Hide();
            }
        }

        private void GoToTestButton_Click(object sender, EventArgs e)
        {
            if (fileOfTest != "")
                GoToForm(new TestForm(fileOfTest, num));
        }

        private void EvaluationСriteriasForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.goFromTheory = false;
            Settings.Default.Save();
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.goFromTheory = false;
                Settings.Default.Save();
                TheoryForm._theoryForm.Show();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
