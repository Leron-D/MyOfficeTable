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
            this.referenceButton = new System.Windows.Forms.Button();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.interactiveTasksButton = new MyOfficeTable.ButtonCard();
            this.testingButton = new MyOfficeTable.ButtonCard();
            this.theoryButton = new MyOfficeTable.ButtonCard();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.buttonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.Font = new System.Drawing.Font("Lucida Sans", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(130, 0);
            this.headerLabel.Size = new System.Drawing.Size(1107, 134);
            // 
            // changeWindowBoxButton
            // 
            this.changeWindowBoxButton.FlatAppearance.BorderSize = 0;
            this.changeWindowBoxButton.Click += new System.EventHandler(this.ChangeWindowBoxButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.FlatAppearance.BorderSize = 0;
            // 
            // minimizeButton
            // 
            this.minimizeButton.FlatAppearance.BorderSize = 0;
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
            this.interactiveTasksButton.Location = new System.Drawing.Point(814, 95);
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
            this.testingButton.Location = new System.Drawing.Point(425, 95);
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
            this.theoryButton.Location = new System.Drawing.Point(52, 95);
            this.theoryButton.Name = "theoryButton";
            this.theoryButton.Size = new System.Drawing.Size(271, 277);
            this.theoryButton.TabIndex = 0;
            this.theoryButton.TextDescrition = "Лекционный материал для самостоятельной подготовки по работе в табличном процессо" +
    "ре «МойОфис Таблица»";
            this.theoryButton.TextHeader = "Теория";
            this.theoryButton.Click += new System.EventHandler(this.TheoryButton_Click);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1240, 703);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.buttonPanel);
            this.Controls.Add(this.referenceButton);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1240, 703);
            this.Name = "MainForm";
            this.Text = "Главная";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.Controls.SetChildIndex(this.referenceButton, 0);
            this.Controls.SetChildIndex(this.buttonPanel, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.minimizeButton, 0);
            this.Controls.SetChildIndex(this.cancelButton, 0);
            this.Controls.SetChildIndex(this.changeWindowBoxButton, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.buttonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button referenceButton;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Panel panel3;
        private ButtonCard theoryButton;
        private ButtonCard interactiveTasksButton;
        private ButtonCard testingButton;
    }
}