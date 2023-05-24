using MyOfficeTable.Forms;
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
        private Point mouseOffset;
        private Point currentOffset;
        private bool isMouseDown = false;
        string file = "";
        int num = 0;

        public EvaluationСriteriasForm(int numberOfQuestions = 0, string fileName = "")
        {
            InitializeComponent();

            num = numberOfQuestions;

            file = fileName;

            if (Properties.Settings.Default.goFromTheory)
                goToTestButton.Visible = true;
            else
                goToTestButton.Visible = false;

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
            GoToForm(new MainForm());
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            GoToForm(new SelectThemeForm("Тестирование"));
        }

        private void EvaluationCriteriasForm_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            mouseOffset = Cursor.Position;
            currentOffset = this.Location;
        }

        private void EvaluationCriteriasForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(mouseOffset));
                this.Location = Point.Add(currentOffset, new Size(dif));
            }
        }

        private void EvaluationCriteriasForm_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
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
            Properties.Settings.Default.goFromTheory = false;
            Properties.Settings.Default.Save();
        }
    }
}
