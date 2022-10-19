using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectASE___Tony_Dong
{
    class Canvass
    {
        Graphics g;
        Pen pen;
        Brush brush;
        int posX, posY;

        public Canvass(Graphics g)
        {
            this.g = g;
            posX = posY = 0;
            pen = new Pen(Color.Red, 1);
            brush = new SolidBrush(Color.Red);
        }

        public void drawLine(int toX, int toY)
        {
            g.DrawLine(pen, posX, posY, toX, toY);
            posX = toX;
            posY = toY;
            Console.WriteLine("drawn the line");
        }

        public void drawSquare(int width)
        {
            g.DrawRectangle(pen, posX, posY, posX + width, posY + width);
        }

        public void drawCircle(int radius)
        {
            g.DrawEllipse(pen, posX, posY, posX + (radius * 2), posY + (radius * 2));
        }
    }
}
