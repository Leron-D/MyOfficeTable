using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Drawing.Drawing2D;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.Globalization;
using System.Drawing.Design;
using System.Security.Permissions;
using System.Threading;

namespace MyOfficeTable
{
    [DefaultEvent("OnSelectedIndexChanged")]
    public partial class MyComboBox : UserControl
    {
        private Color backColor = Color.WhiteSmoke;
        private Color iconColor = Color.MediumSlateBlue;
        private Color listBackColor = Color.FromArgb(230, 228, 245);
        private Color listTextColor = Color.DimGray;
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 1;
        //Items
        private ComboBox comboBoxList;
        private Label labelText;
        private Button buttonIcon;
        //Events
        public event EventHandler OnSelectedIndexChanged;//Default event

        public MyComboBox()
        {
            comboBoxList = new ComboBox();
            labelText = new Label();
            buttonIcon = new Button();
            this.SuspendLayout();

            comboBoxList.BackColor = listBackColor;
            comboBoxList.Font = new Font(this.Font.Name, 10F);
            comboBoxList.ForeColor = listTextColor;
            comboBoxList.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);//Default event
            comboBoxList.TextChanged += new EventHandler(ComboBox_TextChanged);
            comboBoxList.Click += new EventHandler(ComboBoxList_Click);

            buttonIcon.Dock = DockStyle.Right;
            buttonIcon.FlatStyle = FlatStyle.Flat;
            buttonIcon.FlatAppearance.BorderSize = 0;
            buttonIcon.BackColor = backColor;
            buttonIcon.Size = new Size(30, 30);
            buttonIcon.Cursor = Cursors.Hand;
            buttonIcon.Click += new EventHandler(Icon_Click);
            buttonIcon.Paint += new PaintEventHandler(Icon_Paint);

            labelText.Dock = DockStyle.Fill;
            labelText.AutoSize = false;
            labelText.BackColor = backColor;
            labelText.TextAlign = ContentAlignment.MiddleLeft;
            labelText.Padding = new Padding(8, 0, 0, 0);
            labelText.Font = new Font(this.Font.Name, 10F);

            
            labelText.Click += new EventHandler(Surface_Click);
            labelText.MouseEnter += new EventHandler(Surface_MouseEnter);
            labelText.MouseLeave += new EventHandler(Surface_MouseLeave);
            
            this.Controls.Add(labelText);
            this.Controls.Add(buttonIcon);
            this.Controls.Add(comboBoxList);
            this.MinimumSize = new Size(200, 30);
            this.Size = new Size(200, 30);
            this.ForeColor = Color.DimGray;
            this.Padding = new Padding(borderSize);
            this.Font = new Font(this.Font.Name, 10F);
            base.BackColor = borderColor;
            this.ResumeLayout();
            AdjustComboBoxDimensions();
        }

