namespace MyOfficeTable
{
    partial class TestResultForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestResultForm));
            this.rightNumberLabel = new System.Windows.Forms.Label();
            this.markLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // changeWindowBoxButton
            // 
            this.changeWindowBoxButton.Enabled = false;
            this.changeWindowBoxButton.FlatAppearance.BorderSize = 0;
            this.changeWindowBoxButton.Location = new System.Drawing.Point(558, 2);
            // 
            // minimizeButton
            // 
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.Location = new System.Drawing.Point(517, 2);
            // 
            // cancelButton
            // 
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.Location = new System.Drawing.Point(599, 2);
            this.cancelButton.Visible = false;
            this.cancelButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.Size = new System.Drawing.Size(502, 134);
            this.headerLabel.Text = "Результат тестирования";
            // 
            // guideButton
            // 
            this.guideButton.FlatAppearance.BorderSize = 0;
            this.guideButton.Location = new System.Drawing.Point(474, 2);
            // 
            // rightNumberLabel
            // 
            this.rightNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rightNumberLabel.AutoSize = true;
            this.rightNumberLabel.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightNumberLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.rightNumberLabel.Location = new System.Drawing.Point(13, 215);
            this.rightNumberLabel.Name = "rightNumberLabel";
            this.rightNumberLabel.Size = new System.Drawing.Size(495, 27);
            this.rightNumberLabel.TabIndex = 33;
            this.rightNumberLabel.Text = "Вы ответили правильно на # из # вопросов";
            this.rightNumberLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // markLabel
            // 
            this.markLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.markLabel.AutoSize = true;
            this.markLabel.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.markLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.markLabel.Location = new System.Drawing.Point(13, 264);
            this.markLabel.Name = "markLabel";
            this.markLabel.Size = new System.Drawing.Size(162, 27);
            this.markLabel.TabIndex = 37;
            this.markLabel.Text = "Ваша оценка:";
            this.markLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Image = global::MyOfficeTable.Properties.Resources.cancel;
            this.closeButton.Location = new System.Drawing.Point(599, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(31, 32);
            this.closeButton.TabIndex = 77;
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // TestResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(635, 316);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.markLabel);
            this.Controls.Add(this.rightNumberLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TestResultForm";
            this.Text = "Результаты тестирования";
            this.Controls.SetChildIndex(this.guideButton, 0);
            this.Controls.SetChildIndex(this.cancelButton, 0);
            this.Controls.SetChildIndex(this.rightNumberLabel, 0);
            this.Controls.SetChildIndex(this.markLabel, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.minimizeButton, 0);
            this.Controls.SetChildIndex(this.changeWindowBoxButton, 0);
            this.Controls.SetChildIndex(this.closeButton, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label rightNumberLabel;
        private System.Windows.Forms.Label markLabel;
        public System.Windows.Forms.Button closeButton;
    }
}