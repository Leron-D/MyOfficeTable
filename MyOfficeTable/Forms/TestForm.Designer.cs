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
            this.minimizeButton = new System.Windows.Forms.Button();
            this.referenceButton = new System.Windows.Forms.Button();
            this.AnswerCheckBox1 = new System.Windows.Forms.CheckBox();
            this.AnswerCheckBox2 = new System.Windows.Forms.CheckBox();
            this.AnswerCheckBox3 = new System.Windows.Forms.CheckBox();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.questionLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timerLabel = new System.Windows.Forms.Label();
            this.AnswerCheckBox4 = new System.Windows.Forms.CheckBox();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.headerPictureBox = new System.Windows.Forms.PictureBox();
            this.headerLabel = new System.Windows.Forms.Label();
            this.numOfQuestionLabel = new System.Windows.Forms.Label();
            this.offLabel = new System.Windows.Forms.Label();
            this.allNumQuestionLabel = new System.Windows.Forms.Label();
            this.AnswerCheckBox8 = new System.Windows.Forms.CheckBox();
            this.AnswerCheckBox7 = new System.Windows.Forms.CheckBox();
            this.AnswerCheckBox6 = new System.Windows.Forms.CheckBox();
            this.AnswerCheckBox5 = new System.Windows.Forms.CheckBox();
            this.AnswerRadioButton6 = new WindowsFormsApp1.MyRadioButton();
            this.goNextQuestionButton = new WindowsFormsApp1.MyButton();
            this.AnswerRadioButton8 = new WindowsFormsApp1.MyRadioButton();
            this.startTestButton = new WindowsFormsApp1.MyButton();
            this.AnswerRadioButton7 = new WindowsFormsApp1.MyRadioButton();
            this.AnswerRadioButton5 = new WindowsFormsApp1.MyRadioButton();
            this.AnswerRadioButton1 = new WindowsFormsApp1.MyRadioButton();
            this.AnswerRadioButton3 = new WindowsFormsApp1.MyRadioButton();
            this.AnswerRadioButton4 = new WindowsFormsApp1.MyRadioButton();
            this.AnswerRadioButton2 = new WindowsFormsApp1.MyRadioButton();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerPictureBox)).BeginInit();
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
            this.cancelButton.TabIndex = 2;
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
            this.minimizeButton.Location = new System.Drawing.Point(1213, 1);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(35, 32);
            this.minimizeButton.TabIndex = 1;
            this.minimizeButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // referenceButton
            // 
            this.referenceButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.referenceButton.BackColor = System.Drawing.Color.Transparent;
            this.referenceButton.FlatAppearance.BorderSize = 0;
            this.referenceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.referenceButton.ForeColor = System.Drawing.Color.Transparent;
            this.referenceButton.Image = global::MyOfficeTable.Properties.Resources.question;
            this.referenceButton.Location = new System.Drawing.Point(1172, 4);
            this.referenceButton.Name = "referenceButton";
            this.referenceButton.Size = new System.Drawing.Size(22, 29);
            this.referenceButton.TabIndex = 0;
            this.referenceButton.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.referenceButton.UseVisualStyleBackColor = false;
            // 
            // AnswerCheckBox1
            // 
            this.AnswerCheckBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.AnswerCheckBox1.AutoSize = true;
            this.AnswerCheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.AnswerCheckBox1.FlatAppearance.BorderSize = 0;
            this.AnswerCheckBox1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.AnswerCheckBox1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AnswerCheckBox1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AnswerCheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnswerCheckBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerCheckBox1.ForeColor = System.Drawing.Color.DarkCyan;
            this.AnswerCheckBox1.Image = ((System.Drawing.Image)(resources.GetObject("AnswerCheckBox1.Image")));
            this.AnswerCheckBox1.Location = new System.Drawing.Point(160, 260);
            this.AnswerCheckBox1.Name = "AnswerCheckBox1";
            this.AnswerCheckBox1.Size = new System.Drawing.Size(159, 46);
            this.AnswerCheckBox1.TabIndex = 13;
            this.AnswerCheckBox1.Text = "Ответ 1";
            this.AnswerCheckBox1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AnswerCheckBox1.UseVisualStyleBackColor = false;
            this.AnswerCheckBox1.CheckedChanged += new System.EventHandler(this.AnswerCheckBox_CheckedChanged);
            this.AnswerCheckBox1.LocationChanged += new System.EventHandler(this.FirstAnswerCheckBox_LocationChanged);
            // 
            // AnswerCheckBox2
            // 
            this.AnswerCheckBox2.Appearance = System.Windows.Forms.Appearance.Button;
            this.AnswerCheckBox2.AutoSize = true;
            this.AnswerCheckBox2.BackColor = System.Drawing.Color.Transparent;
            this.AnswerCheckBox2.FlatAppearance.BorderSize = 0;
            this.AnswerCheckBox2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.AnswerCheckBox2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AnswerCheckBox2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AnswerCheckBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnswerCheckBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerCheckBox2.ForeColor = System.Drawing.Color.DarkCyan;
            this.AnswerCheckBox2.Image = ((System.Drawing.Image)(resources.GetObject("AnswerCheckBox2.Image")));
            this.AnswerCheckBox2.Location = new System.Drawing.Point(160, 297);
            this.AnswerCheckBox2.Name = "AnswerCheckBox2";
            this.AnswerCheckBox2.Size = new System.Drawing.Size(159, 46);
            this.AnswerCheckBox2.TabIndex = 14;
            this.AnswerCheckBox2.Text = "Ответ 2";
            this.AnswerCheckBox2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AnswerCheckBox2.UseVisualStyleBackColor = false;
            this.AnswerCheckBox2.CheckedChanged += new System.EventHandler(this.AnswerCheckBox_CheckedChanged);
            // 
            // AnswerCheckBox3
            // 
            this.AnswerCheckBox3.Appearance = System.Windows.Forms.Appearance.Button;
            this.AnswerCheckBox3.AutoSize = true;
            this.AnswerCheckBox3.BackColor = System.Drawing.Color.Transparent;
            this.AnswerCheckBox3.FlatAppearance.BorderSize = 0;
            this.AnswerCheckBox3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.AnswerCheckBox3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AnswerCheckBox3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AnswerCheckBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnswerCheckBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerCheckBox3.ForeColor = System.Drawing.Color.DarkCyan;
            this.AnswerCheckBox3.Image = ((System.Drawing.Image)(resources.GetObject("AnswerCheckBox3.Image")));
            this.AnswerCheckBox3.Location = new System.Drawing.Point(160, 334);
            this.AnswerCheckBox3.Name = "AnswerCheckBox3";
            this.AnswerCheckBox3.Size = new System.Drawing.Size(159, 46);
            this.AnswerCheckBox3.TabIndex = 15;
            this.AnswerCheckBox3.Text = "Ответ 3";
            this.AnswerCheckBox3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AnswerCheckBox3.UseVisualStyleBackColor = false;
            this.AnswerCheckBox3.CheckedChanged += new System.EventHandler(this.AnswerCheckBox_CheckedChanged);
            // 
            // answerTextBox
            // 
            this.answerTextBox.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerTextBox.Location = new System.Drawing.Point(17, 424);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(352, 36);
            this.answerTextBox.TabIndex = 12;
            this.answerTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnswerTextBox_KeyDown);
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.BackColor = System.Drawing.Color.Transparent;
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.questionLabel.Location = new System.Drawing.Point(12, 222);
            this.questionLabel.MaximumSize = new System.Drawing.Size(900, 130);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(104, 29);
            this.questionLabel.TabIndex = 27;
            this.questionLabel.Text = "Вопрос";
            this.questionLabel.Resize += new System.EventHandler(this.QuestionLabel_Resize);
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
            this.timerLabel.Location = new System.Drawing.Point(994, 223);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(0, 27);
            this.timerLabel.TabIndex = 28;
            // 
            // AnswerCheckBox4
            // 
            this.AnswerCheckBox4.Appearance = System.Windows.Forms.Appearance.Button;
            this.AnswerCheckBox4.AutoSize = true;
            this.AnswerCheckBox4.BackColor = System.Drawing.Color.Transparent;
            this.AnswerCheckBox4.FlatAppearance.BorderSize = 0;
            this.AnswerCheckBox4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.AnswerCheckBox4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AnswerCheckBox4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AnswerCheckBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnswerCheckBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerCheckBox4.ForeColor = System.Drawing.Color.DarkCyan;
            this.AnswerCheckBox4.Image = ((System.Drawing.Image)(resources.GetObject("AnswerCheckBox4.Image")));
            this.AnswerCheckBox4.Location = new System.Drawing.Point(160, 372);
            this.AnswerCheckBox4.Name = "AnswerCheckBox4";
            this.AnswerCheckBox4.Size = new System.Drawing.Size(159, 46);
            this.AnswerCheckBox4.TabIndex = 16;
            this.AnswerCheckBox4.Text = "Ответ 4";
            this.AnswerCheckBox4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AnswerCheckBox4.UseVisualStyleBackColor = false;
            this.AnswerCheckBox4.CheckedChanged += new System.EventHandler(this.AnswerCheckBox_CheckedChanged);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.headerPanel.Controls.Add(this.headerPictureBox);
            this.headerPanel.Controls.Add(this.headerLabel);
            this.headerPanel.Location = new System.Drawing.Point(-1, 46);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1292, 134);
            this.headerPanel.TabIndex = 29;
            // 
            // headerPictureBox
            // 
            this.headerPictureBox.Image = global::MyOfficeTable.Properties.Resources.MyOfficeTable;
            this.headerPictureBox.Location = new System.Drawing.Point(0, 0);
            this.headerPictureBox.Name = "headerPictureBox";
            this.headerPictureBox.Size = new System.Drawing.Size(132, 133);
            this.headerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.headerPictureBox.TabIndex = 47;
            this.headerPictureBox.TabStop = false;
            // 
            // headerLabel
            // 
            this.headerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerLabel.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel.Font = new System.Drawing.Font("Lucida Sans", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.White;
            this.headerLabel.Location = new System.Drawing.Point(138, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(1137, 113);
            this.headerLabel.TabIndex = 17;
            this.headerLabel.Text = "Тестирование";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numOfQuestionLabel
            // 
            this.numOfQuestionLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numOfQuestionLabel.BackColor = System.Drawing.Color.Transparent;
            this.numOfQuestionLabel.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfQuestionLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.numOfQuestionLabel.Location = new System.Drawing.Point(545, 553);
            this.numOfQuestionLabel.MaximumSize = new System.Drawing.Size(850, 90);
            this.numOfQuestionLabel.Name = "numOfQuestionLabel";
            this.numOfQuestionLabel.Size = new System.Drawing.Size(45, 32);
            this.numOfQuestionLabel.TabIndex = 32;
            this.numOfQuestionLabel.Text = "#";
            this.numOfQuestionLabel.Visible = false;
            // 
            // offLabel
            // 
            this.offLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.offLabel.BackColor = System.Drawing.Color.Transparent;
            this.offLabel.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.offLabel.Location = new System.Drawing.Point(596, 553);
            this.offLabel.MaximumSize = new System.Drawing.Size(850, 90);
            this.offLabel.Name = "offLabel";
            this.offLabel.Size = new System.Drawing.Size(45, 32);
            this.offLabel.TabIndex = 33;
            this.offLabel.Text = "из";
            this.offLabel.Visible = false;
            // 
            // allNumQuestionLabel
            // 
            this.allNumQuestionLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.allNumQuestionLabel.BackColor = System.Drawing.Color.Transparent;
            this.allNumQuestionLabel.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allNumQuestionLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.allNumQuestionLabel.Location = new System.Drawing.Point(647, 553);
            this.allNumQuestionLabel.MaximumSize = new System.Drawing.Size(850, 90);
            this.allNumQuestionLabel.Name = "allNumQuestionLabel";
            this.allNumQuestionLabel.Size = new System.Drawing.Size(45, 32);
            this.allNumQuestionLabel.TabIndex = 34;
            this.allNumQuestionLabel.Text = "10";
            this.allNumQuestionLabel.Visible = false;
            // 
            // AnswerCheckBox8
            // 
            this.AnswerCheckBox8.Appearance = System.Windows.Forms.Appearance.Button;
            this.AnswerCheckBox8.AutoSize = true;
            this.AnswerCheckBox8.BackColor = System.Drawing.Color.Transparent;
            this.AnswerCheckBox8.FlatAppearance.BorderSize = 0;
            this.AnswerCheckBox8.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.AnswerCheckBox8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AnswerCheckBox8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AnswerCheckBox8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnswerCheckBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerCheckBox8.ForeColor = System.Drawing.Color.DarkCyan;
            this.AnswerCheckBox8.Image = ((System.Drawing.Image)(resources.GetObject("AnswerCheckBox8.Image")));
            this.AnswerCheckBox8.Location = new System.Drawing.Point(1098, 378);
            this.AnswerCheckBox8.Name = "AnswerCheckBox8";
            this.AnswerCheckBox8.Size = new System.Drawing.Size(159, 46);
            this.AnswerCheckBox8.TabIndex = 20;
            this.AnswerCheckBox8.Text = "Ответ 8";
            this.AnswerCheckBox8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AnswerCheckBox8.UseVisualStyleBackColor = false;
            this.AnswerCheckBox8.CheckedChanged += new System.EventHandler(this.AnswerCheckBox_CheckedChanged);
            // 
            // AnswerCheckBox7
            // 
            this.AnswerCheckBox7.Appearance = System.Windows.Forms.Appearance.Button;
            this.AnswerCheckBox7.AutoSize = true;
            this.AnswerCheckBox7.BackColor = System.Drawing.Color.Transparent;
            this.AnswerCheckBox7.FlatAppearance.BorderSize = 0;
            this.AnswerCheckBox7.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.AnswerCheckBox7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AnswerCheckBox7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AnswerCheckBox7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnswerCheckBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerCheckBox7.ForeColor = System.Drawing.Color.DarkCyan;
            this.AnswerCheckBox7.Image = ((System.Drawing.Image)(resources.GetObject("AnswerCheckBox7.Image")));
            this.AnswerCheckBox7.Location = new System.Drawing.Point(1098, 336);
            this.AnswerCheckBox7.Name = "AnswerCheckBox7";
            this.AnswerCheckBox7.Size = new System.Drawing.Size(159, 46);
            this.AnswerCheckBox7.TabIndex = 19;
            this.AnswerCheckBox7.Text = "Ответ 7";
            this.AnswerCheckBox7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AnswerCheckBox7.UseVisualStyleBackColor = false;
            this.AnswerCheckBox7.CheckedChanged += new System.EventHandler(this.AnswerCheckBox_CheckedChanged);
            // 
            // AnswerCheckBox6
            // 
            this.AnswerCheckBox6.Appearance = System.Windows.Forms.Appearance.Button;
            this.AnswerCheckBox6.AutoSize = true;
            this.AnswerCheckBox6.BackColor = System.Drawing.Color.Transparent;
            this.AnswerCheckBox6.FlatAppearance.BorderSize = 0;
            this.AnswerCheckBox6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.AnswerCheckBox6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AnswerCheckBox6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AnswerCheckBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnswerCheckBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerCheckBox6.ForeColor = System.Drawing.Color.DarkCyan;
            this.AnswerCheckBox6.Image = ((System.Drawing.Image)(resources.GetObject("AnswerCheckBox6.Image")));
            this.AnswerCheckBox6.Location = new System.Drawing.Point(1098, 296);
            this.AnswerCheckBox6.Name = "AnswerCheckBox6";
            this.AnswerCheckBox6.Size = new System.Drawing.Size(159, 46);
            this.AnswerCheckBox6.TabIndex = 18;
            this.AnswerCheckBox6.Text = "Ответ 6";
            this.AnswerCheckBox6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AnswerCheckBox6.UseVisualStyleBackColor = false;
            this.AnswerCheckBox6.CheckedChanged += new System.EventHandler(this.AnswerCheckBox_CheckedChanged);
            // 
            // AnswerCheckBox5
            // 
            this.AnswerCheckBox5.Appearance = System.Windows.Forms.Appearance.Button;
            this.AnswerCheckBox5.AutoSize = true;
            this.AnswerCheckBox5.BackColor = System.Drawing.Color.Transparent;
            this.AnswerCheckBox5.FlatAppearance.BorderSize = 0;
            this.AnswerCheckBox5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.AnswerCheckBox5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AnswerCheckBox5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AnswerCheckBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnswerCheckBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerCheckBox5.ForeColor = System.Drawing.Color.DarkCyan;
            this.AnswerCheckBox5.Image = ((System.Drawing.Image)(resources.GetObject("AnswerCheckBox5.Image")));
            this.AnswerCheckBox5.Location = new System.Drawing.Point(1098, 258);
            this.AnswerCheckBox5.Name = "AnswerCheckBox5";
            this.AnswerCheckBox5.Size = new System.Drawing.Size(159, 46);
            this.AnswerCheckBox5.TabIndex = 17;
            this.AnswerCheckBox5.Text = "Ответ 5";
            this.AnswerCheckBox5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AnswerCheckBox5.UseVisualStyleBackColor = false;
            this.AnswerCheckBox5.CheckedChanged += new System.EventHandler(this.AnswerCheckBox_CheckedChanged);
            // 
            // AnswerRadioButton6
            // 
            this.AnswerRadioButton6.AutoSize = true;
            this.AnswerRadioButton6.CheckedColor = System.Drawing.Color.Teal;
            this.AnswerRadioButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerRadioButton6.ForeColor = System.Drawing.Color.DarkCyan;
            this.AnswerRadioButton6.Location = new System.Drawing.Point(953, 305);
            this.AnswerRadioButton6.MinimumSize = new System.Drawing.Size(0, 21);
            this.AnswerRadioButton6.Name = "AnswerRadioButton6";
            this.AnswerRadioButton6.Size = new System.Drawing.Size(139, 33);
            this.AnswerRadioButton6.TabIndex = 9;
            this.AnswerRadioButton6.TabStop = true;
            this.AnswerRadioButton6.Text = "Ответ 6";
            this.AnswerRadioButton6.UnCheckedColor = System.Drawing.Color.Gray;
            this.AnswerRadioButton6.UseVisualStyleBackColor = true;
            // 
            // goNextQuestionButton
            // 
            this.goNextQuestionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.goNextQuestionButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.goNextQuestionButton.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.goNextQuestionButton.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.goNextQuestionButton.BorderRadius = 20;
            this.goNextQuestionButton.BorderSize = 0;
            this.goNextQuestionButton.FlatAppearance.BorderSize = 0;
            this.goNextQuestionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goNextQuestionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goNextQuestionButton.ForeColor = System.Drawing.Color.White;
            this.goNextQuestionButton.Location = new System.Drawing.Point(1012, 553);
            this.goNextQuestionButton.MinimumSize = new System.Drawing.Size(150, 40);
            this.goNextQuestionButton.Name = "goNextQuestionButton";
            this.goNextQuestionButton.Size = new System.Drawing.Size(273, 40);
            this.goNextQuestionButton.TabIndex = 21;
            this.goNextQuestionButton.Text = "Следующий вопрос";
            this.goNextQuestionButton.TextColor = System.Drawing.Color.White;
            this.goNextQuestionButton.UseVisualStyleBackColor = false;
            this.goNextQuestionButton.Click += new System.EventHandler(this.GoNextQuestionButton_Click);
            // 
            // AnswerRadioButton8
            // 
            this.AnswerRadioButton8.AutoSize = true;
            this.AnswerRadioButton8.CheckedColor = System.Drawing.Color.Teal;
            this.AnswerRadioButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerRadioButton8.ForeColor = System.Drawing.Color.DarkCyan;
            this.AnswerRadioButton8.Location = new System.Drawing.Point(953, 381);
            this.AnswerRadioButton8.MinimumSize = new System.Drawing.Size(0, 21);
            this.AnswerRadioButton8.Name = "AnswerRadioButton8";
            this.AnswerRadioButton8.Size = new System.Drawing.Size(139, 33);
            this.AnswerRadioButton8.TabIndex = 11;
            this.AnswerRadioButton8.TabStop = true;
            this.AnswerRadioButton8.Text = "Ответ 8";
            this.AnswerRadioButton8.UnCheckedColor = System.Drawing.Color.Gray;
            this.AnswerRadioButton8.UseVisualStyleBackColor = true;
            // 
            // startTestButton
            // 
            this.startTestButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.startTestButton.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.startTestButton.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.startTestButton.BorderRadius = 20;
            this.startTestButton.BorderSize = 0;
            this.startTestButton.FlatAppearance.BorderSize = 0;
            this.startTestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startTestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startTestButton.ForeColor = System.Drawing.Color.White;
            this.startTestButton.Location = new System.Drawing.Point(504, 333);
            this.startTestButton.MinimumSize = new System.Drawing.Size(150, 40);
            this.startTestButton.Name = "startTestButton";
            this.startTestButton.Size = new System.Drawing.Size(297, 40);
            this.startTestButton.TabIndex = 3;
            this.startTestButton.Text = "Начать тестирование";
            this.startTestButton.TextColor = System.Drawing.Color.White;
            this.startTestButton.UseVisualStyleBackColor = false;
            this.startTestButton.Click += new System.EventHandler(this.StartTestButton_Click);
            // 
            // AnswerRadioButton7
            // 
            this.AnswerRadioButton7.AutoSize = true;
            this.AnswerRadioButton7.CheckedColor = System.Drawing.Color.Teal;
            this.AnswerRadioButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerRadioButton7.ForeColor = System.Drawing.Color.DarkCyan;
            this.AnswerRadioButton7.Location = new System.Drawing.Point(953, 343);
            this.AnswerRadioButton7.MinimumSize = new System.Drawing.Size(0, 21);
            this.AnswerRadioButton7.Name = "AnswerRadioButton7";
            this.AnswerRadioButton7.Size = new System.Drawing.Size(139, 33);
            this.AnswerRadioButton7.TabIndex = 10;
            this.AnswerRadioButton7.TabStop = true;
            this.AnswerRadioButton7.Text = "Ответ 7";
            this.AnswerRadioButton7.UnCheckedColor = System.Drawing.Color.Gray;
            this.AnswerRadioButton7.UseVisualStyleBackColor = true;
            // 
            // AnswerRadioButton5
            // 
            this.AnswerRadioButton5.AutoSize = true;
            this.AnswerRadioButton5.CheckedColor = System.Drawing.Color.Teal;
            this.AnswerRadioButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerRadioButton5.ForeColor = System.Drawing.Color.DarkCyan;
            this.AnswerRadioButton5.Location = new System.Drawing.Point(953, 267);
            this.AnswerRadioButton5.MinimumSize = new System.Drawing.Size(0, 21);
            this.AnswerRadioButton5.Name = "AnswerRadioButton5";
            this.AnswerRadioButton5.Size = new System.Drawing.Size(139, 33);
            this.AnswerRadioButton5.TabIndex = 8;
            this.AnswerRadioButton5.TabStop = true;
            this.AnswerRadioButton5.Text = "Ответ 5";
            this.AnswerRadioButton5.UnCheckedColor = System.Drawing.Color.Gray;
            this.AnswerRadioButton5.UseVisualStyleBackColor = true;
            // 
            // AnswerRadioButton1
            // 
            this.AnswerRadioButton1.AutoSize = true;
            this.AnswerRadioButton1.CheckedColor = System.Drawing.Color.Teal;
            this.AnswerRadioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerRadioButton1.ForeColor = System.Drawing.Color.DarkCyan;
            this.AnswerRadioButton1.Location = new System.Drawing.Point(17, 267);
            this.AnswerRadioButton1.MinimumSize = new System.Drawing.Size(0, 21);
            this.AnswerRadioButton1.Name = "AnswerRadioButton1";
            this.AnswerRadioButton1.Size = new System.Drawing.Size(139, 33);
            this.AnswerRadioButton1.TabIndex = 4;
            this.AnswerRadioButton1.TabStop = true;
            this.AnswerRadioButton1.Text = "Ответ 1";
            this.AnswerRadioButton1.UnCheckedColor = System.Drawing.Color.Gray;
            this.AnswerRadioButton1.UseVisualStyleBackColor = true;
            this.AnswerRadioButton1.LocationChanged += new System.EventHandler(this.FirstAnswerRadioButton_LocationChanged);
            // 
            // AnswerRadioButton3
            // 
            this.AnswerRadioButton3.AutoSize = true;
            this.AnswerRadioButton3.CheckedColor = System.Drawing.Color.Teal;
            this.AnswerRadioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerRadioButton3.ForeColor = System.Drawing.Color.DarkCyan;
            this.AnswerRadioButton3.Location = new System.Drawing.Point(17, 343);
            this.AnswerRadioButton3.MinimumSize = new System.Drawing.Size(0, 21);
            this.AnswerRadioButton3.Name = "AnswerRadioButton3";
            this.AnswerRadioButton3.Size = new System.Drawing.Size(139, 33);
            this.AnswerRadioButton3.TabIndex = 6;
            this.AnswerRadioButton3.TabStop = true;
            this.AnswerRadioButton3.Text = "Ответ 3";
            this.AnswerRadioButton3.UnCheckedColor = System.Drawing.Color.Gray;
            this.AnswerRadioButton3.UseVisualStyleBackColor = true;
            // 
            // AnswerRadioButton4
            // 
            this.AnswerRadioButton4.AutoSize = true;
            this.AnswerRadioButton4.CheckedColor = System.Drawing.Color.Teal;
            this.AnswerRadioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerRadioButton4.ForeColor = System.Drawing.Color.DarkCyan;
            this.AnswerRadioButton4.Location = new System.Drawing.Point(17, 381);
            this.AnswerRadioButton4.MinimumSize = new System.Drawing.Size(0, 21);
            this.AnswerRadioButton4.Name = "AnswerRadioButton4";
            this.AnswerRadioButton4.Size = new System.Drawing.Size(139, 33);
            this.AnswerRadioButton4.TabIndex = 7;
            this.AnswerRadioButton4.TabStop = true;
            this.AnswerRadioButton4.Text = "Ответ 4";
            this.AnswerRadioButton4.UnCheckedColor = System.Drawing.Color.Gray;
            this.AnswerRadioButton4.UseVisualStyleBackColor = true;
            // 
            // AnswerRadioButton2
            // 
            this.AnswerRadioButton2.AutoSize = true;
            this.AnswerRadioButton2.CheckedColor = System.Drawing.Color.Teal;
            this.AnswerRadioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerRadioButton2.ForeColor = System.Drawing.Color.DarkCyan;
            this.AnswerRadioButton2.Location = new System.Drawing.Point(17, 305);
            this.AnswerRadioButton2.MinimumSize = new System.Drawing.Size(0, 21);
            this.AnswerRadioButton2.Name = "AnswerRadioButton2";
            this.AnswerRadioButton2.Size = new System.Drawing.Size(139, 33);
            this.AnswerRadioButton2.TabIndex = 5;
            this.AnswerRadioButton2.TabStop = true;
            this.AnswerRadioButton2.Text = "Ответ 2";
            this.AnswerRadioButton2.UnCheckedColor = System.Drawing.Color.Gray;
            this.AnswerRadioButton2.UseVisualStyleBackColor = true;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1286, 594);
            this.Controls.Add(this.AnswerCheckBox2);
            this.Controls.Add(this.AnswerRadioButton6);
            this.Controls.Add(this.referenceButton);
            this.Controls.Add(this.AnswerCheckBox1);
            this.Controls.Add(this.goNextQuestionButton);
            this.Controls.Add(this.AnswerRadioButton8);
            this.Controls.Add(this.startTestButton);
            this.Controls.Add(this.AnswerCheckBox3);
            this.Controls.Add(this.allNumQuestionLabel);
            this.Controls.Add(this.AnswerRadioButton7);
            this.Controls.Add(this.offLabel);
            this.Controls.Add(this.AnswerCheckBox4);
            this.Controls.Add(this.numOfQuestionLabel);
            this.Controls.Add(this.AnswerRadioButton5);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.AnswerRadioButton1);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.AnswerCheckBox8);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.AnswerRadioButton3);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.AnswerCheckBox7);
            this.Controls.Add(this.AnswerRadioButton4);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.AnswerCheckBox6);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.AnswerCheckBox5);
            this.Controls.Add(this.AnswerRadioButton2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1286, 525);
            this.Name = "TestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тестирование";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TestForm_FormClosed);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TestForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TestForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TestForm_MouseUp);
            this.headerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.headerPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button referenceButton;
        private System.Windows.Forms.CheckBox AnswerCheckBox1;
        private System.Windows.Forms.CheckBox AnswerCheckBox2;
        private System.Windows.Forms.CheckBox AnswerCheckBox3;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.CheckBox AnswerCheckBox4;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label numOfQuestionLabel;
        private System.Windows.Forms.Label offLabel;
        private System.Windows.Forms.Label allNumQuestionLabel;
        private WindowsFormsApp1.MyButton startTestButton;
        private WindowsFormsApp1.MyButton goNextQuestionButton;
        private System.Windows.Forms.PictureBox headerPictureBox;
        private WindowsFormsApp1.MyRadioButton AnswerRadioButton1;
        private WindowsFormsApp1.MyRadioButton AnswerRadioButton3;
        private WindowsFormsApp1.MyRadioButton AnswerRadioButton4;
        private WindowsFormsApp1.MyRadioButton AnswerRadioButton2;
        private WindowsFormsApp1.MyRadioButton AnswerRadioButton6;
        private WindowsFormsApp1.MyRadioButton AnswerRadioButton8;
        private WindowsFormsApp1.MyRadioButton AnswerRadioButton7;
        private WindowsFormsApp1.MyRadioButton AnswerRadioButton5;
        private System.Windows.Forms.CheckBox AnswerCheckBox8;
        private System.Windows.Forms.CheckBox AnswerCheckBox7;
        private System.Windows.Forms.CheckBox AnswerCheckBox6;
        private System.Windows.Forms.CheckBox AnswerCheckBox5;
        private System.Windows.Forms.Label headerLabel;
    }
}