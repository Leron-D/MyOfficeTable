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
            this.firstAnswerCheckBox = new System.Windows.Forms.CheckBox();
            this.secondAnswerCheckBox = new System.Windows.Forms.CheckBox();
            this.thirdAnswerCheckBox = new System.Windows.Forms.CheckBox();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.questionLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timerLabel = new System.Windows.Forms.Label();
            this.fourthAnswerCheckBox = new System.Windows.Forms.CheckBox();
            this.headerLabel = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.numOfQuestionLabel = new System.Windows.Forms.Label();
            this.offLabel = new System.Windows.Forms.Label();
            this.allNumQuestionLabel = new System.Windows.Forms.Label();
            this.eighthAnswerCheckBox = new System.Windows.Forms.CheckBox();
            this.seventhAnswerCheckBox = new System.Windows.Forms.CheckBox();
            this.sixthAnswerCheckBox = new System.Windows.Forms.CheckBox();
            this.fifthAnswerCheckBox = new System.Windows.Forms.CheckBox();
            this.sixthAnswerRadioButton = new WindowsFormsApp1.MyRadioButton();
            this.goNextQuestionButton = new WindowsFormsApp1.MyButton();
            this.eighthAnswerRadioButton = new WindowsFormsApp1.MyRadioButton();
            this.startTestButton = new WindowsFormsApp1.MyButton();
            this.seventhAnswerRadioButton = new WindowsFormsApp1.MyRadioButton();
            this.fifthAnswerRadioButton = new WindowsFormsApp1.MyRadioButton();
            this.firstAnswerRadioButton = new WindowsFormsApp1.MyRadioButton();
            this.thirdAnswerRadioButton = new WindowsFormsApp1.MyRadioButton();
            this.fourthAnswerRadioButton = new WindowsFormsApp1.MyRadioButton();
            this.secondAnswerRadioButton = new WindowsFormsApp1.MyRadioButton();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.minimizeButton.TabIndex = 14;
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
            this.referenceButton.TabIndex = 16;
            this.referenceButton.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.referenceButton.UseVisualStyleBackColor = false;
            // 
            // firstAnswerCheckBox
            // 
            this.firstAnswerCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.firstAnswerCheckBox.AutoSize = true;
            this.firstAnswerCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.firstAnswerCheckBox.FlatAppearance.BorderSize = 0;
            this.firstAnswerCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.firstAnswerCheckBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.firstAnswerCheckBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.firstAnswerCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.firstAnswerCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstAnswerCheckBox.ForeColor = System.Drawing.Color.DarkCyan;
            this.firstAnswerCheckBox.Image = ((System.Drawing.Image)(resources.GetObject("firstAnswerCheckBox.Image")));
            this.firstAnswerCheckBox.Location = new System.Drawing.Point(160, 260);
            this.firstAnswerCheckBox.Name = "firstAnswerCheckBox";
            this.firstAnswerCheckBox.Size = new System.Drawing.Size(159, 46);
            this.firstAnswerCheckBox.TabIndex = 22;
            this.firstAnswerCheckBox.Text = "Ответ 1";
            this.firstAnswerCheckBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.firstAnswerCheckBox.UseVisualStyleBackColor = false;
            this.firstAnswerCheckBox.CheckedChanged += new System.EventHandler(this.AnswerCheckBox_CheckedChanged);
            this.firstAnswerCheckBox.LocationChanged += new System.EventHandler(this.FirstAnswerCheckBox_LocationChanged);
            // 
            // secondAnswerCheckBox
            // 
            this.secondAnswerCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.secondAnswerCheckBox.AutoSize = true;
            this.secondAnswerCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.secondAnswerCheckBox.FlatAppearance.BorderSize = 0;
            this.secondAnswerCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.secondAnswerCheckBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.secondAnswerCheckBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.secondAnswerCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.secondAnswerCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondAnswerCheckBox.ForeColor = System.Drawing.Color.DarkCyan;
            this.secondAnswerCheckBox.Image = ((System.Drawing.Image)(resources.GetObject("secondAnswerCheckBox.Image")));
            this.secondAnswerCheckBox.Location = new System.Drawing.Point(160, 297);
            this.secondAnswerCheckBox.Name = "secondAnswerCheckBox";
            this.secondAnswerCheckBox.Size = new System.Drawing.Size(159, 46);
            this.secondAnswerCheckBox.TabIndex = 23;
            this.secondAnswerCheckBox.Text = "Ответ 2";
            this.secondAnswerCheckBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.secondAnswerCheckBox.UseVisualStyleBackColor = false;
            this.secondAnswerCheckBox.CheckedChanged += new System.EventHandler(this.AnswerCheckBox_CheckedChanged);
            // 
            // thirdAnswerCheckBox
            // 
            this.thirdAnswerCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.thirdAnswerCheckBox.AutoSize = true;
            this.thirdAnswerCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.thirdAnswerCheckBox.FlatAppearance.BorderSize = 0;
            this.thirdAnswerCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.thirdAnswerCheckBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.thirdAnswerCheckBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.thirdAnswerCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.thirdAnswerCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdAnswerCheckBox.ForeColor = System.Drawing.Color.DarkCyan;
            this.thirdAnswerCheckBox.Image = ((System.Drawing.Image)(resources.GetObject("thirdAnswerCheckBox.Image")));
            this.thirdAnswerCheckBox.Location = new System.Drawing.Point(160, 334);
            this.thirdAnswerCheckBox.Name = "thirdAnswerCheckBox";
            this.thirdAnswerCheckBox.Size = new System.Drawing.Size(159, 46);
            this.thirdAnswerCheckBox.TabIndex = 24;
            this.thirdAnswerCheckBox.Text = "Ответ 3";
            this.thirdAnswerCheckBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.thirdAnswerCheckBox.UseVisualStyleBackColor = false;
            this.thirdAnswerCheckBox.CheckedChanged += new System.EventHandler(this.AnswerCheckBox_CheckedChanged);
            // 
            // answerTextBox
            // 
            this.answerTextBox.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerTextBox.Location = new System.Drawing.Point(17, 424);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(352, 36);
            this.answerTextBox.TabIndex = 25;
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
            // fourthAnswerCheckBox
            // 
            this.fourthAnswerCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.fourthAnswerCheckBox.AutoSize = true;
            this.fourthAnswerCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.fourthAnswerCheckBox.FlatAppearance.BorderSize = 0;
            this.fourthAnswerCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.fourthAnswerCheckBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.fourthAnswerCheckBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.fourthAnswerCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fourthAnswerCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourthAnswerCheckBox.ForeColor = System.Drawing.Color.DarkCyan;
            this.fourthAnswerCheckBox.Image = ((System.Drawing.Image)(resources.GetObject("fourthAnswerCheckBox.Image")));
            this.fourthAnswerCheckBox.Location = new System.Drawing.Point(160, 372);
            this.fourthAnswerCheckBox.Name = "fourthAnswerCheckBox";
            this.fourthAnswerCheckBox.Size = new System.Drawing.Size(159, 46);
            this.fourthAnswerCheckBox.TabIndex = 31;
            this.fourthAnswerCheckBox.Text = "Ответ 4";
            this.fourthAnswerCheckBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.fourthAnswerCheckBox.UseVisualStyleBackColor = false;
            this.fourthAnswerCheckBox.CheckedChanged += new System.EventHandler(this.AnswerCheckBox_CheckedChanged);
            // 
            // headerLabel
            // 
            this.headerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerLabel.AutoSize = true;
            this.headerLabel.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel.Font = new System.Drawing.Font("Lucida Sans", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.White;
            this.headerLabel.Location = new System.Drawing.Point(508, 53);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(257, 39);
            this.headerLabel.TabIndex = 17;
            this.headerLabel.Text = "Тестирование";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.headerPanel.Controls.Add(this.pictureBox1);
            this.headerPanel.Controls.Add(this.headerLabel);
            this.headerPanel.Location = new System.Drawing.Point(-1, 46);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1292, 134);
            this.headerPanel.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyOfficeTable.Properties.Resources.MyOfficeTable;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
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
            // eighthAnswerCheckBox
            // 
            this.eighthAnswerCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.eighthAnswerCheckBox.AutoSize = true;
            this.eighthAnswerCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.eighthAnswerCheckBox.FlatAppearance.BorderSize = 0;
            this.eighthAnswerCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.eighthAnswerCheckBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.eighthAnswerCheckBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.eighthAnswerCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eighthAnswerCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eighthAnswerCheckBox.ForeColor = System.Drawing.Color.DarkCyan;
            this.eighthAnswerCheckBox.Image = ((System.Drawing.Image)(resources.GetObject("eighthAnswerCheckBox.Image")));
            this.eighthAnswerCheckBox.Location = new System.Drawing.Point(1098, 378);
            this.eighthAnswerCheckBox.Name = "eighthAnswerCheckBox";
            this.eighthAnswerCheckBox.Size = new System.Drawing.Size(159, 46);
            this.eighthAnswerCheckBox.TabIndex = 56;
            this.eighthAnswerCheckBox.Text = "Ответ 8";
            this.eighthAnswerCheckBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.eighthAnswerCheckBox.UseVisualStyleBackColor = false;
            this.eighthAnswerCheckBox.CheckedChanged += new System.EventHandler(this.AnswerCheckBox_CheckedChanged);
            // 
            // seventhAnswerCheckBox
            // 
            this.seventhAnswerCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.seventhAnswerCheckBox.AutoSize = true;
            this.seventhAnswerCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.seventhAnswerCheckBox.FlatAppearance.BorderSize = 0;
            this.seventhAnswerCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.seventhAnswerCheckBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.seventhAnswerCheckBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.seventhAnswerCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seventhAnswerCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seventhAnswerCheckBox.ForeColor = System.Drawing.Color.DarkCyan;
            this.seventhAnswerCheckBox.Image = ((System.Drawing.Image)(resources.GetObject("seventhAnswerCheckBox.Image")));
            this.seventhAnswerCheckBox.Location = new System.Drawing.Point(1098, 336);
            this.seventhAnswerCheckBox.Name = "seventhAnswerCheckBox";
            this.seventhAnswerCheckBox.Size = new System.Drawing.Size(159, 46);
            this.seventhAnswerCheckBox.TabIndex = 55;
            this.seventhAnswerCheckBox.Text = "Ответ 7";
            this.seventhAnswerCheckBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.seventhAnswerCheckBox.UseVisualStyleBackColor = false;
            this.seventhAnswerCheckBox.CheckedChanged += new System.EventHandler(this.AnswerCheckBox_CheckedChanged);
            // 
            // sixthAnswerCheckBox
            // 
            this.sixthAnswerCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.sixthAnswerCheckBox.AutoSize = true;
            this.sixthAnswerCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.sixthAnswerCheckBox.FlatAppearance.BorderSize = 0;
            this.sixthAnswerCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.sixthAnswerCheckBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.sixthAnswerCheckBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.sixthAnswerCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sixthAnswerCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixthAnswerCheckBox.ForeColor = System.Drawing.Color.DarkCyan;
            this.sixthAnswerCheckBox.Image = ((System.Drawing.Image)(resources.GetObject("sixthAnswerCheckBox.Image")));
            this.sixthAnswerCheckBox.Location = new System.Drawing.Point(1098, 296);
            this.sixthAnswerCheckBox.Name = "sixthAnswerCheckBox";
            this.sixthAnswerCheckBox.Size = new System.Drawing.Size(159, 46);
            this.sixthAnswerCheckBox.TabIndex = 54;
            this.sixthAnswerCheckBox.Text = "Ответ 6";
            this.sixthAnswerCheckBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sixthAnswerCheckBox.UseVisualStyleBackColor = false;
            this.sixthAnswerCheckBox.CheckedChanged += new System.EventHandler(this.AnswerCheckBox_CheckedChanged);
            // 
            // fifthAnswerCheckBox
            // 
            this.fifthAnswerCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.fifthAnswerCheckBox.AutoSize = true;
            this.fifthAnswerCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.fifthAnswerCheckBox.FlatAppearance.BorderSize = 0;
            this.fifthAnswerCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.fifthAnswerCheckBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.fifthAnswerCheckBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.fifthAnswerCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fifthAnswerCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fifthAnswerCheckBox.ForeColor = System.Drawing.Color.DarkCyan;
            this.fifthAnswerCheckBox.Image = ((System.Drawing.Image)(resources.GetObject("fifthAnswerCheckBox.Image")));
            this.fifthAnswerCheckBox.Location = new System.Drawing.Point(1098, 258);
            this.fifthAnswerCheckBox.Name = "fifthAnswerCheckBox";
            this.fifthAnswerCheckBox.Size = new System.Drawing.Size(159, 46);
            this.fifthAnswerCheckBox.TabIndex = 53;
            this.fifthAnswerCheckBox.Text = "Ответ 5";
            this.fifthAnswerCheckBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.fifthAnswerCheckBox.UseVisualStyleBackColor = false;
            this.fifthAnswerCheckBox.CheckedChanged += new System.EventHandler(this.AnswerCheckBox_CheckedChanged);
            // 
            // sixthAnswerRadioButton
            // 
            this.sixthAnswerRadioButton.AutoSize = true;
            this.sixthAnswerRadioButton.CheckedColor = System.Drawing.Color.ForestGreen;
            this.sixthAnswerRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixthAnswerRadioButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.sixthAnswerRadioButton.Location = new System.Drawing.Point(953, 305);
            this.sixthAnswerRadioButton.MinimumSize = new System.Drawing.Size(0, 21);
            this.sixthAnswerRadioButton.Name = "sixthAnswerRadioButton";
            this.sixthAnswerRadioButton.Size = new System.Drawing.Size(139, 33);
            this.sixthAnswerRadioButton.TabIndex = 60;
            this.sixthAnswerRadioButton.TabStop = true;
            this.sixthAnswerRadioButton.Text = "Ответ 6";
            this.sixthAnswerRadioButton.UnCheckedColor = System.Drawing.Color.Gray;
            this.sixthAnswerRadioButton.UseVisualStyleBackColor = true;
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
            this.goNextQuestionButton.TabIndex = 46;
            this.goNextQuestionButton.Text = "Следующий вопрос";
            this.goNextQuestionButton.TextColor = System.Drawing.Color.White;
            this.goNextQuestionButton.UseVisualStyleBackColor = false;
            this.goNextQuestionButton.Click += new System.EventHandler(this.GoNextQuestionButton_Click);
            // 
            // eighthAnswerRadioButton
            // 
            this.eighthAnswerRadioButton.AutoSize = true;
            this.eighthAnswerRadioButton.CheckedColor = System.Drawing.Color.CadetBlue;
            this.eighthAnswerRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eighthAnswerRadioButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.eighthAnswerRadioButton.Location = new System.Drawing.Point(953, 381);
            this.eighthAnswerRadioButton.MinimumSize = new System.Drawing.Size(0, 21);
            this.eighthAnswerRadioButton.Name = "eighthAnswerRadioButton";
            this.eighthAnswerRadioButton.Size = new System.Drawing.Size(139, 33);
            this.eighthAnswerRadioButton.TabIndex = 59;
            this.eighthAnswerRadioButton.TabStop = true;
            this.eighthAnswerRadioButton.Text = "Ответ 8";
            this.eighthAnswerRadioButton.UnCheckedColor = System.Drawing.Color.Gray;
            this.eighthAnswerRadioButton.UseVisualStyleBackColor = true;
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
            this.startTestButton.TabIndex = 45;
            this.startTestButton.Text = "Начать тестирование";
            this.startTestButton.TextColor = System.Drawing.Color.White;
            this.startTestButton.UseVisualStyleBackColor = false;
            this.startTestButton.Click += new System.EventHandler(this.StartTestButton_Click);
            // 
            // seventhAnswerRadioButton
            // 
            this.seventhAnswerRadioButton.AutoSize = true;
            this.seventhAnswerRadioButton.CheckedColor = System.Drawing.Color.Teal;
            this.seventhAnswerRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seventhAnswerRadioButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.seventhAnswerRadioButton.Location = new System.Drawing.Point(953, 343);
            this.seventhAnswerRadioButton.MinimumSize = new System.Drawing.Size(0, 21);
            this.seventhAnswerRadioButton.Name = "seventhAnswerRadioButton";
            this.seventhAnswerRadioButton.Size = new System.Drawing.Size(139, 33);
            this.seventhAnswerRadioButton.TabIndex = 58;
            this.seventhAnswerRadioButton.TabStop = true;
            this.seventhAnswerRadioButton.Text = "Ответ 7";
            this.seventhAnswerRadioButton.UnCheckedColor = System.Drawing.Color.Gray;
            this.seventhAnswerRadioButton.UseVisualStyleBackColor = true;
            // 
            // fifthAnswerRadioButton
            // 
            this.fifthAnswerRadioButton.AutoSize = true;
            this.fifthAnswerRadioButton.CheckedColor = System.Drawing.Color.ForestGreen;
            this.fifthAnswerRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fifthAnswerRadioButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.fifthAnswerRadioButton.Location = new System.Drawing.Point(953, 267);
            this.fifthAnswerRadioButton.MinimumSize = new System.Drawing.Size(0, 21);
            this.fifthAnswerRadioButton.Name = "fifthAnswerRadioButton";
            this.fifthAnswerRadioButton.Size = new System.Drawing.Size(139, 33);
            this.fifthAnswerRadioButton.TabIndex = 57;
            this.fifthAnswerRadioButton.TabStop = true;
            this.fifthAnswerRadioButton.Text = "Ответ 5";
            this.fifthAnswerRadioButton.UnCheckedColor = System.Drawing.Color.Gray;
            this.fifthAnswerRadioButton.UseVisualStyleBackColor = true;
            // 
            // firstAnswerRadioButton
            // 
            this.firstAnswerRadioButton.AutoSize = true;
            this.firstAnswerRadioButton.CheckedColor = System.Drawing.Color.ForestGreen;
            this.firstAnswerRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstAnswerRadioButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.firstAnswerRadioButton.Location = new System.Drawing.Point(17, 267);
            this.firstAnswerRadioButton.MinimumSize = new System.Drawing.Size(0, 21);
            this.firstAnswerRadioButton.Name = "firstAnswerRadioButton";
            this.firstAnswerRadioButton.Size = new System.Drawing.Size(139, 33);
            this.firstAnswerRadioButton.TabIndex = 47;
            this.firstAnswerRadioButton.TabStop = true;
            this.firstAnswerRadioButton.Text = "Ответ 1";
            this.firstAnswerRadioButton.UnCheckedColor = System.Drawing.Color.Gray;
            this.firstAnswerRadioButton.UseVisualStyleBackColor = true;
            this.firstAnswerRadioButton.LocationChanged += new System.EventHandler(this.FirstAnswerRadioButton_LocationChanged);
            // 
            // thirdAnswerRadioButton
            // 
            this.thirdAnswerRadioButton.AutoSize = true;
            this.thirdAnswerRadioButton.CheckedColor = System.Drawing.Color.Teal;
            this.thirdAnswerRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdAnswerRadioButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.thirdAnswerRadioButton.Location = new System.Drawing.Point(17, 343);
            this.thirdAnswerRadioButton.MinimumSize = new System.Drawing.Size(0, 21);
            this.thirdAnswerRadioButton.Name = "thirdAnswerRadioButton";
            this.thirdAnswerRadioButton.Size = new System.Drawing.Size(139, 33);
            this.thirdAnswerRadioButton.TabIndex = 49;
            this.thirdAnswerRadioButton.TabStop = true;
            this.thirdAnswerRadioButton.Text = "Ответ 3";
            this.thirdAnswerRadioButton.UnCheckedColor = System.Drawing.Color.Gray;
            this.thirdAnswerRadioButton.UseVisualStyleBackColor = true;
            // 
            // fourthAnswerRadioButton
            // 
            this.fourthAnswerRadioButton.AutoSize = true;
            this.fourthAnswerRadioButton.CheckedColor = System.Drawing.Color.CadetBlue;
            this.fourthAnswerRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourthAnswerRadioButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.fourthAnswerRadioButton.Location = new System.Drawing.Point(17, 381);
            this.fourthAnswerRadioButton.MinimumSize = new System.Drawing.Size(0, 21);
            this.fourthAnswerRadioButton.Name = "fourthAnswerRadioButton";
            this.fourthAnswerRadioButton.Size = new System.Drawing.Size(139, 33);
            this.fourthAnswerRadioButton.TabIndex = 50;
            this.fourthAnswerRadioButton.TabStop = true;
            this.fourthAnswerRadioButton.Text = "Ответ 4";
            this.fourthAnswerRadioButton.UnCheckedColor = System.Drawing.Color.Gray;
            this.fourthAnswerRadioButton.UseVisualStyleBackColor = true;
            // 
            // secondAnswerRadioButton
            // 
            this.secondAnswerRadioButton.AutoSize = true;
            this.secondAnswerRadioButton.CheckedColor = System.Drawing.Color.ForestGreen;
            this.secondAnswerRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondAnswerRadioButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.secondAnswerRadioButton.Location = new System.Drawing.Point(17, 305);
            this.secondAnswerRadioButton.MinimumSize = new System.Drawing.Size(0, 21);
            this.secondAnswerRadioButton.Name = "secondAnswerRadioButton";
            this.secondAnswerRadioButton.Size = new System.Drawing.Size(139, 33);
            this.secondAnswerRadioButton.TabIndex = 52;
            this.secondAnswerRadioButton.TabStop = true;
            this.secondAnswerRadioButton.Text = "Ответ 2";
            this.secondAnswerRadioButton.UnCheckedColor = System.Drawing.Color.Gray;
            this.secondAnswerRadioButton.UseVisualStyleBackColor = true;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1286, 594);
            this.Controls.Add(this.secondAnswerCheckBox);
            this.Controls.Add(this.sixthAnswerRadioButton);
            this.Controls.Add(this.referenceButton);
            this.Controls.Add(this.firstAnswerCheckBox);
            this.Controls.Add(this.goNextQuestionButton);
            this.Controls.Add(this.eighthAnswerRadioButton);
            this.Controls.Add(this.startTestButton);
            this.Controls.Add(this.thirdAnswerCheckBox);
            this.Controls.Add(this.allNumQuestionLabel);
            this.Controls.Add(this.seventhAnswerRadioButton);
            this.Controls.Add(this.offLabel);
            this.Controls.Add(this.fourthAnswerCheckBox);
            this.Controls.Add(this.numOfQuestionLabel);
            this.Controls.Add(this.fifthAnswerRadioButton);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.firstAnswerRadioButton);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.eighthAnswerCheckBox);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.thirdAnswerRadioButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.seventhAnswerCheckBox);
            this.Controls.Add(this.fourthAnswerRadioButton);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.sixthAnswerCheckBox);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.fifthAnswerCheckBox);
            this.Controls.Add(this.secondAnswerRadioButton);
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
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button referenceButton;
        private System.Windows.Forms.CheckBox firstAnswerCheckBox;
        private System.Windows.Forms.CheckBox secondAnswerCheckBox;
        private System.Windows.Forms.CheckBox thirdAnswerCheckBox;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.CheckBox fourthAnswerCheckBox;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label numOfQuestionLabel;
        private System.Windows.Forms.Label offLabel;
        private System.Windows.Forms.Label allNumQuestionLabel;
        private WindowsFormsApp1.MyButton startTestButton;
        private WindowsFormsApp1.MyButton goNextQuestionButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private WindowsFormsApp1.MyRadioButton firstAnswerRadioButton;
        private WindowsFormsApp1.MyRadioButton thirdAnswerRadioButton;
        private WindowsFormsApp1.MyRadioButton fourthAnswerRadioButton;
        private WindowsFormsApp1.MyRadioButton secondAnswerRadioButton;
        private WindowsFormsApp1.MyRadioButton sixthAnswerRadioButton;
        private WindowsFormsApp1.MyRadioButton eighthAnswerRadioButton;
        private WindowsFormsApp1.MyRadioButton seventhAnswerRadioButton;
        private WindowsFormsApp1.MyRadioButton fifthAnswerRadioButton;
        private System.Windows.Forms.CheckBox eighthAnswerCheckBox;
        private System.Windows.Forms.CheckBox seventhAnswerCheckBox;
        private System.Windows.Forms.CheckBox sixthAnswerCheckBox;
        private System.Windows.Forms.CheckBox fifthAnswerCheckBox;
    }
}