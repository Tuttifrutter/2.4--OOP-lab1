using System.Drawing;
using System.Windows.Forms;

namespace Shapes
{
    public abstract class Shape
    {
        public string Name { get; set; }
        public Bitmap Bmp { get; set;} 

        public Pen pen = new Pen(Color.Green);
        public abstract void Draw();
    }
}
