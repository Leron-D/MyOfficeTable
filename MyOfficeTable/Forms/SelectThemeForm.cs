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
using System.Threading;
using System.Threading.Tasks;
using System.Web.WebSockets;
using System.Windows.Forms;

namespace MyOfficeTable
{
    public partial class SelectThemeForm : StyleForm
    {
        public static SelectThemeForm _selectThemeForm;
        string selectMode;
        List<string> listOfTheoryThemes = new List<string>();
        List<string> listOfTestsThemes = new List<string>();
        List<int> listOfNumberOfQuestions = new List<int>();
        public static bool loadForm = true;
        List<ControlRatios> controlRatios;

        public SelectThemeForm(string mode)
        {
            InitializeComponent();
            _selectThemeForm = this;
            LoadForm(mode);

            controlRatios = new List<ControlRatios>
            {
                new ControlRatios(transitionButton, 0.384112, 0.089613, 0.305607, 0.580448),
                new ControlRatios(goToEvaluationCriteriasButton, 0.384112, 0.089613, 0.305607, 0.702648),

                new ControlRatios(goBackButton, 0.141121, 0.081466, 0, 0.837067),

                new ControlRatios(selectThemeComboBox, 0.809346, 0.081466, 0.090654, 0.458248)
            };
        }

        private void LoadForm(string mode)
        {
            headerLabel.Text = "Выбор темы";
            transitionButton.Left = goToEvaluationCriteriasButton.Left = (ClientSize.Width - transitionButton.Width) / 2;
            selectMode = mode;
            if (mode == "Теория")
            {
                transitionButton.Text = "Перейти к лекции";
                goToEvaluationCriteriasButton.Visible = false;
            }
            else if (mode == "Интерактивные задания")
            {
                transitionButton.Text = "Перейти к заданию";
                goToEvaluationCriteriasButton.Visible = false;
            }
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(minimizeButton, "Свернуть");
            toolTip.SetToolTip(cancelButton, "Закрыть");
            listOfTheoryThemes = new List<string>
            {
                "Интерфейс табличного процессора",
                "Создание, редактирование и форматирование рабочих листов табличного процессора",
                "Ссылки на ячейки в табличном процессоре",
                "Использование формул и функций в табличном процессоре",
                "Построение графиков и диаграмм",
                "Фильтрация и сортировка данных"
            };
            listOfTestsThemes = new List<string>
            {
                "Создание, редактирование и форматирование рабочих листов табличного процессора",
                "Использование формул и функций в табличном процессоре",
                "Построение графиков и диаграмм"
            };
            listOfNumberOfQuestions = new List<int>
            {
                13,
                11,
                9
            };

            if (Settings.Default.isFullSize)
            {
                loadForm = false;
                WindowState = FormWindowState.Maximized;
                changeWindowBoxButton.Tag = "NormalScreen";
                changeWindowBoxButton.Image = Resources.NormalScreen;                
                goBackButton.Location = new Point(goBackButton.Location.X, goBackButton.Bottom - 10);
                headerLabel.Font = new Font(headerLabel.Font.Name, 36, FontStyle.Bold);
            }
            else
            {
                WindowState = FormWindowState.Normal;
                if (selectMode != "Тестирование")
                {
                    selectThemeComboBox.Location = new Point(97, 250);
                    transitionButton.Location = new Point(transitionButton.Location.X, 310);
                }
                changeWindowBoxButton.Tag = "Fullscreen";
                changeWindowBoxButton.Image = Resources.Fullscreen;
            }

            AddItemsToComboBox();
        }

