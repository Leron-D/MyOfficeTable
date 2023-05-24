using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Net;

namespace MyOfficeTable
{
    class MyRadioButton : RadioButton
    {
        private Color checkedColor = Color.MediumSlateBlue;
        private Color unCheckedColor = Color.Gray;

        public Color CheckedColor
        {
            get => checkedColor;
            set
            {
                checkedColor = value;
                this.Invalidate();
            }
        }

        public Color UnCheckedColor
        {
            get => unCheckedColor;
            set
            {
                unCheckedColor = value;
                this.Invalidate();
            }
        }

        public MyRadioButton()
        {
            this.MinimumSize = new Size(0, 21);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            Graphics graphics = pevent.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            float rbBorderSize = 18F;
            float rbCheckSize = 12F;
            RectangleF rectRbBorder = new RectangleF()
            {
                X = 0.5F,
                Y = (this.Height - rbBorderSize) / 2, // Центрирование
                Width = rbBorderSize,
                Height = rbBorderSize
            };
            RectangleF rectRbCheck = new RectangleF()
            {
                X = rectRbBorder.X + ((rectRbBorder.Width - rbCheckSize) / 2),   // Центрирование
                Y = (this.Height - rbCheckSize) / 2,   // Центрирование
                Width = rbCheckSize,
                Height = rbCheckSize
            };

            using (Pen penBorder = new Pen(checkedColor, 1.6F))
            using (SolidBrush brushRbCheck = new SolidBrush(checkedColor))
            using (SolidBrush brushText = new SolidBrush(this.ForeColor))
            {
                // Основание
                graphics.Clear(this.BackColor);

                // Сам RadioButton
                if (this.Checked)
                {
                    graphics.DrawEllipse(penBorder, rectRbBorder); // Граница круга
                    graphics.FillEllipse(brushRbCheck, rectRbCheck); // Внутренний круг
                }
                else
                {
                    penBorder.Color = unCheckedColor;
                    graphics.DrawEllipse(penBorder, rectRbBorder);
                }

                // Текст

                graphics.DrawString(this.Text, this.Font, brushText, rbBorderSize + 8,
                    (this.Height - TextRenderer.MeasureText(this.Text, this.Font).Height) / 2); // центрирование Y
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Width = TextRenderer.MeasureText(this.Text, this.Font).Width + 30;
        }
    }
}
