using MyOfficeTable.Forms;
using MyOfficeTable.Properties;
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
    public partial class MainForm : Form
    {
        private Point mouseOffset;
        private Point currentOffset;
        private bool isMouseDown = false;
        bool loadForm = true;

        public MainForm()
        {
            InitializeComponent();
            if (Settings.Default.IsFirstLoad)
            {
                Animator.Start();
                Settings.Default.IsFirstLoad = false;
                Settings.Default.Save();
            }
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(referenceButton, "Справка о программе");
            toolTip.SetToolTip(minimizeButton, "Свернуть");
            toolTip.SetToolTip(cancelButton, "Закрыть");
            headerLabel.Left = (ClientSize.Width - headerLabel.Width) / 2;
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

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            mouseOffset = Cursor.Position;
            currentOffset = this.Location;
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(mouseOffset));
                this.Location = Point.Add(currentOffset, new Size(dif));
            }
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void ReferenceButton_Click(object sender, EventArgs e)
        {
            ReferenceForm form = new ReferenceForm();
            form.ShowDialog();
        }

        private void TheoryButton_Click(object sender, EventArgs e)
        {
            GoToSelectTheme("Теория");
        }

        private void TestingButton_Click(object sender, EventArgs e)
        {
            GoToSelectTheme("Тестирование");
        }

        private void GoToSelectTheme(string mode)
        {
            GoToForm(new SelectThemeForm(mode));
        }

        private void InteractiveTasksButton_Click(object sender, EventArgs e)
        {
            GoToForm(new SelectThemeForm("Интерактивные задания"));
        }

        void GoToForm(Form form)
        {
            Hide();
            form.ShowDialog();
            Close();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (!loadForm)
            {
                if (WindowState == FormWindowState.Maximized)
                {
                    interactiveTasksButton.Size = testingButton.Size = theoryButton.Size = new Size(328, 349);
                    theoryButton.Left = 88;
                    interactiveTasksButton.Left = buttonPanel.Width - 88 - interactiveTasksButton.Width;
                    testingButton.Left = (buttonPanel.Width - testingButton.Width) / 2;
                    theoryButton.Font = testingButton.Font = interactiveTasksButton.Font = theoryButton.FontDescrition = testingButton.FontDescrition =
                    interactiveTasksButton.FontDescrition = new Font(theoryButton.Font.Name, 16);
                    theoryButton.FontHeader = testingButton.FontHeader = interactiveTasksButton.FontHeader = new Font(theoryButton.Font.Name, 16, FontStyle.Bold);
                    headerLabel.Font = new Font(headerLabel.Font.Name, 36, FontStyle.Bold);
                }
                else
                {
                    interactiveTasksButton.Size = testingButton.Size = theoryButton.Size = new Size(271, 277);
                    theoryButton.Location = new Point(57, 93);
                    testingButton.Location = new Point(436, 93);
                    interactiveTasksButton.Location = new Point(813, 93);
                    theoryButton.Font = testingButton.Font = interactiveTasksButton.Font = theoryButton.FontDescrition = testingButton.FontDescrition =
                    interactiveTasksButton.FontDescrition = new Font(theoryButton.Font.Name, 12);
                    theoryButton.FontHeader = testingButton.FontHeader = interactiveTasksButton.FontHeader = new Font(theoryButton.Font.Name, 12, FontStyle.Bold);
                    headerLabel.Font = new Font(headerLabel.Font.Name, 28, FontStyle.Bold);
                }
            }
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
            }
            else
            {
                Settings.Default.isFullSize = false;
                WindowState = FormWindowState.Normal;
                changeWindowBoxButton.Tag = "Fullscreen";
                changeWindowBoxButton.Image = Resources.Fullscreen;
            }
            CenterToScreen();
        }
    }
}
