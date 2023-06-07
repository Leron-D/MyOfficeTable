namespace MyOfficeTable.Forms
{
    partial class StyleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StyleForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.headerLabel = new System.Windows.Forms.Label();
            this.changeWindowBoxButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.guideButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pictPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.pictPanel);
            this.panel1.Controls.Add(this.headerLabel);
            this.panel1.Location = new System.Drawing.Point(0, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1240, 134);
            this.panel1.TabIndex = 44;
            // 
            // pictPanel
            // 
            this.pictPanel.Controls.Add(this.pictureBox2);
            this.pictPanel.Location = new System.Drawing.Point(0, 0);
            this.pictPanel.Name = "pictPanel";
            this.pictPanel.Size = new System.Drawing.Size(134, 134);
            this.pictPanel.TabIndex = 76;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Help;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::MyOfficeTable.Properties.Resources.MyOfficeTable;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(134, 134);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerLabel.Font = new System.Drawing.Font("Lucida Sans", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.White;
            this.headerLabel.Location = new System.Drawing.Point(132, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(1108, 134);
            this.headerLabel.TabIndex = 6;
            this.headerLabel.Text = "Электронное пособие\r\n«Основы работы в МойОфис Таблица»";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changeWindowBoxButton
            // 
            this.changeWindowBoxButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changeWindowBoxButton.BackColor = System.Drawing.Color.Transparent;
            this.changeWindowBoxButton.FlatAppearance.BorderSize = 0;
            this.changeWindowBoxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeWindowBoxButton.Image = global::MyOfficeTable.Properties.Resources.Fullscreen;
            this.changeWindowBoxButton.Location = new System.Drawing.Point(1165, 0);
            this.changeWindowBoxButton.Name = "changeWindowBoxButton";
            this.changeWindowBoxButton.Size = new System.Drawing.Size(35, 32);
            this.changeWindowBoxButton.TabIndex = 75;
            this.changeWindowBoxButton.Tag = "Fullscreen";
            this.changeWindowBoxButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.changeWindowBoxButton.UseVisualStyleBackColor = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.BackColor = System.Drawing.Color.Transparent;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Image = global::MyOfficeTable.Properties.Resources.cancel;
            this.cancelButton.Location = new System.Drawing.Point(1206, 0);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(31, 32);
            this.cancelButton.TabIndex = 74;
            this.cancelButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Image = global::MyOfficeTable.Properties.Resources.minimize;
            this.minimizeButton.Location = new System.Drawing.Point(1124, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(35, 32);
            this.minimizeButton.TabIndex = 73;
            this.minimizeButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // guideButton
            // 
            this.guideButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guideButton.BackColor = System.Drawing.Color.Transparent;
            this.guideButton.FlatAppearance.BorderSize = 0;
            this.guideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guideButton.ForeColor = System.Drawing.Color.Transparent;
            this.guideButton.Image = global::MyOfficeTable.Properties.Resources.Guide;
            this.guideButton.Location = new System.Drawing.Point(1081, 0);
            this.guideButton.Name = "guideButton";
            this.guideButton.Size = new System.Drawing.Size(37, 34);
            this.guideButton.TabIndex = 76;
            this.guideButton.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.guideButton.UseVisualStyleBackColor = false;
            this.guideButton.Click += new System.EventHandler(this.GuideButton_Click);
            // 
            // StyleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1240, 703);
            this.Controls.Add(this.guideButton);
            this.Controls.Add(this.changeWindowBoxButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StyleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StyleForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StyleForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.StyleForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StyleForm_MouseUp);
            this.panel1.ResumeLayout(false);
            this.pictPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.PictureBox pictureBox2;
        protected System.Windows.Forms.Button changeWindowBoxButton;
        protected System.Windows.Forms.Button minimizeButton;
        public System.Windows.Forms.Button cancelButton;
        public System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Panel pictPanel;
        protected System.Windows.Forms.Button guideButton;
    }
}