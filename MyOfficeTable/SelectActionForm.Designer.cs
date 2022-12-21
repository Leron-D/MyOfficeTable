namespace MyOfficeTable
{
    partial class SelectActionForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.referenceButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.goBackButton = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.collapseButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Location = new System.Drawing.Point(-3, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 19);
            this.panel1.TabIndex = 40;
            // 
            // referenceButton
            // 
            this.referenceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.referenceButton.BackColor = System.Drawing.Color.Transparent;
            this.referenceButton.FlatAppearance.BorderSize = 0;
            this.referenceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.referenceButton.ForeColor = System.Drawing.Color.Transparent;
            this.referenceButton.Image = global::MyOfficeTable.Properties.Resources.question;
            this.referenceButton.Location = new System.Drawing.Point(555, 296);
            this.referenceButton.Name = "referenceButton";
            this.referenceButton.Size = new System.Drawing.Size(22, 29);
            this.referenceButton.TabIndex = 39;
            this.referenceButton.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.referenceButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Turquoise;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkCyan;
            this.button1.Location = new System.Drawing.Point(128, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(323, 48);
            this.button1.TabIndex = 38;
            this.button1.Text = "Критерии оценивания";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // goBackButton
            // 
            this.goBackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.goBackButton.BackColor = System.Drawing.Color.Turquoise;
            this.goBackButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.goBackButton.FlatAppearance.BorderSize = 0;
            this.goBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goBackButton.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.goBackButton.Location = new System.Drawing.Point(2, 289);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(121, 36);
            this.goBackButton.TabIndex = 37;
            this.goBackButton.Text = "Назад";
            this.goBackButton.UseVisualStyleBackColor = false;
            this.goBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Lucida Handwriting", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.headerLabel.Location = new System.Drawing.Point(142, 31);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(300, 41);
            this.headerLabel.TabIndex = 35;
            this.headerLabel.Text = "Выбор действия";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.BackColor = System.Drawing.Color.Transparent;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Image = global::MyOfficeTable.Properties.Resources.cancel;
            this.cancelButton.Location = new System.Drawing.Point(546, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(31, 32);
            this.cancelButton.TabIndex = 34;
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
            this.collapseButton.Location = new System.Drawing.Point(505, 2);
            this.collapseButton.Name = "collapseButton";
            this.collapseButton.Size = new System.Drawing.Size(35, 32);
            this.collapseButton.TabIndex = 33;
            this.collapseButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.collapseButton.UseVisualStyleBackColor = false;
            this.collapseButton.Click += new System.EventHandler(this.CollapseButton_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Turquoise;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkCyan;
            this.button2.Location = new System.Drawing.Point(128, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(323, 48);
            this.button2.TabIndex = 41;
            this.button2.Text = "Выбор темы";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SelectActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(580, 328);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.referenceButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.collapseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectActionForm";
            this.Text = "SelectActionForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SelectActionForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SelectActionForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SelectActionForm_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button referenceButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button collapseButton;
        private System.Windows.Forms.Button button2;
    }
}