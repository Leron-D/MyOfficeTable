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
        public EvaluationСriteriasForm()
        {
            InitializeComponent();
            webBrowser.Navigate(Directory.GetCurrentDirectory() + @"\Lections\EvaulationCriterias.html");
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
            SelectActionForm form = new SelectActionForm();
            form.ShowDialog();
            Close();
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
    }
}
