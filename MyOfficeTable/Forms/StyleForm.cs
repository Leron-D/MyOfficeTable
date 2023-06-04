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
    public partial class StyleForm : Form
    {
        private Point mouseOffset;
        private Point currentOffset;
        private bool isMouseDown = false;

        public StyleForm()
        {
            InitializeComponent();
        }

        private void StyleForm_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            mouseOffset = Cursor.Position;
            currentOffset = this.Location;
        }

        private void StyleForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(mouseOffset));
                this.Location = Point.Add(currentOffset, new Size(dif));
            }
        }

        private void StyleForm_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
            MainForm.mainForm.Close();
            if (EvaluationСriteriasForm.evaluationСriteriasForm != null)
            {
                EvaluationСriteriasForm.evaluationСriteriasForm.Close();
            }
            if (TheoryForm.theoryForm != null)
            {
                TheoryForm.theoryForm.Close();
            }
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
