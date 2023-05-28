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
        private Point mouseOffset;
        private Point currentOffset;
        private bool isMouseDown = false;
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
            Settings.Default.goFromTheory = false;
            Settings.Default.Save();
        }

        private void ChangeWindowBoxButton_Click(object sender, EventArgs e)
        {
            //loadForm = false;
            //if (changeWindowBoxButton.Tag == "Fullscreen")
            //{
            //    Settings.Default.isFullSize = true;
            //    WindowState = FormWindowState.Maximized;
            //    changeWindowBoxButton.Tag = "NormalScreen";
            //    changeWindowBoxButton.Image = Resources.NormalScreen;
            //}
            //else
            //{
            //    Settings.Default.isFullSize = false;
            //    WindowState = FormWindowState.Normal;
            //    changeWindowBoxButton.Tag = "Fullscreen";
            //    changeWindowBoxButton.Image = Resources.Fullscreen;
            //}
            //CenterToScreen();
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            GoToForm(new TheoryForm($@"{Directory.GetCurrentDirectory()}\Lections\{Path.GetFileNameWithoutExtension(file)}.html"));
        }
    }
}
