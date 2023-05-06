namespace MyOfficeTable
{
    partial class SelectThemeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectThemeForm));
            this.cancelButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.headerPictureBox = new System.Windows.Forms.PictureBox();
            this.selectThemeComboBox = new MyOfficeTable.MyComboBox();
            this.transitionButton = new WindowsFormsApp1.MyButton();
            this.goToEvaluationCriteriasButton = new WindowsFormsApp1.MyButton();
            this.goBackButton = new WindowsFormsApp1.MyButton();
            this.panel1.SuspendLayout();
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
            this.cancelButton.Location = new System.Drawing.Point(1022, 1);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(31, 32);
            this.cancelButton.TabIndex = 13;
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
            this.minimizeButton.Location = new System.Drawing.Point(981, 1);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(35, 32);
            this.minimizeButton.TabIndex = 12;
            this.minimizeButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Lucida Sans", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.White;
            this.headerLabel.Location = new System.Drawing.Point(416, 57);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(228, 39);
            this.headerLabel.TabIndex = 14;
            this.headerLabel.Text = "Выбор темы";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.headerPictureBox);
            this.panel1.Controls.Add(this.headerLabel);
            this.panel1.Location = new System.Drawing.Point(0, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 134);
            this.panel1.TabIndex = 32;
            // 
            // headerPictureBox
            // 
            this.headerPictureBox.Image = global::MyOfficeTable.Properties.Resources.MyOfficeTable;
            this.headerPictureBox.Location = new System.Drawing.Point(0, 0);
            this.headerPictureBox.Name = "headerPictureBox";
            this.headerPictureBox.Size = new System.Drawing.Size(132, 133);
            this.headerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.headerPictureBox.TabIndex = 43;
            this.headerPictureBox.TabStop = false;
            // 
            // selectThemeComboBox
            // 
            this.selectThemeComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.selectThemeComboBox.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.selectThemeComboBox.BorderSize = 1;
            this.selectThemeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.selectThemeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectThemeComboBox.ForeColor = System.Drawing.Color.DimGray;
            this.selectThemeComboBox.IconColor = System.Drawing.Color.LightSeaGreen;
            this.selectThemeComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.selectThemeComboBox.ListTextColor = System.Drawing.Color.DimGray;
            this.selectThemeComboBox.Location = new System.Drawing.Point(97, 225);
            this.selectThemeComboBox.MinimumSize = new System.Drawing.Size(200, 0);
            this.selectThemeComboBox.Name = "selectThemeComboBox";
            this.selectThemeComboBox.Padding = new System.Windows.Forms.Padding(1);
            this.selectThemeComboBox.Size = new System.Drawing.Size(866, 36);
            this.selectThemeComboBox.TabIndex = 40;
            this.selectThemeComboBox.Texts = "";
            // 
            // transitionButton
            // 
            this.transitionButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.transitionButton.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.transitionButton.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.transitionButton.BorderRadius = 20;
            this.transitionButton.BorderSize = 0;
            this.transitionButton.FlatAppearance.BorderSize = 0;
            this.transitionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transitionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transitionButton.ForeColor = System.Drawing.Color.White;
            this.transitionButton.Location = new System.Drawing.Point(327, 285);
            this.transitionButton.MinimumSize = new System.Drawing.Size(150, 40);
            this.transitionButton.Name = "transitionButton";
            this.transitionButton.Size = new System.Drawing.Size(411, 44);
            this.transitionButton.TabIndex = 41;
            this.transitionButton.Text = "Перейти к тесту";
            this.transitionButton.TextColor = System.Drawing.Color.White;
            this.transitionButton.UseVisualStyleBackColor = false;
            this.transitionButton.Click += new System.EventHandler(this.TransitionButton_Click);
            // 
            // goToEvaluationCriteriasButton
            // 
            this.goToEvaluationCriteriasButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.goToEvaluationCriteriasButton.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.goToEvaluationCriteriasButton.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.goToEvaluationCriteriasButton.BorderRadius = 20;
            this.goToEvaluationCriteriasButton.BorderSize = 0;
            this.goToEvaluationCriteriasButton.FlatAppearance.BorderSize = 0;
            this.goToEvaluationCriteriasButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToEvaluationCriteriasButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goToEvaluationCriteriasButton.ForeColor = System.Drawing.Color.White;
            this.goToEvaluationCriteriasButton.Location = new System.Drawing.Point(327, 351);
            this.goToEvaluationCriteriasButton.MinimumSize = new System.Drawing.Size(150, 40);
            this.goToEvaluationCriteriasButton.Name = "goToEvaluationCriteriasButton";
            this.goToEvaluationCriteriasButton.Size = new System.Drawing.Size(411, 44);
            this.goToEvaluationCriteriasButton.TabIndex = 42;
            this.goToEvaluationCriteriasButton.Text = "Посмотреть критерии оценивания";
            this.goToEvaluationCriteriasButton.TextColor = System.Drawing.Color.White;
            this.goToEvaluationCriteriasButton.UseVisualStyleBackColor = false;
            this.goToEvaluationCriteriasButton.Click += new System.EventHandler(this.GoToEvaulationCriterias_Click);
            // 
            // goBackButton
            // 
            this.goBackButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.goBackButton.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.goBackButton.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.goBackButton.BorderRadius = 20;
            this.goBackButton.BorderSize = 0;
            this.goBackButton.FlatAppearance.BorderSize = 0;
            this.goBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goBackButton.ForeColor = System.Drawing.Color.White;
            this.goBackButton.Location = new System.Drawing.Point(0, 411);
            this.goBackButton.MinimumSize = new System.Drawing.Size(150, 40);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(151, 40);
            this.goBackButton.TabIndex = 43;
            this.goBackButton.Text = "Назад";
            this.goBackButton.TextColor = System.Drawing.Color.White;
            this.goBackButton.UseVisualStyleBackColor = false;
            this.goBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // SelectThemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1054, 452);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.goToEvaluationCriteriasButton);
            this.Controls.Add(this.transitionButton);
            this.Controls.Add(this.selectThemeComboBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.minimizeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SelectThemeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор темы";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SelectTestForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SelectTestForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SelectTestForm_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Panel panel1;
        private MyComboBox selectThemeComboBox;
        private WindowsFormsApp1.MyButton transitionButton;
        private WindowsFormsApp1.MyButton goToEvaluationCriteriasButton;
        private System.Windows.Forms.PictureBox headerPictureBox;
        private WindowsFormsApp1.MyButton goBackButton;
    }
}