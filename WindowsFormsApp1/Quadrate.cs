using System;
using System.Drawing;

namespace Shapes
{
    class Quadrate : Line
    {
        public int a;
        public override void Draw() 
        {
            DrawQuadrate(x1, y1, a);
        }
        public void DrawQuadrate(int x1, int y1, int a)
        {
            base.DrawLine(x1, y1, x1 + a + Convert.ToInt32(pen.Width), y1);
            base.DrawLine(x1, y1, x1, y1 + a + Convert.ToInt32(pen.Width));
            base.DrawLine(x1 + a + Convert.ToInt32(pen.Width), y1 + a + Convert.ToInt32(pen.Width), x1 + a + Convert.ToInt32(pen.Width), y1);
            base.DrawLine(x1 + a + Convert.ToInt32(pen.Width), y1 + a + Convert.ToInt32(pen.Width), x1 , y1 + a + Convert.ToInt32(pen.Width));
        }
    }
}
//Graphics graph = Graphics.FromImage(Bmp);
//   graph.DrawRectangle(pen, x1, y1, x1 + a, y1 + a);
