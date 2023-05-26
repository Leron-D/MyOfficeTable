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
            DestinationPictureBox5.AllowDrop = DestinationPictureBox6.AllowDrop = DestinationPictureBox7.AllowDrop = DestinationPictureBox8.AllowDrop =
            DestinationPictureBox9.AllowDrop = DestinationPictureBox10.AllowDrop = DestinationPictureBox11.AllowDrop = DestinationPictureBox12.AllowDrop =
            SourcePictureBox1.AllowDrop = SourcePictureBox2.AllowDrop = SourcePictureBox3.AllowDrop = SourcePictureBox4.AllowDrop = SourcePictureBox4.AllowDrop =
            SourcePictureBox5.AllowDrop = SourcePictureBox6.AllowDrop = SourcePictureBox7.AllowDrop = SourcePictureBox8.AllowDrop = SourcePictureBox9.AllowDrop =
            SourcePictureBox10.AllowDrop = SourcePictureBox11.AllowDrop = SourcePictureBox12.AllowDrop = true;
            headerLabel1.Text = headerLabel2.Text = headerLabel3.Text = headerLabel4.Text = headerLabel5.Text = theme;
            srcPictureBox = null;
            numOfTaskLabel.Left = (ClientSize.Width - numOfTaskLabel.Width) / 2;
            if (theme == "Интерфейс табличного процессора")
            {
                tabControl.SelectedTab = tabControl.TabPages[0];
            }
            else if (theme == "Ссылка на ячейки в табличном процессоре")
            {
                tabControl.SelectedTab = tabControl.TabPages[3];
            }
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
                tabControl.SelectedTab = tabControl.TabPages[1];
                goNextButton.Text = "Продолжить";
                goBackButton.Enabled = true;
            }
            else if (tabControl.SelectedTab == tabControl.TabPages[1] && resultLabel5.Tag == "Correct" && resultLabel6.Tag == "Correct" && resultLabel7.Tag == "Correct" && resultLabel8.Tag == "Correct")
            {
                tabControl.SelectedTab = tabControl.TabPages[2];
                goNextButton.Text = "Завершить";
            }
            else if (tabControl.SelectedTab == tabControl.TabPages[2] && resultLabel9.Tag == "Correct" && resultLabel10.Tag == "Correct" && resultLabel11.Tag == "Correct" && resultLabel12.Tag == "Correct")
            {
                ShowForm(new ResultInteractiveForm(theme));
            }
            else if (tabControl.SelectedTab == tabControl.TabPages[3] && resultLabel13.Tag == "Correct" && resultLabel14.Tag == "Correct" && resultLabel15.Tag == "Correct" && resultLabel16.Tag == "Correct")
            {
                tabControl.SelectedTab = tabControl.TabPages[4];
                goNextButton.Text = "Завершить";
                goBackButton.Enabled = true;
            }
            else if (tabControl.SelectedTab == tabControl.TabPages[4] && resultLabel17.Tag == "Correct" && resultLabel18.Tag == "Correct" && resultLabel19.Tag == "Correct" && resultLabel20.Tag == "Correct")
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
            numOfTask++;
            numOfTaskLabel.Text = $"{numOfTask} из 3";
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
                ChangeImageOfLabel(DestinationPictureBox1, "cut", resultLabel1);
                ChangeImageOfLabel(DestinationPictureBox2, "copyFormat", resultLabel2);
                ChangeImageOfLabel(DestinationPictureBox3, "bold", resultLabel3);
                ChangeImageOfLabel(DestinationPictureBox4, "allLettersUppercase", resultLabel4);
            }
            else if (tabControl.SelectedTab == tabControl.TabPages[1])
            {
                ChangeImageOfLabel(DestinationPictureBox5, "save", resultLabel5);
                ChangeImageOfLabel(DestinationPictureBox6, "print", resultLabel6);
                ChangeImageOfLabel(DestinationPictureBox7, "copy", resultLabel7);
                ChangeImageOfLabel(DestinationPictureBox8, "enter", resultLabel8);
            }
            else if (tabControl.SelectedTab == tabControl.TabPages[2])
            {
                ChangeImageOfLabel(DestinationPictureBox9, "underlined", resultLabel9);
                ChangeImageOfLabel(DestinationPictureBox10, "colorOfFill", resultLabel10);
                ChangeImageOfLabel(DestinationPictureBox11, "italic", resultLabel11);
                ChangeImageOfLabel(DestinationPictureBox12, "colorOfText", resultLabel12);
            }
            else if (tabControl.SelectedTab == tabControl.TabPages[3])
            {
                ChangeImageOfLabel(answerTextBox1, "=A3+$B$2", resultLabel13);
                ChangeImageOfLabel(answerTextBox2, "=B3+$B$2*C3", resultLabel14);
                ChangeImageOfLabel(answerTextBox3, "=$A4+B4", resultLabel15);
                ChangeImageOfLabel(answerTextBox4, "=$B5/B$2", resultLabel16);
            }
            else if (tabControl.SelectedTab == tabControl.TabPages[4])
            {
                ChangeImageOfLabel(answerTextBox5, "=$A$1-C3+B$2", resultLabel17);
                ChangeImageOfLabel(answerTextBox6, "=A$1*B$1", resultLabel18);
                ChangeImageOfLabel(answerTextBox7, "=$B5-B$3/C3", resultLabel19);
                ChangeImageOfLabel(answerTextBox8, "=$B$2/C$3", resultLabel20);
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

        private void ChangeImageOfLabel(TextBox textBox, string formula, Label resultLabel)
        {
            resultLabel.Visible = true;
            if(textBox.Text.ToLower() != formula.ToLower())
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
