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
    public partial class SelectThemeForm : Form
    {
        bool selectMode;
        private Point mouseOffset;
        private Point currentOffset;
        private bool isMouseDown = false;
        public SelectThemeForm(bool mode)
        {
            InitializeComponent();
            //headerLabel.Left = (ClientSize.Width - headerPictureBox.Width) / 2;
            transitionButton.Left = goToEvaluationCriteriasButton.Left = (ClientSize.Width - transitionButton.Width) / 2;
            selectMode = mode;
            if(!mode)
            {
                transitionButton.Text = "Перейти к лекции";
                goToEvaluationCriteriasButton.Visible = false;
            }
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(minimizeButton, "Свернуть");
            toolTip.SetToolTip(cancelButton, "Закрыть");
            AddItemsToComboBox();
        }

        void AddItemsToComboBox()
        {
            try
            {
                if (selectMode)
                {
                    var items = Directory.GetFiles(Directory.GetCurrentDirectory() + @"\Tests", "*.xml");
                    foreach (var file in items)
                    {
                        selectThemeComboBox.Items.Add(Path.GetFileNameWithoutExtension(file));
                    }
                    selectThemeComboBox.SelectedIndex = 0;
                }
                else
                {
                    var items = Directory.GetFiles(Directory.GetCurrentDirectory() + @"\Lections", "*.html");
                    foreach (var file in items)
                    {
                        selectThemeComboBox.Items.Add(Path.GetFileNameWithoutExtension(file));
                    }
                    selectThemeComboBox.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            GoToForm(new MainForm());
        }
        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TransitionButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectMode)
                {
                    GoToForm(new TestForm(Directory.GetCurrentDirectory() + $@"\Tests\{selectThemeComboBox.SelectedItem}.xml"));
                }
                else
                {
                    GoToForm(new TheoryForm(Directory.GetCurrentDirectory() + $@"\Lections\{selectThemeComboBox.SelectedItem}.html"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SelectTestForm_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            mouseOffset = Cursor.Position;
            currentOffset = this.Location;
        }

        private void SelectTestForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(mouseOffset));
                this.Location = Point.Add(currentOffset, new Size(dif));
            }
        }

        private void SelectTestForm_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void GoToEvaulationCriterias_Click(object sender, EventArgs e)
        {
            GoToForm(new EvaluationСriteriasForm());
        }
        
        void GoToForm(Form form)
        {
            Hide();
            form.ShowDialog();
            Close();
        }
    }
}