        void AddItemsToComboBox()
        {
            try
            {
                if (selectMode == "Тестирование")
                {
                    foreach (string theme in listOfTestsThemes)
                    {
                        selectThemeComboBox.Items.Add(theme);
                    }
                    selectThemeComboBox.SelectedIndex = 0;
                }
                else if (selectMode == "Теория")
                {
                    foreach (string theme in listOfTheoryThemes)
                    {
                        selectThemeComboBox.Items.Add(theme);
                    }
                    selectThemeComboBox.SelectedIndex = 0;
                }
                else
                {
                    selectThemeComboBox.Items.Add("Интерфейс табличного процессора");
                    selectThemeComboBox.Items.Add("Ссылки на ячейки в табличном процессоре");
                    selectThemeComboBox.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void GoToForm(Form form)
        {
            form.Show();
            Hide();
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            MainForm._mainForm.Show();
            Hide();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void TransitionButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectMode == "Тестирование")
                {
                    GoToForm(new TestForm(Directory.GetCurrentDirectory() + $@"\Tests\{selectThemeComboBox.SelectedItem}.xml", listOfNumberOfQuestions[selectThemeComboBox.SelectedIndex]));
                    if (Settings.Default.isFullSize)
                        TestForm._testForm.WindowState = FormWindowState.Maximized;
                    else
                        TestForm._testForm.WindowState = FormWindowState.Normal;
                }
                else if (selectMode == "Теория")
                {
                    GoToForm(new TheoryForm(Directory.GetCurrentDirectory() + $@"\Lections\{selectThemeComboBox.SelectedItem}.html"));
                }
                else
                {
                    GoToForm(new InteractiveTaskForm($"{selectThemeComboBox.SelectedItem}"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GoToEvaulationCriterias_Click(object sender, EventArgs e)
        {
            EvaluationСriteriasForm form = new EvaluationСriteriasForm();
            goToEvaluationCriteriasButton.Enabled = transitionButton.Enabled = goBackButton.Enabled = cancelButton.Enabled = false;
            form.Show();
            form.FormClosed += Form_FormClosed;
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            goToEvaluationCriteriasButton.Enabled = transitionButton.Enabled = goBackButton.Enabled = cancelButton.Enabled = true;
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
                CenterToScreen();
            }
            else
            {
                Settings.Default.isFullSize = false;
                this.WindowState = FormWindowState.Normal;
                changeWindowBoxButton.Tag = "Fullscreen";
                changeWindowBoxButton.Image = Resources.Fullscreen;
                CenterToScreen();
            }
        }

        private void SelectThemeForm_Resize(object sender, EventArgs e)
        {
            if (!loadForm)
            {
                if (WindowState == FormWindowState.Maximized)
                {
                    selectThemeComboBox.Size = new Size(1400, 70);
                    selectThemeComboBox.Left = (ClientSize.Width - selectThemeComboBox.Width) / 2;
                    if (selectMode == "Тестирование")
                        selectThemeComboBox.Top = (ClientSize.Height - selectThemeComboBox.Height) / 2 - 50;
                    else
                        selectThemeComboBox.Top = (ClientSize.Height - selectThemeComboBox.Height) / 2 + 10;
                    selectThemeComboBox.Font = new Font("Microsoft Sans Serif", 22);
                    selectThemeComboBox.BorderSize = 1;
                    headerLabel.Font = new Font(headerLabel.Font.Name, 36, FontStyle.Bold);

                    transitionButton.Size = goToEvaluationCriteriasButton.Size = new Size(440, 50);
                    transitionButton.Left = goToEvaluationCriteriasButton.Left = (ClientSize.Width - transitionButton.Width) / 2;
                    transitionButton.Top = selectThemeComboBox.Location.Y + 130;
                    goToEvaluationCriteriasButton.Top = transitionButton.Location.Y + 80;
                    goBackButton.Size = new Size(261, 50);
                    goBackButton.Location = new Point(0, Height - goBackButton.Height - 2);
                    transitionButton.Font = goToEvaluationCriteriasButton.Font = goBackButton.Font = new Font("Microsoft Sans Serif", 24, FontStyle.Bold);
                }
                else
                {
                    selectThemeComboBox.Size = new Size(866, 36);
                    selectThemeComboBox.Left = (ClientSize.Width - selectThemeComboBox.Width) / 2;
                    if (selectMode == "Тестирование")
                        selectThemeComboBox.Location = new Point(97, 225);
                    else
                    {
                        selectThemeComboBox.Location = new Point(97, 250);
                        transitionButton.Location = new Point(transitionButton.Location.X, 310);
                    }

                    selectThemeComboBox.Font = new Font("Microsoft Sans Serif", 14);
                    selectThemeComboBox.BorderSize = 1;
                    headerLabel.Font = new Font(headerLabel.Font.Name, 30, FontStyle.Bold);

                    transitionButton.Size = goToEvaluationCriteriasButton.Size = new Size(411, 44);
                    transitionButton.Left = goToEvaluationCriteriasButton.Left = (ClientSize.Width - transitionButton.Width) / 2;
                    transitionButton.Top = selectThemeComboBox.Location.Y + 60;
                    goToEvaluationCriteriasButton.Top = transitionButton.Location.Y + 60;
                    goBackButton.Size = new Size(151, 40);
                    goBackButton.Location = new Point(0, 411);
                    transitionButton.Font = goToEvaluationCriteriasButton.Font = goBackButton.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
                }
                CenterToScreen();
            }
        }

        private void SelectThemeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (TheoryForm.theoryForm != null)
            {
                TheoryForm.theoryForm.Close();
            }
            if (TestForm._testForm != null)
            {
                TestForm._testForm.Close();
            }
            if (InteractiveTaskForm._interactiveTaskForm != null)
            {
                InteractiveTaskForm._interactiveTaskForm.Close();
            }
        }
    }
}
