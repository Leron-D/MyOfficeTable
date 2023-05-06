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
            this.takeTestAgainButton = new WindowsFormsApp1.MyButton();
            this.resultLabel3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.resultLabel2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.resultLabel1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.headerLabel = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // takeTestAgainButton
            // 
            this.takeTestAgainButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.takeTestAgainButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.takeTestAgainButton.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.takeTestAgainButton.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.takeTestAgainButton.BorderRadius = 20;
            this.takeTestAgainButton.BorderSize = 0;
            this.takeTestAgainButton.FlatAppearance.BorderSize = 0;
            this.takeTestAgainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.takeTestAgainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.takeTestAgainButton.ForeColor = System.Drawing.Color.White;
            this.takeTestAgainButton.Location = new System.Drawing.Point(241, 432);
            this.takeTestAgainButton.MinimumSize = new System.Drawing.Size(150, 40);
            this.takeTestAgainButton.Name = "takeTestAgainButton";
            this.takeTestAgainButton.Size = new System.Drawing.Size(239, 40);
            this.takeTestAgainButton.TabIndex = 64;
            this.takeTestAgainButton.Text = "Пройти тест заново";
            this.takeTestAgainButton.TextColor = System.Drawing.Color.White;
            this.takeTestAgainButton.UseVisualStyleBackColor = false;
            this.takeTestAgainButton.Click += new System.EventHandler(this.TakeTestAgainButton_Click);
            // 
            // resultLabel3
            // 
            this.resultLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resultLabel3.AutoSize = true;
            this.resultLabel3.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel3.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.resultLabel3.Location = new System.Drawing.Point(430, 358);
            this.resultLabel3.Name = "resultLabel3";
            this.resultLabel3.Size = new System.Drawing.Size(37, 37);
            this.resultLabel3.TabIndex = 63;
            this.resultLabel3.Text = "#";
            this.resultLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label5.Location = new System.Drawing.Point(142, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(265, 37);
            this.label5.TabIndex = 62;
            this.label5.Text = "Третье задание:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // resultLabel2
            // 
            this.resultLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resultLabel2.AutoSize = true;
            this.resultLabel2.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.resultLabel2.Location = new System.Drawing.Point(430, 290);
            this.resultLabel2.Name = "resultLabel2";
            this.resultLabel2.Size = new System.Drawing.Size(37, 37);
            this.resultLabel2.TabIndex = 61;
            this.resultLabel2.Text = "#";
            this.resultLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Location = new System.Drawing.Point(142, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 37);
            this.label3.TabIndex = 60;
            this.label3.Text = "Второе задание:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Image = global::MyOfficeTable.Properties.Resources.cancel;
            this.cancelButton.Location = new System.Drawing.Point(720, 7);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(31, 32);
            this.cancelButton.TabIndex = 59;
            this.cancelButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Image = global::MyOfficeTable.Properties.Resources.minimize;
            this.minimizeButton.Location = new System.Drawing.Point(679, 7);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(35, 32);
            this.minimizeButton.TabIndex = 58;
            this.minimizeButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // resultLabel1
            // 
            this.resultLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resultLabel1.AutoSize = true;
            this.resultLabel1.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.resultLabel1.Location = new System.Drawing.Point(430, 227);
            this.resultLabel1.Name = "resultLabel1";
            this.resultLabel1.Size = new System.Drawing.Size(37, 37);
            this.resultLabel1.TabIndex = 57;
            this.resultLabel1.Text = "#";
            this.resultLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(142, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 37);
            this.label1.TabIndex = 56;
            this.label1.Text = "Первое задание:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel.Controls.Add(this.pictureBox1);
            this.panel.Controls.Add(this.headerLabel);
            this.panel.Location = new System.Drawing.Point(-2, 45);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(762, 135);
            this.panel.TabIndex = 55;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyOfficeTable.Properties.Resources.MyOfficeTable;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // headerLabel
            // 
            this.headerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Lucida Sans", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.White;
            this.headerLabel.Location = new System.Drawing.Point(285, 45);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(263, 55);
            this.headerLabel.TabIndex = 18;
            this.headerLabel.Text = "Результат";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ResultInteractiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(758, 479);
            this.Controls.Add(this.takeTestAgainButton);
            this.Controls.Add(this.resultLabel3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.resultLabel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.resultLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResultInteractiveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResultInteractiveForm";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WindowsFormsApp1.MyButton takeTestAgainButton;
        private System.Windows.Forms.Label resultLabel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label resultLabel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Label resultLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label headerLabel;
    }
}