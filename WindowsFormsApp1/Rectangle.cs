using System;
using System.Drawing;
namespace Shapes
{
    public class Rectangle : Line
    {
        public override void Draw() 
        {
            DrawRectangle(x1, y1, x2, y2);
        }
        public void DrawRectangle(int x1, int y1, int x2, int y2)
        {
            DrawLine(x1, y1, x1, y2);
            DrawLine(x1, y2, x2, y2);
            DrawLine(x2, y2, x2, y1);
            DrawLine(x2, y1, x1, y1);
        }
    }
    //Graphics graph = Graphics.FromImage(Bmp);
    // graph.DrawRectangle(pen, x1, y1, x2, y2);
}
