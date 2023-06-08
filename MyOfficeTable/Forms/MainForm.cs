using MyOfficeTable.Forms;
using MyOfficeTable.Properties;
using MyOfficeTable.Support;
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
    public partial class MainForm : StyleForm
    {
        bool loadForm = true;
        public static MainForm _mainForm;
        ToolTip toolTip = new ToolTip();

        public MainForm()
        {
            InitializeComponent();
            try
            {
                _mainForm = this;
                if (Settings.Default.IsFirstLoad)
                {
                    Animator.Start();
                    Settings.Default.IsFirstLoad = false;
                    Settings.Default.Save();
                }
                toolTip.SetToolTip(minimizeButton, "Свернуть");
                toolTip.SetToolTip(cancelButton, "Закрыть");
                if (Settings.Default.isFullSize)
                {
                    loadForm = false;
                    WindowState = FormWindowState.Maximized;
                    changeWindowBoxButton.Tag = "Normalscreen";
                    changeWindowBoxButton.Image = Resources.NormalScreen;
                    toolTip.SetToolTip(changeWindowBoxButton, "Свернуть в окно");
                }
                else
                {
                    WindowState = FormWindowState.Normal;
                    changeWindowBoxButton.Tag = "Fullscreen";
                    changeWindowBoxButton.Image = Resources.Fullscreen;
                    toolTip.SetToolTip(changeWindowBoxButton, "Развернуть");
                }
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

        private void TheoryButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (SelectThemeForm._selectThemeForm != null)
                {
                    SelectThemeForm._selectThemeForm.Close();
                    GoToForm(new SelectThemeForm("Теория"));
                }
                else
                    GoToForm(new SelectThemeForm("Теория"));
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
                if (SelectThemeForm._selectThemeForm != null)
                {
                    SelectThemeForm._selectThemeForm.Close();
                    GoToForm(new SelectThemeForm("Тестирование"));
                }
                else
                    GoToForm(new SelectThemeForm("Тестирование"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InteractiveTasksButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (SelectThemeForm._selectThemeForm != null)
                {
                    SelectThemeForm._selectThemeForm.Close();
                    GoToForm(new SelectThemeForm("Интерактивные задания"));
                }
                else
                    GoToForm(new SelectThemeForm("Интерактивные задания"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangeWindowBoxButton_Click(object sender, EventArgs e)
        {
            try
            {
                loadForm = false;
                if (changeWindowBoxButton.Tag == "Fullscreen")
                {
                    Settings.Default.isFullSize = true;
                    WindowState = FormWindowState.Maximized;
                    changeWindowBoxButton.Tag = "NormalScreen";
                    changeWindowBoxButton.Image = Resources.NormalScreen;
                    toolTip.SetToolTip(changeWindowBoxButton, "Свернуть в окно");
                }
                else
                {
                    Settings.Default.isFullSize = false;
                    WindowState = FormWindowState.Normal;
                    changeWindowBoxButton.Tag = "Fullscreen";
                    changeWindowBoxButton.Image = Resources.Fullscreen;
                    toolTip.SetToolTip(changeWindowBoxButton, "Развернуть");
                }
                CenterToScreen();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (ReferenceForm._referenceForm != null)
                {
                    ReferenceForm._referenceForm.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            try
            {
                if (WindowState == FormWindowState.Maximized)
                {
                    changeWindowBoxButton.Tag = "NormalScreen";
                    changeWindowBoxButton.Image = Resources.NormalScreen;
                    toolTip.SetToolTip(changeWindowBoxButton, "Свернуть в окно");
                }
                else
                {
                    changeWindowBoxButton.Tag = "Fullscreen";
                    changeWindowBoxButton.Image = Resources.Fullscreen;
                    toolTip.SetToolTip(changeWindowBoxButton, "Развернуть");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
