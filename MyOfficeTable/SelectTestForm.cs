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
    public partial class SelectTestForm : Form
    {
        private Point mouseOffset;
        private Point currentOffset;
        private bool isMouseDown = false;
        public SelectTestForm()
        {
            InitializeComponent();
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(collapseButton, "Свернуть");
            toolTip.SetToolTip(cancelButton, "Закрыть");
            AddItemsToComboBox();
        }

        void AddItemsToComboBox()
        {
            var items = Directory.GetFiles(Directory.GetCurrentDirectory() + @"\Tests", "*.xml");
            foreach(var file in items)
            {
                selectThemeComboBox.Items.Add(Path.GetFileNameWithoutExtension(file));
            }
            selectThemeComboBox.SelectedIndex = 0;
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            Hide();
            MainForm form = new MainForm();
            form.ShowDialog();
            Close();
        }
        private void CollapseButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GoToTestButton_Click(object sender, EventArgs e)
        {
            try
            {
                Hide();
                TestForm form = new TestForm(Directory.GetCurrentDirectory() + $@"\Tests\{selectThemeComboBox.SelectedItem}.xml");
                form.ShowDialog();
                Close();
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
            Hide();
            EvaluationСriteriasForm form = new EvaluationСriteriasForm();
            form.ShowDialog();
            Close();
        }
    }
}
