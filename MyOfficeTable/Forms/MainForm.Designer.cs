namespace MyOfficeTable
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.referenceButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.changeWindowBoxButton = new System.Windows.Forms.Button();
            this.interactiveTasksButton = new MyOfficeTable.ButtonCard();
            this.testingButton = new MyOfficeTable.ButtonCard();
            this.theoryButton = new MyOfficeTable.ButtonCard();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.buttonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerLabel.Font = new System.Drawing.Font("Lucida Sans", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.White;
            this.headerLabel.Location = new System.Drawing.Point(133, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(1111, 134);
            this.headerLabel.TabIndex = 6;
            this.headerLabel.Text = "Электронное пособие\r\n«Основы работы в МойОфис Таблица»";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.cancelButton.TabIndex = 11;
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
            this.minimizeButton.TabIndex = 10;
            this.minimizeButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // referenceButton
            // 
            this.referenceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.referenceButton.BackColor = System.Drawing.Color.Transparent;
            this.referenceButton.FlatAppearance.BorderSize = 0;
            this.referenceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.referenceButton.ForeColor = System.Drawing.Color.Transparent;
            this.referenceButton.Image = global::MyOfficeTable.Properties.Resources.question;
            this.referenceButton.Location = new System.Drawing.Point(1215, 671);
            this.referenceButton.Name = "referenceButton";
            this.referenceButton.Size = new System.Drawing.Size(22, 29);
            this.referenceButton.TabIndex = 40;
            this.referenceButton.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.referenceButton.UseVisualStyleBackColor = false;
            this.referenceButton.Click += new System.EventHandler(this.ReferenceButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.headerLabel);
            this.panel1.Location = new System.Drawing.Point(-1, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1247, 134);
            this.panel1.TabIndex = 41;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyOfficeTable.Properties.Resources.MyOfficeTable;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // buttonPanel
            // 
            this.buttonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPanel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonPanel.Controls.Add(this.interactiveTasksButton);
            this.buttonPanel.Controls.Add(this.testingButton);
            this.buttonPanel.Controls.Add(this.theoryButton);
            this.buttonPanel.Location = new System.Drawing.Point(51, 229);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(1139, 434);
            this.buttonPanel.TabIndex = 42;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Salmon;
            this.panel3.Location = new System.Drawing.Point(51, 229);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1139, 19);
            this.panel3.TabIndex = 9;
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
            this.changeWindowBoxButton.TabIndex = 72;
            this.changeWindowBoxButton.Tag = "Fullscreen";
            this.changeWindowBoxButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.changeWindowBoxButton.UseVisualStyleBackColor = false;
            this.changeWindowBoxButton.Click += new System.EventHandler(this.ChangeWindowBoxButton_Click);
            // 
            // interactiveTasksButton
            // 
            this.interactiveTasksButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.interactiveTasksButton.BackColor = System.Drawing.Color.White;
            this.interactiveTasksButton.BackColorCurtain = System.Drawing.Color.RoyalBlue;
            this.interactiveTasksButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.interactiveTasksButton.FontDescrition = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.interactiveTasksButton.FontHeader = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.interactiveTasksButton.ForeColorDescrition = System.Drawing.Color.Black;
            this.interactiveTasksButton.ForeColorHeader = System.Drawing.Color.White;
            this.interactiveTasksButton.Location = new System.Drawing.Point(813, 93);
            this.interactiveTasksButton.Name = "interactiveTasksButton";
            this.interactiveTasksButton.Size = new System.Drawing.Size(271, 277);
            this.interactiveTasksButton.TabIndex = 2;
            this.interactiveTasksButton.TextDescrition = "Упражнения для проверки знаний лекционного материала в виде интерактивных заданий" +
    "";
            this.interactiveTasksButton.TextHeader = "Интерактивные задания";
            this.interactiveTasksButton.Click += new System.EventHandler(this.InteractiveTasksButton_Click);
            // 
            // testingButton
            // 
            this.testingButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.testingButton.BackColor = System.Drawing.Color.White;
            this.testingButton.BackColorCurtain = System.Drawing.Color.SeaGreen;
            this.testingButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.testingButton.FontDescrition = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.testingButton.FontHeader = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.testingButton.ForeColorDescrition = System.Drawing.Color.Black;
            this.testingButton.ForeColorHeader = System.Drawing.Color.White;
            this.testingButton.Location = new System.Drawing.Point(436, 93);
            this.testingButton.Name = "testingButton";
            this.testingButton.Size = new System.Drawing.Size(271, 277);
            this.testingButton.TabIndex = 1;
            this.testingButton.TextDescrition = "Проверка знаний лекционного материала в виде тестирования";
            this.testingButton.TextHeader = "Тестирование";
            this.testingButton.Click += new System.EventHandler(this.TestingButton_Click);
            // 
            // theoryButton
            // 
            this.theoryButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.theoryButton.BackColor = System.Drawing.Color.White;
            this.theoryButton.BackColorCurtain = System.Drawing.Color.Tomato;
            this.theoryButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.theoryButton.FontDescrition = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.theoryButton.FontHeader = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.theoryButton.ForeColorDescrition = System.Drawing.Color.Black;
            this.theoryButton.ForeColorHeader = System.Drawing.Color.White;
            this.theoryButton.Location = new System.Drawing.Point(57, 93);
            this.theoryButton.Name = "theoryButton";
            this.theoryButton.Size = new System.Drawing.Size(271, 277);
            this.theoryButton.TabIndex = 0;
            this.theoryButton.TextDescrition = "Лекционный материал для самостоятельной подготовки по работе в табличном процессо" +
    "ре «МойОфис Таблица»";
            this.theoryButton.TextHeader = "Теория";
            this.theoryButton.Click += new System.EventHandler(this.TheoryButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1240, 703);
            this.Controls.Add(this.changeWindowBoxButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.buttonPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.referenceButton);
            this.Controls.Add(this.minimizeButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1240, 703);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.buttonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button referenceButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Panel panel3;
        private ButtonCard theoryButton;
        private ButtonCard interactiveTasksButton;
        private ButtonCard testingButton;
        private System.Windows.Forms.Button changeWindowBoxButton;
    }
}