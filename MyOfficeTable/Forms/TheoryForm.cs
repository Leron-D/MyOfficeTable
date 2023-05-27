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
    public partial class TheoryForm : Form
    {
        bool isCollapsed = false;
        string file;
        private Point mouseOffset;
        private Point currentOffset;
        private bool isMouseDown = false;
        ToolTip toolTip = new ToolTip();
        bool loadForm = true;

        public TheoryForm(string lection)
        {
            InitializeComponent();
            LoadForm(lection);
        }

        private void LoadForm(string lection)
        {
            string fileTest = $@"{Directory.GetCurrentDirectory()}\Tests\{Path.GetFileNameWithoutExtension(lection)}.xml";
            if (!File.Exists(fileTest))
            {
                testingButton.Visible = false;
            }
            else
            {
                testingButton.Visible = true;
            }
            headerLabel.Left = (ClientSize.Width - headerLabel.Width) / 2;
            file = lection;
            toolTip.SetToolTip(minimizeButton, "Свернуть");
            toolTip.SetToolTip(cancelButton, "Закрыть");
            toolTip.SetToolTip(changeSizePanelButton, "Свернуть панель");
            InitialWebView();

            if (Settings.Default.isFullSize)
            {
                loadForm = false;
                WindowState = FormWindowState.Maximized;
                changeWindowBoxButton.Tag = "Normalscreen";
                changeWindowBoxButton.Image = Resources.NormalScreen;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                changeWindowBoxButton.Tag = "Fullscreen";
                changeWindowBoxButton.Image = Resources.Fullscreen;
            }
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
            GoToForm(new SelectThemeForm("Теория"));
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
                Settings.Default.goFromTheory = true;
                Settings.Default.Save();
                GoToForm(new EvaluationСriteriasForm(0, fileName));
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

        private void ChangeSizePanelButton_Click(object sender, EventArgs e)
        {
            if(changeSizePanelButton.Tag == "Свернуть")
            {
                isCollapsed = false;
            }
            else
            {
                isCollapsed = true;
            }
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (!isCollapsed)
            {
                if (leftPanel.Width > 0)
                {
                    leftPanel.Width -= 29;
                    rightPanel.Left -= 29;
                    rightPanel.Width += 29;
                }
                else
                {
                    timer.Stop();
                    changeSizePanelButton.Image = Resources.Expand;
                    changeSizePanelButton.Tag = "Развернуть";
                    toolTip.SetToolTip(changeSizePanelButton, "Развернуть панель");
                }
            }
            else
            {
                if (leftPanel.Width < 290)
                {
                    leftPanel.Width += 29;
                    rightPanel.Left += 29;
                    rightPanel.Width -= 29;
                }
                else
                {
                    timer.Stop();
                    changeSizePanelButton.Image = Resources.Collapse;
                    changeSizePanelButton.Tag = "Свернуть";
                    toolTip.SetToolTip(changeSizePanelButton, "Свернуть панель");
                }
            }
        }

        private void СhangeWindowBoxButton_Click(object sender, EventArgs e)
        {
            loadForm = false;
            if (changeWindowBoxButton.Tag == "Fullscreen")
            {
                Settings.Default.isFullSize = true;
                this.WindowState = FormWindowState.Maximized;
                changeWindowBoxButton.Tag = "NormalScreen";
                changeWindowBoxButton.Image = Resources.NormalScreen;
            }
            else
            {
                Settings.Default.isFullSize = false;
                this.WindowState = FormWindowState.Normal;
                changeWindowBoxButton.Tag = "Fullscreen";
                changeWindowBoxButton.Image = Resources.Fullscreen;
            }
            CenterToScreen();
        }
    }
}
