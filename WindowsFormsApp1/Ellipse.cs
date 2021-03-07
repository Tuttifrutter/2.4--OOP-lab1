using System.Drawing;

namespace Shapes
{
    class Ellipse :Circle
    {
        public int R2;
        public override void Draw() 
        {
            DrawEllipse(x1, y1, R, R2);
        }
        public void DrawEllipse(int x1, int y1, int R, int R2)
        {
            Graphics graph = Graphics.FromImage(Bmp);
            graph.DrawEllipse(pen, x1, y1, R, R2);
        }
    }
}
