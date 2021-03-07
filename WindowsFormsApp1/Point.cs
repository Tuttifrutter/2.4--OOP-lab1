using System.Drawing;

namespace Shapes
{
    public class Point : Shape
    {
        public int x1, y1;
        public override void Draw()
        {
            DrawDrop(x1, y1);
        }
        public void DrawDrop(int x1, int y1)
        {
            Graphics graph = Graphics.FromImage(Bmp);
            graph.DrawLine(pen, x1, y1, x1 + 1, y1);
        }
    }
}
