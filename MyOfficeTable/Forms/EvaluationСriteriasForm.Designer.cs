namespace MyOfficeTable
{
    partial class EvaluationСriteriasForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvaluationСriteriasForm));
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.panel2 = new System.Windows.Forms.Panel();
            this.goBackButton = new MyOfficeTable.MyButton();
            this.goToTestButton = new MyOfficeTable.MyButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(917, 134);
            // 
            // headerLabel
            // 
            this.headerLabel.Size = new System.Drawing.Size(781, 134);
            this.headerLabel.Text = "Критерии оценивания";
            // 
            // changeWindowBoxButton
            // 
            this.changeWindowBoxButton.Enabled = false;
            this.changeWindowBoxButton.FlatAppearance.BorderSize = 0;
            this.changeWindowBoxButton.Location = new System.Drawing.Point(834, 2);
            // 
            // minimizeButton
            // 
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.Location = new System.Drawing.Point(793, 2);
            // 
            // cancelButton
            // 
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.Location = new System.Drawing.Point(875, 2);
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(889, 404);
            this.webBrowser.TabIndex = 51;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.webBrowser);
            this.panel2.Location = new System.Drawing.Point(9, 206);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(889, 404);
            this.panel2.TabIndex = 52;
            // 
            // goBackButton
            // 
            this.goBackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.goBackButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.goBackButton.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.goBackButton.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.goBackButton.BorderRadius = 20;
            this.goBackButton.BorderSize = 0;
            this.goBackButton.FlatAppearance.BorderSize = 0;
            this.goBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goBackButton.ForeColor = System.Drawing.Color.White;
            this.goBackButton.Location = new System.Drawing.Point(-1, 616);
            this.goBackButton.MinimumSize = new System.Drawing.Size(150, 40);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(179, 40);
            this.goBackButton.TabIndex = 75;
            this.goBackButton.Text = "Назад";
            this.goBackButton.TextColor = System.Drawing.Color.White;
            this.goBackButton.UseVisualStyleBackColor = false;
            this.goBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // goToTestButton
            // 
            this.goToTestButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.goToTestButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.goToTestButton.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.goToTestButton.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.goToTestButton.BorderRadius = 20;
            this.goToTestButton.BorderSize = 0;
            this.goToTestButton.FlatAppearance.BorderSize = 0;
            this.goToTestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToTestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goToTestButton.ForeColor = System.Drawing.Color.White;
            this.goToTestButton.Location = new System.Drawing.Point(728, 616);
            this.goToTestButton.MinimumSize = new System.Drawing.Size(150, 40);
            this.goToTestButton.Name = "goToTestButton";
            this.goToTestButton.Size = new System.Drawing.Size(179, 40);
            this.goToTestButton.TabIndex = 76;
            this.goToTestButton.Text = "Продолжить";
            this.goToTestButton.TextColor = System.Drawing.Color.White;
            this.goToTestButton.UseVisualStyleBackColor = false;
            this.goToTestButton.Visible = false;
            this.goToTestButton.Click += new System.EventHandler(this.GoToTestButton_Click);
            // 
            // EvaluationСriteriasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(910, 659);
            this.Controls.Add(this.goToTestButton);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EvaluationСriteriasForm";
            this.Text = "Критерии оценивания";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EvaluationСriteriasForm_FormClosed);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.goBackButton, 0);
            this.Controls.SetChildIndex(this.goToTestButton, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.minimizeButton, 0);
            this.Controls.SetChildIndex(this.cancelButton, 0);
            this.Controls.SetChildIndex(this.changeWindowBoxButton, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Panel panel2;
        private MyButton goBackButton;
        private MyButton goToTestButton;
    }
}