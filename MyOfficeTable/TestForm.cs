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

namespace MyOfficeTable
{
    public partial class TestForm : Form
    {
        int mark = 0;
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
                startTestButton.Left = (ClientSize.Width - startTestButton.Width) / 2;
                startTestButton.Top = (ClientSize.Height - startTestButton.Height) / 2;
                firstAnswerCheckBox.Location = answerTextBox.Location = new Point(12, 144);
                secondAnswerCheckBox.Location = new Point(12, 181);
                thirdAnswerCheckBox.Location = new Point(12, 218);
                ToolTip toolTip = new ToolTip();
                toolTip.SetToolTip(collapseButton, "Свернуть");
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

        private void CollapseButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
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
            GetXml();
        }

        void ChangeVisibilityButtons()
        {
            firstAnswerRadioButton.Visible = secondAnswerRadioButton.Visible = thirdAnswerRadioButton.Visible = firstAnswerCheckBox.Visible = timerLabel.Visible = goNextQuestionButton.Visible =
                secondAnswerCheckBox.Visible = thirdAnswerCheckBox.Visible = answerTextBox.Visible = firstAnswerRadioButton.Checked = secondAnswerRadioButton.Checked = 
                thirdAnswerRadioButton.Checked = firstAnswerCheckBox.Checked = secondAnswerCheckBox.Checked = thirdAnswerCheckBox.Checked = questionLabel.Visible = false;
            answerTextBox.Text = "";
        }

        void GetXml()
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
                    firstAnswerRadioButton.Visible = true;
                    secondAnswerRadioButton.Visible = true;
                    thirdAnswerRadioButton.Visible = true;
                    successfulAnswer = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("True");
                    XmlNode answer1 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer1");
                    XmlNode answer2 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer2");
                    XmlNode answer3 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer3");
                    firstAnswerRadioButton.Text = answer1.Value;
                    secondAnswerRadioButton.Text = answer2.Value;
                    thirdAnswerRadioButton.Text = answer3.Value;
                }
                else if (a.Item(questionsArray[numQuestion]).Attributes["Type"].Value == "Multiple")
                {
                    seconds = 60;
                    timer.Start();
                    firstAnswerCheckBox.Visible = true;
                    secondAnswerCheckBox.Visible = true;
                    thirdAnswerCheckBox.Visible = true;
                    successfulAnswer = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("True");
                    XmlNode answer1 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer1");
                    XmlNode answer2 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer2");
                    XmlNode answer3 = a.Item(questionsArray[numQuestion]).Attributes.GetNamedItem("Answer3");
                    firstAnswerCheckBox.Text = answer1.Value;
                    secondAnswerCheckBox.Text = answer2.Value;
                    thirdAnswerCheckBox.Text = answer3.Value;
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
                if (firstAnswerCheckBox.Visible)
                {
                    string answerString = "";
                    if (firstAnswerCheckBox.Checked)
                        answerString += firstAnswerCheckBox.Text;
                    if (secondAnswerCheckBox.Checked)
                        answerString += secondAnswerCheckBox.Text;
                    if (thirdAnswerCheckBox.Checked)
                        answerString += thirdAnswerCheckBox.Text;
                    if (answerString == successfulAnswer.Value)
                        mark++;
                }
                if (answerTextBox.Text.ToLower() == successfulAnswer.Value.ToLower())
                    mark++;
                numQuestion++;
                if (numQuestion > 9)
                {
                    timer.Stop();
                    if (mark > 8.5)
                        OpenResultForm(mark, 5);
                    else if (mark > 7.5)
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
            CheckСorrectness();
            ChangeVisibilityButtons();
            GetXml();
        }

        private void TestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
            MainForm form = new MainForm();
            form.ShowDialog();
        }
    }
}
