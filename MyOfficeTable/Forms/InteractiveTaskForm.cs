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

namespace MyOfficeTable.Forms
{
    public partial class InteractiveTaskForm : Form
    {
        PictureBox srcPictureBox;
        private Point mouseOffset;
        private Point currentOffset;
        private bool isMouseDown = false;
        string theme = "";
        int numOfTask = 1;
        int numberOfTasks;
        int index1;
        int index2;
        List<string> listOfNames;
        List<string> listOfTags1;
        List<string> listOfTags2;
        List<int> listOfIndexes1;
        List<int> listOfIndexes2;
        List<Image> listOfImages1;
        List<Image> listOfImages2;
        List<PictureBox> listOfSourcePictureBoxes;
        List<PictureBox> listOfDestinationPictureBoxes;
        List<PictureBox> listOfFormulaPictureBoxes;
        List<Label> listOfNameLabels;
        List<Label> listOfResultLabels1;
        List<Label> listOfResultLabels2;
        List<TextBox> listOfTextBoxes;

        public InteractiveTaskForm(string taskName)
        {
            InitializeComponent();
            theme = taskName;
            LoadForm();
        }

        private void LoadForm()
        {
            AutoScaleMode = AutoScaleMode.Font;
            Settings.Default.firstLoadInstruction = false;
            Settings.Default.Save();
            ToolTip toolTip = new ToolTip();
            tabControl.Multiline = true;
            tabControl.Appearance = TabAppearance.Buttons;
            tabControl.ItemSize = new System.Drawing.Size(0, 1);
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.TabStop = false;
            DestinationPictureBox1.AllowDrop = DestinationPictureBox2.AllowDrop = DestinationPictureBox3.AllowDrop = DestinationPictureBox4.AllowDrop =
            SourcePictureBox1.AllowDrop = SourcePictureBox2.AllowDrop = SourcePictureBox3.AllowDrop = SourcePictureBox4.AllowDrop = SourcePictureBox4.AllowDrop = true;
            headerLabel1.Text = headerLabel3.Text = headerLabel4.Text = theme;
            srcPictureBox = null;
            numOfTaskLabel.Left = (ClientSize.Width - numOfTaskLabel.Width) / 2;
            if (theme == "Интерфейс табличного процессора")
            {
                listOfNames = new List<string>
                {
                    "Вырезать",
                    "Копировать\nформатирование",
                    "Полужирное\nначертание",
                    "Все буквы\nпрописные",
                    "Сохранить",
                    "Печать",
                    "Копировать",
                    "Вставить",
                    "Подчёркнутый",
                    "Цвет заливки",
                    "Курсив",
                    "Цвет текста"
                };

                listOfTags1 = new List<string>
                {
                    "cut",
                    "copyFormat",
                    "bold",
                    "allLettersUppercase",
                    "save",
                    "print",
                    "copy",
                    "enter",
                    "underlined",
                    "colorOfFill",
                    "italic",
                    "colorOfText"
                };

                listOfImages1 = new List<Image>
                {
                    Resources.Cut,
                    Resources.CopyFormat,
                    Resources.Bold,
                    Resources.AllLettersUppercase,
                    Resources.Save,
                    Resources.Print,
                    Resources.Copy,
                    Resources.Enter,
                    Resources.Underlined,
                    Resources.ColorOfFill,
                    Resources.Italic,
                    Resources.ColorOfText
                };

                listOfSourcePictureBoxes = new List<PictureBox>
                {
                    SourcePictureBox1,
                    SourcePictureBox2,
                    SourcePictureBox3,
                    SourcePictureBox4
                };

                listOfDestinationPictureBoxes = new List<PictureBox>
                {
                    DestinationPictureBox1,
                    DestinationPictureBox2,
                    DestinationPictureBox3,
                    DestinationPictureBox4
                };

                listOfNameLabels = new List<Label>
                {
                    nameLabel1,
                    nameLabel2,
                    nameLabel3,
                    nameLabel4
                };


                listOfIndexes1 = new List<int>
                {
                    0,
                    4,
                    8
                };

                listOfResultLabels1 = new List<Label>
                {
                    resultLabel1,
                    resultLabel2,
                    resultLabel3,
                    resultLabel4
                };

                numberOfTasks = 1;
                tabControl.SelectedTab = tabControl.TabPages[0];
                TakeTaskByInterface();
            }
            else if (theme == "Ссылки на ячейки в табличном процессоре")
            {
                tabControl.SelectedTab = tabControl.TabPages[1];

                listOfImages2 = new List<Image>
                {
                    Resources.InteractiveTask1,
                    Resources.InteractiveTask2,
                    Resources.InteractiveTask3,
                    Resources.InteractiveTask4, 
                    Resources.InteractiveTask5,
                    Resources.InteractiveTask6,
                    Resources.InteractiveTask7,
                    Resources.InteractiveTask8
                };

                listOfTags2 = new List<string>
                {
                    "=A3+$B$2",
                    "=B3+$B$2*C3",
                    "=$A4+B4",
                    "=$B5/B$2",
                    "=$A$1-C3+B$2",
                    "=A$1*B$1",
                    "=$B5-B$3/C3",
                    "=$B$2/C$3",
                };

                listOfIndexes2 = new List<int>
                {
                    0,
                    4
                };

                listOfFormulaPictureBoxes = new List<PictureBox>
                {
                    formulaPictureBox1,
                    formulaPictureBox2,
                    formulaPictureBox3,
                    formulaPictureBox4
                };

                listOfTextBoxes = new List<TextBox>
                {
                    answerTextBox1,
                    answerTextBox2,
                    answerTextBox3,
                    answerTextBox4
                };

                listOfResultLabels2 = new List<Label>
                {
                    resultLabel5,
                    resultLabel10,
                    resultLabel7,
                    resultLabel8
                };

                numberOfTasks = 1;

                TakeFirstTaskByReferences();
            }
            numOfTaskLabel.Text = $"{numOfTask} из {numberOfTasks}";
        }

