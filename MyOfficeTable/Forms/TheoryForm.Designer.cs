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
            this.minimizeButton = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.webBrowser = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.goToLectionButton = new System.Windows.Forms.Button();
            this.testingButton = new System.Windows.Forms.Button();
            this.goBackButton = new WindowsFormsApp1.MyButton();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webBrowser)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Image = global::MyOfficeTable.Properties.Resources.cancel;
            this.cancelButton.Location = new System.Drawing.Point(1361, 1);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(31, 32);
            this.cancelButton.TabIndex = 13;
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
            this.minimizeButton.Location = new System.Drawing.Point(1320, 1);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(35, 32);
            this.minimizeButton.TabIndex = 12;
            this.minimizeButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Lucida Sans", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.White;
            this.headerLabel.Location = new System.Drawing.Point(482, 49);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(453, 39);
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
            this.panel.Location = new System.Drawing.Point(300, 225);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1092, 635);
            this.panel.TabIndex = 1;
            // 
            // webBrowser
            // 
            this.webBrowser.AllowExternalDrop = true;
            this.webBrowser.BackColor = System.Drawing.Color.White;
            this.webBrowser.CreationProperties = null;
            this.webBrowser.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(1092, 635);
            this.webBrowser.TabIndex = 0;
            this.webBrowser.ZoomFactor = 1D;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.headerLabel);
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1403, 135);
            this.panel1.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyOfficeTable.Properties.Resources.MyOfficeTable;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.goToLectionButton);
            this.panel2.Controls.Add(this.testingButton);
            this.panel2.Location = new System.Drawing.Point(3, 225);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 635);
            this.panel2.TabIndex = 31;
            // 
            // goToLectionButton
            // 
            this.goToLectionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.goToLectionButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.goToLectionButton.FlatAppearance.BorderSize = 0;
            this.goToLectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToLectionButton.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToLectionButton.ForeColor = System.Drawing.Color.White;
            this.goToLectionButton.Location = new System.Drawing.Point(3, 231);
            this.goToLectionButton.Name = "goToLectionButton";
            this.goToLectionButton.Size = new System.Drawing.Size(285, 50);
            this.goToLectionButton.TabIndex = 34;
            this.goToLectionButton.Text = "Лекция";
            this.goToLectionButton.UseVisualStyleBackColor = false;
            this.goToLectionButton.Click += new System.EventHandler(this.GoToLectionButton_Click);
            // 
            // testingButton
            // 
            this.testingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.testingButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.testingButton.FlatAppearance.BorderSize = 0;
            this.testingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testingButton.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testingButton.ForeColor = System.Drawing.Color.White;
            this.testingButton.Location = new System.Drawing.Point(3, 314);
            this.testingButton.Name = "testingButton";
            this.testingButton.Size = new System.Drawing.Size(285, 50);
            this.testingButton.TabIndex = 33;
            this.testingButton.Text = "Пройти тестирование\r\n";
            this.testingButton.UseVisualStyleBackColor = false;
            this.testingButton.Click += new System.EventHandler(this.TestingButton_Click);
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
            this.goBackButton.Location = new System.Drawing.Point(0, 865);
            this.goBackButton.MinimumSize = new System.Drawing.Size(150, 40);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(151, 40);
            this.goBackButton.TabIndex = 44;
            this.goBackButton.Text = "Назад";
            this.goBackButton.TextColor = System.Drawing.Color.White;
            this.goBackButton.UseVisualStyleBackColor = false;
            this.goBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // TheoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1394, 906);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.minimizeButton);
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
            ((System.ComponentModel.ISupportInitialize)(this.webBrowser)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private WindowsFormsApp1.MyButton goBackButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webBrowser;
        private System.Windows.Forms.Button testingButton;
        private System.Windows.Forms.Button goToLectionButton;
    }
}