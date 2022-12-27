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
            this.fourthAnswerCheckBox = new System.Windows.Forms.CheckBox();
            this.headerLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numOfQuestionLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fourthAnswerRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.BackColor = System.Drawing.Color.Transparent;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Image = global::MyOfficeTable.Properties.Resources.cancel;
            this.cancelButton.Location = new System.Drawing.Point(1254, 1);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(31, 32);
            this.cancelButton.TabIndex = 15;
            this.cancelButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // collapseButton
            // 
            this.collapseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.collapseButton.BackColor = System.Drawing.Color.Transparent;
            this.collapseButton.FlatAppearance.BorderSize = 0;
            this.collapseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.collapseButton.Image = global::MyOfficeTable.Properties.Resources.collapse;
            this.collapseButton.Location = new System.Drawing.Point(1213, 1);
            this.collapseButton.Name = "collapseButton";
            this.collapseButton.Size = new System.Drawing.Size(35, 32);
            this.collapseButton.TabIndex = 14;
            this.collapseButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.collapseButton.UseVisualStyleBackColor = false;
            this.collapseButton.Click += new System.EventHandler(this.CollapseButton_Click);
            // 
            // referenceButton
            // 
            this.referenceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.referenceButton.BackColor = System.Drawing.Color.PaleGreen;
            this.referenceButton.FlatAppearance.BorderSize = 0;
            this.referenceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.referenceButton.ForeColor = System.Drawing.Color.Transparent;
            this.referenceButton.Location = new System.Drawing.Point(1185, -200);
            this.referenceButton.Name = "referenceButton";
            this.referenceButton.Size = new System.Drawing.Size(22, 29);
            this.referenceButton.TabIndex = 16;
            this.referenceButton.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.referenceButton.UseVisualStyleBackColor = false;
            // 
            // goNextQuestionButton
            // 
            this.goNextQuestionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.goNextQuestionButton.BackColor = System.Drawing.Color.Turquoise;
            this.goNextQuestionButton.FlatAppearance.BorderSize = 0;
            this.goNextQuestionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goNextQuestionButton.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goNextQuestionButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.goNextQuestionButton.Location = new System.Drawing.Point(1012, 305);
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
            this.firstAnswerRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.firstAnswerRadioButton.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstAnswerRadioButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.firstAnswerRadioButton.Location = new System.Drawing.Point(12, 145);
            this.firstAnswerRadioButton.Name = "firstAnswerRadioButton";
            this.firstAnswerRadioButton.Size = new System.Drawing.Size(117, 31);
            this.firstAnswerRadioButton.TabIndex = 19;
            this.firstAnswerRadioButton.TabStop = true;
            this.firstAnswerRadioButton.Text = "Ответ 1";
            this.firstAnswerRadioButton.UseVisualStyleBackColor = false;
            // 
            // secondAnswerRadioButton
            // 
            this.secondAnswerRadioButton.AutoSize = true;
            this.secondAnswerRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.secondAnswerRadioButton.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondAnswerRadioButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.secondAnswerRadioButton.Location = new System.Drawing.Point(12, 182);
            this.secondAnswerRadioButton.Name = "secondAnswerRadioButton";
            this.secondAnswerRadioButton.Size = new System.Drawing.Size(117, 31);
            this.secondAnswerRadioButton.TabIndex = 20;
            this.secondAnswerRadioButton.TabStop = true;
            this.secondAnswerRadioButton.Text = "Ответ 2";
            this.secondAnswerRadioButton.UseVisualStyleBackColor = false;
            // 
            // thirdAnswerRadioButton
            // 
            this.thirdAnswerRadioButton.AutoSize = true;
            this.thirdAnswerRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.thirdAnswerRadioButton.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdAnswerRadioButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.thirdAnswerRadioButton.Location = new System.Drawing.Point(12, 219);
            this.thirdAnswerRadioButton.Name = "thirdAnswerRadioButton";
            this.thirdAnswerRadioButton.Size = new System.Drawing.Size(117, 31);
            this.thirdAnswerRadioButton.TabIndex = 21;
            this.thirdAnswerRadioButton.TabStop = true;
            this.thirdAnswerRadioButton.Text = "Ответ 3";
            this.thirdAnswerRadioButton.UseVisualStyleBackColor = false;
            // 
            // firstAnswerCheckBox
            // 
            this.firstAnswerCheckBox.AutoSize = true;
            this.firstAnswerCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.firstAnswerCheckBox.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstAnswerCheckBox.ForeColor = System.Drawing.Color.DarkCyan;
            this.firstAnswerCheckBox.Location = new System.Drawing.Point(135, 145);
            this.firstAnswerCheckBox.Name = "firstAnswerCheckBox";
            this.firstAnswerCheckBox.Size = new System.Drawing.Size(118, 31);
            this.firstAnswerCheckBox.TabIndex = 22;
            this.firstAnswerCheckBox.Text = "Ответ 1";
            this.firstAnswerCheckBox.UseVisualStyleBackColor = false;
            // 
            // secondAnswerCheckBox
            // 
            this.secondAnswerCheckBox.AutoSize = true;
            this.secondAnswerCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.secondAnswerCheckBox.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondAnswerCheckBox.ForeColor = System.Drawing.Color.DarkCyan;
            this.secondAnswerCheckBox.Location = new System.Drawing.Point(135, 183);
            this.secondAnswerCheckBox.Name = "secondAnswerCheckBox";
            this.secondAnswerCheckBox.Size = new System.Drawing.Size(118, 31);
            this.secondAnswerCheckBox.TabIndex = 23;
            this.secondAnswerCheckBox.Text = "Ответ 2";
            this.secondAnswerCheckBox.UseVisualStyleBackColor = false;
            // 
            // thirdAnswerCheckBox
            // 
            this.thirdAnswerCheckBox.AutoSize = true;
            this.thirdAnswerCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.thirdAnswerCheckBox.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdAnswerCheckBox.ForeColor = System.Drawing.Color.DarkCyan;
            this.thirdAnswerCheckBox.Location = new System.Drawing.Point(135, 220);
            this.thirdAnswerCheckBox.Name = "thirdAnswerCheckBox";
            this.thirdAnswerCheckBox.Size = new System.Drawing.Size(118, 31);
            this.thirdAnswerCheckBox.TabIndex = 24;
            this.thirdAnswerCheckBox.Text = "Ответ 3";
            this.thirdAnswerCheckBox.UseVisualStyleBackColor = false;
            // 
            // answerTextBox
            // 
            this.answerTextBox.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerTextBox.Location = new System.Drawing.Point(12, 295);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(352, 36);
            this.answerTextBox.TabIndex = 25;
            this.answerTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnswerTextBox_KeyDown);
            // 
            // startTestButton
            // 
            this.startTestButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.startTestButton.BackColor = System.Drawing.Color.Turquoise;
            this.startTestButton.FlatAppearance.BorderSize = 0;
            this.startTestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startTestButton.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTestButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.startTestButton.Location = new System.Drawing.Point(486, 162);
            this.startTestButton.Name = "startTestButton";
            this.startTestButton.Size = new System.Drawing.Size(297, 41);
            this.startTestButton.TabIndex = 26;
            this.startTestButton.Text = "Начать тестирование";
            this.startTestButton.UseVisualStyleBackColor = false;
            this.startTestButton.Click += new System.EventHandler(this.StartTestButton_Click);
            // 
            // questionLabel
            // 
            this.questionLabel.BackColor = System.Drawing.Color.Transparent;
            this.questionLabel.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.questionLabel.Location = new System.Drawing.Point(12, 71);
            this.questionLabel.MaximumSize = new System.Drawing.Size(900, 90);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(900, 58);
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
            this.timerLabel.BackColor = System.Drawing.Color.Transparent;
            this.timerLabel.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.timerLabel.Location = new System.Drawing.Point(1007, 71);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(0, 27);
            this.timerLabel.TabIndex = 28;
            // 
            // fourthAnswerCheckBox
            // 
            this.fourthAnswerCheckBox.AutoSize = true;
            this.fourthAnswerCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.fourthAnswerCheckBox.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourthAnswerCheckBox.ForeColor = System.Drawing.Color.DarkCyan;
            this.fourthAnswerCheckBox.Location = new System.Drawing.Point(135, 256);
            this.fourthAnswerCheckBox.Name = "fourthAnswerCheckBox";
            this.fourthAnswerCheckBox.Size = new System.Drawing.Size(118, 31);
            this.fourthAnswerCheckBox.TabIndex = 31;
            this.fourthAnswerCheckBox.Text = "Ответ 4";
            this.fourthAnswerCheckBox.UseVisualStyleBackColor = false;
            // 
            // headerLabel
            // 
            this.headerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerLabel.AutoSize = true;
            this.headerLabel.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel.Font = new System.Drawing.Font("Lucida Handwriting", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.headerLabel.Location = new System.Drawing.Point(5, 2);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(258, 41);
            this.headerLabel.TabIndex = 17;
            this.headerLabel.Text = "Тестирование";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Location = new System.Drawing.Point(-1, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1292, 22);
            this.panel1.TabIndex = 29;
            // 
            // numOfQuestionLabel
            // 
            this.numOfQuestionLabel.BackColor = System.Drawing.Color.Transparent;
            this.numOfQuestionLabel.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfQuestionLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.numOfQuestionLabel.Location = new System.Drawing.Point(490, 309);
            this.numOfQuestionLabel.MaximumSize = new System.Drawing.Size(850, 90);
            this.numOfQuestionLabel.Name = "numOfQuestionLabel";
            this.numOfQuestionLabel.Size = new System.Drawing.Size(45, 32);
            this.numOfQuestionLabel.TabIndex = 32;
            this.numOfQuestionLabel.Text = "#";
            this.numOfQuestionLabel.Visible = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(541, 309);
            this.label2.MaximumSize = new System.Drawing.Size(850, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 32);
            this.label2.TabIndex = 33;
            this.label2.Text = "из";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(592, 309);
            this.label3.MaximumSize = new System.Drawing.Size(850, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 32);
            this.label3.TabIndex = 34;
            this.label3.Text = "10";
            this.label3.Visible = false;
            // 
            // fourthAnswerRadioButton
            // 
            this.fourthAnswerRadioButton.AutoSize = true;
            this.fourthAnswerRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.fourthAnswerRadioButton.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourthAnswerRadioButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.fourthAnswerRadioButton.Location = new System.Drawing.Point(12, 256);
            this.fourthAnswerRadioButton.Name = "fourthAnswerRadioButton";
            this.fourthAnswerRadioButton.Size = new System.Drawing.Size(117, 31);
            this.fourthAnswerRadioButton.TabIndex = 35;
            this.fourthAnswerRadioButton.TabStop = true;
            this.fourthAnswerRadioButton.Text = "Ответ 4";
            this.fourthAnswerRadioButton.UseVisualStyleBackColor = false;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1286, 343);
            this.Controls.Add(this.fourthAnswerRadioButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numOfQuestionLabel);
            this.Controls.Add(this.fourthAnswerCheckBox);
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
            this.Text = "Тестирование";
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
        private System.Windows.Forms.CheckBox fourthAnswerCheckBox;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label numOfQuestionLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton fourthAnswerRadioButton;
    }
}