        private void TakeTaskByInterface()
        {
            Random random = new Random();
            int randomIndex = random.Next(0, 3);
            index1 = listOfIndexes1[randomIndex];
            int k = 0;
            for (int i = index1; i < index1 + 4; i++)
            {
                listOfSourcePictureBoxes[k].Image = listOfImages1[i];
                listOfSourcePictureBoxes[k].Tag = listOfTags1[i];
                listOfNameLabels[k].Text = listOfNames[i];
                k++;
            }
            goNextButton.Text = "Завершить";
        }

        private void TakeFirstTaskByReferences()
        {
            Random random = new Random();
            int randomIndex = random.Next(0, 2);
            index2 = listOfIndexes2[randomIndex];
            int k = 0;
            for (int i = index2; i < index2 + 4; i++)
            {
                listOfFormulaPictureBoxes[k].Image = listOfImages2[i];
                listOfTextBoxes[k].Tag = listOfTags2[i];
                k++;
            }
            goNextButton.Text = "Завершить";
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            var message = MessageBox.Show("Вы точно хотите выйти?", "Выход из задания", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (message == DialogResult.Yes)
            {
                Settings.Default.firstLoadInstruction = true;
                Settings.Default.Save();
                MainForm form = new MainForm();
                Hide();
                form.ShowDialog();
                Close();
            }
        }

        private void InteractiveTaskForm_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            mouseOffset = Cursor.Position;
            currentOffset = this.Location;
        }

