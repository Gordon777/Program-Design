using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Textbook_L10_Part1_shape
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public abstract class Shape
        {
            public virtual double Area()
            {
                return 0;
            }
            public virtual double Volume()
            {
                return 0;
            }
            public abstract string Name
            {
                get;
            }
        }

        public class Point2 : Shape
        {
            private int x, y;
            public Point2() { }
            public Point2(int xValue, int yValue)
            {
                x = xValue;
                y = yValue;
            }
            public int X
            {
                get
                {
                    return x;
                }
                set
                {
                    x = value;
                }


            }
            public int Y
            {
                get { return y; }
                set { y = value; }
            }

            public override string ToString()
            {
                return "[" + X + "," + Y + "]";
            }
            public override string Name
            {
                get { return "Point2"; }
            }
        }
        public class Circle2 : Point2
        {
            private double radius;
            public Circle2() { }
            public Circle2(int xValue,int yValue,double radiusValue) : base(xValue, yValue) { radius = radiusValue; }
            public double Radius
            {
                get
                {
                    return radius;
                }
                set
                {
                    if (value >= 0)
                        radius = value;
                }
            }
            public double Diameter()
            {
                return Radius * 2;
            }
            public double Circumference()
            {
                return Math.PI * Diameter();
            }
            public override double Area()
            {
               
                   
                return Math.PI * Math.Pow(Radius, 2);
                    
            }
            public override string ToString()
            {
                return "Center= " + base.ToString() + "; Radius= " + Radius;
            }
            public override string Name
            {
                get { return "Circle2"; }
            }
        }
        
        public class Cylinder2 : Circle2
        {
            private double height;
            public Cylinder2() { }
            public Cylinder2(int xValue, int yValue, double radiusValue, double heighValue) : base(xValue, yValue, radiusValue) { Height = heighValue; }
            public double Height
            {
                get
                {
                    return Height;
                }
                set
                {
                    if (value >= 0)
                        Height = value;
                }
            }
            public override double Area()
            {
                return 2 * base.Area() + base.Circumference()* Height;
            }
        }
        public class AbstractShapesTest
        {
            public static void Main(string[] args)
            {
                Point2 point = new Point2(7, 11);
                Circle2 circle = new Circle2(22, 8, 3.5);
                Cylinder2 cylinder = new Cylinder2(10, 10, 3.3, 10);
                Shape[] arrayshapeOfShape = new Shape[3];
                arrayshapeOfShape[0] = point;
                arrayshapeOfShape[1] = circle;
                arrayshapeOfShape[2] = cylinder;
                string output = point.Name + ": " + point + "\n" + circle.Name + ": " + circle + "\n" + circle.Name + ": " + cylinder;
                foreach(Shape shape in arrayshapeOfShape)
                {
                    output += "\n\n" + shape.Name + ":" + shape + "\nArea= " + shape.Area().ToString("F") + "\nVolume= " + shape.Volume().ToString("F");
                }
                MessageBox.Show(output, "Demonstrating Polymorphism");

                
            }
        }
    }

}
