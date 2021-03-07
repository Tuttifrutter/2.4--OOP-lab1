using System;
using System.Drawing;

namespace Shapes
{
    class Circle : Point
    {
        public int R;
        public override void Draw() 
        {
            DrawCircle(x1, y1, R);
        }
        
        public void DrawCircle(int x1,int y1,int R)
        {
            Graphics graph = Graphics.FromImage(Bmp);
            graph.DrawEllipse(pen, Math.Abs(x1 - R), Math.Abs(y1 - R), R * 2, R * 2);
        }
    }
}

           
