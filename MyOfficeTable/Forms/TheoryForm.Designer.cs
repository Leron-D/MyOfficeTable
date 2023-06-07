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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheoryForm));
            this.rightPanel = new System.Windows.Forms.Panel();
            this.webBrowser = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.goToLectionButton = new MyOfficeTable.MyButton();
            this.testingButton = new MyOfficeTable.MyButton();
            this.changeSizePanelButton = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.goBackButton = new MyOfficeTable.MyButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webBrowser)).BeginInit();
            this.leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1406, 134);
            // 
            // changeWindowBoxButton
            // 
            this.changeWindowBoxButton.FlatAppearance.BorderSize = 0;
            this.changeWindowBoxButton.Location = new System.Drawing.Point(1324, 0);
            this.changeWindowBoxButton.Click += new System.EventHandler(this.СhangeWindowBoxButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.Location = new System.Drawing.Point(1283, 0);
            // 
            // cancelButton
            // 
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.Location = new System.Drawing.Point(1365, 0);
            // 
            // headerLabel
            // 
            this.headerLabel.Size = new System.Drawing.Size(1270, 134);
            this.headerLabel.Text = "Теоретический материал";
            // 
            // guideButton
            // 
            this.guideButton.FlatAppearance.BorderSize = 0;
            this.guideButton.Location = new System.Drawing.Point(1240, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rightPanel.Controls.Add(this.webBrowser);
            this.rightPanel.Location = new System.Drawing.Point(300, 251);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(1098, 651);
            this.rightPanel.TabIndex = 1;
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
            this.webBrowser.Size = new System.Drawing.Size(1098, 651);
            this.webBrowser.TabIndex = 0;
            this.webBrowser.ZoomFactor = 1D;
            // 
            // leftPanel
            // 
            this.leftPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.leftPanel.BackColor = System.Drawing.Color.PowderBlue;
            this.leftPanel.Controls.Add(this.goToLectionButton);
            this.leftPanel.Controls.Add(this.testingButton);
            this.leftPanel.Location = new System.Drawing.Point(3, 251);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(290, 650);
            this.leftPanel.TabIndex = 31;
            // 
            // goToLectionButton
            // 
            this.goToLectionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.goToLectionButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.goToLectionButton.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.goToLectionButton.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.goToLectionButton.BorderRadius = 20;
            this.goToLectionButton.BorderSize = 0;
            this.goToLectionButton.FlatAppearance.BorderSize = 0;
            this.goToLectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToLectionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goToLectionButton.ForeColor = System.Drawing.Color.White;
            this.goToLectionButton.Location = new System.Drawing.Point(2, 248);
            this.goToLectionButton.MinimumSize = new System.Drawing.Size(150, 40);
            this.goToLectionButton.Name = "goToLectionButton";
            this.goToLectionButton.Size = new System.Drawing.Size(286, 60);
            this.goToLectionButton.TabIndex = 76;
            this.goToLectionButton.Text = "Перейти к лекции";
            this.goToLectionButton.TextColor = System.Drawing.Color.White;
            this.goToLectionButton.UseVisualStyleBackColor = false;
            this.goToLectionButton.Click += new System.EventHandler(this.GoToLectionButton_Click);
            // 
            // testingButton
            // 
            this.testingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.testingButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.testingButton.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.testingButton.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.testingButton.BorderRadius = 20;
            this.testingButton.BorderSize = 0;
            this.testingButton.FlatAppearance.BorderSize = 0;
            this.testingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.testingButton.ForeColor = System.Drawing.Color.White;
            this.testingButton.Location = new System.Drawing.Point(1, 350);
            this.testingButton.MinimumSize = new System.Drawing.Size(150, 40);
            this.testingButton.Name = "testingButton";
            this.testingButton.Size = new System.Drawing.Size(286, 60);
            this.testingButton.TabIndex = 76;
            this.testingButton.Text = "Перейти к тестированию";
            this.testingButton.TextColor = System.Drawing.Color.White;
            this.testingButton.UseVisualStyleBackColor = false;
            this.testingButton.Click += new System.EventHandler(this.TestingButton_Click);
            // 
            // changeSizePanelButton
            // 
            this.changeSizePanelButton.BackColor = System.Drawing.Color.LightCyan;
            this.changeSizePanelButton.FlatAppearance.BorderSize = 0;
            this.changeSizePanelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeSizePanelButton.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeSizePanelButton.ForeColor = System.Drawing.Color.White;
            this.changeSizePanelButton.Image = global::MyOfficeTable.Properties.Resources.Collapse;
            this.changeSizePanelButton.Location = new System.Drawing.Point(3, 216);
            this.changeSizePanelButton.Name = "changeSizePanelButton";
            this.changeSizePanelButton.Size = new System.Drawing.Size(27, 29);
            this.changeSizePanelButton.TabIndex = 35;
            this.changeSizePanelButton.Tag = "Свернуть";
            this.changeSizePanelButton.UseVisualStyleBackColor = false;
            this.changeSizePanelButton.Click += new System.EventHandler(this.ChangeSizePanelButton_Click);
            // 
            // timer
            // 
            this.timer.Interval = 20;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
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
            this.goBackButton.Location = new System.Drawing.Point(0, 907);
            this.goBackButton.MinimumSize = new System.Drawing.Size(150, 40);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(290, 40);
            this.goBackButton.TabIndex = 44;
            this.goBackButton.Text = "Назад к выбору темы";
            this.goBackButton.TextColor = System.Drawing.Color.White;
            this.goBackButton.UseVisualStyleBackColor = false;
            this.goBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // TheoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1400, 948);
            this.Controls.Add(this.changeSizePanelButton);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.rightPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TheoryForm";
            this.Text = "Теоретический материал";
            this.Controls.SetChildIndex(this.guideButton, 0);
            this.Controls.SetChildIndex(this.rightPanel, 0);
            this.Controls.SetChildIndex(this.leftPanel, 0);
            this.Controls.SetChildIndex(this.goBackButton, 0);
            this.Controls.SetChildIndex(this.changeSizePanelButton, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.minimizeButton, 0);
            this.Controls.SetChildIndex(this.cancelButton, 0);
            this.Controls.SetChildIndex(this.changeWindowBoxButton, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webBrowser)).EndInit();
            this.leftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel leftPanel;
        private MyOfficeTable.MyButton goBackButton;
        private Microsoft.Web.WebView2.WinForms.WebView2 webBrowser;
        private System.Windows.Forms.Button changeSizePanelButton;
        private System.Windows.Forms.Timer timer;
        private MyButton goToLectionButton;
        private MyButton testingButton;
    }
}