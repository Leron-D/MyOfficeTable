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
                answerCheckBox1.Top = answerTextBox.Top = answerRadioButton1.Top = questionLabel.Location.Y + questionLabel.Height + 42;
                answerCheckBox2.Location = new Point(1, answerCheckBox1.Location.Y + 42);
                answerCheckBox3.Location = new Point(1, answerCheckBox2.Location.Y + 42);
                answerCheckBox4.Location = new Point(1, answerCheckBox3.Location.Y + 42);
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
            answerRadioButton1.Location = new Point(17, questionLabel.Location.Y + questionLabel.Height + 35);
            answerCheckBox1.Location = new Point(1, questionLabel.Location.Y + questionLabel.Height + 35);
            if (Settings.Default.isFullSize)
            {
                timerLabel.Left -= 70;
                timerLabel.Width += 70;
            }
        }

        void ChangeVisibilityButtons()
        {
            answerRadioButton1.Visible = answerRadioButton2.Visible = answerRadioButton3.Visible = answerCheckBox1.Visible = timerLabel.Visible = goNextQuestionButton.Visible =
            answerCheckBox2.Visible = answerCheckBox3.Visible = answerCheckBox4.Visible = answerCheckBox4.Checked = answerRadioButton4.Visible = answerRadioButton4.Checked = 
            answerTextBox.Visible = answerRadioButton1.Checked = answerRadioButton2.Checked = answerRadioButton3.Checked = answerRadioButton4.Checked = answerRadioButton5.Checked = 
            answerRadioButton6.Checked = answerRadioButton7.Checked = answerRadioButton8.Checked = answerCheckBox1.Checked = answerCheckBox2.Checked = answerCheckBox3.Checked = 
            answerCheckBox4.Checked = questionLabel.Visible = answerCheckBox5.Checked = answerCheckBox6.Checked = answerCheckBox7.Checked = answerCheckBox8.Checked = 
            answerRadioButton5.Visible = answerCheckBox5.Visible = answerRadioButton6.Visible = answerCheckBox6.Visible = answerRadioButton7.Visible = answerCheckBox7.Visible = 
            answerRadioButton8.Visible = answerCheckBox8.Visible = false;
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
                        answerRadioButton1.Visible = answerRadioButton2.Visible = answerRadioButton3.Visible = true;
                        successfulAnswer = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("True");
                        XmlNode answer1 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer1");
                        XmlNode answer2 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer2");
                        XmlNode answer3 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer3");
                        XmlNode answer4 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer4");
                        XmlNode answer5 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer5");
                        XmlNode answer6 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer6");
                        XmlNode answer7 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer7");
                        XmlNode answer8 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer8");
                        answerRadioButton1.Text = answer1.Value;
                        answerRadioButton2.Text = answer2.Value;
                        answerRadioButton3.Text = answer3.Value;
                        if (answer4 != null)
                        {
                            answerRadioButton4.Visible = true;
                            answerRadioButton4.Text = answer4.Value;
                        }

                        if (answer5 != null)
                        {
                            if (WindowState != FormWindowState.Maximized)
                                Height += 42;
                            else
                                addedHeight += 42;
                            answerRadioButton5.Visible = true;
                            answerRadioButton5.Text = answer5.Value;
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
                            answerRadioButton6.Visible = true;
                            answerRadioButton6.Text = answer6.Value;
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
                            answerRadioButton7.Visible = true;
                            answerRadioButton7.Text = answer7.Value;
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
                            answerRadioButton8.Visible = true;
                            answerRadioButton8.Text = answer8.Value;
                        }
                    }
                    else if (a.Item(questionsArray[numQuestion]).Attributes["Type"].Value == "Multiple")
                    {
                        answerCheckBox1.Visible = answerCheckBox2.Visible = answerCheckBox3.Visible = true;
                        successfulAnswer = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("True");
                        XmlNode answer1 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer1");
                        XmlNode answer2 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer2");
                        XmlNode answer3 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer3");
                        XmlNode answer4 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer4");
                        XmlNode answer5 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer5");
                        XmlNode answer6 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer6");
                        XmlNode answer7 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer7");
                        XmlNode answer8 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer8");
                        answerCheckBox1.Text = answer1.Value;
                        answerCheckBox2.Text = answer2.Value;
                        answerCheckBox3.Text = answer3.Value;

                        if (answer4 != null)
                        {
                            answerCheckBox4.Visible = true;
                            answerCheckBox4.Text = answer4.Value;
                        }

                        if (answer5 != null)
                        {
                            if (WindowState != FormWindowState.Maximized)
                                Height += 42;
                            else
                                addedHeight += 42;
                            answerCheckBox5.Visible = true;
                            answerCheckBox5.Text = answer5.Value;
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
                            answerCheckBox6.Visible = true;
                            answerCheckBox6.Text = answer6.Value;
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
                            answerCheckBox7.Visible = true;
                            answerCheckBox7.Text = answer7.Value;
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
                            answerCheckBox8.Visible = true;
                            answerCheckBox8.Text = answer8.Value;
                        }
                    }

                    else if (a.Item(questionsArray[numQuestion]).Attributes["Type"].Value == "String")
                    {
                        answerTextBox.Visible = true;
                        successfulAnswer = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("True");
                    }
                }
                answerCheckBox1.Top = answerTextBox.Top = answerRadioButton1.Top = questionLabel.Location.Y + questionLabel.Height + 20;
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
                if (answerRadioButton1.Checked)
                {
                    if (answerRadioButton1.Text.ToLower() == successfulAnswer.Value.ToLower())
                        mark++;
                }
                else if (answerRadioButton2.Checked)
                {
                    if (answerRadioButton2.Text.ToLower() == successfulAnswer.Value.ToLower())
                        mark++;
                }
                else if (answerRadioButton3.Checked)
                {
                    if (answerRadioButton3.Text.ToLower() == successfulAnswer.Value.ToLower())
                        mark++;
                }
                else if (answerRadioButton4.Checked)
                {
                    if (answerRadioButton4.Text.ToLower() == successfulAnswer.Value.ToLower())
                        mark++;
                }
                else if (answerRadioButton5.Checked)
                {
                    if (answerRadioButton5.Text.ToLower() == successfulAnswer.Value.ToLower())
                        mark++;
                }
                else if (answerRadioButton6.Checked)
                {
                    if (answerRadioButton6.Text.ToLower() == successfulAnswer.Value.ToLower())
                        mark++;
                }
                else if (answerRadioButton7.Checked)
                {
                    if (answerRadioButton7.Text.ToLower() == successfulAnswer.Value.ToLower())
                        mark++;
                }
                else if (answerRadioButton8.Checked)
                {
                    if (answerRadioButton8.Text.ToLower() == successfulAnswer.Value.ToLower())
                        mark++;
                }
                if (answerCheckBox1.Visible)
                {
                    string answerString = "";
                    if (answerCheckBox1.Checked)
                        answerString += answerCheckBox1.Text;
                    if (answerCheckBox2.Checked)
                        answerString += answerCheckBox2.Text;
                    if (answerCheckBox3.Checked)
                        answerString += answerCheckBox3.Text;
                    if(answerCheckBox4.Checked)
                        answerString += answerCheckBox4.Text;
                    if (answerString == successfulAnswer.Value)
                        mark++;
                    if (answerCheckBox5.Checked)
                        answerString += answerCheckBox6.Text;
                    if (answerCheckBox6.Checked)
                        answerString += answerCheckBox6.Text;
                    if (answerCheckBox7.Checked)
                        answerString += answerCheckBox7.Text;
                    if (answerCheckBox8.Checked)
                        answerString += answerCheckBox8.Text;
                    if (answerString == successfulAnswer.Value)
                        mark++;
                }
                if (answerTextBox.Text.ToLower() == successfulAnswer.Value.ToLower())
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
            answerRadioButton1.Location = new Point(17, questionLabel.Location.Y + questionLabel.Height + 35);
            answerCheckBox1.Location = new Point(1, questionLabel.Location.Y + questionLabel.Height + 35);
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
            answerTextBox.Location = answerRadioButton1.Location;
            answerRadioButton2.Location = new Point(17, answerRadioButton1.Location.Y + y);
            answerRadioButton3.Location = new Point(17, answerRadioButton2.Location.Y + y);
            answerRadioButton4.Location = new Point(17, answerRadioButton3.Location.Y + y);
            answerRadioButton5.Location = new Point(17, answerRadioButton4.Location.Y + y);
            answerRadioButton6.Location = new Point(17, answerRadioButton5.Location.Y + y);
            answerRadioButton7.Location = new Point(17, answerRadioButton6.Location.Y + y);
            answerRadioButton8.Location = new Point(17, answerRadioButton7.Location.Y + y);
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
            answerCheckBox2.Location = new Point(1, answerCheckBox1.Location.Y + y);
            answerCheckBox3.Location = new Point(1, answerCheckBox2.Location.Y + y);
            answerCheckBox4.Location = new Point(1, answerCheckBox3.Location.Y + y);
            answerCheckBox5.Location = new Point(1, answerCheckBox4.Location.Y + y);
            answerCheckBox6.Location = new Point(1, answerCheckBox5.Location.Y + y);
            answerCheckBox7.Location = new Point(1, answerCheckBox6.Location.Y + y);
            answerCheckBox8.Location = new Point(1, answerCheckBox7.Location.Y + y);
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
                answerRadioButton1.Font = answerRadioButton2.Font = answerRadioButton3.Font = answerRadioButton4.Font = answerRadioButton5.Font =
                answerRadioButton6.Font = answerRadioButton7.Font = answerRadioButton8.Font = answerCheckBox1.Font = answerCheckBox2.Font =
                answerCheckBox3.Font = answerCheckBox4.Font = answerCheckBox5.Font = answerCheckBox6.Font = answerCheckBox7.Font = answerCheckBox8.Font =
                new Font(answerCheckBox1.Font.Name, 22, FontStyle.Bold);
                answerTextBox.Font = new Font(answerTextBox.Font.Name, 22);
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
                answerRadioButton1.Font = answerRadioButton2.Font = answerRadioButton3.Font = answerRadioButton4.Font = answerRadioButton5.Font =
                answerRadioButton6.Font = answerRadioButton7.Font = answerRadioButton8.Font = answerCheckBox1.Font = answerCheckBox2.Font =
                answerCheckBox3.Font = answerCheckBox4.Font = answerCheckBox5.Font = answerCheckBox6.Font = answerCheckBox7.Font = answerCheckBox8.Font =
                new Font(answerCheckBox1.Font.Name, 18, FontStyle.Bold);
                answerTextBox.Font = new Font(answerTextBox.Font.Name, 18);
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
            answerRadioButton1.Location = new Point(17, questionLabel.Location.Y + questionLabel.Height + 35);
            answerCheckBox1.Location = new Point(1, questionLabel.Location.Y + questionLabel.Height + 35);
        }
    }
}
