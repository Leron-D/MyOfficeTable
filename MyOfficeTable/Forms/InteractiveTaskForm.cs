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
            Properties.Settings.Default.firstLoadInstruction = false;
            Properties.Settings.Default.Save();
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
                Properties.Settings.Default.firstLoadInstruction = true;
                Properties.Settings.Default.Save();
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

        private void SourcePictureBox_DragDrop(object sender, DragEventArgs e)
        {

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
                    ReturnPicture(SourcePictureBox1, destinationPictureBox);
                }
                else if (destinationPictureBox.Tag == "copyFormat")
                {
                    ReturnPicture(SourcePictureBox2, destinationPictureBox);
                }
                else if (destinationPictureBox.Tag == "allLettersUppercase")
                {
                    ReturnPicture(SourcePictureBox3, destinationPictureBox);
                }
                else if (destinationPictureBox.Tag == "bold")
                {
                    ReturnPicture(SourcePictureBox4, destinationPictureBox);
                }
                else if (destinationPictureBox.Tag == "print")
                {
                    ReturnPicture(SourcePictureBox5, destinationPictureBox);
                }
                else if (destinationPictureBox.Tag == "save")
                {
                    ReturnPicture(SourcePictureBox6, destinationPictureBox);
                }
                else if (destinationPictureBox.Tag == "enter")
                {
                    ReturnPicture(SourcePictureBox7, destinationPictureBox);
                }
                else if (destinationPictureBox.Tag == "copy")
                {
                    ReturnPicture(SourcePictureBox8, destinationPictureBox);
                }
                else if (destinationPictureBox.Tag == "italic")
                {
                    ReturnPicture(SourcePictureBox9, destinationPictureBox);
                }
                else if (destinationPictureBox.Tag == "colorOfText")
                {
                    ReturnPicture(SourcePictureBox10, destinationPictureBox);
                }
                else if (destinationPictureBox.Tag == "underlined")
                {
                    ReturnPicture(SourcePictureBox11, destinationPictureBox);
                }
                else if (destinationPictureBox.Tag == "colorOfFill")
                {
                    ReturnPicture(SourcePictureBox12, destinationPictureBox);
                }
            }
        }

        private void ReturnPicture(PictureBox pictureBox1, PictureBox pictureBox2)
        {
            pictureBox1.Image = pictureBox2.Image;
            pictureBox2.Image = null;
            pictureBox2.Tag = null;
        }

        private void GoToNextTask()
        {
            if (tabControl.SelectedTab == tabControl.TabPages[0])
            {
                tabControl.SelectedTab = tabControl.TabPages[1];
                goNextButton.Text = "Продолжить";
                goBackButton.Enabled = true;
            }
            else if (tabControl.SelectedTab == tabControl.TabPages[1])
            {
                tabControl.SelectedTab = tabControl.TabPages[2];
                goNextButton.Text = "Завершить";
            }
            else
            {
                CheckCorrectness();
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
            if (DestinationPictureBox1.Tag == "cut" && DestinationPictureBox2.Tag == "copyFormat" && DestinationPictureBox3.Tag == "bold" && DestinationPictureBox4.Tag == "allLettersUppercase")
            {
                Properties.Settings.Default.correctTask1 = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.correctTask1 = false;
                Properties.Settings.Default.Save();
            }

            if (DestinationPictureBox5.Tag == "save" && DestinationPictureBox6.Tag == "print" && DestinationPictureBox7.Tag == "copy" && DestinationPictureBox8.Tag == "enter")
            {
                Properties.Settings.Default.correctTask2 = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.correctTask2 = false;
                Properties.Settings.Default.Save();
            }

            if (DestinationPictureBox9.Tag == "underlined" && DestinationPictureBox10.Tag == "colorOfFill" && DestinationPictureBox11.Tag == "italic" && DestinationPictureBox12.Tag == "colorOfText")
            {
                Properties.Settings.Default.correctTask3 = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.correctTask3 = false;
                Properties.Settings.Default.Save();
            }
            ResultInteractiveForm form = new ResultInteractiveForm();
            Hide();
            form.ShowDialog();
            Close();
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
    }
}
