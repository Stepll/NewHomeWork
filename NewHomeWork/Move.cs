using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace NewHomeWork
{
    static class MoveClass
    {
        static public void MoveCommand(MouseEventArgs e, ref Point lastPoint, Form form)
        {
            if (e.Button == MouseButtons.Left)
            {
                form.Left += e.X - lastPoint.X;
                form.Top += e.Y - lastPoint.Y;
            }
        }

        static public void DownCommand(MouseEventArgs e, ref Point lastPoint)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
