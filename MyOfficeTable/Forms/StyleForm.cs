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
        ToolTip toolTip = new ToolTip();

        public StyleForm()
        {
            InitializeComponent();
            toolTip.SetToolTip(pictureBox2, "Справка о программе");
            toolTip.SetToolTip(guideButton, "Руководство пользователя");
        }

        private void StyleForm_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    isMouseDown = true;
                    mouseOffset = Cursor.Position;
                    currentOffset = this.Location;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StyleForm_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (isMouseDown)
                {
                    Point dif = Point.Subtract(Cursor.Position, new Size(mouseOffset));
                    this.Location = Point.Add(currentOffset, new Size(dif));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StyleForm_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
                MainForm._mainForm.Close();
                if (EvaluationСriteriasForm.evaluationСriteriasForm != null)
                {
                    EvaluationСriteriasForm.evaluationСriteriasForm.Close();
                }
                if (TheoryForm.theoryForm != null)
                {
                    TheoryForm.theoryForm.Close();
                }
                if (InstructionForm._instructionForm != null)
                {
                    InstructionForm._instructionForm.Close();
                }
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

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                if (ReferenceForm._referenceForm == null)
                {
                    ReferenceForm form = new ReferenceForm();
                    form.ShowDialog();
                }
                else
                {
                    ReferenceForm._referenceForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuideButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (InstructionForm._instructionForm == null)
                {
                    InstructionForm form = new InstructionForm();
                    form.ShowDialog();
                }
                else
                {
                    InstructionForm._instructionForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StyleForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                toolTip.SetToolTip(changeWindowBoxButton, "Свернуть в окно");
                headerLabel.Font = new Font(headerLabel.Font.Name, 32, headerLabel.Font.Style);
            }
            else
            {
                toolTip.SetToolTip(changeWindowBoxButton, "Развернуть");
                headerLabel.Font = new Font(headerLabel.Font.Name, 28, headerLabel.Font.Style);
            }
        }
    }
}
