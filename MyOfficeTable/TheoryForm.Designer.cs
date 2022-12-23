namespace MyOfficeTable
{
    partial class TheoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheoryForm));
            this.cancelButton = new System.Windows.Forms.Button();
            this.collapseButton = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.goBackButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.firstChapterButton = new System.Windows.Forms.Button();
            this.thirdChapterButton = new System.Windows.Forms.Button();
            this.secondChapterButton = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Image = global::MyOfficeTable.Properties.Resources.cancel;
            this.cancelButton.Location = new System.Drawing.Point(1303, 1);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(31, 32);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // collapseButton
            // 
            this.collapseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.collapseButton.FlatAppearance.BorderSize = 0;
            this.collapseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.collapseButton.Image = global::MyOfficeTable.Properties.Resources.collapse;
            this.collapseButton.Location = new System.Drawing.Point(1262, 1);
            this.collapseButton.Name = "collapseButton";
            this.collapseButton.Size = new System.Drawing.Size(35, 32);
            this.collapseButton.TabIndex = 12;
            this.collapseButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.collapseButton.UseVisualStyleBackColor = true;
            this.collapseButton.Click += new System.EventHandler(this.CollapseButton_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Lucida Handwriting", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.headerLabel.Location = new System.Drawing.Point(5, 1);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(455, 41);
            this.headerLabel.TabIndex = 7;
            this.headerLabel.Text = "Теоретический материал";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.Controls.Add(this.webBrowser);
            this.panel.Location = new System.Drawing.Point(224, 70);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1110, 591);
            this.panel.TabIndex = 1;
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(1110, 591);
            this.webBrowser.TabIndex = 0;
            // 
            // goBackButton
            // 
            this.goBackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.goBackButton.BackColor = System.Drawing.Color.Turquoise;
            this.goBackButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.goBackButton.FlatAppearance.BorderSize = 0;
            this.goBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goBackButton.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.goBackButton.Location = new System.Drawing.Point(12, 667);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(148, 36);
            this.goBackButton.TabIndex = 11;
            this.goBackButton.Text = "Назад";
            this.goBackButton.UseVisualStyleBackColor = false;
            this.goBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1346, 19);
            this.panel1.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.firstChapterButton);
            this.panel2.Controls.Add(this.thirdChapterButton);
            this.panel2.Controls.Add(this.secondChapterButton);
            this.panel2.Location = new System.Drawing.Point(12, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 591);
            this.panel2.TabIndex = 31;
            // 
            // firstChapterButton
            // 
            this.firstChapterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.firstChapterButton.BackColor = System.Drawing.Color.Turquoise;
            this.firstChapterButton.FlatAppearance.BorderSize = 0;
            this.firstChapterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.firstChapterButton.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstChapterButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.firstChapterButton.Location = new System.Drawing.Point(0, 3);
            this.firstChapterButton.Name = "firstChapterButton";
            this.firstChapterButton.Size = new System.Drawing.Size(203, 70);
            this.firstChapterButton.TabIndex = 31;
            this.firstChapterButton.Text = "I глава";
            this.firstChapterButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.firstChapterButton.UseVisualStyleBackColor = false;
            this.firstChapterButton.Click += new System.EventHandler(this.firstChapterButton_Click);
            // 
            // thirdChapterButton
            // 
            this.thirdChapterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.thirdChapterButton.AutoSize = true;
            this.thirdChapterButton.BackColor = System.Drawing.Color.Turquoise;
            this.thirdChapterButton.FlatAppearance.BorderSize = 0;
            this.thirdChapterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.thirdChapterButton.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdChapterButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.thirdChapterButton.Location = new System.Drawing.Point(0, 178);
            this.thirdChapterButton.Name = "thirdChapterButton";
            this.thirdChapterButton.Size = new System.Drawing.Size(203, 70);
            this.thirdChapterButton.TabIndex = 33;
            this.thirdChapterButton.Text = "III глава";
            this.thirdChapterButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.thirdChapterButton.UseVisualStyleBackColor = false;
            this.thirdChapterButton.Click += new System.EventHandler(this.thirdChapterButton_Click);
            // 
            // secondChapterButton
            // 
            this.secondChapterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.secondChapterButton.AutoSize = true;
            this.secondChapterButton.BackColor = System.Drawing.Color.Turquoise;
            this.secondChapterButton.FlatAppearance.BorderSize = 0;
            this.secondChapterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.secondChapterButton.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondChapterButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.secondChapterButton.Location = new System.Drawing.Point(0, 91);
            this.secondChapterButton.Name = "secondChapterButton";
            this.secondChapterButton.Size = new System.Drawing.Size(203, 70);
            this.secondChapterButton.TabIndex = 32;
            this.secondChapterButton.Text = "II глава";
            this.secondChapterButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.secondChapterButton.UseVisualStyleBackColor = false;
            this.secondChapterButton.Click += new System.EventHandler(this.secondChapterButton_Click);
            // 
            // TheoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1336, 707);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.collapseButton);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TheoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Теоретический материал";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TheoryForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TheoryForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TheoryForm_MouseUp);
            this.panel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button collapseButton;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button firstChapterButton;
        private System.Windows.Forms.Button secondChapterButton;
        private System.Windows.Forms.Button thirdChapterButton;
    }
}