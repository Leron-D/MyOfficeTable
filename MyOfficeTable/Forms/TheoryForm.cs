using Microsoft.Web.WebView2.Core;
using MyOfficeTable.Forms;
using MyOfficeTable.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyOfficeTable
{
    public partial class TheoryForm : StyleForm
    {
        public static TheoryForm _theoryForm;
        bool isCollapsed = false;
        string file;
        string testFileName;
        bool themeWithTest;
        ToolTip toolTip = new ToolTip();

        public TheoryForm(string lection, bool withTest, string nameOfTestTheme = null)
        {
            InitializeComponent();
            themeWithTest = withTest;
            testFileName = nameOfTestTheme;
            _theoryForm = this;
            leftPanel.Paint += LeftPanel_Paint;
            LoadForm(lection, nameOfTestTheme);
        }

        private void LoadForm(string lection, string nameOfTestTheme)
        {
            try
            {
                testFileName = $@"{Directory.GetCurrentDirectory()}\Tests\{Path.GetFileNameWithoutExtension(nameOfTestTheme)}.xml";
                if (themeWithTest)
                {
                    testingButton.Visible = true;
                }
                else
                {
                    testingButton.Visible = false;
                }
                headerLabel.Left = (ClientSize.Width - headerLabel.Width) / 2;
                file = lection;
                toolTip.SetToolTip(minimizeButton, "Свернуть");
                toolTip.SetToolTip(cancelButton, "Закрыть");
                toolTip.SetToolTip(changeSizePanelButton, "Свернуть панель");
                InitialWebView();

                if (Settings.Default.isFullSize)
                {
                    WindowState = FormWindowState.Maximized;
                    changeWindowBoxButton.Tag = "NormalScreen";
                    changeWindowBoxButton.Image = Resources.NormalScreen;
                }
                else
                {
                    WindowState = FormWindowState.Normal;
                    changeWindowBoxButton.Tag = "Fullscreen";
                    changeWindowBoxButton.Image = Resources.Fullscreen;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void InitialWebView()
        {
            try
            {
                var environment = await CoreWebView2Environment.CreateAsync(null, Program.TempFolder);
                await webBrowser.EnsureCoreWebView2Async(environment);
                webBrowser.CoreWebView2.Navigate(file);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GoToForm(Form form)
        {
            try
            {
                form.Show();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            try
            {
                GoToForm(new SelectThemeForm("Теория"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                GoToForm(new EvaluationСriteriasForm(0, themeWithTest, testFileName));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangeSizePanelButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (changeSizePanelButton.Tag == "Свернуть")
                {
                    isCollapsed = false;
                }
                else
                {
                    isCollapsed = true;
                }
                timer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            try
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
                    leftPanel.Invalidate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void СhangeWindowBoxButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (changeWindowBoxButton.Tag == "Fullscreen")
                {
                    Settings.Default.isFullSize = true;
                    WindowState = FormWindowState.Maximized;
                    changeWindowBoxButton.Tag = "NormalScreen";
                    changeWindowBoxButton.Image = Resources.NormalScreen;
                    if (testingButton.Visible == false)
                        goToLectionButton.Top = (leftPanel.Height - goToLectionButton.Height) / 2;
                    else
                    {
                        goToLectionButton.Top = (leftPanel.Height - goToLectionButton.Height) / 2 - 42;
                        testingButton.Top = goToLectionButton.Top + goToLectionButton.Height + 42;
                    }
                }
                else
                {
                    Settings.Default.isFullSize = false;
                    WindowState = FormWindowState.Normal;
                    changeWindowBoxButton.Tag = "Fullscreen";
                    changeWindowBoxButton.Image = Resources.Fullscreen;
                    if (testingButton.Visible == false)
                        goToLectionButton.Top = (leftPanel.Height - goToLectionButton.Height) / 2;
                    else
                    {
                        goToLectionButton.Top = (leftPanel.Height - goToLectionButton.Height) / 2 - 42;
                        testingButton.Top = goToLectionButton.Top + goToLectionButton.Height + 42;
                    }
                }
                leftPanel.Invalidate();
                CenterToScreen();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LeftPanel_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.Clear(leftPanel.Parent.BackColor);
                Control control = leftPanel;
                int radius = 30;
                using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
                {
                    path.AddLine(radius, 0, control.Width - radius, 0);
                    path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
                    path.AddLine(control.Width, radius, control.Width, control.Height - radius);
                    path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
                    path.AddLine(control.Width - radius, control.Height, radius, control.Height);
                    path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
                    path.AddLine(0, control.Height - radius, 0, radius);
                    path.AddArc(0, 0, radius, radius, 180, 90);
                    using (SolidBrush brush = new SolidBrush(control.BackColor))
                    {
                        e.Graphics.FillPath(brush, path);
                    }
                }
                if (testingButton.Visible == false)
                    goToLectionButton.Top = (leftPanel.Height - goToLectionButton.Height) / 2;
                else
                {
                    goToLectionButton.Top = (leftPanel.Height - goToLectionButton.Height) / 2 - 42;
                    testingButton.Top = goToLectionButton.Top + goToLectionButton.Height + 42;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TheoryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                var webViewProcessId = Convert.ToInt32(webBrowser.CoreWebView2.BrowserProcessId);
                var webViewProcess = Process.GetProcessById(webViewProcessId);
                webBrowser.Dispose();
                webViewProcess.WaitForExit(3000);
                Directory.Delete(Program.TempFolder, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