        private void InteractiveTaskForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(mouseOffset));
                this.Location = Point.Add(currentOffset, new Size(dif));
            }
        }

        private void InteractiveTaskForm_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void SourcePictureBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            srcPictureBox = sender as PictureBox;
            PictureBox pictureBox = sender as PictureBox;
            if (e.Button == MouseButtons.Left && pictureBox.Image != null)
                pictureBox.DoDragDrop(pictureBox.Image, DragDropEffects.Move);
        }

        private void PictureBox_DragEnter(object sender, DragEventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Move) != 0)
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void PictureBox_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox destinationPictureBox = sender as PictureBox;
            Image image = destinationPictureBox.Image;
            string tag = "";
            if (destinationPictureBox.Tag == null)
                tag = null;
            else
                tag = destinationPictureBox.Tag.ToString();
            destinationPictureBox.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap, true);
            destinationPictureBox.Tag = srcPictureBox.Tag;
            srcPictureBox.Image = image;
            srcPictureBox.Tag = tag;
            CheckCorrectness();
        }

        private void GoToNextTask()
        {
            if (tabControl.SelectedTab == tabControl.TabPages[0] && resultLabel1.Tag == "Correct" && resultLabel2.Tag == "Correct" && resultLabel3.Tag == "Correct" && resultLabel4.Tag == "Correct")
            {
                ShowForm(new SelectThemeForm("Интерактивные задания"));
            }
            else if (tabControl.SelectedTab == tabControl.TabPages[1] && resultLabel5.Tag == "Correct" && resultLabel10.Tag == "Correct" && resultLabel7.Tag == "Correct" && resultLabel8.Tag == "Correct")
            {
                ShowForm(new SelectThemeForm("Интерактивные задания"));
            }
            else if (tabControl.SelectedTab == tabControl.TabPages[2] && resultLabel17.Tag == "Correct" && resultLabel18.Tag == "Correct" && resultLabel19.Tag == "Correct" && resultLabel20.Tag == "Correct")
            {
                ShowForm(new ResultInteractiveForm(theme));
            }
            else
            {
                MessageBox.Show("Задание решено неверно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CheckCorrectness();
        }

        private void GoNextButton_Click(object sender, EventArgs e)
        {
            GoToNextTask();
            if(numberOfTasks > 1)
            {
                numOfTask++;
                numOfTaskLabel.Text = $"{numOfTask} из {numberOfTasks}";
            }
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            if (theme == "Интерфейс")
            {
                if (tabControl.SelectedTab == tabControl.TabPages[1])
                {
                    tabControl.SelectedTab = tabControl.TabPages[0];
                    goBackButton.Enabled = false;
                }
                else
                {
                    tabControl.SelectedTab = tabControl.TabPages[1];
                    goNextButton.Text = "Продолжить";
                }
            }
            else if (theme == "Ссылки")
            {
                if (tabControl.SelectedTab == tabControl.TabPages[4])
                {
                    tabControl.SelectedTab = tabControl.TabPages[3];
                    goBackButton.Enabled = false;
                }
                else
                {
                    tabControl.SelectedTab = tabControl.TabPages[4];
                    goNextButton.Text = "Продолжить";
                }
            }
        }

        void CheckCorrectness()
        {
            if (tabControl.SelectedTab == tabControl.TabPages[0])
            {
                int k = 0;
                for (int i = index1; i < index1 + 4; i++)
                {
                    ChangeImageOfLabel(listOfDestinationPictureBoxes[k], listOfTags1[i], listOfResultLabels1[k]);
                    k++;
                }
            }
            else if (tabControl.SelectedTab == tabControl.TabPages[1])
            {
                //ChangeImageOfLabel(answerTextBox1, "=A3+$B$2", resultLabel5);
                //ChangeImageOfLabel(answerTextBox2, "=B3+$B$2*C3", resultLabel7);
                //ChangeImageOfLabel(answerTextBox3, "=$A4+B4", resultLabel6);
                //ChangeImageOfLabel(answerTextBox4, "=$B5/B$2", resultLabel8);
                int k = 0;
                for (int i = index2; i < index2 + 4; i++)
                {
                    ChangeImageOfLabel(listOfTextBoxes[k], listOfResultLabels2[k]);
                    k++;
                }
            }
            else if (tabControl.SelectedTab == tabControl.TabPages[2])
            {
                //ChangeImageOfLabel(answerTextBox5, "=$A$1-C3+B$2", resultLabel17);
                //ChangeImageOfLabel(answerTextBox6, "=A$1*B$1", resultLabel18);
                //ChangeImageOfLabel(answerTextBox7, "=$B5-B$3/C3", resultLabel19);
                //ChangeImageOfLabel(answerTextBox8, "=$B$2/C$3", resultLabel20);
            }
        }

        private void ChangeImageOfLabel(PictureBox destination, string tag, Label resultLabel)
        {
            resultLabel.Visible = true;
            if (destination.Tag != tag)
            {
                resultLabel.Text = "";
                resultLabel.Image = Resources.Incorrect;
                resultLabel.Tag = "Incorrect";
            }
            else
            {
                resultLabel.Text = "";
                resultLabel.Image = Resources.Correct;
                resultLabel.Tag = "Correct";
            }
        }

        private void ChangeImageOfLabel(TextBox textBox, Label resultLabel)
        {
            resultLabel.Visible = true;
            if(textBox.Text.ToLower() != textBox.Tag.ToString().ToLower())
            {
                resultLabel.Text = "";
                resultLabel.Image = Resources.Incorrect;
                resultLabel.Tag = "Incorrect";
            }
            else
            {
                resultLabel.Text = "";
                resultLabel.Image = Resources.Correct;
                resultLabel.Tag = "Correct";
            }
        }

        void ShowForm(Form form)
        {
            Hide();
            form.ShowDialog();
            Close();
        }

        private void AnswerTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckCorrectness();
        }

        private void ChangeWindowBoxButton_Click(object sender, EventArgs e)
        {
            if (changeWindowBoxButton.Tag == "Fullscreen")
            {
                this.WindowState = FormWindowState.Maximized;
                changeWindowBoxButton.Tag = "NormalScreen";
                changeWindowBoxButton.Image = Resources.NormalScreen;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                changeWindowBoxButton.Tag = "Fullscreen";
                changeWindowBoxButton.Image = Resources.Fullscreen;
            }
        }
    }
}
