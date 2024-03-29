﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Textbook_L10_Part1_circle
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
        public class Point
        {
            private int x, y;
            public Point() { }

            public Point(int xValue, int yValue)

            {
                X = xValue;
                Y = yValue;
            }
            public int X
            {
                get { return x; }
                set { x = value; }
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
        }
        public class Circle : Point
        {
            private double radius;
            public Circle() { }
            public Circle(int xValue, int yValue, double radiusValue) : base(xValue, yValue)
            {
                Radius = radiusValue;
            }
            public double Radius
            {
                get { return radius; }
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
            public virtual double Area()
            {
                return Math.PI * Math.Pow(Radius, 2);
            }
            public override string ToString()
            {
                return "Center= " + base.ToString() + "Radius= " + Radius;
            }



        }
        class PointCircleTest
        {
            static void Main(string[] args)
            {

                Point point1 = new Point(30, 50);
                Circle circle1 = new Circle(120, 89, 2.7);
                string output = "Point point1: " + point1.ToString() + "\nCircle circle1: " + circle1.ToString();
                Point point2 = circle1;
                output += "\n\nCCircle circle1 (via point2): " + point2.ToString();
                Circle circle2 = (Circle)point2;
                output += "\n\nCircle circle1 (via circle2): " + circle2.ToString();
                output += "\n\nArea of circle1 (via circle2): " + circle2.Area().ToString("F");
                if (point1 is Circle)
                {
                    circle2 = (Circle)point1;
                    output += "\n\ncast successful";
                }
                else
                {
                    output += "\n\npoint1 does not refer to a Circle";
                }
                MessageBox.Show(output, "Demonstrating the is a relationship");
            }
        }


    }
}
