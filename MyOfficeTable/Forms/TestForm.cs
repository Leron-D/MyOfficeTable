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
using WindowsFormsApp1;
using CheckBox = System.Windows.Forms.CheckBox;
using Polly;
using Microsoft.Web.WebView2.Core;

namespace MyOfficeTable
{
    public partial class TestForm : Form
    {
        int mark = 0;
        int numOfQuestion = 1;
        int[] questionsArray = new int[15] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
        int numQuestion = 0;
        int seconds = 0;
        private Point mouseOffset;
        private Point currentOffset;
        private bool isMouseDown = false;
        string testName;
        XmlNode successfulAnswer;

        public TestForm(string fileName)
        {
            InitializeComponent();
            LoadForm(fileName);
            headerLabel.Left = (ClientSize.Width - headerLabel.Width) / 2;
        }

        private void LoadForm(string fileName)
        {
            try
            {
                startTestButton.Left = (ClientSize.Width - startTestButton.Width) / 2;
                startTestButton.Top = ((ClientSize.Height - startTestButton.Height) / 2) + headerPanel.Height - 46;
                offLabel.Left = (ClientSize.Width - offLabel.Width) / 2;
                numOfQuestionLabel.Left = offLabel.Left - 51;
                allNumQuestionLabel.Left = offLabel.Left + 51;
                firstAnswerCheckBox.Location = answerTextBox.Location = firstAnswerRadioButton.Location;
                secondAnswerCheckBox.Location = new Point(12, firstAnswerCheckBox.Location.Y + 42);
                thirdAnswerCheckBox.Location = new Point(12, secondAnswerCheckBox.Location.Y + 42);
                fourthAnswerCheckBox.Location = new Point(12, thirdAnswerCheckBox.Location.Y + 42);
                ToolTip toolTip = new ToolTip();
                toolTip.SetToolTip(minimizeButton, "Свернуть");
                toolTip.SetToolTip(cancelButton, "Закрыть");
                testName = fileName;
                Random rnd = new Random();
                for (int i = questionsArray.Length - 1; i >= 1; i--)
                {
                    int j = rnd.Next(i + 1);
                    var temp = questionsArray[j];
                    questionsArray[j] = questionsArray[i];
                    questionsArray[i] = temp;
                }
                ChangeVisibilityButtons();
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
            numOfQuestionLabel.Visible = offLabel.Visible = allNumQuestionLabel.Visible = true;
            numOfQuestionLabel.Text = $"{numOfQuestion}";
            GetXml();
            timerLabel.Text = $"Осталось {seconds} секунд(-ы)";
        }

        void ChangeVisibilityButtons()
        {
            firstAnswerRadioButton.Visible = secondAnswerRadioButton.Visible = thirdAnswerRadioButton.Visible = firstAnswerCheckBox.Visible = timerLabel.Visible = goNextQuestionButton.Visible =
            secondAnswerCheckBox.Visible = thirdAnswerCheckBox.Visible = fourthAnswerCheckBox.Visible = fourthAnswerCheckBox.Checked = fourthAnswerRadioButton.Visible = fourthAnswerRadioButton.Checked = answerTextBox.Visible = firstAnswerRadioButton.Checked = 
            secondAnswerRadioButton.Checked = thirdAnswerRadioButton.Checked = firstAnswerCheckBox.Checked = secondAnswerCheckBox.Checked = thirdAnswerCheckBox.Checked = questionLabel.Visible = 
            fifthAnswerRadioButton.Visible = fifthAnswerCheckBox.Visible = sixthAnswerRadioButton.Visible = sixthAnswerCheckBox.Visible = seventhAnswerRadioButton.Visible = seventhAnswerCheckBox.Visible = 
            eighthAnswerRadioButton.Visible = eighthAnswerCheckBox.Visible = false;
            answerTextBox.Text = "";
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
                        seconds = 30;
                        timer.Start();
                        firstAnswerRadioButton.Visible = secondAnswerRadioButton.Visible = thirdAnswerRadioButton.Visible = true;
                        successfulAnswer = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("True");
                        XmlNode answer1 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer1");
                        XmlNode answer2 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer2");
                        XmlNode answer3 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer3");
                        XmlNode answer4 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer4");
                        XmlNode answer5 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer5");
                        XmlNode answer6 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer6");
                        XmlNode answer7 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer7");
                        XmlNode answer8 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer8");
                        firstAnswerRadioButton.Text = answer1.Value;
                        secondAnswerRadioButton.Text = answer2.Value;
                        thirdAnswerRadioButton.Text = answer3.Value;
                        if (answer4 != null)
                        {
                            fourthAnswerRadioButton.Visible = true;
                            fourthAnswerRadioButton.Text = answer4.Value;
                            Height += 42;
                        }

                        if (answer5 != null)
                        {
                            Height += 42;
                            fifthAnswerRadioButton.Location = new Point(12, fourthAnswerRadioButton.Location.Y + 42);
                            fifthAnswerRadioButton.Visible = true;
                            fifthAnswerRadioButton.Text = answer5.Value;
                        }
                        else
                        {
                            return;
                        }

                        if (answer6 != null)
                        {
                            Height += 42;
                            sixthAnswerRadioButton.Location = new Point(12, fifthAnswerRadioButton.Location.Y + 42);
                            sixthAnswerRadioButton.Visible = true;
                            sixthAnswerRadioButton.Text = answer6.Value;
                        }
                        else
                        {
                            return;
                        }

                        if (answer7 != null)
                        {
                            Height += 42;
                            seventhAnswerRadioButton.Location = new Point(12, sixthAnswerRadioButton.Location.Y + 42);
                            seventhAnswerRadioButton.Visible = true;
                            seventhAnswerRadioButton.Text = answer7.Value;
                        }
                        else
                        {
                            return;
                        }

                        if (answer8 != null)
                        {
                            Height += 42;
                            eighthAnswerRadioButton.Location = new Point(12, seventhAnswerRadioButton.Location.Y + 42);
                            eighthAnswerRadioButton.Visible = true;
                            eighthAnswerRadioButton.Text = answer8.Value;
                        }
                    }
                    else if (a.Item(questionsArray[numQuestion]).Attributes["Type"].Value == "Multiple")
                    {
                        seconds = 60;
                        timer.Start();
                        firstAnswerCheckBox.Visible = secondAnswerCheckBox.Visible = thirdAnswerCheckBox.Visible = true;
                        successfulAnswer = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("True");
                        XmlNode answer1 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer1");
                        XmlNode answer2 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer2");
                        XmlNode answer3 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer3");
                        XmlNode answer4 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer4");
                        XmlNode answer5 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer5");
                        XmlNode answer6 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer6");
                        XmlNode answer7 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer7");
                        XmlNode answer8 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer8");
                        firstAnswerCheckBox.Text = answer1.Value;
                        secondAnswerCheckBox.Text = answer2.Value;
                        thirdAnswerCheckBox.Text = answer3.Value;

                        if (answer4 != null)
                        {
                            fourthAnswerCheckBox.Visible = true;
                            fourthAnswerCheckBox.Text = answer4.Value;
                        }

                        if (answer5 != null)
                        {
                            Height += 42;
                            fifthAnswerCheckBox.Location = new Point(12, fourthAnswerCheckBox.Location.Y + 42);
                            fifthAnswerCheckBox.Visible = true;
                            fifthAnswerCheckBox.Text = answer5.Value;
                        }
                        else
                        {
                            return;
                        }

                        if (answer6 != null)
                        {
                            Height += 42;
                            sixthAnswerCheckBox.Location = new Point(12, fifthAnswerCheckBox.Location.Y + 42);
                            sixthAnswerCheckBox.Visible = true;
                            sixthAnswerCheckBox.Text = answer6.Value;
                        }
                        else
                        {
                            return;
                        }

                        if (answer7 != null)
                        {
                            Height += 42;
                            seventhAnswerCheckBox.Location = new Point(12, sixthAnswerCheckBox.Location.Y + 42);
                            seventhAnswerCheckBox.Visible = true;
                            seventhAnswerCheckBox.Text = answer7.Value;
                        }
                        else
                        {
                            return;
                        }

                        if (answer8 != null)
                        {
                            Height += 42;
                            eighthAnswerCheckBox.Location = new Point(12, seventhAnswerCheckBox.Location.Y + 42);
                            eighthAnswerCheckBox.Visible = true;
                            eighthAnswerCheckBox.Text = answer8.Value;
                        }
                    }

                    else if (a.Item(questionsArray[numQuestion]).Attributes["Type"].Value == "String")
                    {
                        seconds = 90;
                        timer.Start();
                        answerTextBox.Visible = true;
                        successfulAnswer = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("True");
                    }
                }
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
                if (firstAnswerRadioButton.Checked)
                {
                    if (firstAnswerRadioButton.Text.ToLower() == successfulAnswer.Value.ToLower())
                        mark++;
                }
                else if (secondAnswerRadioButton.Checked)
                {
                    if (secondAnswerRadioButton.Text.ToLower() == successfulAnswer.Value.ToLower())
                        mark++;
                }
                else if (thirdAnswerRadioButton.Checked)
                {
                    if (thirdAnswerRadioButton.Text.ToLower() == successfulAnswer.Value.ToLower())
                        mark++;
                }
                else if (fourthAnswerRadioButton.Checked)
                {
                    if (fourthAnswerRadioButton.Text.ToLower() == successfulAnswer.Value.ToLower())
                        mark++;
                }
                if (firstAnswerCheckBox.Visible)
                {
                    string answerString = "";
                    if (firstAnswerCheckBox.Checked)
                        answerString += firstAnswerCheckBox.Text;
                    if (secondAnswerCheckBox.Checked)
                        answerString += secondAnswerCheckBox.Text;
                    if (thirdAnswerCheckBox.Checked)
                        answerString += thirdAnswerCheckBox.Text;
                    if(fourthAnswerCheckBox.Checked)
                        answerString += fourthAnswerCheckBox.Text;
                    if (answerString == successfulAnswer.Value)
                        mark++;
                }
                if (answerTextBox.Text.ToLower() == successfulAnswer.Value.ToLower())
                    mark++;
                numQuestion++;
                if (numQuestion > 9)
                {
                    timer.Stop();
                    if (mark > 8)
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

        void OpenResultForm(int rightNum, int mark)
        {
            Hide();
            TestResultForm form = new TestResultForm(rightNum, mark);
            form.ShowDialog();
            Close();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            seconds--;
            timerLabel.Text = $"Осталось {seconds} секунд(-ы)";
            if (firstAnswerRadioButton.Visible == true)
            {
                if (seconds == 0)
                {
                    seconds = 30;
                    GoNextQuestionButton_Click(this, EventArgs.Empty);
                }
            }

            else if (firstAnswerCheckBox.Visible == true)
            {
                if (seconds == 0)
                {
                    seconds = 60;
                    GoNextQuestionButton_Click(this, EventArgs.Empty);
                }
            }           
            else if (answerTextBox.Visible == true)
            {
                if (seconds == 0)
                {
                    seconds = 90;
                    GoNextQuestionButton_Click(this, EventArgs.Empty);
                }
            }
        }

        private void GoNextQuestionButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
            numOfQuestion++;
            numOfQuestionLabel.Text = $"{numOfQuestion}";
            Height = MinimumSize.Height;
            CheckСorrectness();            
            ChangeVisibilityButtons();
            GetXml();
            timerLabel.Text = $"Осталось {seconds} секунд(-ы)";
            timer.Start();

        }

