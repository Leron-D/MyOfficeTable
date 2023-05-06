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
            this.panel2 = new System.Windows.Forms.Panel();
            this.interactiveTasksButton = new MyOfficeTable.ButtonCard();
            this.testingButton = new MyOfficeTable.ButtonCard();
            this.theoryButton = new MyOfficeTable.ButtonCard();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.White;
            this.headerLabel.Location = new System.Drawing.Point(343, 39);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(607, 74);
            this.headerLabel.TabIndex = 6;
            this.headerLabel.Text = "Электронное пособие\r\n«Основы работы в МойОфис Таблица»";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.minimizeButton.Location = new System.Drawing.Point(1155, 0);
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
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.headerLabel);
            this.panel1.Location = new System.Drawing.Point(-1, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1248, 134);
            this.panel1.TabIndex = 41;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyOfficeTable.Properties.Resources.MyOfficeTable2;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.Controls.Add(this.interactiveTasksButton);
            this.panel2.Controls.Add(this.testingButton);
            this.panel2.Controls.Add(this.theoryButton);
            this.panel2.Location = new System.Drawing.Point(51, 229);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1139, 434);
            this.panel2.TabIndex = 42;
            // 
            // interactiveTasksButton
            // 
            this.interactiveTasksButton.BackColor = System.Drawing.Color.White;
            this.interactiveTasksButton.BackColorCurtain = System.Drawing.Color.RoyalBlue;
            this.interactiveTasksButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.interactiveTasksButton.FontDescrition = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.interactiveTasksButton.FontHeader = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.interactiveTasksButton.ForeColorDescrition = System.Drawing.Color.Black;
            this.interactiveTasksButton.ForeColorHeader = System.Drawing.Color.White;
            this.interactiveTasksButton.Location = new System.Drawing.Point(795, 93);
            this.interactiveTasksButton.Name = "interactiveTasksButton";
            this.interactiveTasksButton.Size = new System.Drawing.Size(271, 277);
            this.interactiveTasksButton.TabIndex = 2;
            this.interactiveTasksButton.Text = "Выбор 3";
            this.interactiveTasksButton.TextDescrition = "Проверка знания теоретического материала в виде интерактивных заданий";
            this.interactiveTasksButton.TextHeader = "Интерактивные задания";
            this.interactiveTasksButton.Click += new System.EventHandler(this.InteractiveTasksButton_Click);
            // 
            // testingButton
            // 
            this.testingButton.BackColor = System.Drawing.Color.White;
            this.testingButton.BackColorCurtain = System.Drawing.Color.SeaGreen;
            this.testingButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.testingButton.FontDescrition = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.testingButton.FontHeader = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.testingButton.ForeColorDescrition = System.Drawing.Color.Black;
            this.testingButton.ForeColorHeader = System.Drawing.Color.White;
            this.testingButton.Location = new System.Drawing.Point(433, 93);
            this.testingButton.Name = "testingButton";
            this.testingButton.Size = new System.Drawing.Size(271, 277);
            this.testingButton.TabIndex = 1;
            this.testingButton.Text = "Выбор 2";
            this.testingButton.TextDescrition = "Проверка знания теоретического материала в виде тестов";
            this.testingButton.TextHeader = "Тестирование";
            this.testingButton.Click += new System.EventHandler(this.TestingButton_Click);
            // 
            // theoryButton
            // 
            this.theoryButton.BackColor = System.Drawing.Color.White;
            this.theoryButton.BackColorCurtain = System.Drawing.Color.Tomato;
            this.theoryButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.theoryButton.FontDescrition = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.theoryButton.FontHeader = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.theoryButton.ForeColorDescrition = System.Drawing.Color.Black;
            this.theoryButton.ForeColorHeader = System.Drawing.Color.White;
            this.theoryButton.Location = new System.Drawing.Point(63, 93);
            this.theoryButton.Name = "theoryButton";
            this.theoryButton.Size = new System.Drawing.Size(271, 277);
            this.theoryButton.TabIndex = 0;
            this.theoryButton.Text = "Выбор 1";
            this.theoryButton.TextDescrition = "Теоретический материал по табличному процессору «МойОфис Таблица»";
            this.theoryButton.TextHeader = "Теория";
            this.theoryButton.Click += new System.EventHandler(this.TheoryButton_Click);
            // 
            // panel3
            // 
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
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.referenceButton);
            this.Controls.Add(this.minimizeButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button referenceButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private ButtonCard theoryButton;
        private ButtonCard interactiveTasksButton;
        private ButtonCard testingButton;
    }
}