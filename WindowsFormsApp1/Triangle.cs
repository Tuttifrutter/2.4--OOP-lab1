using System.Drawing;

namespace Shapes
{
    public class Triangle : Line
    {
        public int x3, y3;
        public override void Draw() 
        {
            DrawTriangle(x1, y1, x2, y2, x3, y3);
        }
        public void DrawTriangle(int x1,int y1, int x2, int y2, int x3, int y3)
        {
            DrawLine(x1, y1, x2, y2);
            DrawLine(x1, y1, x3, y3);
            DrawLine(x2, y2, x3, y3);
        }
    }
}

/*Graphics graph = Graphics.FromImage(Bmp);
  Point[] PointARR = { new Point(x1, y1), new Point(x2, y2), new Point(x3, y3) };
  graph.DrawPolygon(pen, PointARR);*/
