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

namespace MyOfficeTable
{
    public partial class ReferenceForm : Form
    {
        private Point mouseOffset;
        private Point currentOffset;
        private bool isMouseDown = false;
        public ReferenceForm()
        {
            InitializeComponent();
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(minimizeButton, "Свернуть");
            toolTip.SetToolTip(cancelButton, "Закрыть");
            headerLabel.Left = (ClientSize.Width - headerLabel.Width) / 2;
            titleLabel.Text = "Название: Электронное пособиеОсновы работы в «МойОфис Таблица»";
            versionLabel.Text = $"Версия программы: {Assembly.GetExecutingAssembly().GetName().Version}";
            descriptionLabel.Text = "Описание: программа предназначена для самостоятельного изучения материала и самопроверки знаний по теме «Основы работы в «МойОфис Таблица»";
            creatorLabel.Text = "Создатель: Студент группы ПКС-91 Шаньгин Максим";
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ReferenceForm_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            mouseOffset = Cursor.Position;
            currentOffset = this.Location;
        }

        private void ReferenceForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(mouseOffset));
                this.Location = Point.Add(currentOffset, new Size(dif));
            }
        }

        private void ReferenceForm_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }
    }
}
