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
    public partial class ResultInteractiveForm : StyleForm
    {
        string theme = "";

        public ResultInteractiveForm(string taskName)
        {
            theme = taskName;
            InitializeComponent();
            LoadForm();
        }

        private void LoadForm()
        {
            goTestAgainButton.Left = (ClientSize.Width - goTestAgainButton.Width) / 2;
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

        private void TakeTestAgainButton_Click(object sender, EventArgs e)
        {
            InteractiveTaskForm form = new InteractiveTaskForm(theme);
            Hide();
            form.ShowDialog();
            Close();
        }
    }
}
