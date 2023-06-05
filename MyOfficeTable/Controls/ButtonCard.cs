using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MyOfficeTable
{
    public class ButtonCard : Control
    {
        #region -- Переменные --

        Animation animCurtain;
        private float CurtainHeight;

        private bool MouseEntered = false;
        private bool MousePressed = false;

        #endregion

        #region -- Свойства --

        public string TextHeader { get; set; } = "Header";
        public Font FontHeader { get; set; } = new Font("Verdana", 12F, FontStyle.Bold);
        public Color ForeColorHeader { get; set; } = Color.White;

        public string TextDescrition { get; set; } = "Your description text for this control";
        public Font FontDescrition { get; set; } = new Font("Verdana", 12F, FontStyle.Regular);
        public Color ForeColorDescrition { get; set; } = Color.Black;

        public Color BackColorCurtain { get; set; } = Color.Red;

        #endregion

        public ButtonCard()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
            DoubleBuffered = true;

            Size = new Size(250, 200);
            CurtainHeight = Height - (48 + this.FontHeader.Size*2);

            Font = new Font("Verdana", 9F, FontStyle.Regular);
            BackColor = Color.White;

            animCurtain = new Animation();
            animCurtain.Value = CurtainHeight;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graph = e.Graphics;
            graph.SmoothingMode = SmoothingMode.HighQuality;

            graph.Clear(Parent.BackColor);

            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
            Rectangle rectCurtain = new Rectangle(0, 0, Width - 1, (int)animCurtain.Value);

            //Фон
            graph.FillRectangle(new SolidBrush(BackColor), rect);

            //Шторка
            graph.DrawRectangle(new Pen(BackColorCurtain), rectCurtain);
            graph.FillRectangle(new SolidBrush(BackColorCurtain), rectCurtain);

            //Обводка
            graph.DrawRectangle(new Pen(Color.Gray), rect);

            if (animCurtain.Value == 20 + this.FontHeader.Size * 2) // 50
            {
                graph.DrawString(TextDescrition, FontDescrition, new SolidBrush(ForeColorDescrition),
                new Rectangle(15, (int)(20 + this.FontHeader.Size * 2.6), Width - 15, Height - 70));
            }

            graph.DrawString(Text, Font, new SolidBrush(ForeColor), 15, Height - 37);
            graph.DrawString(TextHeader, FontHeader, new SolidBrush(ForeColorHeader),
                new Rectangle(15, 15, rectCurtain.Width, rectCurtain.Height));
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            if (Height <= 100)
                Height = 100;
            if (Width <= 100)
                Width = 100;


            this.FontHeader = new Font(this.Font.Name, Height / 23, FontStyle.Bold);
            this.FontDescrition = new Font(this.Font.Name, Height / 23);

            if (FontHeader.Size < 9)
                FontHeader = new Font(this.Font.Name, 9, FontStyle.Bold);
            if (FontDescrition.Size < 9)
                FontDescrition = new Font(this.Font.Name, 9);

            CurtainHeight = Height - (48 + this.FontHeader.Size);
            animCurtain = new Animation();
            animCurtain.Value = CurtainHeight;

            Invalidate();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);

            MouseEntered = true;

            DoCurtainAnimation();

            //Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            MouseEntered = false;

            DoCurtainAnimation();

            //Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            MousePressed = true;

            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            MousePressed = false;

            Invalidate();
        }

        private void DoCurtainAnimation()
        {
            if (MouseEntered == true)
            {
                animCurtain = new Animation("Curtain_" + Handle, Invalidate, animCurtain.Value, 20+this.FontHeader.Size*2); //50
            }
            else
            {
                animCurtain = new Animation("Curtain_" + Handle, Invalidate, animCurtain.Value, CurtainHeight);
            }

            Animator.Request(animCurtain, true);
        }
    }
}