        private void TestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
            MainForm form = new MainForm();
            form.ShowDialog();
        }

        private void AnswerTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                var question = MessageBox.Show("Вы уверены, что хотите продолжить?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(question == DialogResult.Yes)
                {
                    GoNextQuestionButton_Click(sender, e);
                }
            }
        }

        private void AnswerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var checkBox = sender as CheckBox;
            if (checkBox.Checked)
            {
                checkBox.Image = Properties.Resources._checked;
            }
            else
            {
                checkBox.Image = Properties.Resources._unchecked;
            }
        }

        private void FirstAnswerRadioButton_LocationChanged(object sender, EventArgs e)
        {
            secondAnswerRadioButton.Location = secondAnswerCheckBox.Location = new Point(12, firstAnswerRadioButton.Location.Y + 42);
            thirdAnswerRadioButton.Location = thirdAnswerCheckBox.Location = new Point(12, secondAnswerRadioButton.Location.Y + 42);
            fourthAnswerRadioButton.Location = fourthAnswerCheckBox.Location = new Point(12, thirdAnswerRadioButton.Location.Y + 42);
        }

        private void QuestionLabel_Resize(object sender, EventArgs e)
        {
            int height = questionLabel.Size.Height + questionLabel.Location.Y;
            if (height > 290)
            {
                firstAnswerRadioButton.Location = firstAnswerCheckBox.Location = new Point(12, height + 15);
            }
            else
            {
                firstAnswerRadioButton.Location = firstAnswerCheckBox.Location = new Point(12, 305);
            }
        }
    }
}
