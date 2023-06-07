using MyOfficeTable.Forms;
using MyOfficeTable.Properties;
using MyOfficeTable.Support;
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
    public partial class MainForm : StyleForm
    {
        bool loadForm = true;
        public static MainForm _mainForm;
        ToolTip toolTip = new ToolTip();

        public MainForm()
        {
            InitializeComponent();
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

        private void GoToForm(Form form)
        {
            form.Show();
            Hide();
        }

        private void ReferenceButton_Click(object sender, EventArgs e)
        {
            InstructionForm form = new InstructionForm();
            form.ShowDialog();
        }

        private void TheoryButton_Click(object sender, EventArgs e)
        {
            if (SelectThemeForm._selectThemeForm != null)
            {
                SelectThemeForm._selectThemeForm.Close();
                GoToForm(new SelectThemeForm("Теория"));
            }
            else
                GoToForm(new SelectThemeForm("Теория"));
        }

        private void TestingButton_Click(object sender, EventArgs e)
        {
            if (SelectThemeForm._selectThemeForm != null)
            {
                SelectThemeForm._selectThemeForm.Close();
                GoToForm(new SelectThemeForm("Тестирование"));
            }
            else
                GoToForm(new SelectThemeForm("Тестирование"));
        }

        private void InteractiveTasksButton_Click(object sender, EventArgs e)
        {
            if (SelectThemeForm._selectThemeForm != null)
            {
                SelectThemeForm._selectThemeForm.Close();
                GoToForm(new SelectThemeForm("Интерактивные задания"));
            }
            else
                GoToForm(new SelectThemeForm("Интерактивные задания"));
        }

        private void ChangeWindowBoxButton_Click(object sender, EventArgs e)
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

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ReferenceForm._referenceForm != null)
            {
                ReferenceForm._referenceForm.Close();
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                changeWindowBoxButton.Tag = "NormalScreen";
                changeWindowBoxButton.Image = Resources.NormalScreen;
            }
            else
            {
                changeWindowBoxButton.Tag = "Fullscreen";
                changeWindowBoxButton.Image = Resources.Fullscreen;
            }
        }
    }
}
