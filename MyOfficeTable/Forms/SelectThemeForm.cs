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
    public partial class SelectThemeForm : Form
    {
        string selectMode;
        private Point mouseOffset;
        private Point currentOffset;
        private bool isMouseDown = false;
        List<string> listOfTheoryThemes = new List<string>();
        List<string> listOfTestsThemes = new List<string>();
        List<int> listOfNumberOfQuestions = new List<int>();

        public SelectThemeForm(string mode)
        {
            InitializeComponent();
            LoadForm(mode);
        }

        private void LoadForm(string mode)
        {
            transitionButton.Left = goToEvaluationCriteriasButton.Left = (ClientSize.Width - transitionButton.Width) / 2;
            selectMode = mode;
            if (mode == "Теория")
            {
                transitionButton.Text = "Перейти к лекции";
                goToEvaluationCriteriasButton.Visible = false;
            }
            if (mode == "Интерактивные задания")
            {
                transitionButton.Text = "Перейти к заданию";
                goToEvaluationCriteriasButton.Visible = false;
            }
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(minimizeButton, "Свернуть");
            toolTip.SetToolTip(cancelButton, "Закрыть");
            listOfTheoryThemes = new List<string>
            {
                "Работа в табличном процессоре",
                "Создание, редактирование и форматирование рабочих листов табличного процессора",
                "Использование формул и функций в табличном процессоре",
                "Построение графиков и диаграмм",
                "Работа с данными в табличном процессоре",
                "Ссылки на ячейки в табличном процессоре"
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
                    selectThemeComboBox.Items.Add("Ссылка на ячейки в табличном процессоре");
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
                if (selectMode == "Тестирование")
                {
                    GoToForm(new TestForm(Directory.GetCurrentDirectory() + $@"\Tests\{selectThemeComboBox.SelectedItem}.xml", listOfNumberOfQuestions[selectThemeComboBox.SelectedIndex]));
                }
                else if (selectMode == "Теория")
                {
                    GoToForm(new TheoryForm(Directory.GetCurrentDirectory() + $@"\Lections\{selectThemeComboBox.SelectedItem}.html"));
                }
                else
                {
                    GoToForm(new InstructionForm($"{selectThemeComboBox.SelectedItem}"));
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
            GoToForm(new EvaluationСriteriasForm(listOfNumberOfQuestions[selectThemeComboBox.SelectedIndex]));
        }
        
        void GoToForm(Form form)
        {
            Hide();
            form.ShowDialog();
            Close();
        }
    }
}
