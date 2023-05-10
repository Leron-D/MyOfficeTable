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

        public InteractiveTaskForm()
        {
            InitializeComponent();
            Settings.Default.firstLoadInstruction = false;
            Settings.Default.Save();
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(helpButton, "Помощь");
            tabControl.Multiline = true;
            tabControl.Appearance = TabAppearance.Buttons;
            tabControl.ItemSize = new System.Drawing.Size(0, 1);
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.TabStop = false;
            DestinationPictureBox1.AllowDrop = DestinationPictureBox2.AllowDrop = DestinationPictureBox3.AllowDrop = DestinationPictureBox4.AllowDrop =
            DestinationPictureBox5.AllowDrop = DestinationPictureBox6.AllowDrop = DestinationPictureBox7.AllowDrop = DestinationPictureBox8.AllowDrop =
            DestinationPictureBox9.AllowDrop = DestinationPictureBox10.AllowDrop = DestinationPictureBox11.AllowDrop = DestinationPictureBox12.AllowDrop = true;
            srcPictureBox = null;
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

        private void SourcePictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            srcPictureBox = sender as PictureBox;
            PictureBox pictureBox = sender as PictureBox;
            if (e.Button == MouseButtons.Left && pictureBox.Image != null)
                pictureBox.DoDragDrop(pictureBox.Image, DragDropEffects.Move);
        }

        private void DestinationPictureBox_DragEnter(object sender, DragEventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Move) != 0)
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void DestinationPictureBox_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox destinationPictureBox = sender as PictureBox;
            if (destinationPictureBox.Image == null)
            {
                destinationPictureBox.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap, true);
                destinationPictureBox.Tag = srcPictureBox.Tag;
                srcPictureBox.Image = null;            
                CheckCorrectness();
            }
        }

        private void DestinationPictureBox_DoubleClick(object sender, EventArgs e)
        {
            DoOnDoubleClick(sender as PictureBox);
        }

        private void DoOnDoubleClick(PictureBox destinationPictureBox)
        {
            if (destinationPictureBox.Tag != null)
            {
                if (destinationPictureBox.Tag == "cut")
                {
                    ReturnPicture(SourcePictureBox1, destinationPictureBox, resultLabel1);
                }
                else if (destinationPictureBox.Tag == "copyFormat")
                {
                    ReturnPicture(SourcePictureBox2, destinationPictureBox, resultLabel2);
                }
                else if (destinationPictureBox.Tag == "allLettersUppercase")
                {
                    ReturnPicture(SourcePictureBox3, destinationPictureBox, resultLabel3);
                }
                else if (destinationPictureBox.Tag == "bold")
                {
                    ReturnPicture(SourcePictureBox4, destinationPictureBox, resultLabel4);
                }
                else if (destinationPictureBox.Tag == "print")
                {
                    ReturnPicture(SourcePictureBox5, destinationPictureBox, resultLabel5);
                }
                else if (destinationPictureBox.Tag == "save")
                {
                    ReturnPicture(SourcePictureBox6, destinationPictureBox, resultLabel6);
                }
                else if (destinationPictureBox.Tag == "enter")
                {
                    ReturnPicture(SourcePictureBox7, destinationPictureBox, resultLabel7);
                }
                else if (destinationPictureBox.Tag == "copy")
                {
                    ReturnPicture(SourcePictureBox8, destinationPictureBox, resultLabel8);
                }
                else if (destinationPictureBox.Tag == "italic")
                {
                    ReturnPicture(SourcePictureBox9, destinationPictureBox, resultLabel9);
                }
                else if (destinationPictureBox.Tag == "colorOfText")
                {
                    ReturnPicture(SourcePictureBox10, destinationPictureBox, resultLabel10);
                }
                else if (destinationPictureBox.Tag == "underlined")
                {
                    ReturnPicture(SourcePictureBox11, destinationPictureBox, resultLabel11);
                }
                else if (destinationPictureBox.Tag == "colorOfFill")
                {
                    ReturnPicture(SourcePictureBox12, destinationPictureBox, resultLabel12);
                }
            }
        }

        private void ReturnPicture(PictureBox pictureBox1, PictureBox pictureBox2, Label resultLabel)
        {
            pictureBox1.Image = pictureBox2.Image;
            pictureBox2.Image = null;
            pictureBox2.Tag = null;
            resultLabel.Tag = null;
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
                ShowForm(new ResultInteractiveForm());
            }
            else
            {
                CheckCorrectness();
                MessageBox.Show("Задание решено неверно, попробуйте снова", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GoNextButton_Click(object sender, EventArgs e)
        {
            GoToNextTask();
        }

        private void GoBackButton_Click(object sender, EventArgs e)
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
            else
            {
                ChangeImageOfLabel(DestinationPictureBox9, "underlined", resultLabel9);
                ChangeImageOfLabel(DestinationPictureBox10, "colorOfFill", resultLabel10);
                ChangeImageOfLabel(DestinationPictureBox11, "italic", resultLabel11);
                ChangeImageOfLabel(DestinationPictureBox12, "colorOfText", resultLabel12);
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

        private void HelpButton_Click(object sender, EventArgs e)
        {
            helpButton.Enabled = false;
            InstructionForm form = new InstructionForm();
            form.FormClosed += InstructionForm_Closed;
            form.Show();
        }

        private void InstructionForm_Closed(object sender, FormClosedEventArgs e)
        {
            helpButton.Enabled = true;
        }

        void ShowForm(Form form)
        {
            Hide();
            form.ShowDialog();
            Close();
        }
    }
}
