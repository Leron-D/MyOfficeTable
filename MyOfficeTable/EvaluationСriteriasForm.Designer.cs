namespace MyOfficeTable
{
    partial class EvaluationСriteriasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvaluationСriteriasForm));
            this.cancelButton = new System.Windows.Forms.Button();
            this.collapseButton = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.goBackButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Image = global::MyOfficeTable.Properties.Resources.cancel;
            this.cancelButton.Location = new System.Drawing.Point(876, 1);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(31, 32);
            this.cancelButton.TabIndex = 50;
            this.cancelButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // collapseButton
            // 
            this.collapseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.collapseButton.FlatAppearance.BorderSize = 0;
            this.collapseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.collapseButton.Image = global::MyOfficeTable.Properties.Resources.collapse;
            this.collapseButton.Location = new System.Drawing.Point(835, 1);
            this.collapseButton.Name = "collapseButton";
            this.collapseButton.Size = new System.Drawing.Size(35, 32);
            this.collapseButton.TabIndex = 49;
            this.collapseButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.collapseButton.UseVisualStyleBackColor = true;
            this.collapseButton.Click += new System.EventHandler(this.CollapseButton_Click);
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BackColor = System.Drawing.Color.Teal;
            this.panel.Location = new System.Drawing.Point(-1, 64);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(921, 19);
            this.panel.TabIndex = 42;
            // 
            // headerLabel
            // 
            this.headerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Lucida Handwriting", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.headerLabel.Location = new System.Drawing.Point(2, 20);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(397, 41);
            this.headerLabel.TabIndex = 41;
            this.headerLabel.Text = "Критерии оценивания";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(889, 245);
            this.webBrowser.TabIndex = 51;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.webBrowser);
            this.panel1.Location = new System.Drawing.Point(9, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 245);
            this.panel1.TabIndex = 52;
            // 
            // goBackButton
            // 
            this.goBackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.goBackButton.BackColor = System.Drawing.Color.Turquoise;
            this.goBackButton.FlatAppearance.BorderSize = 0;
            this.goBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goBackButton.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.goBackButton.Location = new System.Drawing.Point(9, 340);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(166, 36);
            this.goBackButton.TabIndex = 53;
            this.goBackButton.Text = "Назад";
            this.goBackButton.UseVisualStyleBackColor = false;
            this.goBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // EvaluationСriteriasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(910, 382);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.collapseButton);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.headerLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EvaluationСriteriasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Критерии оценивания";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EvaluationCriteriasForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EvaluationCriteriasForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EvaluationCriteriasForm_MouseUp);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button collapseButton;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button goBackButton;
    }
}