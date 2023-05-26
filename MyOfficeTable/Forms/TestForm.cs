using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Xml;
using System.IO;
using System.Threading;
using CheckBox = System.Windows.Forms.CheckBox;
using Polly;
using Microsoft.Web.WebView2.Core;
using MyOfficeTable.Properties;

namespace MyOfficeTable
{
    public partial class TestForm : Form
    {
        double mark = 0;
        int numOfQuestion = 1;
        int[] questionsArray = new int[15] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
        int numQuestion = 0;
        double numOfQuestions = 0;
        int seconds = 0;
        int minutes = 0;
        private Point mouseOffset;
        private Point currentOffset;
        private bool isMouseDown = false;
        string testName;
        XmlNode successfulAnswer;
        bool loadForm = true;
        int addedHeight = 0;

        public TestForm(string fileName, double numberOfQuestions)
        {
            InitializeComponent();
            numOfQuestions = numberOfQuestions;
            LoadForm(fileName);
        }

        private void LoadForm(string fileName)
        {
            try
            {
                testName = fileName;
                minutes = Convert.ToInt32(numOfQuestions);             
                headerLabel.Text = Path.GetFileNameWithoutExtension(testName);
                AnswerCheckBox1.Top = AnswerTextBox.Top = AnswerRadioButton1.Top = questionLabel.Location.Y + questionLabel.Height + 42;
                AnswerCheckBox2.Location = new Point(1, AnswerCheckBox1.Location.Y + 42);
                AnswerCheckBox3.Location = new Point(1, AnswerCheckBox2.Location.Y + 42);
                AnswerCheckBox4.Location = new Point(1, AnswerCheckBox3.Location.Y + 42);
                ToolTip toolTip = new ToolTip();
                toolTip.SetToolTip(minimizeButton, "Свернуть");
                toolTip.SetToolTip(cancelButton, "Закрыть");
                Random rnd = new Random();
                for (int i = questionsArray.Length - 1; i >= 1; i--)
                {
                    int j = rnd.Next(i + 1);
                    var temp = questionsArray[j];
                    questionsArray[j] = questionsArray[i];
                    questionsArray[i] = temp;
                }
                ChangeVisibilityButtons();
                if (Settings.Default.isFullSize)
                {
                    loadForm = false;
                    WindowState = FormWindowState.Maximized;
                    changeWindowBoxButton.Tag = "Normalscreen";
                    changeWindowBoxButton.Image = Resources.NormalScreen;
                    questionLabel.MaximumSize = new Size(1500, 130);
                    headerLabel.Font = new Font(headerLabel.Font.Name, 36, FontStyle.Bold);
                    startTestButton.Font = new Font(startTestButton.Font.Name, 22, FontStyle.Bold);
                    startTestButton.Size = new Size(404, 49);
                    startTestButton.Left = (Screen.GetWorkingArea(this).Width - startTestButton.Width) / 2;
                    startTestButton.Top = ((Screen.GetWorkingArea(this).Height - startTestButton.Height) / 2) + headerPanel.Height - 46;
                }
                else
                {
                    WindowState = FormWindowState.Normal;
                    changeWindowBoxButton.Tag = "Fullscreen";
                    changeWindowBoxButton.Image = Resources.Fullscreen;
                    startTestButton.Left = (ClientSize.Width - startTestButton.Width) / 2;
                    startTestButton.Top = ((ClientSize.Height - startTestButton.Height) / 2) + headerPanel.Height - 46;
                }

                timer.Start();
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
            if (numOfQuestionLabel.Text != "#")
            {
                var message = MessageBox.Show("Вы уверены, что хотите завершить тестирование?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (message == DialogResult.Yes)
                    Close();
            }
            else
                Close();
        }

        private void TestForm_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            mouseOffset = Cursor.Position;
            currentOffset = this.Location;
        }

        private void TestForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(mouseOffset));
                this.Location = Point.Add(currentOffset, new Size(dif));
            }
        }

        private void TestForm_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void StartTestButton_Click(object sender, EventArgs e)
        {
            startTestButton.Visible = false;
            numOfQuestionLabel.Visible = true;
            GetXml();
            numOfQuestionLabel.Text = $"{numOfQuestion} из {numOfQuestions}";
            numOfQuestionLabel.Left = (ClientSize.Width - numOfQuestionLabel.Width) / 2;
            timerLabel.Text = $"Осталось {minutes} мин {seconds} сек";
            AnswerRadioButton1.Location = new Point(17, questionLabel.Location.Y + questionLabel.Height + 35);
            AnswerCheckBox1.Location = new Point(1, questionLabel.Location.Y + questionLabel.Height + 35);
            if (Settings.Default.isFullSize)
            {
                timerLabel.Left -= 70;
                timerLabel.Width += 70;
            }
        }

        void ChangeVisibilityButtons()
        {
            AnswerRadioButton1.Visible = AnswerRadioButton2.Visible = AnswerRadioButton3.Visible = AnswerCheckBox1.Visible = timerLabel.Visible = goNextQuestionButton.Visible =
            AnswerCheckBox2.Visible = AnswerCheckBox3.Visible = AnswerCheckBox4.Visible = AnswerCheckBox4.Checked = AnswerRadioButton4.Visible = AnswerRadioButton4.Checked = 
            AnswerTextBox.Visible = AnswerRadioButton1.Checked = AnswerRadioButton2.Checked = AnswerRadioButton3.Checked = AnswerRadioButton4.Checked = AnswerRadioButton5.Checked = 
            AnswerRadioButton6.Checked = AnswerRadioButton7.Checked = AnswerRadioButton8.Checked = AnswerCheckBox1.Checked = AnswerCheckBox2.Checked = AnswerCheckBox3.Checked = 
            AnswerCheckBox4.Checked = questionLabel.Visible = AnswerCheckBox5.Checked = AnswerCheckBox6.Checked = AnswerCheckBox7.Checked = AnswerCheckBox8.Checked = 
            AnswerRadioButton5.Visible = AnswerCheckBox5.Visible = AnswerRadioButton6.Visible = AnswerCheckBox6.Visible = AnswerRadioButton7.Visible = AnswerCheckBox7.Visible = 
            AnswerRadioButton8.Visible = AnswerCheckBox8.Visible = false;
            AnswerTextBox.Text = "";
        }

        void GetXml()
        {
            try
            {
                questionLabel.Visible = timerLabel.Visible = goNextQuestionButton.Visible = true;
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(testName);
                XmlElement xRoot = xDoc.DocumentElement;
                if (xRoot != null)
                {
                    XmlNodeList a = xDoc.GetElementsByTagName("Question");
                    XmlNode question = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Text");
                    questionLabel.Text = $"Вопрос {numQuestion + 1}. {question.Value}";
                    if (a.Item(questionsArray[numQuestion]).Attributes["Type"].Value == "Single")
                    {
                        AnswerRadioButton1.Visible = AnswerRadioButton2.Visible = AnswerRadioButton3.Visible = true;
                        successfulAnswer = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("True");
                        XmlNode answer1 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer1");
                        XmlNode answer2 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer2");
                        XmlNode answer3 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer3");
                        XmlNode answer4 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer4");
                        XmlNode answer5 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer5");
                        XmlNode answer6 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer6");
                        XmlNode answer7 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer7");
                        XmlNode answer8 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer8");
                        AnswerRadioButton1.Text = answer1.Value;
                        AnswerRadioButton2.Text = answer2.Value;
                        AnswerRadioButton3.Text = answer3.Value;
                        if (answer4 != null)
                        {
                            AnswerRadioButton4.Visible = true;
                            AnswerRadioButton4.Text = answer4.Value;
                        }

                        if (answer5 != null)
                        {
                            if (WindowState != FormWindowState.Maximized)
                                Height += 42;
                            else
                                addedHeight += 42;
                            AnswerRadioButton5.Visible = true;
                            AnswerRadioButton5.Text = answer5.Value;
                        }
                        else
                        {
                            return;
                        }

                        if (answer6 != null)
                        {
                            if (WindowState != FormWindowState.Maximized)
                                Height += 42;
                            else
                                addedHeight += 42;
                            AnswerRadioButton6.Visible = true;
                            AnswerRadioButton6.Text = answer6.Value;
                        }
                        else
                        {
                            return;
                        }

                        if (answer7 != null)
                        {
                            if (WindowState != FormWindowState.Maximized)
                                Height += 42;
                            else
                                addedHeight += 42;
                            AnswerRadioButton7.Visible = true;
                            AnswerRadioButton7.Text = answer7.Value;
                        }
                        else
                        {
                            return;
                        }

                        if (answer8 != null)
                        {
                            if (WindowState != FormWindowState.Maximized)
                                Height += 42;
                            else
                                addedHeight += 42;
                            AnswerRadioButton8.Visible = true;
                            AnswerRadioButton8.Text = answer8.Value;
                        }
                    }
                    else if (a.Item(questionsArray[numQuestion]).Attributes["Type"].Value == "Multiple")
                    {
                        AnswerCheckBox1.Visible = AnswerCheckBox2.Visible = AnswerCheckBox3.Visible = true;
                        successfulAnswer = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("True");
                        XmlNode answer1 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer1");
                        XmlNode answer2 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer2");
                        XmlNode answer3 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer3");
                        XmlNode answer4 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer4");
                        XmlNode answer5 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer5");
                        XmlNode answer6 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer6");
                        XmlNode answer7 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer7");
                        XmlNode answer8 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer8");
                        AnswerCheckBox1.Text = answer1.Value;
                        AnswerCheckBox2.Text = answer2.Value;
                        AnswerCheckBox3.Text = answer3.Value;

                        if (answer4 != null)
                        {
                            AnswerCheckBox4.Visible = true;
                            AnswerCheckBox4.Text = answer4.Value;
                        }

                        if (answer5 != null)
                        {
                            if (WindowState != FormWindowState.Maximized)
                                Height += 42;
                            else
                                addedHeight += 42;
                            AnswerCheckBox5.Visible = true;
                            AnswerCheckBox5.Text = answer5.Value;
                        }
                        else
                        {
                            return;
                        }

                        if (answer6 != null)
                        {
                            if (WindowState != FormWindowState.Maximized)
                                Height += 42;
                            else
                                addedHeight += 42;
                            AnswerCheckBox6.Visible = true;
                            AnswerCheckBox6.Text = answer6.Value;
                        }
                        else
                        {
                            return;
                        }

                        if (answer7 != null)
                        {
                            if (WindowState != FormWindowState.Maximized)
                                Height += 42;
                            else
                                addedHeight += 42;
                            AnswerCheckBox7.Visible = true;
                            AnswerCheckBox7.Text = answer7.Value;
                        }
                        else
                        {
                            return;
                        }

                        if (answer8 != null)
                        {
                            if (WindowState != FormWindowState.Maximized)
                                Height += 42;
                            else
                                addedHeight += 42;
                            AnswerCheckBox8.Visible = true;
                            AnswerCheckBox8.Text = answer8.Value;
                        }
                    }

                    else if (a.Item(questionsArray[numQuestion]).Attributes["Type"].Value == "String")
                    {
                        AnswerTextBox.Visible = true;
                        successfulAnswer = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("True");
                    }
                }
                AnswerCheckBox1.Top = AnswerTextBox.Top = AnswerRadioButton1.Top = questionLabel.Location.Y + questionLabel.Height + 20;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CheckСorrectness()
        {
            try
            {
                if (AnswerRadioButton1.Checked)
                {
                    if (AnswerRadioButton1.Text.ToLower() == successfulAnswer.Value.ToLower())
                        mark++;
                }
                else if (AnswerRadioButton2.Checked)
                {
                    if (AnswerRadioButton2.Text.ToLower() == successfulAnswer.Value.ToLower())
                        mark++;
                }
                else if (AnswerRadioButton3.Checked)
                {
                    if (AnswerRadioButton3.Text.ToLower() == successfulAnswer.Value.ToLower())
                        mark++;
                }
                else if (AnswerRadioButton4.Checked)
                {
                    if (AnswerRadioButton4.Text.ToLower() == successfulAnswer.Value.ToLower())
                        mark++;
                }
                else if (AnswerRadioButton5.Checked)
                {
                    if (AnswerRadioButton5.Text.ToLower() == successfulAnswer.Value.ToLower())
                        mark++;
                }
                else if (AnswerRadioButton6.Checked)
                {
                    if (AnswerRadioButton6.Text.ToLower() == successfulAnswer.Value.ToLower())
                        mark++;
                }
                else if (AnswerRadioButton7.Checked)
                {
                    if (AnswerRadioButton7.Text.ToLower() == successfulAnswer.Value.ToLower())
                        mark++;
                }
                else if (AnswerRadioButton8.Checked)
                {
                    if (AnswerRadioButton8.Text.ToLower() == successfulAnswer.Value.ToLower())
                        mark++;
                }
                if (AnswerCheckBox1.Visible)
                {
                    string answerString = "";
                    if (AnswerCheckBox1.Checked)
                        answerString += AnswerCheckBox1.Text;
                    if (AnswerCheckBox2.Checked)
                        answerString += AnswerCheckBox2.Text;
                    if (AnswerCheckBox3.Checked)
                        answerString += AnswerCheckBox3.Text;
                    if(AnswerCheckBox4.Checked)
                        answerString += AnswerCheckBox4.Text;
                    if (answerString == successfulAnswer.Value)
                        mark++;
                    if (AnswerCheckBox5.Checked)
                        answerString += AnswerCheckBox6.Text;
                    if (AnswerCheckBox6.Checked)
                        answerString += AnswerCheckBox6.Text;
                    if (AnswerCheckBox7.Checked)
                        answerString += AnswerCheckBox7.Text;
                    if (AnswerCheckBox8.Checked)
                        answerString += AnswerCheckBox8.Text;
                    if (answerString == successfulAnswer.Value)
                        mark++;
                }
                if (AnswerTextBox.Text.ToLower() == successfulAnswer.Value.ToLower())
                    mark++;
                numQuestion++;
                if (numQuestion > numOfQuestions - 1)
                {
                    if (mark/numOfQuestions > 80)
                        OpenResultForm(mark, 5);
                    else if (mark > 7)
                        OpenResultForm(mark, 4);
                    else if (mark >= 6)
                        OpenResultForm(mark, 3);
                    else
                        OpenResultForm(mark, 2);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void OpenResultForm(double rightNum, int mark)
        {
            Hide();
            TestResultForm form = new TestResultForm(rightNum, mark, numOfQuestions);
            form.ShowDialog();
            Close();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            seconds--;
            if (seconds < 0)
            {
                seconds = 59;
                minutes--;
            }
            if (minutes == 0)
            {
                timerLabel.Text = $"Осталось {seconds} сек";
            }
            else
            {
                timerLabel.Text = $"Осталось {minutes} мин {seconds} сек";
            }
        }

        private void GoNextQuestionButton_Click(object sender, EventArgs e)
        {
            numOfQuestion++;
            numOfQuestionLabel.Text = $"{numOfQuestion} из {numOfQuestions}";
            Height = MinimumSize.Height;
            addedHeight = 0;
            CheckСorrectness();            
            ChangeVisibilityButtons();
            GetXml();
            AnswerRadioButton1.Location = new Point(17, questionLabel.Location.Y + questionLabel.Height + 35);
            AnswerCheckBox1.Location = new Point(1, questionLabel.Location.Y + questionLabel.Height + 35);
        }

        private void TestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
            MainForm form = new MainForm();
            form.ShowDialog();
        }

        private void AnswerTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            GoNextQuestionButton_Click(sender, e);
        }

        private void AnswerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var checkBox = sender as CheckBox;
            if (checkBox.Checked)
            {
                checkBox.Image = Resources._checked;
            }
            else
            {
                checkBox.Image = Resources._unchecked;
            }
        }

        private void FirstAnswerRadioButton_LocationChanged(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Maximized)
                ChangePositionOfRadioButtons(42);
            else
                ChangePositionOfRadioButtons(82);
        }

        private void ChangePositionOfRadioButtons(int y)
        {
            AnswerTextBox.Location = AnswerRadioButton1.Location;
            AnswerRadioButton2.Location = new Point(17, AnswerRadioButton1.Location.Y + y);
            AnswerRadioButton3.Location = new Point(17, AnswerRadioButton2.Location.Y + y);
            AnswerRadioButton4.Location = new Point(17, AnswerRadioButton3.Location.Y + y);
            AnswerRadioButton5.Location = new Point(17, AnswerRadioButton4.Location.Y + y);
            AnswerRadioButton6.Location = new Point(17, AnswerRadioButton5.Location.Y + y);
            AnswerRadioButton7.Location = new Point(17, AnswerRadioButton6.Location.Y + y);
            AnswerRadioButton8.Location = new Point(17, AnswerRadioButton7.Location.Y + y);
        }

        private void FirstAnswerCheckBox_LocationChanged(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Maximized)
                ChangePositionOfCheckBoxes(42);
            else
                ChangePositionOfCheckBoxes(92);
        }

        private void ChangePositionOfCheckBoxes(int y)
        {
            AnswerCheckBox2.Location = new Point(1, AnswerCheckBox1.Location.Y + y);
            AnswerCheckBox3.Location = new Point(1, AnswerCheckBox2.Location.Y + y);
            AnswerCheckBox4.Location = new Point(1, AnswerCheckBox3.Location.Y + y);
            AnswerCheckBox5.Location = new Point(1, AnswerCheckBox4.Location.Y + y);
            AnswerCheckBox6.Location = new Point(1, AnswerCheckBox5.Location.Y + y);
            AnswerCheckBox7.Location = new Point(1, AnswerCheckBox6.Location.Y + y);
            AnswerCheckBox8.Location = new Point(1, AnswerCheckBox7.Location.Y + y);
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
                questionLabel.MaximumSize = new Size(1300, 150);
                AnswerRadioButton1.Font = AnswerRadioButton2.Font = AnswerRadioButton3.Font = AnswerRadioButton4.Font = AnswerRadioButton5.Font =
                AnswerRadioButton6.Font = AnswerRadioButton7.Font = AnswerRadioButton8.Font = AnswerCheckBox1.Font = AnswerCheckBox2.Font =
                AnswerCheckBox3.Font = AnswerCheckBox4.Font = AnswerCheckBox5.Font = AnswerCheckBox6.Font = AnswerCheckBox7.Font = AnswerCheckBox8.Font =
                new Font(AnswerCheckBox1.Font.Name, 22, FontStyle.Bold);
                AnswerTextBox.Font = new Font(AnswerTextBox.Font.Name, 22);
                questionLabel.Font = new Font(questionLabel.Font.Name, 22, FontStyle.Bold);
                headerLabel.Font = new Font(headerLabel.Font.Name, 36, FontStyle.Bold);
                timerLabel.Font = new Font(timerLabel.Font.Name, 22, FontStyle.Bold);
                timerLabel.Left -= 70;
                timerLabel.Width += 70;
                numOfQuestionLabel.Font = new Font(numOfQuestionLabel.Font.Name, 22, FontStyle.Bold);

                startTestButton.Font = new Font(startTestButton.Font.Name, 22, FontStyle.Bold);
                startTestButton.Size = new Size(404, 49);
                startTestButton.Left = (ClientSize.Width - startTestButton.Width) / 2;
                startTestButton.Top = ((ClientSize.Height - startTestButton.Height) / 2) + headerPanel.Height - 46;
            }
            else
            {
                Settings.Default.isFullSize = false;
                WindowState = FormWindowState.Normal;
                changeWindowBoxButton.Tag = "Fullscreen";
                changeWindowBoxButton.Image = Resources.Fullscreen;
                questionLabel.MaximumSize = new Size(900, 150);
                Height += addedHeight;
                addedHeight = 0;
                AnswerRadioButton1.Font = AnswerRadioButton2.Font = AnswerRadioButton3.Font = AnswerRadioButton4.Font = AnswerRadioButton5.Font =
                AnswerRadioButton6.Font = AnswerRadioButton7.Font = AnswerRadioButton8.Font = AnswerCheckBox1.Font = AnswerCheckBox2.Font =
                AnswerCheckBox3.Font = AnswerCheckBox4.Font = AnswerCheckBox5.Font = AnswerCheckBox6.Font = AnswerCheckBox7.Font = AnswerCheckBox8.Font =
                new Font(AnswerCheckBox1.Font.Name, 18, FontStyle.Bold);
                AnswerTextBox.Font = new Font(AnswerTextBox.Font.Name, 18);
                questionLabel.Font = new Font(questionLabel.Font.Name, 18, FontStyle.Bold);
                headerLabel.Font = new Font(headerLabel.Font.Name, 28, FontStyle.Bold);
                timerLabel.Font = new Font(timerLabel.Font.Name, 18, FontStyle.Bold);
                timerLabel.Location = new Point(953, 199);
                timerLabel.Width -= 70;
                numOfQuestionLabel.Font = new Font(numOfQuestionLabel.Font.Name, 18, FontStyle.Bold);

                startTestButton.Font = new Font(startTestButton.Font.Name, 18, FontStyle.Bold);
                startTestButton.Size = new Size(348, 40);
                startTestButton.Left = (ClientSize.Width - startTestButton.Width) / 2;
                startTestButton.Top = ((ClientSize.Height - startTestButton.Height) / 2) + headerPanel.Height - 46;
            }
            AnswerRadioButton1.Location = new Point(17, questionLabel.Location.Y + questionLabel.Height + 35);
            AnswerCheckBox1.Location = new Point(1, questionLabel.Location.Y + questionLabel.Height + 35);
        }
    }
}
