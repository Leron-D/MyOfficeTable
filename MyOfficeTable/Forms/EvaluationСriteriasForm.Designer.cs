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
            this.cancelButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.headerLabel = new System.Windows.Forms.Label();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.goBackButton = new WindowsFormsApp1.MyButton();
            this.goToTestButton = new WindowsFormsApp1.MyButton();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Image = global::MyOfficeTable.Properties.Resources.cancel;
            this.cancelButton.Location = new System.Drawing.Point(876, 1);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(31, 32);
            this.cancelButton.TabIndex = 50;
            this.cancelButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Image = global::MyOfficeTable.Properties.Resources.minimize;
            this.minimizeButton.Location = new System.Drawing.Point(835, 1);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(35, 32);
            this.minimizeButton.TabIndex = 49;
            this.minimizeButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel.Controls.Add(this.pictureBox1);
            this.panel.Controls.Add(this.headerLabel);
            this.panel.Location = new System.Drawing.Point(-1, 54);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(921, 134);
            this.panel.TabIndex = 42;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyOfficeTable.Properties.Resources.MyOfficeTable;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // headerLabel
            // 
            this.headerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Lucida Sans", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.White;
            this.headerLabel.Location = new System.Drawing.Point(281, 52);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(395, 39);
            this.headerLabel.TabIndex = 41;
            this.headerLabel.Text = "Критерии оценивания";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.webBrowser);
            this.panel1.Location = new System.Drawing.Point(9, 206);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 404);
            this.panel1.TabIndex = 52;
            // 
            // goBackButton
            // 
            this.goBackButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.goBackButton.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.goBackButton.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.goBackButton.BorderRadius = 20;
            this.goBackButton.BorderSize = 0;
            this.goBackButton.FlatAppearance.BorderSize = 0;
            this.goBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goBackButton.ForeColor = System.Drawing.Color.White;
            this.goBackButton.Location = new System.Drawing.Point(9, 616);
            this.goBackButton.MinimumSize = new System.Drawing.Size(150, 40);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(151, 40);
            this.goBackButton.TabIndex = 53;
            this.goBackButton.Text = "Назад";
            this.goBackButton.TextColor = System.Drawing.Color.White;
            this.goBackButton.UseVisualStyleBackColor = false;
            this.goBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // goToTestButton
            // 
            this.goToTestButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.goToTestButton.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.goToTestButton.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.goToTestButton.BorderRadius = 20;
            this.goToTestButton.BorderSize = 0;
            this.goToTestButton.FlatAppearance.BorderSize = 0;
            this.goToTestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToTestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goToTestButton.ForeColor = System.Drawing.Color.White;
            this.goToTestButton.Location = new System.Drawing.Point(687, 616);
            this.goToTestButton.MinimumSize = new System.Drawing.Size(150, 40);
            this.goToTestButton.Name = "goToTestButton";
            this.goToTestButton.Size = new System.Drawing.Size(211, 40);
            this.goToTestButton.TabIndex = 54;
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
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EvaluationСriteriasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Критерии оценивания";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EvaluationCriteriasForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EvaluationCriteriasForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EvaluationCriteriasForm_MouseUp);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Panel panel1;
        private WindowsFormsApp1.MyButton goBackButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private WindowsFormsApp1.MyButton goToTestButton;
    }
}