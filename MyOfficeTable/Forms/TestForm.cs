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
        private List<MyRadioButton> radioButtons;
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
        }

        private void LoadForm(string fileName)
        {
            try
            {                
                testName = fileName;                
                headerLabel.Text = Path.GetFileNameWithoutExtension(testName);
                startTestButton.Left = (ClientSize.Width - startTestButton.Width) / 2;
                startTestButton.Top = ((ClientSize.Height - startTestButton.Height) / 2) + headerPanel.Height - 46;
                offLabel.Left = (ClientSize.Width - offLabel.Width) / 2;
                numOfQuestionLabel.Left = offLabel.Left - 51;
                allNumQuestionLabel.Left = offLabel.Left + 51;
                //firstAnswerCheckBox.Location = answerTextBox.Location = firstAnswerRadioButton.Location;
                //secondAnswerCheckBox.Location = new Point(1, firstAnswerCheckBox.Location.Y + 42);
                //thirdAnswerCheckBox.Location = new Point(1, secondAnswerCheckBox.Location.Y + 42);
                //fourthAnswerCheckBox.Location = new Point(1, thirdAnswerCheckBox.Location.Y + 42);
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
            
            AnswerRadioButton1.Visible = AnswerRadioButton2.Visible = AnswerRadioButton3.Visible = AnswerCheckBox1.Visible = timerLabel.Visible = goNextQuestionButton.Visible =
            AnswerCheckBox2.Visible = AnswerCheckBox3.Visible = AnswerCheckBox4.Visible = AnswerCheckBox4.Checked = AnswerRadioButton4.Visible = AnswerRadioButton4.Checked = answerTextBox.Visible = AnswerRadioButton1.Checked = 
            AnswerRadioButton2.Checked = AnswerRadioButton3.Checked = AnswerCheckBox1.Checked = AnswerCheckBox2.Checked = AnswerCheckBox3.Checked = questionLabel.Visible = 
            AnswerRadioButton5.Visible = AnswerCheckBox5.Visible = AnswerRadioButton6.Visible = AnswerCheckBox6.Visible = AnswerRadioButton7.Visible = AnswerCheckBox7.Visible = 
            AnswerRadioButton8.Visible = AnswerCheckBox8.Visible = false;
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
                            Height += 42;
                        }

                        if (answer5 != null)
                        {
                            Height += 42;
                            AnswerRadioButton5.Location = new Point(17, AnswerRadioButton4.Location.Y + 42);
                            AnswerRadioButton5.Visible = true;
                            AnswerRadioButton5.Text = answer5.Value;
                        }
                        else
                        {
                            return;
                        }

                        if (answer6 != null)
                        {
                            Height += 42;
                            AnswerRadioButton6.Location = new Point(17, AnswerRadioButton5.Location.Y + 42);
                            AnswerRadioButton6.Visible = true;
                            AnswerRadioButton6.Text = answer6.Value;
                        }
                        else
                        {
                            return;
                        }

                        if (answer7 != null)
                        {
                            Height += 42;
                            AnswerRadioButton7.Location = new Point(17, AnswerRadioButton6.Location.Y + 42);
                            AnswerRadioButton7.Visible = true;
                            AnswerRadioButton7.Text = answer7.Value;
                        }
                        else
                        {
                            return;
                        }

                        if (answer8 != null)
                        {
                            Height += 42;
                            AnswerRadioButton8.Location = new Point(17, AnswerRadioButton7.Location.Y + 42);
                            AnswerRadioButton8.Visible = true;
                            AnswerRadioButton8.Text = answer8.Value;
                        }
                    }
                    else if (a.Item(questionsArray[numQuestion]).Attributes["Type"].Value == "Multiple")
                    {
                        seconds = 60;
                        timer.Start();
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
                            Height += 42;
                            AnswerCheckBox5.Location = new Point(1, AnswerCheckBox4.Location.Y + 42);
                            AnswerCheckBox5.Visible = true;
                            AnswerCheckBox5.Text = answer5.Value;
                        }
                        else
                        {
                            return;
                        }

                        if (answer6 != null)
                        {
                            Height += 42;
                            AnswerCheckBox6.Location = new Point(1, AnswerCheckBox5.Location.Y + 42);
                            AnswerCheckBox6.Visible = true;
                            AnswerCheckBox6.Text = answer6.Value;
                        }
                        else
                        {
                            return;
                        }

                        if (answer7 != null)
                        {
                            Height += 42;
                            AnswerCheckBox7.Location = new Point(1, AnswerCheckBox6.Location.Y + 42);
                            AnswerCheckBox7.Visible = true;
                            AnswerCheckBox7.Text = answer7.Value;
                        }
                        else
                        {
                            return;
                        }

                        if (answer8 != null)
                        {
                            Height += 42;
                            AnswerCheckBox8.Location = new Point(1, AnswerCheckBox7.Location.Y + 42);
                            AnswerCheckBox8.Visible = true;
                            AnswerCheckBox8.Text = answer8.Value;
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
            if (AnswerRadioButton1.Visible == true)
            {
                if (seconds == 0)
                {
                    seconds = 30;
                    GoNextQuestionButton_Click(this, EventArgs.Empty);
                }
            }

            else if (AnswerCheckBox1.Visible == true)
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
            AnswerRadioButton2.Location = new Point(17, AnswerRadioButton1.Location.Y + 42);
            AnswerRadioButton3.Location = new Point(17, AnswerRadioButton2.Location.Y + 42);
            AnswerRadioButton4.Location = new Point(17, AnswerRadioButton3.Location.Y + 42);
        }

        private void QuestionLabel_Resize(object sender, EventArgs e)
        {
            int height = questionLabel.Size.Height + questionLabel.Location.Y;
            if (height > 275)
            {
                AnswerRadioButton1.Location = answerTextBox.Location = new Point(17, height + 16);
                AnswerCheckBox1.Location = new Point(1, height + 16);
            }
            else
            {
                AnswerRadioButton1.Location = answerTextBox.Location = new Point(17, 267);
                AnswerCheckBox1.Location = new Point(1, 260);
            }
        }

        private void FirstAnswerCheckBox_LocationChanged(object sender, EventArgs e)
        {
            AnswerCheckBox2.Location = new Point(1, AnswerCheckBox1.Location.Y + 42);
            AnswerCheckBox3.Location = new Point(1, AnswerCheckBox2.Location.Y + 42);
            AnswerCheckBox4.Location = new Point(1, AnswerCheckBox3.Location.Y + 42);
        }
    }
}
