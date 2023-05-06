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
    public partial class TheoryForm : Form
    {
        string file;
        private Point mouseOffset;
        private Point currentOffset;
        private bool isMouseDown = false;
        public TheoryForm(string lection)
        {
            InitializeComponent();
            headerLabel.Left = (ClientSize.Width - headerLabel.Width) / 2;
            file = lection;
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(minimizeButton, "Свернуть");
            toolTip.SetToolTip(cancelButton, "Закрыть");
            InitialWebView();
        }

        async void InitialWebView()
        {
            try
            {
                await webBrowser.EnsureCoreWebView2Async(null);
                webBrowser.CoreWebView2.Navigate(file);
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

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            GoToForm(new SelectThemeForm(false));
        }

        private void TheoryForm_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            mouseOffset = Cursor.Position;
            currentOffset = this.Location;
        }

        private void TheoryForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(mouseOffset));
                this.Location = Point.Add(currentOffset, new Size(dif));
            }
        }

        private void TheoryForm_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void GoToLectionButton_Click(object sender, EventArgs e)
        {
            try
            {
                webBrowser.CoreWebView2.Navigate(file);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TestingButton_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = $@"{Directory.GetCurrentDirectory()}\Tests\{Path.GetFileNameWithoutExtension(file)}.xml";
                Properties.Settings.Default.goFromTheory = true;
                Properties.Settings.Default.Save();
                GoToForm(new EvaluationСriteriasForm(fileName));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void GoToForm(Form form)
        {
            Hide();
            form.ShowDialog();
            Close();
        }
    }
}
