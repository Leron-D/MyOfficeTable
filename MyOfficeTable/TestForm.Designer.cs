namespace MyOfficeTable
{
    partial class TestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
            this.cancelButton = new System.Windows.Forms.Button();
            this.collapseButton = new System.Windows.Forms.Button();
            this.referenceButton = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.goNextQuestionButton = new System.Windows.Forms.Button();
            this.firstAnswerRadioButton = new System.Windows.Forms.RadioButton();
            this.secondAnswerRadioButton = new System.Windows.Forms.RadioButton();
            this.thirdAnswerRadioButton = new System.Windows.Forms.RadioButton();
            this.firstAnswerCheckBox = new System.Windows.Forms.CheckBox();
            this.secondAnswerCheckBox = new System.Windows.Forms.CheckBox();
            this.thirdAnswerCheckBox = new System.Windows.Forms.CheckBox();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.startTestButton = new System.Windows.Forms.Button();
            this.questionLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timerLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Image = global::MyOfficeTable.Properties.Resources.cancel;
            this.cancelButton.Location = new System.Drawing.Point(842, 1);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(31, 32);
            this.cancelButton.TabIndex = 15;
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
            this.collapseButton.Location = new System.Drawing.Point(801, 1);
            this.collapseButton.Name = "collapseButton";
            this.collapseButton.Size = new System.Drawing.Size(35, 32);
            this.collapseButton.TabIndex = 14;
            this.collapseButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.collapseButton.UseVisualStyleBackColor = true;
            this.collapseButton.Click += new System.EventHandler(this.CollapseButton_Click);
            // 
            // referenceButton
            // 
            this.referenceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.referenceButton.BackColor = System.Drawing.Color.PaleGreen;
            this.referenceButton.FlatAppearance.BorderSize = 0;
            this.referenceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.referenceButton.ForeColor = System.Drawing.Color.Transparent;
            this.referenceButton.Image = global::MyOfficeTable.Properties.Resources.question;
            this.referenceButton.Location = new System.Drawing.Point(773, -234);
            this.referenceButton.Name = "referenceButton";
            this.referenceButton.Size = new System.Drawing.Size(22, 29);
            this.referenceButton.TabIndex = 16;
            this.referenceButton.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.referenceButton.UseVisualStyleBackColor = false;
            // 
            // headerLabel
            // 
            this.headerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Lucida Handwriting", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.headerLabel.Location = new System.Drawing.Point(5, 2);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(258, 41);
            this.headerLabel.TabIndex = 17;
            this.headerLabel.Text = "Тестирование";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // goNextQuestionButton
            // 
            this.goNextQuestionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.goNextQuestionButton.BackColor = System.Drawing.Color.Turquoise;
            this.goNextQuestionButton.FlatAppearance.BorderSize = 0;
            this.goNextQuestionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goNextQuestionButton.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goNextQuestionButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.goNextQuestionButton.Location = new System.Drawing.Point(600, 271);
            this.goNextQuestionButton.Name = "goNextQuestionButton";
            this.goNextQuestionButton.Size = new System.Drawing.Size(273, 36);
            this.goNextQuestionButton.TabIndex = 18;
            this.goNextQuestionButton.Text = "Следующий вопрос";
            this.goNextQuestionButton.UseVisualStyleBackColor = false;
            this.goNextQuestionButton.Click += new System.EventHandler(this.GoNextQuestionButton_Click);
            // 
            // firstAnswerRadioButton
            // 
            this.firstAnswerRadioButton.AutoSize = true;
            this.firstAnswerRadioButton.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstAnswerRadioButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.firstAnswerRadioButton.Location = new System.Drawing.Point(12, 145);
            this.firstAnswerRadioButton.Name = "firstAnswerRadioButton";
            this.firstAnswerRadioButton.Size = new System.Drawing.Size(117, 31);
            this.firstAnswerRadioButton.TabIndex = 19;
            this.firstAnswerRadioButton.TabStop = true;
            this.firstAnswerRadioButton.Text = "Ответ 1";
            this.firstAnswerRadioButton.UseVisualStyleBackColor = true;
            // 
            // secondAnswerRadioButton
            // 
            this.secondAnswerRadioButton.AutoSize = true;
            this.secondAnswerRadioButton.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondAnswerRadioButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.secondAnswerRadioButton.Location = new System.Drawing.Point(12, 182);
            this.secondAnswerRadioButton.Name = "secondAnswerRadioButton";
            this.secondAnswerRadioButton.Size = new System.Drawing.Size(117, 31);
            this.secondAnswerRadioButton.TabIndex = 20;
            this.secondAnswerRadioButton.TabStop = true;
            this.secondAnswerRadioButton.Text = "Ответ 2";
            this.secondAnswerRadioButton.UseVisualStyleBackColor = true;
            // 
            // thirdAnswerRadioButton
            // 
            this.thirdAnswerRadioButton.AutoSize = true;
            this.thirdAnswerRadioButton.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdAnswerRadioButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.thirdAnswerRadioButton.Location = new System.Drawing.Point(12, 219);
            this.thirdAnswerRadioButton.Name = "thirdAnswerRadioButton";
            this.thirdAnswerRadioButton.Size = new System.Drawing.Size(117, 31);
            this.thirdAnswerRadioButton.TabIndex = 21;
            this.thirdAnswerRadioButton.TabStop = true;
            this.thirdAnswerRadioButton.Text = "Ответ 3";
            this.thirdAnswerRadioButton.UseVisualStyleBackColor = true;
            // 
            // firstAnswerCheckBox
            // 
            this.firstAnswerCheckBox.AutoSize = true;
            this.firstAnswerCheckBox.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstAnswerCheckBox.ForeColor = System.Drawing.Color.DarkCyan;
            this.firstAnswerCheckBox.Location = new System.Drawing.Point(258, 240);
            this.firstAnswerCheckBox.Name = "firstAnswerCheckBox";
            this.firstAnswerCheckBox.Size = new System.Drawing.Size(118, 31);
            this.firstAnswerCheckBox.TabIndex = 22;
            this.firstAnswerCheckBox.Text = "Ответ 1";
            this.firstAnswerCheckBox.UseVisualStyleBackColor = true;
            // 
            // secondAnswerCheckBox
            // 
            this.secondAnswerCheckBox.AutoSize = true;
            this.secondAnswerCheckBox.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondAnswerCheckBox.ForeColor = System.Drawing.Color.DarkCyan;
            this.secondAnswerCheckBox.Location = new System.Drawing.Point(382, 240);
            this.secondAnswerCheckBox.Name = "secondAnswerCheckBox";
            this.secondAnswerCheckBox.Size = new System.Drawing.Size(118, 31);
            this.secondAnswerCheckBox.TabIndex = 23;
            this.secondAnswerCheckBox.Text = "Ответ 2";
            this.secondAnswerCheckBox.UseVisualStyleBackColor = true;
            // 
            // thirdAnswerCheckBox
            // 
            this.thirdAnswerCheckBox.AutoSize = true;
            this.thirdAnswerCheckBox.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdAnswerCheckBox.ForeColor = System.Drawing.Color.DarkCyan;
            this.thirdAnswerCheckBox.Location = new System.Drawing.Point(506, 240);
            this.thirdAnswerCheckBox.Name = "thirdAnswerCheckBox";
            this.thirdAnswerCheckBox.Size = new System.Drawing.Size(118, 31);
            this.thirdAnswerCheckBox.TabIndex = 24;
            this.thirdAnswerCheckBox.Text = "Ответ 3";
            this.thirdAnswerCheckBox.UseVisualStyleBackColor = true;
            // 
            // answerTextBox
            // 
            this.answerTextBox.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerTextBox.Location = new System.Drawing.Point(258, 198);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(352, 36);
            this.answerTextBox.TabIndex = 25;
            // 
            // startTestButton
            // 
            this.startTestButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.startTestButton.BackColor = System.Drawing.Color.Turquoise;
            this.startTestButton.FlatAppearance.BorderSize = 0;
            this.startTestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startTestButton.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTestButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.startTestButton.Location = new System.Drawing.Point(283, 145);
            this.startTestButton.Name = "startTestButton";
            this.startTestButton.Size = new System.Drawing.Size(297, 41);
            this.startTestButton.TabIndex = 26;
            this.startTestButton.Text = "Начать тестирование";
            this.startTestButton.UseVisualStyleBackColor = false;
            this.startTestButton.Click += new System.EventHandler(this.StartTestButton_Click);
            // 
            // questionLabel
            // 
            this.questionLabel.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.questionLabel.Location = new System.Drawing.Point(12, 71);
            this.questionLabel.MaximumSize = new System.Drawing.Size(850, 90);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(850, 58);
            this.questionLabel.TabIndex = 27;
            this.questionLabel.Text = "Вопрос";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.timerLabel.Location = new System.Drawing.Point(12, 271);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(94, 27);
            this.timerLabel.TabIndex = 28;
            this.timerLabel.Text = "Таймер";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Location = new System.Drawing.Point(-1, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 10);
            this.panel1.TabIndex = 29;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(874, 309);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.startTestButton);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.thirdAnswerCheckBox);
            this.Controls.Add(this.secondAnswerCheckBox);
            this.Controls.Add(this.firstAnswerCheckBox);
            this.Controls.Add(this.thirdAnswerRadioButton);
            this.Controls.Add(this.secondAnswerRadioButton);
            this.Controls.Add(this.firstAnswerRadioButton);
            this.Controls.Add(this.goNextQuestionButton);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.referenceButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.collapseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TestForm_FormClosed);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TestForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TestForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TestForm_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button collapseButton;
        private System.Windows.Forms.Button referenceButton;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button goNextQuestionButton;
        private System.Windows.Forms.RadioButton firstAnswerRadioButton;
        private System.Windows.Forms.RadioButton secondAnswerRadioButton;
        private System.Windows.Forms.RadioButton thirdAnswerRadioButton;
        private System.Windows.Forms.CheckBox firstAnswerCheckBox;
        private System.Windows.Forms.CheckBox secondAnswerCheckBox;
        private System.Windows.Forms.CheckBox thirdAnswerCheckBox;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Button startTestButton;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Panel panel1;
    }
}