using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyOfficeTable
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Properties.Settings.Default.IsFirstLoad = Properties.Settings.Default.firstLoadInstruction = true;
            Properties.Settings.Default.goFromTheory = false;
            Properties.Settings.Default.isFullSize = false;
            Properties.Settings.Default.Save();
            String processName = Process.GetCurrentProcess().ProcessName;
            if (Process.GetProcesses().Count(p => p.ProcessName == processName) > 1)
            {
                MessageBox.Show("Приложение уже запущено", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Application.Run(new MainForm());
        }
    }
}
