using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace MyOfficeTable
{
    public class MyTextBox : TextBox
    {
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            Font = new Font(Font.Name, Height/2, Font.Style);
        }
    }
}
