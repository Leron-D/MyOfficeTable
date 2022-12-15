﻿using System;
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
    public partial class TestResultForm : Form
    {
        public TestResultForm(int rightNum, int mark)
        {
            InitializeComponent();
            rightNumLabel.Text = rightNum.ToString();
            markLabel.Text = mark.ToString();
            headerLabel.Left = (ClientSize.Width - headerLabel.Width) / 2;
        }

        private void CollapseButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