        private void ComboBoxList_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
            comboBoxList.Select();
            if (comboBoxList.DropDownStyle == ComboBoxStyle.DropDownList)
                comboBoxList.DroppedDown = true;
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OnSelectedIndexChanged != null)
                OnSelectedIndexChanged.Invoke(sender, e);
            
            labelText.Text = comboBoxList.Text;
        }

        private void Icon_Click(object sender, EventArgs e)
        {
            comboBoxList.Select();
            comboBoxList.DroppedDown = true;
        }

        private void Surface_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
            comboBoxList.Select();
            if (comboBoxList.DropDownStyle == ComboBoxStyle.DropDownList)
                comboBoxList.DroppedDown = true;
        }
        private void ComboBox_TextChanged(object sender, EventArgs e)
        {
            labelText.Text = comboBoxList.Text;
        }

        private void Icon_Paint(object sender, PaintEventArgs e)
        {
            int iconWidht = 14;
            int iconHeight = 6;
            var rectIcon = new Rectangle((buttonIcon.Width - iconWidht) / 2, (buttonIcon.Height - iconHeight) / 2, iconWidht, iconHeight);
            Graphics graph = e.Graphics;

            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(iconColor, 2))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rectIcon.X, rectIcon.Y, rectIcon.X + (iconWidht / 2), rectIcon.Bottom);
                path.AddLine(rectIcon.X + (iconWidht / 2), rectIcon.Bottom, rectIcon.Right, rectIcon.Y);
                graph.DrawPath(pen, path);
            }
        }

        public new Color BackColor
        {
            get { return backColor; }
            set
            {
                backColor = value;
                labelText.BackColor = backColor;
                buttonIcon.BackColor = backColor;
            }
        }

        public Color IconColor
        {
            get { return iconColor; }
            set
            {
                iconColor = value;
                buttonIcon.Invalidate();
            }
        }

        public Color ListBackColor
        {
            get { return listBackColor; }
            set
            {
                listBackColor = value;
                comboBoxList.BackColor = listBackColor;
            }
        }

        public Color ListTextColor
        {
            get { return listTextColor; }
            set
            {
                listTextColor = value;
                comboBoxList.ForeColor = listTextColor;
            }
        }

        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                base.BackColor = borderColor;
            }
        }

        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Padding = new Padding(borderSize);
                AdjustComboBoxDimensions();
            }
        }

        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                labelText.ForeColor = value;
            }
        }

        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                labelText.Font = value;
                comboBoxList.Font = value;
            }
        }

        public string Texts
        {
            get { return labelText.Text; }
            set { labelText.Text = value; }
        }

        public ComboBoxStyle DropDownStyle
        {
            get { return comboBoxList.DropDownStyle; }
            set
            {
                if (comboBoxList.DropDownStyle != ComboBoxStyle.Simple)
                    comboBoxList.DropDownStyle = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [Localizable(true)]
        [MergableProperty(false)]
        public ComboBox.ObjectCollection Items
        {
            get { return comboBoxList.Items; }
        }

        [AttributeProvider(typeof(IListSource))]
        [DefaultValue(null)]
        public object DataSource
        {
            get { return comboBoxList.DataSource; }
            set { comboBoxList.DataSource = value; }
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Localizable(true)]
        public AutoCompleteStringCollection AutoCompleteCustomSource
        {
            get { return comboBoxList.AutoCompleteCustomSource; }
            set { comboBoxList.AutoCompleteCustomSource = value; }
        }

        [Browsable(true)]
        [DefaultValue(AutoCompleteSource.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteSource AutoCompleteSource
        {
            get { return comboBoxList.AutoCompleteSource; }
            set { comboBoxList.AutoCompleteSource = value; }
        }

        [Browsable(true)]
        [DefaultValue(AutoCompleteMode.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteMode AutoCompleteMode
        {
            get { return comboBoxList.AutoCompleteMode; }
            set { comboBoxList.AutoCompleteMode = value; }
        }

        [Bindable(true)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public object SelectedItem
        {
            get { return comboBoxList.SelectedItem; }
            set { comboBoxList.SelectedItem = value; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedIndex
        {
            get { return comboBoxList.SelectedIndex; }
            set { comboBoxList.SelectedIndex = value; }
        }

        [DefaultValue("")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [TypeConverter("System.Windows.Forms.Design.DataMemberFieldConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        public string DisplayMember
        {
            get { return comboBoxList.DisplayMember; }
            set { comboBoxList.DisplayMember = value; }
        }

        [DefaultValue("")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public string ValueMember
        {
            get { return comboBoxList.ValueMember; }
            set { comboBoxList.ValueMember = value; }
        }

        //->Attach label events to user control event
        private void Surface_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }
        private void Surface_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }
        //::::+

        //Overridden methods
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            AdjustComboBoxDimensions();
        }

        private void AdjustComboBoxDimensions()
        {
            comboBoxList.Width = labelText.Width;
            comboBoxList.Location = new Point()
            {
                X = this.Width - comboBoxList.Width,
                Y = labelText.Bottom - comboBoxList.Height
            };
        }
    }
}

