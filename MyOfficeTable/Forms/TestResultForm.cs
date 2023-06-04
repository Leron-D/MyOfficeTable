using MyOfficeTable.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyOfficeTable
{
    public partial class TestResultForm : StyleForm
    {

        public TestResultForm(double rightNum, int mark, double numberOfQuestions)
        {
            InitializeComponent();
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(minimizeButton, "Свернуть");
            toolTip.SetToolTip(cancelButton, "Закрыть");
            rightNumberLabel.Text = $"Вы ответили правильно на {rightNum} из {numberOfQuestions} вопросов";
            markLabel.Text = $"Ваша оценка: {mark}";
        }
    }
}
