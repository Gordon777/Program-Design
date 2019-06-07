﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextbookL9_GCcollect
{
    class Program
    {
        public class Point4
        {
            private int x, y;
            public Point4()
            {
                Console.WriteLine("Point4 constructor:{0}", this);
            }
            public Point4(int xValue, int yValue)
            {
                X = xValue;
                Y = yValue;
                Console.WriteLine("Point4 constructor:{0}", this);
            }
            ~Point4()
            {
                Console.WriteLine("Point4 destructor:{0}", this);
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
                return "[" + x + "," + y + "]";
            }
            public class Circle5 : Point4
            {
                private double radius;
                public Circle5()
                {
                    Console.WriteLine("Circle5 constructor:{0}", this);
                }
                public Circle5(int xValue, int yValue, double radiusValue) : base(xValue, yValue)
                {
                    Radius = radiusValue;
                    Console.WriteLine("Circle5 constructor:{0}", this);
                }
                ~Circle5()
                {
                    Console.WriteLine("Circle5 destructor:{0}", this);
                }
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
                public virtual double Area()
                {
                    return Math.PI * Math.Pow(Radius, 2);
                }
                public override string ToString()
                {
                    return "Center = " + base.ToString() + "Radius = " + Radius;
                }
                class ConstructorAndFinalizer
                {
                    static void Main(string[] args)
                    {
                        Circle5 circle1, circle2;
                        circle1 = new Circle5(72, 29, 4.5);
                        circle2 = new Circle5(5, 5, 10);
                        Console.WriteLine();
                        circle1 = null;
                        circle2 = null;
                        System.GC.Collect();
                        Console.Read();
                    }
                }

            }
            
        }
        
    }

    
}



        
    
