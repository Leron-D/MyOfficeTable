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
using static System.Drawing.Image;

namespace MyOfficeTable.Forms
{
    public partial class InteractiveTaskForm : Form
    {
        public static InteractiveTaskForm _interactiveTaskForm;
        PictureBox srcPictureBox;
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
        bool loadForm = true;
        int randomCount = 3;
        private Point mouseOffset;
        private Point currentOffset;
        private bool isMouseDown = false;
        List<ControlRatios> controlRatiosOnForm1;
        List<ControlRatios> controlRatiosOnForm2;
        List<ControlRatios> controlRatiosInPanel;

        public InteractiveTaskForm(string taskName)
        {
            InitializeComponent();
            theme = taskName;
            LoadForm();
            _interactiveTaskForm = this;
            controlRatiosOnForm1 = new List<ControlRatios>
            {
                new ControlRatios(nameLabel1, 0.291627, 0.132626, 0, 0.338196),
                new ControlRatios(nameLabel2, 0.291627, 0.132626, 0, 0.503979),
                new ControlRatios(nameLabel3, 0.291627, 0.132626, 0, 0.676393),
                new ControlRatios(nameLabel4, 0.291627, 0.132626, 0, 0.848806),

                new ControlRatios(destinationPictureBox1, 0.096246, 0.132626, 0.320500, 0.331565),
                new ControlRatios(destinationPictureBox2, 0.096246, 0.132626, 0.320500, 0.503979),
                new ControlRatios(destinationPictureBox3, 0.096246, 0.132626, 0.320500, 0.676393),
                new ControlRatios(destinationPictureBox4, 0.096246, 0.132626, 0.320500, 0.848806),

                new ControlRatios(imagesPanel, 0.412897, 0.568966, 0.547642, 0.364721),
                
                new ControlRatios(resultLabel1, 0.035611, 0.049072, 0.457170, 0.375332),
                new ControlRatios(resultLabel2, 0.035611, 0.049072, 0.457170, 0.549072),
                new ControlRatios(resultLabel3, 0.035611, 0.049072, 0.457170, 0.721485),
                new ControlRatios(resultLabel4, 0.035611, 0.049072, 0.457170, 0.884615),

                new ControlRatios(taskLabel1, 0.846006, 0.128647, 0.092397, 0.185676)
            };

            controlRatiosOnForm2 = new List<ControlRatios>
            {
                new ControlRatios(formulaPictureBox1, 0.314726, 0.177719, 0.096246, 0.367374),
                new ControlRatios(formulaPictureBox2, 0.314726, 0.177719, 0.589028, 0.367374),
                new ControlRatios(formulaPictureBox3, 0.314726, 0.177719, 0.096246, 0.702918),
                new ControlRatios(formulaPictureBox4, 0.314726, 0.177719, 0.589028, 0.702918),

                new ControlRatios(answerTextBox1, 0.314726, 0.047745, 0.096246, 0.576923),
                new ControlRatios(answerTextBox2, 0.314726, 0.047745, 0.589028, 0.576923),
                new ControlRatios(answerTextBox3, 0.314726, 0.047745, 0.096246, 0.909814),
                new ControlRatios(answerTextBox4, 0.314726, 0.047745, 0.589028, 0.909814),
                
                new ControlRatios(resultLabel5, 0.035611, 0.049072, 0.431184, 0.575597),
                new ControlRatios(resultLabel6, 0.035611, 0.049072, 0.923965, 0.575597),
                new ControlRatios(resultLabel7, 0.035611, 0.049072, 0.431184, 0.909814),
                new ControlRatios(resultLabel8, 0.035611, 0.049072, 0.923965, 0.909814),

                new ControlRatios(taskLabel2, 0.846006, 0.128647, 0.072185, 0.196286)
            };

            controlRatiosInPanel = new List<ControlRatios>
            {
                new ControlRatios(sourcePictureBox1, 0.233100, 0.233100, 0.620047, 0.664336),
                new ControlRatios(sourcePictureBox2, 0.233100, 0.233100, 0.146853, 0.256410),
                new ControlRatios(sourcePictureBox3, 0.233100, 0.233100, 0.146853, 0.664336),
                new ControlRatios(sourcePictureBox4, 0.233100, 0.233100, 0.620047, 0.256410)
            };
        }

