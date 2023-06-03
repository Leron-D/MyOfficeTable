namespace MyOfficeTable.Forms
{
    partial class ResultInteractiveForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultInteractiveForm));
            this.goTestAgainButton = new MyOfficeTable.MyButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.Location = new System.Drawing.Point(128, 0);
            this.headerLabel.Size = new System.Drawing.Size(630, 134);
            this.headerLabel.Text = "Результаты задания";
            // 
            // changeWindowBoxButton
            // 
            this.changeWindowBoxButton.Enabled = false;
            this.changeWindowBoxButton.FlatAppearance.BorderSize = 0;
            this.changeWindowBoxButton.Location = new System.Drawing.Point(682, -1);
            // 
            // cancelButton
            // 
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.Location = new System.Drawing.Point(723, -1);
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.Location = new System.Drawing.Point(641, -1);
            // 
            // goTestAgainButton
            // 
            this.goTestAgainButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.goTestAgainButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.goTestAgainButton.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.goTestAgainButton.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.goTestAgainButton.BorderRadius = 20;
            this.goTestAgainButton.BorderSize = 0;
            this.goTestAgainButton.FlatAppearance.BorderSize = 0;
            this.goTestAgainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goTestAgainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goTestAgainButton.ForeColor = System.Drawing.Color.White;
            this.goTestAgainButton.Location = new System.Drawing.Point(252, 427);
            this.goTestAgainButton.MinimumSize = new System.Drawing.Size(150, 40);
            this.goTestAgainButton.Name = "goTestAgainButton";
            this.goTestAgainButton.Size = new System.Drawing.Size(239, 40);
            this.goTestAgainButton.TabIndex = 64;
            this.goTestAgainButton.Text = "Пройти тест заново";
            this.goTestAgainButton.TextColor = System.Drawing.Color.White;
            this.goTestAgainButton.UseVisualStyleBackColor = false;
            this.goTestAgainButton.Click += new System.EventHandler(this.TakeTestAgainButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(25, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(712, 111);
            this.label1.TabIndex = 56;
            this.label1.Text = "Все задания были решены верно.\r\nВы можете попробовать пройти другие тесты,\r\nлибо " +
    "пройти тест заново";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ResultInteractiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(758, 479);
            this.Controls.Add(this.goTestAgainButton);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResultInteractiveForm";
            this.Text = "ResultInteractiveForm";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.goTestAgainButton, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.minimizeButton, 0);
            this.Controls.SetChildIndex(this.cancelButton, 0);
            this.Controls.SetChildIndex(this.changeWindowBoxButton, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyOfficeTable.MyButton goTestAgainButton;
        private System.Windows.Forms.Label label1;
    }
}