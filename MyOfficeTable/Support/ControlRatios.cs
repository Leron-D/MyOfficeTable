using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyOfficeTable.Support
{
    class ControlRatios
    {
        private double width;
        private double height;
        private double left;
        private double top;
        private Control control;

        public double Width { get => width; set => width = value; }

        public double Height { get => height; set => height = value; }

        public double Left { get => left; set => left = value; }

        public double Top { get => top; set => top = value; }

        public Control Control { get => control; set => control = value; }

        public ControlRatios(Control control, double width, double height, double left, double top)
        {
            Control = control;
            Width = width;
            Height = height;
            Left = left;
            Top = top;
        }
        public void Resize(Form form)
        {
            Control.Width = (int)(Width * form.Width);
            Control.Height = (int)(Height * form.Height);
            Control.Left = (int)(Left * form.Width);
            Control.Top = (int)(Top * form.Height);
        }

        public void Resize(Panel panel)
        {
            if (Control.Width == Control.Height)
            {
                Control.Height = (int)(Height * panel.Height);
                Control.Width = Control.Height;
            }
            else
            {
                Control.Width = (int)(Width * panel.Width);
                Control.Height = (int)(Height * panel.Height);
            }
            Control.Left = (int)(Left * panel.Width);
            Control.Top = (int)(Top * panel.Height);
        }
    }
}