        private void InteractiveTaskForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = true;
                mouseOffset = Cursor.Position;
                currentOffset = this.Location;
            }
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

        private void LoadForm()
        {
            try
            {
                AutoScaleMode = AutoScaleMode.Font;
                Settings.Default.firstLoadInstruction = false;
                Settings.Default.Save();
                ToolTip toolTip = new ToolTip();
                tabControl.Multiline = true;
                tabControl.Appearance = TabAppearance.Buttons;
                tabControl.ItemSize = new Size(0, 1);
                tabControl.SizeMode = TabSizeMode.Fixed;
                tabControl.TabStop = false;
                destinationPictureBox1.AllowDrop = destinationPictureBox2.AllowDrop = destinationPictureBox3.AllowDrop = destinationPictureBox4.AllowDrop =
                sourcePictureBox1.AllowDrop = sourcePictureBox2.AllowDrop = sourcePictureBox3.AllowDrop = sourcePictureBox4.AllowDrop = sourcePictureBox4.AllowDrop = true;
                headerLabel1.Text = headerLabel2.Text = theme;
                srcPictureBox = null;

                if (theme == "Интерфейс табличного процессора")
                {
                    Random random = new Random();

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
                        sourcePictureBox1,
                        sourcePictureBox2,
                        sourcePictureBox3,
                        sourcePictureBox4
                    };

                    listOfDestinationPictureBoxes = new List<PictureBox>
                    {
                        destinationPictureBox1,
                        destinationPictureBox2,
                        destinationPictureBox3,
                        destinationPictureBox4
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

                    numberOfTasks = random.Next(2, 4);
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
                        Resources.InteractiveTask8,
                        Resources.InteractiveTask9,
                        Resources.InteractiveTask10,
                        Resources.InteractiveTask11,
                        Resources.InteractiveTask12
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
                        "Смешанная",
                        "Относительная",
                        "Абсолютная",
                        "Объемная"
                    };

                    listOfIndexes2 = new List<int>
                    {
                        0,
                        4,
                        8
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
                        resultLabel6,
                        resultLabel7,
                        resultLabel8
                    };

                    numberOfTasks = 2;

                    TakeTaskByReferences();
                }
                numOfTaskLabel.Text = $"{numOfTask} из {numberOfTasks}";
                numOfTaskLabel.Left = (ClientSize.Width - numOfTaskLabel.Width) / 2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TakeTaskByInterface()
        {
            Random random = new Random();
            for (int i = 0; i < 4; i++)
            {
                listOfDestinationPictureBoxes[i].Image = null;
                listOfDestinationPictureBoxes[i].Tag = false;
                listOfResultLabels1[i].Visible = false;
            }
            int randomIndex = random.Next(0, randomCount);
            index1 = listOfIndexes1[randomIndex];
            listOfIndexes1.RemoveAt(randomIndex);
            randomCount--;
            int k = 0;
            for (int i = index1; i < index1 + 4; i++)
            {
                listOfSourcePictureBoxes[k].Image = listOfImages1[i];
                listOfSourcePictureBoxes[k].Tag = listOfTags1[i];
                listOfNameLabels[k].Text = listOfNames[i];
                k++;
            }
        }

        private void TakeTaskByReferences()
        {
            Random random = new Random();
            for (int i = 0; i < 4; i++)
            {
                listOfTextBoxes[i].Text = "";
                listOfResultLabels2[i].Visible = false;
            }
            int randomIndex = random.Next(0, 3);
            if (randomIndex == 2)
                taskLabel2.Text = "Задание: Введите тип ссылки, которая записана в выделенной ячейке";
            else
                taskLabel2.Text = "Задание: Введите формулу, которая будет написана в выделенной ячейке при копировании";
            index2 = listOfIndexes2[randomIndex];
            listOfIndexes2.RemoveAt(randomIndex);
            int k = 0;
            for (int i = index2; i < index2 + 4; i++)
            {
                listOfFormulaPictureBoxes[k].Image = listOfImages2[i];
                listOfTextBoxes[k].Tag = listOfTags2[i];
                k++;
            }
        }

        private void SetInvisibleOfResultLabels()
        {
            resultLabel1.Visible = resultLabel2.Visible = resultLabel3.Visible = resultLabel4.Visible = resultLabel5.Visible = resultLabel6.Visible = resultLabel7.Visible =
            resultLabel8.Visible = false;
        }

        private void ChangeControlsForNormalscreen()
        {
            changeWindowBoxButton.Image = Resources.Fullscreen;
            headerLabel1.Font = headerLabel2.Font = new Font(headerLabel1.Font.Name, 28, FontStyle.Bold);
            taskLabel1.Font = taskLabel2.Font = new Font(taskLabel1.Font.Name, 24, FontStyle.Bold);
            numOfTaskLabel.Font = new Font(numOfTaskLabel.Font.Name, 24, FontStyle.Bold);

            goBackButton.Font = goNextButton.Font = new Font(goBackButton.Font.Name, 18, FontStyle.Bold);
            goBackButton.Size = goNextButton.Size = new Size(194, 40);
            goBackButton.Location = new Point(0, 840);
            goNextButton.Location = new Point(840, 840);

            if (tabControl.SelectedTab == tabControl.TabPages[0])
            {
                imagesPanel.Size = new Size(429, 314);
                imagesPanel.Location = new Point(574, 340);
                destinationPictureBox1.Size = destinationPictureBox2.Size = destinationPictureBox3.Size = destinationPictureBox4.Size =
                sourcePictureBox1.Size = sourcePictureBox2.Size = sourcePictureBox3.Size = sourcePictureBox4.Size = new Size(100, 100);
                destinationPictureBox1.Location = new Point(333, taskLabel1.Location.Y + taskLabel1.Height + 27);
                nameLabel1.Font = nameLabel2.Font = nameLabel3.Font = nameLabel4.Font = new Font(nameLabel1.Font.Name, 24, FontStyle.Bold);

                sourcePictureBox2.Location = new Point(63, 75);
                sourcePictureBox3.Location = new Point(63, 199);
                sourcePictureBox4.Location = new Point(266, 75);
                sourcePictureBox1.Location = new Point(266, 199);
            }
            else
            {
                formulaPictureBox1.Size = formulaPictureBox2.Size = formulaPictureBox3.Size = formulaPictureBox4.Size = new Size(327, 134);
                formulaPictureBox1.Location = new Point(100, 277);
                answerTextBox1.Font = answerTextBox2.Font = answerTextBox3.Font = answerTextBox4.Font = new Font(answerTextBox1.Font.Name, 22, FontStyle.Bold);
            }
            Settings.Default.isFullSize = false;
        }

        private void ChangeControlsForFullscreen()
        {
            changeWindowBoxButton.Image = Resources.NormalScreen;
            headerLabel1.Font = headerLabel2.Font = new Font(headerLabel1.Font.Name, 36, FontStyle.Bold);
            taskLabel1.Font = taskLabel2.Font = new Font(taskLabel1.Font.Name, 28, FontStyle.Bold);
            numOfTaskLabel.Font = new Font(numOfTaskLabel.Font.Name, 28, FontStyle.Bold);

            goBackButton.Font = goNextButton.Font = new Font(goBackButton.Font.Name, 22, FontStyle.Bold);
            goBackButton.Size = goNextButton.Size = new Size(230, 47);
            goBackButton.Location = new Point(goBackButton.Location.X + 5, goBackButton.Location.Y - 7);
            goNextButton.Location = new Point(goNextButton.Location.X - 40, goNextButton.Location.Y - 7);

            if (tabControl.SelectedTab == tabControl.TabPages[0])
            {
                //imagesPanel.Location = new Point(imagesPanel.Location.X - 500, imagesPanel.Location.Y);
                destinationPictureBox1.Size = destinationPictureBox2.Size = destinationPictureBox3.Size = destinationPictureBox4.Size =
                sourcePictureBox1.Size = sourcePictureBox2.Size = sourcePictureBox3.Size = sourcePictureBox4.Size = new Size(146, 146);
                destinationPictureBox1.Location = new Point(destinationPictureBox1.Location.X + 50, taskLabel1.Location.Y + taskLabel1.Height + 27);
                nameLabel1.Font = nameLabel2.Font = nameLabel3.Font = nameLabel4.Font = new Font(nameLabel1.Font.Name, 28, FontStyle.Bold);

                imagesPanel.Size = new Size(658, 453);
                imagesPanel.Location = new Point((SystemInformation.VirtualScreen.Width - (resultLabel1.Location.X + resultLabel1.Width - imagesPanel.Width)) / 2, imagesPanel.Location.Y);

                sourcePictureBox2.Location = new Point(63, 88);
                sourcePictureBox3.Location = new Point(sourcePictureBox2.Location.X, sourcePictureBox2.Location.Y + sourcePictureBox2.Height + 39);
                sourcePictureBox4.Location = new Point(sourcePictureBox2.Location.X + sourcePictureBox2.Width + 239, sourcePictureBox2.Location.Y);
                sourcePictureBox1.Location = new Point(sourcePictureBox4.Location.X, sourcePictureBox4.Location.Y + sourcePictureBox4.Height + 39);

            }
            else
            {
                formulaPictureBox1.Size = formulaPictureBox2.Size = formulaPictureBox3.Size = formulaPictureBox4.Size = new Size(551, 224);
                formulaPictureBox1.Location = new Point(100, taskLabel2.Location.Y + taskLabel2.Height + 32);
                answerTextBox1.Font = answerTextBox2.Font = answerTextBox3.Font = answerTextBox4.Font = new Font(answerTextBox1.Font.Name, 22, FontStyle.Bold);
            }
            Settings.Default.isFullSize = true;
        }

        private void GoToNextTask()
        {
            if (tabControl.SelectedTab == tabControl.TabPages[0] && resultLabel1.Tag == "Correct" && resultLabel2.Tag == "Correct" && resultLabel3.Tag == "Correct" && resultLabel4.Tag == "Correct")
            {
                if (numOfTask != numberOfTasks)
                    TakeTaskByInterface();
                else
                {
                    GoToSelectThemeForm();
                }
                CheckCorrectness();
            }
            else if (tabControl.SelectedTab == tabControl.TabPages[1] && numOfTask != numberOfTasks && resultLabel5.Tag == "Correct" && resultLabel6.Tag == "Correct" && resultLabel7.Tag == "Correct" && resultLabel8.Tag == "Correct")
            {
                if (numOfTask != numberOfTasks)
                    TakeTaskByReferences();
                else
                {
                    GoToSelectThemeForm();
                }
                CheckCorrectness();
            }
            else
            {
                MessageBox.Show("Задание решено неверно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CheckCorrectness();
                return;
            }
            numOfTask++;
            if (numOfTask == numberOfTasks)
                goNextButton.Text = "Завершить";
            numOfTaskLabel.Text = $"{numOfTask} из {numberOfTasks}";
            SetInvisibleOfResultLabels();
        }

        private void GoToSelectThemeForm()
        {
            Settings.Default.firstLoadInstruction = true;
            Settings.Default.Save();
            MessageBox.Show("Вы завершили выполнение задания!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowForm(new SelectThemeForm("Интерактивные задания"));
        }

        private void CheckCorrectness()
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
            else
            {
                int k = 0;
                for (int i = index2; i < index2 + 4; i++)
                {
                    ChangeImageOfLabel(listOfTextBoxes[k], listOfResultLabels2[k]);
                    k++;
                }
            }
        }

        private void ShowForm(Form form)
        {
            Hide();
            form.ShowDialog();
            Close();
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
            if (textBox.Text.Replace('ё', 'е').ToLower() != textBox.Tag.ToString().Replace('ё', 'е').ToLower())
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

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            SelectThemeForm form = new SelectThemeForm("Интерактивные задания");
            var message = MessageBox.Show("Вы точно хотите выйти?", "Выход из задания", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (message == DialogResult.Yes)
            {
                Settings.Default.firstLoadInstruction = true;
                Settings.Default.Save();
                //Hide();
                //form.ShowDialog();
                //Close();
                Hide();
                SelectThemeForm._selectThemeForm.Show();
            }
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

        private void GoNextButton_Click(object sender, EventArgs e)
        {
            GoToNextTask();
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

        private void AnswerTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckCorrectness();
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

        #region
        private void DestinationPictureBox1_LocationChanged(object sender, EventArgs e)
        {
            //if (!loadForm)
            //{
            //    destinationPictureBox2.Location = new Point(destinationPictureBox1.Location.X, destinationPictureBox1.Location.Y + destinationPictureBox1.Height + 25);
            //    destinationPictureBox3.Location = new Point(destinationPictureBox1.Location.X, destinationPictureBox2.Location.Y + destinationPictureBox2.Height + 25);
            //    destinationPictureBox4.Location = new Point(destinationPictureBox1.Location.X, destinationPictureBox3.Location.Y + destinationPictureBox3.Height + 25);

            //    nameLabel1.Location = new Point(destinationPictureBox1.Location.X - nameLabel1.Width - 30, destinationPictureBox1.Location.Y);

            //    resultLabel1.Location = new Point(destinationPictureBox1.Location.X + destinationPictureBox1.Width + 42,
            //                                      destinationPictureBox1.Location.Y + (destinationPictureBox1.Height - resultLabel1.Height) / 2);
            //    resultLabel2.Location = new Point(destinationPictureBox2.Location.X + destinationPictureBox2.Width + 42,
            //                                      destinationPictureBox2.Location.Y + (destinationPictureBox2.Height - resultLabel2.Height) / 2);
            //    resultLabel3.Location = new Point(destinationPictureBox3.Location.X + destinationPictureBox3.Width + 42,
            //                                      destinationPictureBox3.Location.Y + (destinationPictureBox3.Height - resultLabel3.Height) / 2);
            //    resultLabel4.Location = new Point(destinationPictureBox4.Location.X + destinationPictureBox4.Width + 42,
            //                                      destinationPictureBox4.Location.Y + (destinationPictureBox4.Height - resultLabel4.Height) / 2);
            //}
        }

        private void DestinationPictureBox1_Resize(object sender, EventArgs e)
        {
            //if (!loadForm)
            //{
            //    nameLabel1.Size = nameLabel2.Size = nameLabel3.Size = nameLabel4.Size = new Size(nameLabel1.Width, destinationPictureBox1.Height);
            //}
        }

        private void NameLabel1_LocationChanged(object sender, EventArgs e)
        {
            //if (!loadForm)
            //{
            //    nameLabel2.Location = new Point(nameLabel1.Location.X, destinationPictureBox2.Location.Y);
            //    nameLabel3.Location = new Point(nameLabel2.Location.X, destinationPictureBox3.Location.Y);
            //    nameLabel4.Location = new Point(nameLabel3.Location.X, destinationPictureBox4.Location.Y);
            //}
        }
        #endregion

        private void InteractiveTaskForm_Resize(object sender, EventArgs e)
        {
            #region
            //if (!loadForm)
            //{
            //    if (WindowState == FormWindowState.Maximized)
            //    {
            //        ChangeControlsForFullscreen();
            //    }
            //    else
            //    {
            //        ChangeControlsForNormalscreen();
            //    }
            //}
            #endregion

            if (tabControl.SelectedTab == tabControl.TabPages[0])
            {
                foreach (var item in controlRatiosOnForm1)
                {
                    item.Resize(tabControl.TabPages[0]);
                }
                foreach (var item in controlRatiosInPanel)
                {
                    item.Resize(imagesPanel);
                }
            }
            else
            {
                foreach (var item in controlRatiosOnForm2)
                {
                    item.Resize(tabControl.TabPages[1]);
                }
            }

            if (WindowState == FormWindowState.Maximized)
            {
                loadForm = false;
                WindowState = FormWindowState.Maximized;
                changeWindowBoxButton.Image = Resources.NormalScreen;
                changeWindowBoxButton.Tag = "Normalscreen";
            }
            else
            {
                WindowState = FormWindowState.Normal;
                changeWindowBoxButton.Tag = "Fullscreen";
                changeWindowBoxButton.Image = Resources.Fullscreen;
            }
        }

        private void InteractiveTaskForm_Load(object sender, EventArgs e)
        {
            if (Settings.Default.isFullSize)
            {
                loadForm = false;
                WindowState = FormWindowState.Maximized;
                changeWindowBoxButton.Image = Resources.NormalScreen;
                changeWindowBoxButton.Tag = "Normalscreen";
            }
            else
            {
                WindowState = FormWindowState.Normal;
                changeWindowBoxButton.Tag = "Fullscreen";
                changeWindowBoxButton.Image = Resources.Fullscreen;
            }
        }

        private void FormulaPictureBox1_LocationChanged(object sender, EventArgs e)
        {
            if (!loadForm)
            {
                answerTextBox1.Location = new Point(formulaPictureBox1.Location.X, formulaPictureBox1.Location.Y + formulaPictureBox1.Height + 24);
                formulaPictureBox2.Location = new Point(ClientSize.Width - formulaPictureBox1.Width - 100, formulaPictureBox1.Location.Y);

                formulaPictureBox3.Location = new Point(formulaPictureBox1.Location.X, answerTextBox1.Location.Y + answerTextBox1.Height + 53);

                answerTextBox2.Location = new Point(formulaPictureBox2.Location.X, formulaPictureBox2.Location.Y + formulaPictureBox2.Height + 24);
                formulaPictureBox4.Location = new Point(formulaPictureBox2.Location.X, answerTextBox2.Location.Y + answerTextBox2.Height + 53);

                answerTextBox3.Location = new Point(formulaPictureBox3.Location.X, formulaPictureBox3.Location.Y + formulaPictureBox3.Height + 24);
                answerTextBox4.Location = new Point(formulaPictureBox4.Location.X, formulaPictureBox4.Location.Y + formulaPictureBox4.Height + 24);

                resultLabel5.Location = new Point(answerTextBox1.Location.X + answerTextBox1.Width + 28, answerTextBox1.Location.Y);
                resultLabel6.Location = new Point(answerTextBox2.Location.X + answerTextBox2.Width + 28, answerTextBox2.Location.Y);
                resultLabel7.Location = new Point(answerTextBox3.Location.X + answerTextBox3.Width + 28, answerTextBox3.Location.Y);
                resultLabel8.Location = new Point(answerTextBox4.Location.X + answerTextBox4.Width + 28, answerTextBox4.Location.Y);
            }
        }

        private void FormulaPictureBox1_Resize(object sender, EventArgs e)
        {
            //answerTextBox1.Width = answerTextBox2.Width = answerTextBox3.Width = answerTextBox4.Width = formulaPictureBox1.Width;
        }
    }
}
