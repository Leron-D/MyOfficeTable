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
            this.answerCheckBox1 = new System.Windows.Forms.CheckBox();
            this.answerCheckBox2 = new System.Windows.Forms.CheckBox();
            this.answerCheckBox3 = new System.Windows.Forms.CheckBox();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.questionLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timerLabel = new System.Windows.Forms.Label();
            this.answerCheckBox4 = new System.Windows.Forms.CheckBox();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.headerPictureBox = new System.Windows.Forms.PictureBox();
            this.headerLabel = new System.Windows.Forms.Label();
            this.numOfQuestionLabel = new System.Windows.Forms.Label();
            this.answerCheckBox8 = new System.Windows.Forms.CheckBox();
            this.answerCheckBox7 = new System.Windows.Forms.CheckBox();
            this.answerCheckBox6 = new System.Windows.Forms.CheckBox();
            this.answerCheckBox5 = new System.Windows.Forms.CheckBox();
            this.changeWindowBoxButton = new System.Windows.Forms.Button();
            this.answerRadioButton6 = new MyOfficeTable.MyRadioButton();
            this.goNextQuestionButton = new MyOfficeTable.MyButton();
            this.answerRadioButton8 = new MyOfficeTable.MyRadioButton();
            this.startTestButton = new MyOfficeTable.MyButton();
            this.answerRadioButton7 = new MyOfficeTable.MyRadioButton();
            this.answerRadioButton5 = new MyOfficeTable.MyRadioButton();
            this.answerRadioButton1 = new MyOfficeTable.MyRadioButton();
            this.answerRadioButton3 = new MyOfficeTable.MyRadioButton();
            this.answerRadioButton4 = new MyOfficeTable.MyRadioButton();
            this.answerRadioButton2 = new MyOfficeTable.MyRadioButton();
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
            this.minimizeButton.Location = new System.Drawing.Point(1172, 1);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(35, 32);
            this.minimizeButton.TabIndex = 1;
            this.minimizeButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // answerCheckBox1
            // 
            this.answerCheckBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.answerCheckBox1.AutoSize = true;
            this.answerCheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.answerCheckBox1.FlatAppearance.BorderSize = 0;
            this.answerCheckBox1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.answerCheckBox1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.answerCheckBox1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.answerCheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answerCheckBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerCheckBox1.ForeColor = System.Drawing.Color.DarkCyan;
            this.answerCheckBox1.Image = ((System.Drawing.Image)(resources.GetObject("answerCheckBox1.Image")));
            this.answerCheckBox1.Location = new System.Drawing.Point(160, 260);
            this.answerCheckBox1.Name = "answerCheckBox1";
            this.answerCheckBox1.Size = new System.Drawing.Size(159, 46);
            this.answerCheckBox1.TabIndex = 13;
            this.answerCheckBox1.Text = "Ответ 1";
            this.answerCheckBox1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.answerCheckBox1.UseVisualStyleBackColor = false;
            this.answerCheckBox1.CheckedChanged += new System.EventHandler(this.AnswerCheckBox_CheckedChanged);
            this.answerCheckBox1.LocationChanged += new System.EventHandler(this.FirstAnswerCheckBox_LocationChanged);
            // 
            // answerCheckBox2
            // 
            this.answerCheckBox2.Appearance = System.Windows.Forms.Appearance.Button;
            this.answerCheckBox2.AutoSize = true;
            this.answerCheckBox2.BackColor = System.Drawing.Color.Transparent;
            this.answerCheckBox2.FlatAppearance.BorderSize = 0;
            this.answerCheckBox2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.answerCheckBox2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.answerCheckBox2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.answerCheckBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answerCheckBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerCheckBox2.ForeColor = System.Drawing.Color.DarkCyan;
            this.answerCheckBox2.Image = ((System.Drawing.Image)(resources.GetObject("answerCheckBox2.Image")));
            this.answerCheckBox2.Location = new System.Drawing.Point(160, 297);
            this.answerCheckBox2.Name = "answerCheckBox2";
            this.answerCheckBox2.Size = new System.Drawing.Size(159, 46);
            this.answerCheckBox2.TabIndex = 14;
            this.answerCheckBox2.Text = "Ответ 2";
            this.answerCheckBox2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.answerCheckBox2.UseVisualStyleBackColor = false;
            this.answerCheckBox2.CheckedChanged += new System.EventHandler(this.AnswerCheckBox_CheckedChanged);
            // 
            // answerCheckBox3
            // 
            this.answerCheckBox3.Appearance = System.Windows.Forms.Appearance.Button;
            this.answerCheckBox3.AutoSize = true;
            this.answerCheckBox3.BackColor = System.Drawing.Color.Transparent;
            this.answerCheckBox3.FlatAppearance.BorderSize = 0;
            this.answerCheckBox3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.answerCheckBox3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.answerCheckBox3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.answerCheckBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answerCheckBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerCheckBox3.ForeColor = System.Drawing.Color.DarkCyan;
            this.answerCheckBox3.Image = ((System.Drawing.Image)(resources.GetObject("answerCheckBox3.Image")));
            this.answerCheckBox3.Location = new System.Drawing.Point(160, 334);
            this.answerCheckBox3.Name = "answerCheckBox3";
            this.answerCheckBox3.Size = new System.Drawing.Size(159, 46);
            this.answerCheckBox3.TabIndex = 15;
            this.answerCheckBox3.Text = "Ответ 3";
            this.answerCheckBox3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.answerCheckBox3.UseVisualStyleBackColor = false;
            this.answerCheckBox3.CheckedChanged += new System.EventHandler(this.AnswerCheckBox_CheckedChanged);
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
            this.questionLabel.Location = new System.Drawing.Point(12, 210);
            this.questionLabel.MaximumSize = new System.Drawing.Size(900, 130);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(104, 29);
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
            this.timerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timerLabel.AutoSize = true;
            this.timerLabel.BackColor = System.Drawing.Color.Transparent;
            this.timerLabel.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.timerLabel.Location = new System.Drawing.Point(948, 199);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(0, 27);
            this.timerLabel.TabIndex = 28;
            this.timerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answerCheckBox4
            // 
            this.answerCheckBox4.Appearance = System.Windows.Forms.Appearance.Button;
            this.answerCheckBox4.AutoSize = true;
            this.answerCheckBox4.BackColor = System.Drawing.Color.Transparent;
            this.answerCheckBox4.FlatAppearance.BorderSize = 0;
            this.answerCheckBox4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.answerCheckBox4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.answerCheckBox4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.answerCheckBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answerCheckBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerCheckBox4.ForeColor = System.Drawing.Color.DarkCyan;
            this.answerCheckBox4.Image = ((System.Drawing.Image)(resources.GetObject("answerCheckBox4.Image")));
            this.answerCheckBox4.Location = new System.Drawing.Point(160, 372);
            this.answerCheckBox4.Name = "answerCheckBox4";
            this.answerCheckBox4.Size = new System.Drawing.Size(159, 46);
            this.answerCheckBox4.TabIndex = 16;
            this.answerCheckBox4.Text = "Ответ 4";
            this.answerCheckBox4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.answerCheckBox4.UseVisualStyleBackColor = false;
            this.answerCheckBox4.CheckedChanged += new System.EventHandler(this.AnswerCheckBox_CheckedChanged);
            // 
            // headerPanel
            // 
            this.headerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.headerLabel.Font = new System.Drawing.Font("Lucida Sans", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.White;
            this.headerLabel.Location = new System.Drawing.Point(130, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(1156, 133);
            this.headerLabel.TabIndex = 17;
            this.headerLabel.Text = "Тестирование";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numOfQuestionLabel
            // 
            this.numOfQuestionLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numOfQuestionLabel.AutoSize = true;
            this.numOfQuestionLabel.BackColor = System.Drawing.Color.Transparent;
            this.numOfQuestionLabel.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfQuestionLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.numOfQuestionLabel.Location = new System.Drawing.Point(545, 553);
            this.numOfQuestionLabel.MaximumSize = new System.Drawing.Size(850, 90);
            this.numOfQuestionLabel.Name = "numOfQuestionLabel";
            this.numOfQuestionLabel.Size = new System.Drawing.Size(180, 27);
            this.numOfQuestionLabel.TabIndex = 32;
            this.numOfQuestionLabel.Text = "Номер вопроса";
            this.numOfQuestionLabel.Visible = false;
            // 
            // answerCheckBox8
            // 
            this.answerCheckBox8.Appearance = System.Windows.Forms.Appearance.Button;
            this.answerCheckBox8.AutoSize = true;
            this.answerCheckBox8.BackColor = System.Drawing.Color.Transparent;
            this.answerCheckBox8.FlatAppearance.BorderSize = 0;
            this.answerCheckBox8.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.answerCheckBox8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.answerCheckBox8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.answerCheckBox8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answerCheckBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerCheckBox8.ForeColor = System.Drawing.Color.DarkCyan;
            this.answerCheckBox8.Image = ((System.Drawing.Image)(resources.GetObject("answerCheckBox8.Image")));
            this.answerCheckBox8.Location = new System.Drawing.Point(1098, 378);
            this.answerCheckBox8.Name = "answerCheckBox8";
            this.answerCheckBox8.Size = new System.Drawing.Size(159, 46);
            this.answerCheckBox8.TabIndex = 20;
            this.answerCheckBox8.Text = "Ответ 8";
            this.answerCheckBox8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.answerCheckBox8.UseVisualStyleBackColor = false;
            this.answerCheckBox8.CheckedChanged += new System.EventHandler(this.AnswerCheckBox_CheckedChanged);
            // 
            // answerCheckBox7
            // 
            this.answerCheckBox7.Appearance = System.Windows.Forms.Appearance.Button;
            this.answerCheckBox7.AutoSize = true;
            this.answerCheckBox7.BackColor = System.Drawing.Color.Transparent;
            this.answerCheckBox7.FlatAppearance.BorderSize = 0;
            this.answerCheckBox7.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.answerCheckBox7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.answerCheckBox7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.answerCheckBox7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answerCheckBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerCheckBox7.ForeColor = System.Drawing.Color.DarkCyan;
            this.answerCheckBox7.Image = ((System.Drawing.Image)(resources.GetObject("answerCheckBox7.Image")));
            this.answerCheckBox7.Location = new System.Drawing.Point(1098, 336);
            this.answerCheckBox7.Name = "answerCheckBox7";
            this.answerCheckBox7.Size = new System.Drawing.Size(159, 46);
            this.answerCheckBox7.TabIndex = 19;
            this.answerCheckBox7.Text = "Ответ 7";
            this.answerCheckBox7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.answerCheckBox7.UseVisualStyleBackColor = false;
            this.answerCheckBox7.CheckedChanged += new System.EventHandler(this.AnswerCheckBox_CheckedChanged);
            // 
            // answerCheckBox6
            // 
            this.answerCheckBox6.Appearance = System.Windows.Forms.Appearance.Button;
            this.answerCheckBox6.AutoSize = true;
            this.answerCheckBox6.BackColor = System.Drawing.Color.Transparent;
            this.answerCheckBox6.FlatAppearance.BorderSize = 0;
            this.answerCheckBox6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.answerCheckBox6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.answerCheckBox6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.answerCheckBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answerCheckBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerCheckBox6.ForeColor = System.Drawing.Color.DarkCyan;
            this.answerCheckBox6.Image = ((System.Drawing.Image)(resources.GetObject("answerCheckBox6.Image")));
            this.answerCheckBox6.Location = new System.Drawing.Point(1098, 296);
            this.answerCheckBox6.Name = "answerCheckBox6";
            this.answerCheckBox6.Size = new System.Drawing.Size(159, 46);
            this.answerCheckBox6.TabIndex = 18;
            this.answerCheckBox6.Text = "Ответ 6";
            this.answerCheckBox6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.answerCheckBox6.UseVisualStyleBackColor = false;
            this.answerCheckBox6.CheckedChanged += new System.EventHandler(this.AnswerCheckBox_CheckedChanged);
            // 
            // answerCheckBox5
            // 
            this.answerCheckBox5.Appearance = System.Windows.Forms.Appearance.Button;
            this.answerCheckBox5.AutoSize = true;
            this.answerCheckBox5.BackColor = System.Drawing.Color.Transparent;
            this.answerCheckBox5.FlatAppearance.BorderSize = 0;
            this.answerCheckBox5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.answerCheckBox5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.answerCheckBox5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.answerCheckBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answerCheckBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerCheckBox5.ForeColor = System.Drawing.Color.DarkCyan;
            this.answerCheckBox5.Image = ((System.Drawing.Image)(resources.GetObject("answerCheckBox5.Image")));
            this.answerCheckBox5.Location = new System.Drawing.Point(1098, 258);
            this.answerCheckBox5.Name = "answerCheckBox5";
            this.answerCheckBox5.Size = new System.Drawing.Size(159, 46);
            this.answerCheckBox5.TabIndex = 17;
            this.answerCheckBox5.Text = "Ответ 5";
            this.answerCheckBox5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.answerCheckBox5.UseVisualStyleBackColor = false;
            this.answerCheckBox5.CheckedChanged += new System.EventHandler(this.AnswerCheckBox_CheckedChanged);
            // 
            // changeWindowBoxButton
            // 
            this.changeWindowBoxButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changeWindowBoxButton.BackColor = System.Drawing.Color.Transparent;
            this.changeWindowBoxButton.FlatAppearance.BorderSize = 0;
            this.changeWindowBoxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeWindowBoxButton.Image = global::MyOfficeTable.Properties.Resources.Fullscreen;
            this.changeWindowBoxButton.Location = new System.Drawing.Point(1213, 1);
            this.changeWindowBoxButton.Name = "changeWindowBoxButton";
            this.changeWindowBoxButton.Size = new System.Drawing.Size(35, 32);
            this.changeWindowBoxButton.TabIndex = 74;
            this.changeWindowBoxButton.Tag = "Fullscreen";
            this.changeWindowBoxButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.changeWindowBoxButton.UseVisualStyleBackColor = false;
            this.changeWindowBoxButton.Click += new System.EventHandler(this.ChangeWindowBoxButton_Click);
            // 
            // answerRadioButton6
            // 
            this.answerRadioButton6.AutoSize = true;
            this.answerRadioButton6.CheckedColor = System.Drawing.Color.Teal;
            this.answerRadioButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerRadioButton6.ForeColor = System.Drawing.Color.DarkCyan;
            this.answerRadioButton6.Location = new System.Drawing.Point(953, 305);
            this.answerRadioButton6.MinimumSize = new System.Drawing.Size(0, 21);
            this.answerRadioButton6.Name = "answerRadioButton6";
            this.answerRadioButton6.Size = new System.Drawing.Size(139, 33);
            this.answerRadioButton6.TabIndex = 9;
            this.answerRadioButton6.TabStop = true;
            this.answerRadioButton6.Text = "Ответ 6";
            this.answerRadioButton6.UnCheckedColor = System.Drawing.Color.Gray;
            this.answerRadioButton6.UseVisualStyleBackColor = true;
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
            this.goNextQuestionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goNextQuestionButton.ForeColor = System.Drawing.Color.White;
            this.goNextQuestionButton.Location = new System.Drawing.Point(1003, 553);
            this.goNextQuestionButton.MinimumSize = new System.Drawing.Size(150, 40);
            this.goNextQuestionButton.Name = "goNextQuestionButton";
            this.goNextQuestionButton.Size = new System.Drawing.Size(282, 40);
            this.goNextQuestionButton.TabIndex = 21;
            this.goNextQuestionButton.Text = "Следующий вопрос";
            this.goNextQuestionButton.TextColor = System.Drawing.Color.White;
            this.goNextQuestionButton.UseVisualStyleBackColor = false;
            this.goNextQuestionButton.Click += new System.EventHandler(this.GoNextQuestionButton_Click);
            // 
            // answerRadioButton8
            // 
            this.answerRadioButton8.AutoSize = true;
            this.answerRadioButton8.CheckedColor = System.Drawing.Color.Teal;
            this.answerRadioButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerRadioButton8.ForeColor = System.Drawing.Color.DarkCyan;
            this.answerRadioButton8.Location = new System.Drawing.Point(953, 381);
            this.answerRadioButton8.MinimumSize = new System.Drawing.Size(0, 21);
            this.answerRadioButton8.Name = "answerRadioButton8";
            this.answerRadioButton8.Size = new System.Drawing.Size(139, 33);
            this.answerRadioButton8.TabIndex = 11;
            this.answerRadioButton8.TabStop = true;
            this.answerRadioButton8.Text = "Ответ 8";
            this.answerRadioButton8.UnCheckedColor = System.Drawing.Color.Gray;
            this.answerRadioButton8.UseVisualStyleBackColor = true;
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
            this.startTestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startTestButton.ForeColor = System.Drawing.Color.White;
            this.startTestButton.Location = new System.Drawing.Point(490, 333);
            this.startTestButton.MinimumSize = new System.Drawing.Size(150, 40);
            this.startTestButton.Name = "startTestButton";
            this.startTestButton.Size = new System.Drawing.Size(348, 40);
            this.startTestButton.TabIndex = 3;
            this.startTestButton.Text = "Начать тестирование";
            this.startTestButton.TextColor = System.Drawing.Color.White;
            this.startTestButton.UseVisualStyleBackColor = false;
            this.startTestButton.Click += new System.EventHandler(this.StartTestButton_Click);
            // 
            // answerRadioButton7
            // 
            this.answerRadioButton7.AutoSize = true;
            this.answerRadioButton7.CheckedColor = System.Drawing.Color.Teal;
            this.answerRadioButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerRadioButton7.ForeColor = System.Drawing.Color.DarkCyan;
            this.answerRadioButton7.Location = new System.Drawing.Point(953, 343);
            this.answerRadioButton7.MinimumSize = new System.Drawing.Size(0, 21);
            this.answerRadioButton7.Name = "answerRadioButton7";
            this.answerRadioButton7.Size = new System.Drawing.Size(139, 33);
            this.answerRadioButton7.TabIndex = 10;
            this.answerRadioButton7.TabStop = true;
            this.answerRadioButton7.Text = "Ответ 7";
            this.answerRadioButton7.UnCheckedColor = System.Drawing.Color.Gray;
            this.answerRadioButton7.UseVisualStyleBackColor = true;
            // 
            // answerRadioButton5
            // 
            this.answerRadioButton5.AutoSize = true;
            this.answerRadioButton5.CheckedColor = System.Drawing.Color.Teal;
            this.answerRadioButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerRadioButton5.ForeColor = System.Drawing.Color.DarkCyan;
            this.answerRadioButton5.Location = new System.Drawing.Point(953, 267);
            this.answerRadioButton5.MinimumSize = new System.Drawing.Size(0, 21);
            this.answerRadioButton5.Name = "answerRadioButton5";
            this.answerRadioButton5.Size = new System.Drawing.Size(139, 33);
            this.answerRadioButton5.TabIndex = 8;
            this.answerRadioButton5.TabStop = true;
            this.answerRadioButton5.Text = "Ответ 5";
            this.answerRadioButton5.UnCheckedColor = System.Drawing.Color.Gray;
            this.answerRadioButton5.UseVisualStyleBackColor = true;
            // 
            // answerRadioButton1
            // 
            this.answerRadioButton1.AutoSize = true;
            this.answerRadioButton1.CheckedColor = System.Drawing.Color.Teal;
            this.answerRadioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerRadioButton1.ForeColor = System.Drawing.Color.DarkCyan;
            this.answerRadioButton1.Location = new System.Drawing.Point(17, 267);
            this.answerRadioButton1.MinimumSize = new System.Drawing.Size(0, 21);
            this.answerRadioButton1.Name = "answerRadioButton1";
            this.answerRadioButton1.Size = new System.Drawing.Size(139, 33);
            this.answerRadioButton1.TabIndex = 4;
            this.answerRadioButton1.TabStop = true;
            this.answerRadioButton1.Text = "Ответ 1";
            this.answerRadioButton1.UnCheckedColor = System.Drawing.Color.Gray;
            this.answerRadioButton1.UseVisualStyleBackColor = true;
            this.answerRadioButton1.LocationChanged += new System.EventHandler(this.FirstAnswerRadioButton_LocationChanged);
            // 
            // answerRadioButton3
            // 
            this.answerRadioButton3.AutoSize = true;
            this.answerRadioButton3.CheckedColor = System.Drawing.Color.Teal;
            this.answerRadioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerRadioButton3.ForeColor = System.Drawing.Color.DarkCyan;
            this.answerRadioButton3.Location = new System.Drawing.Point(17, 343);
            this.answerRadioButton3.MinimumSize = new System.Drawing.Size(0, 21);
            this.answerRadioButton3.Name = "answerRadioButton3";
            this.answerRadioButton3.Size = new System.Drawing.Size(139, 33);
            this.answerRadioButton3.TabIndex = 6;
            this.answerRadioButton3.TabStop = true;
            this.answerRadioButton3.Text = "Ответ 3";
            this.answerRadioButton3.UnCheckedColor = System.Drawing.Color.Gray;
            this.answerRadioButton3.UseVisualStyleBackColor = true;
            // 
            // answerRadioButton4
            // 
            this.answerRadioButton4.AutoSize = true;
            this.answerRadioButton4.CheckedColor = System.Drawing.Color.Teal;
            this.answerRadioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerRadioButton4.ForeColor = System.Drawing.Color.DarkCyan;
            this.answerRadioButton4.Location = new System.Drawing.Point(17, 381);
            this.answerRadioButton4.MinimumSize = new System.Drawing.Size(0, 21);
            this.answerRadioButton4.Name = "answerRadioButton4";
            this.answerRadioButton4.Size = new System.Drawing.Size(139, 33);
            this.answerRadioButton4.TabIndex = 7;
            this.answerRadioButton4.TabStop = true;
            this.answerRadioButton4.Text = "Ответ 4";
            this.answerRadioButton4.UnCheckedColor = System.Drawing.Color.Gray;
            this.answerRadioButton4.UseVisualStyleBackColor = true;
            // 
            // answerRadioButton2
            // 
            this.answerRadioButton2.AutoSize = true;
            this.answerRadioButton2.CheckedColor = System.Drawing.Color.Teal;
            this.answerRadioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerRadioButton2.ForeColor = System.Drawing.Color.DarkCyan;
            this.answerRadioButton2.Location = new System.Drawing.Point(17, 305);
            this.answerRadioButton2.MinimumSize = new System.Drawing.Size(0, 21);
            this.answerRadioButton2.Name = "answerRadioButton2";
            this.answerRadioButton2.Size = new System.Drawing.Size(139, 33);
            this.answerRadioButton2.TabIndex = 5;
            this.answerRadioButton2.TabStop = true;
            this.answerRadioButton2.Text = "Ответ 2";
            this.answerRadioButton2.UnCheckedColor = System.Drawing.Color.Gray;
            this.answerRadioButton2.UseVisualStyleBackColor = true;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1286, 594);
            this.Controls.Add(this.changeWindowBoxButton);
            this.Controls.Add(this.answerCheckBox2);
            this.Controls.Add(this.answerRadioButton6);
            this.Controls.Add(this.answerCheckBox1);
            this.Controls.Add(this.goNextQuestionButton);
            this.Controls.Add(this.answerRadioButton8);
            this.Controls.Add(this.startTestButton);
            this.Controls.Add(this.answerCheckBox3);
            this.Controls.Add(this.answerRadioButton7);
            this.Controls.Add(this.answerCheckBox4);
            this.Controls.Add(this.numOfQuestionLabel);
            this.Controls.Add(this.answerRadioButton5);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.answerRadioButton1);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.answerCheckBox8);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.answerRadioButton3);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.answerCheckBox7);
            this.Controls.Add(this.answerRadioButton4);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.answerCheckBox6);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.answerCheckBox5);
            this.Controls.Add(this.answerRadioButton2);
            this.DoubleBuffered = true;
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
        private System.Windows.Forms.CheckBox answerCheckBox1;
        private System.Windows.Forms.CheckBox answerCheckBox2;
        private System.Windows.Forms.CheckBox answerCheckBox3;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.CheckBox answerCheckBox4;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label numOfQuestionLabel;
        private MyOfficeTable.MyButton goNextQuestionButton;
        private System.Windows.Forms.PictureBox headerPictureBox;
        private MyOfficeTable.MyRadioButton answerRadioButton1;
        private MyOfficeTable.MyRadioButton answerRadioButton3;
        private MyOfficeTable.MyRadioButton answerRadioButton4;
        private MyOfficeTable.MyRadioButton answerRadioButton2;
        private MyOfficeTable.MyRadioButton answerRadioButton6;
        private MyOfficeTable.MyRadioButton answerRadioButton8;
        private MyOfficeTable.MyRadioButton answerRadioButton7;
        private MyOfficeTable.MyRadioButton answerRadioButton5;
        private System.Windows.Forms.CheckBox answerCheckBox8;
        private System.Windows.Forms.CheckBox answerCheckBox7;
        private System.Windows.Forms.CheckBox answerCheckBox6;
        private System.Windows.Forms.CheckBox answerCheckBox5;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button changeWindowBoxButton;
        private MyButton startTestButton;
    }
}