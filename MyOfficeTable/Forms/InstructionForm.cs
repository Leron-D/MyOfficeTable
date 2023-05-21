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

namespace MyOfficeTable.Forms
{
    public partial class InstructionForm : Form
    {
        private Point mouseOffset;
        private Point currentOffset;
        private bool isMouseDown = false;

        public InstructionForm()
        {
            InitializeComponent();
            if (Properties.Settings.Default.firstLoadInstruction)
            {
                goNextButton.Visible = true;
            }
            else
            {
                goNextButton.Visible = false;
                Size = new Size(Size.Width, 700);
            }
            goNextButton.Left = (ClientSize.Width - goNextButton.Width) / 2;
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.firstLoadInstruction)
            {
                var message = MessageBox.Show("Вы точно хотите выйти?", "Выход из задания", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (message == DialogResult.Yes)
                {
                    MainForm form = new MainForm();
                    Hide();
                    form.ShowDialog();
                    Close();
                }
            }
            else
                Close();
        }

        private void InteractiveTaskForm_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            mouseOffset = Cursor.Position;
            currentOffset = this.Location;
        }

        private void InteractiveTaskForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(mouseOffset));
                this.Location = Point.Add(currentOffset, new Size(dif));
            }
        }

        private void InteractiveTaskForm_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void GoNextButton_Click(object sender, EventArgs e)
        {
            LoadInteractiveTask();
        }

        private void LoadInteractiveTask()
        {
            InteractiveTaskForm form = new InteractiveTaskForm("Интерактивные задания");
            Hide();
            form.ShowDialog();
            Close();
        }
    }
}
