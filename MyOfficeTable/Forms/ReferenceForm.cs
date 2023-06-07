using MyOfficeTable.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace MyOfficeTable
{
    public partial class ReferenceForm : StyleForm
    {
        public static ReferenceForm _referenceForm;
        public ReferenceForm()
        {
            InitializeComponent();
            try
            {
                _referenceForm = this;
                ToolTip toolTip = new ToolTip();
                toolTip.SetToolTip(minimizeButton, "Свернуть");
                toolTip.SetToolTip(cancelButton, "Закрыть");
                headerLabel.Left = (ClientSize.Width - headerLabel.Width) / 2;
                titleLabel.Text = "Название: Электронное пособие «Основы работы в МойОфис Таблица»";
                versionLabel.Text = $"Версия программы: {Assembly.GetExecutingAssembly().GetName().Version}";
                descriptionLabel.Text = "Описание: программа предназначена для самостоятельного изучения материала и самопроверки знаний по теме «Основы работы в «МойОфис Таблица»";
                creatorLabel.Text = "Создатель: Студент группы ПКС-91 Шаньгин Максим";
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

        private void closeButton_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
