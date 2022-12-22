using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyOfficeTable
{
    public partial class TheoryForm : Form
    {
        private Point mouseOffset;
        private Point currentOffset;
        private bool isMouseDown = false;
        public TheoryForm()
        {
            InitializeComponent();
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(collapseButton, "Свернуть");
            toolTip.SetToolTip(cancelButton, "Закрыть");
            firstChapterButton.Text = "I глава\nРабота в приложении\nв «МойОфис Таблица»";
            secondChapterButton.Text = "II глава\nРабота с файлами\nв «МойОфис Таблица»";
            thirdChapterButton.Text = "III глава\nВставка элементов\nв таблицу";
            webBrowser.Navigate(Directory.GetCurrentDirectory() + @"\Lections\Lection.html");
        }

        private void CollapseButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            Hide();
            MainForm form = new MainForm();
            form.ShowDialog();
            Close();
        }

        private void TheoryForm_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            mouseOffset = Cursor.Position;
            currentOffset = this.Location;
        }

        private void TheoryForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(mouseOffset));
                this.Location = Point.Add(currentOffset, new Size(dif));
            }
        }

        private void TheoryForm_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void firstChapterButton_Click(object sender, EventArgs e)
        {
            HtmlElement sectionAnchor = webBrowser.Document.GetElementById("firstChapter");
            if (sectionAnchor != null)
            {
                sectionAnchor.ScrollIntoView(true);
            }
        }

        private void secondChapterButton_Click(object sender, EventArgs e)
        {
            HtmlElement sectionAnchor = webBrowser.Document.GetElementById("secondChapter");
            if (sectionAnchor != null)
            {
                sectionAnchor.ScrollIntoView(true);
            }
        }

        private void thirdChapterButton_Click(object sender, EventArgs e)
        {
            HtmlElement sectionAnchor = webBrowser.Document.GetElementById("thirdChapter");
            if (sectionAnchor != null)
            {
                sectionAnchor.ScrollIntoView(true);
            }
        }
    }
}
