using MyOfficeTable.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyOfficeTable
{
    public partial class MainForm : Form
    {
        private Point mouseOffset;
        private Point currentOffset;
        private bool isMouseDown = false;
        
        public MainForm()
        {
            InitializeComponent();
            if(Properties.Settings.Default.IsFirstLoad)
            {
                Animator.Start();
                Properties.Settings.Default.IsFirstLoad = false;
                Properties.Settings.Default.Save();
            }
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(referenceButton, "Справка о программе");
            toolTip.SetToolTip(minimizeButton, "Свернуть");
            toolTip.SetToolTip(cancelButton, "Закрыть");
            headerLabel.Left = (ClientSize.Width - headerLabel.Width) / 2;
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            mouseOffset = Cursor.Position;
            currentOffset = this.Location;
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(mouseOffset));
                this.Location = Point.Add(currentOffset, new Size(dif));
            }
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void ReferenceButton_Click(object sender, EventArgs e)
        {
            ReferenceForm form = new ReferenceForm();
            form.ShowDialog();
        }

        private void TheoryButton_Click(object sender, EventArgs e)
        {
            GoToSelectTheme("Теория");
        }

        private void TestingButton_Click(object sender, EventArgs e)
        {
            GoToSelectTheme("Тестирование");
        }

        private void GoToSelectTheme(string mode)
        {
            GoToForm(new SelectThemeForm(mode));
        }

        private void InteractiveTasksButton_Click(object sender, EventArgs e)
        {
            GoToForm(new SelectThemeForm("Интерактивные задания"));
        }

        void GoToForm(Form form)
        {
            Hide();
            form.ShowDialog();
            Close();
        }
    }
}
