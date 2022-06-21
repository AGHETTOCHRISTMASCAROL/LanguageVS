using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageVS
{
    public class BorderForm
    {
        public void FormPaint(Form form)
        {
            Graphics g = form.CreateGraphics();
            Pen p1 = new Pen(Color.DarkGray);
            g.DrawLine(p1, 0, 0, form.Width - 1, 0);
            g.DrawLine(p1, 0, 0, 0, form.Height - 1);
            g.DrawLine(p1, form.Width - 1, 0, form.Width - 1, form.Height - 1);
            g.DrawLine(p1, 0, form.Height - 1, form.Width - 1, form.Height - 1);
        }
    }

    internal class Transfer
    {
        public static string quary;
    }
}