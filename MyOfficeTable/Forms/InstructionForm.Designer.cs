namespace MyOfficeTable.Forms
{
    partial class InstructionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructionForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.goNextButton = new MyOfficeTable.MyButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1137, 134);
            // 
            // headerLabel
            // 
            this.headerLabel.Size = new System.Drawing.Size(1001, 134);
            this.headerLabel.Text = "Инструкция для выполнения задания";
            // 
            // changeWindowBoxButton
            // 
            this.changeWindowBoxButton.Enabled = false;
            this.changeWindowBoxButton.FlatAppearance.BorderSize = 0;
            this.changeWindowBoxButton.Location = new System.Drawing.Point(1059, 2);
            // 
            // cancelButton
            // 
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.Location = new System.Drawing.Point(1100, 2);
            // 
            // minimizeButton
            // 
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.Location = new System.Drawing.Point(1018, 2);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(74, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(929, 186);
            this.label1.TabIndex = 66;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(74, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(929, 93);
            this.label2.TabIndex = 65;
            this.label2.Text = "Для выполнения задания требуется перетащить изображения, \r\nобозначающие элементы " +
    "панели инструментов в нужный  квадрат \r\nнапротив названия элемента.";
            // 
            // goNextButton
            // 
            this.goNextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.goNextButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.goNextButton.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.goNextButton.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.goNextButton.BorderRadius = 20;
            this.goNextButton.BorderSize = 0;
            this.goNextButton.FlatAppearance.BorderSize = 0;
            this.goNextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goNextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goNextButton.ForeColor = System.Drawing.Color.White;
            this.goNextButton.Location = new System.Drawing.Point(454, 683);
            this.goNextButton.MinimumSize = new System.Drawing.Size(150, 40);
            this.goNextButton.Name = "goNextButton";
            this.goNextButton.Size = new System.Drawing.Size(253, 40);
            this.goNextButton.TabIndex = 64;
            this.goNextButton.Text = "Продолжить";
            this.goNextButton.TextColor = System.Drawing.Color.White;
            this.goNextButton.UseVisualStyleBackColor = false;
            this.goNextButton.Click += new System.EventHandler(this.GoNextButton_Click);
            // 
            // InstructionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1136, 735);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.goNextButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InstructionForm";
            this.Text = "InstructionForm";
            this.Controls.SetChildIndex(this.goNextButton, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.minimizeButton, 0);
            this.Controls.SetChildIndex(this.cancelButton, 0);
            this.Controls.SetChildIndex(this.changeWindowBoxButton, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MyOfficeTable.MyButton goNextButton;
    }
}