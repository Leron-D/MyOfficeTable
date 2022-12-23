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
            this.goToEvaulationCriterias = new System.Windows.Forms.Button();
            this.goBackButton = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.collapseButton = new System.Windows.Forms.Button();
            this.goToSelectTestButton = new System.Windows.Forms.Button();
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
            // goToEvaulationCriterias
            // 
            this.goToEvaulationCriterias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.goToEvaulationCriterias.BackColor = System.Drawing.Color.Turquoise;
            this.goToEvaulationCriterias.FlatAppearance.BorderSize = 0;
            this.goToEvaulationCriterias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToEvaulationCriterias.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToEvaulationCriterias.ForeColor = System.Drawing.Color.DarkCyan;
            this.goToEvaulationCriterias.Location = new System.Drawing.Point(132, 129);
            this.goToEvaulationCriterias.Name = "goToEvaulationCriterias";
            this.goToEvaulationCriterias.Size = new System.Drawing.Size(310, 48);
            this.goToEvaulationCriterias.TabIndex = 38;
            this.goToEvaulationCriterias.Text = "Критерии оценивания";
            this.goToEvaulationCriterias.UseVisualStyleBackColor = false;
            this.goToEvaulationCriterias.Click += new System.EventHandler(this.GoToEvaulationCriterias_Click);
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
            this.goBackButton.Location = new System.Drawing.Point(-3, 293);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(130, 36);
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
            // goToSelectTestButton
            // 
            this.goToSelectTestButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.goToSelectTestButton.BackColor = System.Drawing.Color.Turquoise;
            this.goToSelectTestButton.FlatAppearance.BorderSize = 0;
            this.goToSelectTestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToSelectTestButton.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToSelectTestButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.goToSelectTestButton.Location = new System.Drawing.Point(132, 196);
            this.goToSelectTestButton.Name = "goToSelectTestButton";
            this.goToSelectTestButton.Size = new System.Drawing.Size(310, 48);
            this.goToSelectTestButton.TabIndex = 41;
            this.goToSelectTestButton.Text = "Перейти к тестированию";
            this.goToSelectTestButton.UseVisualStyleBackColor = false;
            this.goToSelectTestButton.Click += new System.EventHandler(this.GoToSelectTestButton_Click);
            // 
            // SelectActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(580, 328);
            this.Controls.Add(this.goToSelectTestButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.goToEvaulationCriterias);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.collapseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectActionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор действия";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SelectActionForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SelectActionForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SelectActionForm_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button goToEvaulationCriterias;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button collapseButton;
        private System.Windows.Forms.Button goToSelectTestButton;
    }
}