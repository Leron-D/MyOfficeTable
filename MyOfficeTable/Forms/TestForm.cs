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
using MyOfficeTable.Forms;

namespace MyOfficeTable
{
    public partial class TestForm : StyleForm
    {
        public static TestForm _testForm;
        double mark = 0;
        int numOfQuestion = 1;
        int[] questionsArray = new int[15] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
        int numQuestion = 0;
        double numOfQuestions = 0;
        int seconds = 60;
        string testName;
        bool loadForm = true;
        int addedHeight = 0;
        XmlNode successfulAnswer;
        List<MyRadioButton> radioButtonsList;
        List<CheckBox> checkBoxesList;


        public TestForm(string fileName, double numberOfQuestions)
        {
            InitializeComponent();
            _testForm = this;
            numOfQuestions = numberOfQuestions;
            LoadForm(fileName);
        }

        private void LoadForm(string fileName)
        {
            try
            {
                testName = fileName;           
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

                radioButtonsList = new List<MyRadioButton>
                {
                    answerRadioButton1, answerRadioButton2, answerRadioButton3, answerRadioButton4, answerRadioButton5, answerRadioButton6, answerRadioButton7, answerRadioButton8
                };

                checkBoxesList = new List<CheckBox>
                {
                    answerCheckBox1, answerCheckBox2, answerCheckBox3, answerCheckBox4, answerCheckBox5, answerCheckBox6, answerCheckBox7,answerCheckBox8
                };

                timer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangeControlsForNormalScreen()
        {
            try
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
                timerLabel.Location = new Point(ClientSize.Width - timerLabel.Width - 30, timerLabel.Location.Y);
                timerLabel.Width -= 70;
                numOfQuestionLabel.Font = new Font(numOfQuestionLabel.Font.Name, 18, FontStyle.Bold);

                startTestButton.Font = new Font(startTestButton.Font.Name, 18, FontStyle.Bold);
                startTestButton.Size = new Size(348, 40);
                startTestButton.Left = (ClientSize.Width - startTestButton.Width) / 2;
                startTestButton.Top = ((ClientSize.Height - startTestButton.Height) / 2) + panel1.Height - 46;

                goNextQuestionButton.Font = new Font(goNextQuestionButton.Font.Name, 18, FontStyle.Bold);
                if (numOfQuestion != numOfQuestions)
                    goNextQuestionButton.Size = new Size(282, 40);
                else
                    goNextQuestionButton.Size = new Size(346, 40);
                goNextQuestionButton.Location = new Point(ClientSize.Width - goNextQuestionButton.Width, ClientSize.Height - goNextQuestionButton.Height - 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangeControlsForFullscreen()
        {
            try
            {
                Settings.Default.isFullSize = true;
                WindowState = FormWindowState.Maximized;
                changeWindowBoxButton.Tag = "NormalScreen";
                changeWindowBoxButton.Image = Resources.NormalScreen;
                questionLabel.MaximumSize = new Size(1300, 150);
                headerLabel.Font = new Font(headerLabel.Font.Name, 32, FontStyle.Bold);
                answerRadioButton1.Font = answerRadioButton2.Font = answerRadioButton3.Font = answerRadioButton4.Font = answerRadioButton5.Font =
                answerRadioButton6.Font = answerRadioButton7.Font = answerRadioButton8.Font = answerCheckBox1.Font = answerCheckBox2.Font =
                answerCheckBox3.Font = answerCheckBox4.Font = answerCheckBox5.Font = answerCheckBox6.Font = answerCheckBox7.Font = answerCheckBox8.Font =
                new Font(answerCheckBox1.Font.Name, 22, FontStyle.Bold);
                answerTextBox.Font = new Font(answerTextBox.Font.Name, 22);
                questionLabel.Font = new Font(questionLabel.Font.Name, 22, FontStyle.Bold);
                timerLabel.Font = new Font(timerLabel.Font.Name, 22, FontStyle.Bold);
                timerLabel.Location = new Point(ClientSize.Width - timerLabel.Width - 30, timerLabel.Location.Y);
                timerLabel.Width += 70;
                numOfQuestionLabel.Font = new Font(numOfQuestionLabel.Font.Name, 22, FontStyle.Bold);

                startTestButton.Font = new Font(startTestButton.Font.Name, 22, FontStyle.Bold);
                startTestButton.Size = new Size(404, 49);
                startTestButton.Left = (ClientSize.Width - startTestButton.Width) / 2;
                startTestButton.Top = ((ClientSize.Height - startTestButton.Height) / 2) + panel1.Height - 46;

                goNextQuestionButton.Font = new Font(goNextQuestionButton.Font.Name, 22, FontStyle.Bold);
                if (numOfQuestion != numOfQuestions)
                    goNextQuestionButton.Size = new Size(389, 49);
                else
                    goNextQuestionButton.Size = new Size(309, 49);
                goNextQuestionButton.Location = new Point(ClientSize.Width - goNextQuestionButton.Width, ClientSize.Height - goNextQuestionButton.Height - 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangeVisibilityButtons()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetXml()
        {
            try
            {
                questionLabel.Visible = timerLabel.Visible = goNextQuestionButton.Visible = true;
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(testName);
                XmlElement xRoot = xDoc.DocumentElement;
                int n = 0;
                if (xRoot != null)
                {
                    XmlNodeList a = xDoc.GetElementsByTagName("Question");
                    XmlNode question = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Text");
                    questionLabel.Text = $"Вопрос {numQuestion + 1}. {question.Value}";
                    successfulAnswer = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("True");
                    XmlNode answer1 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer1");
                    XmlNode answer2 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer2");
                    XmlNode answer3 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer3");
                    XmlNode answer4 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer4");
                    XmlNode answer5 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer5");
                    XmlNode answer6 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer6");
                    XmlNode answer7 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer7");
                    XmlNode answer8 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer8");
                    List<XmlNode> optionAnswersList = new List<XmlNode>
                    {
                        answer5, answer6, answer7,  answer8
                    };
                    if (a.Item(questionsArray[numQuestion]).Attributes["Type"].Value == "Single")
                    {
                        seconds = 30;
                        answerRadioButton1.Visible = answerRadioButton2.Visible = answerRadioButton3.Visible = answerRadioButton4.Visible = true;
                        answerRadioButton1.Text = answer1.Value;
                        answerRadioButton2.Text = answer2.Value;
                        answerRadioButton3.Text = answer3.Value;
                        answerRadioButton4.Text = answer4.Value;
                        for (int i = 4; i < radioButtonsList.Count; i++)
                        {
                            if (optionAnswersList[n] != null)
                            {
                                if (WindowState != FormWindowState.Maximized)
                                    Height += 42;
                                else
                                    addedHeight += 42;
                                radioButtonsList[i].Visible = true;
                                radioButtonsList[i].Text = optionAnswersList[n].Value;
                            }
                            else
                            {
                                return;
                            }
                            n++;
                        }
                    }
                    else if (a.Item(questionsArray[numQuestion]).Attributes["Type"].Value == "Multiple")
                    {
                        seconds = 60;
                        answerCheckBox1.Visible = answerCheckBox2.Visible = answerCheckBox3.Visible = answerCheckBox4.Visible = true;
                        answerCheckBox1.Text = answer1.Value;
                        answerCheckBox2.Text = answer2.Value;
                        answerCheckBox3.Text = answer3.Value;
                        answerCheckBox4.Text = answer4.Value;

                        for (int i = 4; i < checkBoxesList.Count; i++)
                        {
                            if (optionAnswersList[n] != null)
                            {
                                if (WindowState != FormWindowState.Maximized)
                                    Height += 42;
                                else
                                    addedHeight += 42;
                                checkBoxesList[i].Visible = true;
                                checkBoxesList[i].Text = optionAnswersList[n].Value;
                                n++;
                            }
                            else
                            {
                                return;
                            }
                        }
                    }
                    else if (a.Item(questionsArray[numQuestion]).Attributes["Type"].Value == "String")
                    {
                        seconds = 90;
                        answerTextBox.Visible = true;
                    }
                }
                answerCheckBox1.Top = answerTextBox.Top = answerRadioButton1.Top = questionLabel.Location.Y + questionLabel.Height + 20;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckСorrectness()
        {
            try
            {
                if (answerRadioButton1.Visible)
                {
                    for (int i = 0; i < radioButtonsList.Count - 1; i++)
                    {
                        if (radioButtonsList[i].Text.ToLower() == successfulAnswer.Value.ToLower() && radioButtonsList[i].Checked)
                            mark++;
                    }
                }
                else if (answerCheckBox1.Visible)
                {
                    string answerString = "";
                    for (int i = 0; i < checkBoxesList.Count; i++)
                    {
                        if (checkBoxesList[i].Checked)
                            answerString += checkBoxesList[i].Text;
                    }
                    if (answerString == successfulAnswer.Value)
                        mark++;
                }
                else if (answerTextBox.Visible)
                {
                    if (answerTextBox.Text.ToLower() == successfulAnswer.Value.ToLower())
                        mark++;
                }
                numQuestion++;
                if (numQuestion > numOfQuestions - 1)
                {
                    if ((mark / numOfQuestions) * 100 >= 91)
                        OpenResultForm(mark, 5);
                    else if ((mark / numOfQuestions) * 100 >= 81)
                        OpenResultForm(mark, 4);
                    else if ((mark / numOfQuestions) * 100 >= 70)
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

        private void OpenResultForm(double rightNum, int mark)
        {
            try
            {
                TestResultForm form = new TestResultForm(rightNum, mark, numOfQuestions);
                form.Show();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangePositionOfRadioButtons(int y)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangePositionOfCheckBoxes(int y)
        {
            try
            {
                answerCheckBox2.Location = new Point(1, answerCheckBox1.Location.Y + y);
                answerCheckBox3.Location = new Point(1, answerCheckBox2.Location.Y + y);
                answerCheckBox4.Location = new Point(1, answerCheckBox3.Location.Y + y);
                answerCheckBox5.Location = new Point(1, answerCheckBox4.Location.Y + y);
                answerCheckBox6.Location = new Point(1, answerCheckBox5.Location.Y + y);
                answerCheckBox7.Location = new Point(1, answerCheckBox6.Location.Y + y);
                answerCheckBox8.Location = new Point(1, answerCheckBox7.Location.Y + y);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StartTestButton_Click(object sender, EventArgs e)
        {
            try
            {
                startTestButton.Visible = false;
                numOfQuestionLabel.Visible = true;
                GetXml();
                numOfQuestionLabel.Text = $"{numOfQuestion} из {numOfQuestions}";
                numOfQuestionLabel.Left = (ClientSize.Width - numOfQuestionLabel.Width) / 2;
                timerLabel.Text = $"Осталось {seconds} секунд(-ы)";
                answerRadioButton1.Location = new Point(17, questionLabel.Location.Y + questionLabel.Height + 35);
                answerCheckBox1.Location = new Point(1, questionLabel.Location.Y + questionLabel.Height + 35);
                if (Settings.Default.isFullSize)
                {
                    timerLabel.Width += 70;
                }
                timerLabel.Location = new Point(ClientSize.Width - timerLabel.Width - 30, timerLabel.Location.Y);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                seconds--;
                timerLabel.Text = $"Осталось {seconds} секунд(-ы)";
                if (answerRadioButton1.Visible == true)
                {
                    if (seconds == 0)
                    {
                        seconds = 30;
                        GoNextQuestionButton_Click(this, EventArgs.Empty);
                    }
                }

                else if (answerCheckBox1.Visible == true)
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GoNextQuestionButton_Click(object sender, EventArgs e)
        {
            try
            {
                timer.Stop();
                numOfQuestion++;
                numOfQuestionLabel.Text = $"{numOfQuestion} из {numOfQuestions}";
                Height = MinimumSize.Height;
                addedHeight = 0;
                CheckСorrectness();
                ChangeVisibilityButtons();
                GetXml();
                timerLabel.Text = $"Осталось {seconds} секунд(-ы)";
                answerRadioButton1.Location = new Point(17, questionLabel.Location.Y + questionLabel.Height + 35);
                answerCheckBox1.Location = new Point(1, questionLabel.Location.Y + questionLabel.Height + 35);
                if (numOfQuestion == numOfQuestions)
                {
                    goNextQuestionButton.Text = "Завершить тестирование";
                    goNextQuestionButton.Width += 30;
                    goNextQuestionButton.Left -= 30;
                }
                timer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                SelectThemeForm._selectThemeForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AnswerTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                    GoNextQuestionButton_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AnswerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FirstAnswerRadioButton_LocationChanged(object sender, EventArgs e)
        {
            try
            {
                if (WindowState != FormWindowState.Maximized)
                    ChangePositionOfRadioButtons(42);
                else
                    ChangePositionOfRadioButtons(82);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FirstAnswerCheckBox_LocationChanged(object sender, EventArgs e)
        {
            try
            {
                if (WindowState != FormWindowState.Maximized)
                    ChangePositionOfCheckBoxes(42);
                else
                    ChangePositionOfCheckBoxes(92);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangeWindowBoxButton_Click(object sender, EventArgs e)
        {
            try
            {
                loadForm = false;
                if (changeWindowBoxButton.Tag == "Fullscreen")
                {
                    ChangeControlsForFullscreen();
                }
                else
                {
                    ChangeControlsForNormalScreen();
                }
                answerRadioButton1.Location = new Point(17, questionLabel.Location.Y + questionLabel.Height + 35);
                answerCheckBox1.Location = new Point(1, questionLabel.Location.Y + questionLabel.Height + 35);
                CenterToScreen();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (Settings.Default.isFullSize)
                {
                    loadForm = false;

                    ChangeControlsForFullscreen();
                }
                else
                {
                    ChangeControlsForNormalScreen();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (numOfQuestionLabel.Text != "Номер вопроса")
                {
                    var message = MessageBox.Show("Вы уверены, что хотите завершить тестирование?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (message == DialogResult.Yes)
                    {
                        SelectThemeForm.loadForm = false;
                        SelectThemeForm._selectThemeForm.Show();
                        if (Settings.Default.isFullSize)
                        {
                            SelectThemeForm._selectThemeForm.WindowState = FormWindowState.Maximized;
                        }
                        else
                            SelectThemeForm._selectThemeForm.WindowState = FormWindowState.Normal;
                        Hide();
                    }
                }
                else
                {
                    SelectThemeForm.loadForm = false;
                    SelectThemeForm._selectThemeForm.Show();
                    if (Settings.Default.isFullSize)
                        SelectThemeForm._selectThemeForm.WindowState = FormWindowState.Maximized;
                    else
                        SelectThemeForm._selectThemeForm.WindowState = FormWindowState.Normal;
                    SelectThemeForm._selectThemeForm.Show();
                    Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
