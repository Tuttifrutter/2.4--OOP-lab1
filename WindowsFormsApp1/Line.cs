using System.Drawing;

namespace Shapes
{
    public class Line : Point
    {
        public int x2, y2;
        public override void Draw()
        {
            DrawLine(x1, y1, x2, y2);
        }
        public void DrawLine(int x1, int y1, int x2, int y2) 
        {
            Graphics graph = Graphics.FromImage(Bmp);
            graph.DrawLine(pen, x1, y1, x2, y2);
        }
    }
}
