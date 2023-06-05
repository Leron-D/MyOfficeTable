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
            this.goBackButton = new MyOfficeTable.MyButton();
            this.goToEvaluationCriteriasButton = new MyOfficeTable.MyButton();
            this.transitionButton = new MyOfficeTable.MyButton();
            this.selectThemeComboBox = new MyOfficeTable.MyComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1057, 134);
            // 
            // changeWindowBoxButton
            // 
            this.changeWindowBoxButton.FlatAppearance.BorderSize = 0;
            this.changeWindowBoxButton.Location = new System.Drawing.Point(979, 1);
            this.changeWindowBoxButton.Click += new System.EventHandler(this.СhangeWindowBoxButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.Location = new System.Drawing.Point(938, 1);
            // 
            // cancelButton
            // 
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.Location = new System.Drawing.Point(1020, 1);
            // 
            // headerLabel
            // 
            this.headerLabel.Location = new System.Drawing.Point(0, 0);
            this.headerLabel.Size = new System.Drawing.Size(1057, 134);
            this.headerLabel.Text = "Выбор темы";
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
            this.goToEvaluationCriteriasButton.Location = new System.Drawing.Point(327, 345);
            this.goToEvaluationCriteriasButton.MinimumSize = new System.Drawing.Size(150, 40);
            this.goToEvaluationCriteriasButton.Name = "goToEvaluationCriteriasButton";
            this.goToEvaluationCriteriasButton.Size = new System.Drawing.Size(411, 44);
            this.goToEvaluationCriteriasButton.TabIndex = 42;
            this.goToEvaluationCriteriasButton.Text = "Посмотреть критерии оценивания";
            this.goToEvaluationCriteriasButton.TextColor = System.Drawing.Color.White;
            this.goToEvaluationCriteriasButton.UseVisualStyleBackColor = false;
            this.goToEvaluationCriteriasButton.Click += new System.EventHandler(this.GoToEvaulationCriterias_Click);
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
            // selectThemeComboBox
            // 
            this.selectThemeComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.selectThemeComboBox.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.selectThemeComboBox.BorderSize = 2;
            this.selectThemeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectThemeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectThemeComboBox.ForeColor = System.Drawing.Color.DimGray;
            this.selectThemeComboBox.IconColor = System.Drawing.Color.LightSeaGreen;
            this.selectThemeComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.selectThemeComboBox.ListTextColor = System.Drawing.Color.DimGray;
            this.selectThemeComboBox.Location = new System.Drawing.Point(97, 225);
            this.selectThemeComboBox.MinimumSize = new System.Drawing.Size(200, 2);
            this.selectThemeComboBox.Name = "selectThemeComboBox";
            this.selectThemeComboBox.Padding = new System.Windows.Forms.Padding(2);
            this.selectThemeComboBox.Size = new System.Drawing.Size(866, 36);
            this.selectThemeComboBox.TabIndex = 40;
            this.selectThemeComboBox.Texts = "";
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1054, 452);
            this.Name = "SelectThemeForm";
            this.Text = "Выбор темы";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SelectThemeForm_FormClosed);
            this.Resize += new System.EventHandler(this.SelectThemeForm_Resize);
            this.Controls.SetChildIndex(this.selectThemeComboBox, 0);
            this.Controls.SetChildIndex(this.transitionButton, 0);
            this.Controls.SetChildIndex(this.goToEvaluationCriteriasButton, 0);
            this.Controls.SetChildIndex(this.goBackButton, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.minimizeButton, 0);
            this.Controls.SetChildIndex(this.cancelButton, 0);
            this.Controls.SetChildIndex(this.changeWindowBoxButton, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MyComboBox selectThemeComboBox;
        private MyOfficeTable.MyButton transitionButton;
        private MyOfficeTable.MyButton goToEvaluationCriteriasButton;
        private MyOfficeTable.MyButton goBackButton;
    }
}