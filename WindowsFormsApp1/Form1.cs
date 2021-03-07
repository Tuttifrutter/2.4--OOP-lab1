using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    using Shapes;

    public partial class Form1 : Form
    {
        public Form1() 
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            List<Shape> shapes = new List<Shape>()
            {
            new Line()
            {
                x1 = 100,
                y1 = 30,
                x2 = 30,
                y2 = 30,
                Name = "Line",
                pen = new Pen(Brushes.DeepSkyBlue, 3)
             },
            new Rectangle()
            {
                x1 = 115,
                y1 = 75,
                x2 = 45,
                y2 = 45,
                Name = "Rectangle",
                pen = new Pen(Brushes.LightGray, 3)
            },
            new Ellipse()
            {
                x1 = 130,
                y1 = 60,
                R = 80,
                R2 = 35,
                Name = "Ellipse",
                pen = new Pen(Brushes.DarkOrange, 3)
            },
            new Triangle()
            {
                x1 = 70,
                y1 = 70,
                x2 = 120,
                y2 = 185,
                x3 = 145,
                y3 = 70,
                Name = "Triangle",
                pen = new Pen(Brushes.Coral, 3)
            },
            new Circle()
            {
                x1 = 110,
                y1 = 110,
                Name = "Circle",
                R = Convert.ToInt32(Math.Sqrt(Math.Pow(40, 2) + Math.Pow(25, 2))),
                pen = new Pen(Brushes.ForestGreen, 3)
            },
            new Quadrate()
            {
                x1 = 175,
                y1 = 75,
                a = 100,
                Name = "Quadrate",
                pen = new Pen(Brushes.MediumPurple, 3)
            },
            new Arc()
            {
                x1 = 90,
                y1 = 90,
                x2 = 115,
                y2 = 180,
                x3 = 200,
                y3 = 90,
                Name = "Arc",
                pen = new Pen(Brushes.LightSalmon, 3)
            }
            };

            Bitmap BMP = new Bitmap(pictureBox1.Width, pictureBox1.Height);
               foreach(Shape shape in shapes)
               {
                   shape.Bmp = BMP;
                   shape.Draw();
                   textBox1.Text = textBox1.Text + " " + shape.Name;
                   BMP = shape.Bmp;
               }
            pictureBox1.Image = BMP;
        }
    }
    
}
