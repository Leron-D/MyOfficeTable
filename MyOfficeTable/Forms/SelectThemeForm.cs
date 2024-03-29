﻿using MyOfficeTable.Forms;
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
        List<int> listOfNumberOfQuestions = new List<int>();
        ToolTip toolTip = new ToolTip();

        public SelectThemeForm(string mode)
        {
            InitializeComponent();
            _selectThemeForm = this;
            LoadForm(mode);
        }

        private void LoadForm(string mode)
        {
            try
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
                toolTip.SetToolTip(minimizeButton, "Свернуть");
                toolTip.SetToolTip(cancelButton, "Закрыть");
                listOfNumberOfQuestions = new List<int>
                {
                    13,
                    11,
                    9
                };

                if (Settings.Default.isFullSize)
                {
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void AddItemsToComboBox()
        {
            try
            {
                if (selectMode == "Тестирование")
                {
                    var dir = new DirectoryInfo(Path.Combine(Directory.GetCurrentDirectory(), "Tests"));
                    foreach (var theme in dir.GetFiles("*.xml"))
                    {
                        selectThemeComboBox.Items.Add(Path.GetFileNameWithoutExtension(theme.FullName));
                    }
                    selectThemeComboBox.SelectedIndex = 0;
                }
                else if (selectMode == "Теория")
                {
                    var dir = new DirectoryInfo(Path.Combine(Directory.GetCurrentDirectory(), "Lections"));
                    foreach (var theme in dir.GetFiles("*.html"))
                    {
                        selectThemeComboBox.Items.Add(Path.GetFileNameWithoutExtension(theme.FullName));
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
                MainForm._mainForm.Show();
                if (Settings.Default.isFullSize)
                    MainForm._mainForm.WindowState = FormWindowState.Maximized;
                else
                    MainForm._mainForm.WindowState = FormWindowState.Normal;
                Hide();
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

        private void TransitionButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectMode == "Тестирование")
                {
                    if (File.Exists($@"{Directory.GetCurrentDirectory()}\Tests\{selectThemeComboBox.SelectedItem}.xml"))
                        GoToForm(new TestForm($@"{Directory.GetCurrentDirectory()}\Tests\{selectThemeComboBox.SelectedItem}.xml", listOfNumberOfQuestions[selectThemeComboBox.SelectedIndex]));
                    else
                        throw new Exception("Выбранного теста не существует");
                    if (Settings.Default.isFullSize)
                        TestForm._testForm.WindowState = FormWindowState.Maximized;
                    else
                        TestForm._testForm.WindowState = FormWindowState.Normal;
                }
                else if (selectMode == "Теория")
                {
                    if (TheoryForm._theoryForm != null)
                        TheoryForm._theoryForm.Close();
                    if (File.Exists($@"{Directory.GetCurrentDirectory()}\Lections\{selectThemeComboBox.SelectedItem}.html"))
                    {
                        if (selectThemeComboBox.SelectedIndex == 1)
                            GoToForm(new TheoryForm(Directory.GetCurrentDirectory() + $@"\Lections\{selectThemeComboBox.SelectedItem}.html", true, "1. Создание, редактирование и форматирование рабочих листов табличного процессора"));
                        else if (selectThemeComboBox.SelectedIndex == 3)
                            GoToForm(new TheoryForm(Directory.GetCurrentDirectory() + $@"\Lections\{selectThemeComboBox.SelectedItem}.html", true, "2. Использование формул и функций в табличном процессоре"));
                        else if (selectThemeComboBox.SelectedIndex == 4)
                            GoToForm(new TheoryForm(Directory.GetCurrentDirectory() + $@"\Lections\{selectThemeComboBox.SelectedItem}.html", true, "3. Построение графиков и диаграмм"));
                        else
                            GoToForm(new TheoryForm(Directory.GetCurrentDirectory() + $@"\Lections\{selectThemeComboBox.SelectedItem}.html", false));
                    }
                    else
                        throw new Exception("Выбранной лекции не существует");
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
            try
            {
                EvaluationСriteriasForm form = new EvaluationСriteriasForm();
                goToEvaluationCriteriasButton.Enabled = transitionButton.Enabled = goBackButton.Enabled = cancelButton.Enabled = false;
                form.Show();
                form.FormClosed += Form_FormClosed;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            goToEvaluationCriteriasButton.Enabled = transitionButton.Enabled = goBackButton.Enabled = cancelButton.Enabled = true;
        }

        private void СhangeWindowBoxButton_Click(object sender, EventArgs e)
        {
            try
            {
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SelectThemeForm_Resize(object sender, EventArgs e)
        {
            try
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
                    changeWindowBoxButton.Tag = "NormalScreen";
                    changeWindowBoxButton.Image = Resources.NormalScreen;
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
                    changeWindowBoxButton.Tag = "Fullscreen";
                    changeWindowBoxButton.Image = Resources.Fullscreen;
                }
                CenterToScreen();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SelectThemeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (TheoryForm._theoryForm != null)
                {
                    TheoryForm._theoryForm.Close();
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
