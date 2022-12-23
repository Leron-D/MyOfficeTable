namespace MyOfficeTable
{
    partial class ReferenceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReferenceForm));
            this.cancelButton = new System.Windows.Forms.Button();
            this.collapseButton = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.creatorLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.BackColor = System.Drawing.Color.Transparent;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Image = global::MyOfficeTable.Properties.Resources.cancel;
            this.cancelButton.Location = new System.Drawing.Point(592, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(31, 32);
            this.cancelButton.TabIndex = 15;
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
            this.collapseButton.Location = new System.Drawing.Point(551, 2);
            this.collapseButton.Name = "collapseButton";
            this.collapseButton.Size = new System.Drawing.Size(35, 32);
            this.collapseButton.TabIndex = 14;
            this.collapseButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.collapseButton.UseVisualStyleBackColor = false;
            this.collapseButton.Click += new System.EventHandler(this.CollapseButton_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Lucida Handwriting", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.headerLabel.Location = new System.Drawing.Point(185, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(244, 41);
            this.headerLabel.TabIndex = 16;
            this.headerLabel.Text = "О программе";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // creatorLabel
            // 
            this.creatorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.creatorLabel.AutoSize = true;
            this.creatorLabel.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creatorLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.creatorLabel.Location = new System.Drawing.Point(12, 352);
            this.creatorLabel.Name = "creatorLabel";
            this.creatorLabel.Size = new System.Drawing.Size(142, 27);
            this.creatorLabel.TabIndex = 17;
            this.creatorLabel.Text = "Создатель: ";
            this.creatorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.titleLabel.Location = new System.Drawing.Point(12, 92);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(131, 27);
            this.titleLabel.TabIndex = 18;
            this.titleLabel.Text = "Название: ";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // versionLabel
            // 
            this.versionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.versionLabel.AutoSize = true;
            this.versionLabel.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.versionLabel.Location = new System.Drawing.Point(12, 154);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(234, 27);
            this.versionLabel.TabIndex = 19;
            this.versionLabel.Text = "Версия программы: ";
            this.versionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionLabel.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.descriptionLabel.Location = new System.Drawing.Point(12, 221);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(574, 117);
            this.descriptionLabel.TabIndex = 20;
            this.descriptionLabel.Text = "Описание: ";
            // 
            // ReferenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(626, 401);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.creatorLabel);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.collapseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReferenceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReferenceForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ReferenceForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ReferenceForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ReferenceForm_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button collapseButton;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label creatorLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label descriptionLabel;
    }
}