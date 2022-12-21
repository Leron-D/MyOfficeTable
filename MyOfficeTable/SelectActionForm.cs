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
    public partial class SelectActionForm : Form
    {
        private Point mouseOffset;
        private Point currentOffset;
        private bool isMouseDown = false;
        public SelectActionForm()
        {
            InitializeComponent();
        }

        private void CollapseButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Hide();
            MainForm form = new MainForm();
            form.ShowDialog();
            Close();
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            Hide();
            MainForm form = new MainForm();
            form.ShowDialog();
            Close();
        }

        private void SelectActionForm_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            mouseOffset = Cursor.Position;
            currentOffset = this.Location;
        }

        private void SelectActionForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(mouseOffset));
                this.Location = Point.Add(currentOffset, new Size(dif));
            }
        }

        private void SelectActionForm_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            SelectTestForm form = new SelectTestForm();
            form.ShowDialog();
            Close();
        }
    }
}
