﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textbook_L4L5
{
    class Program
    {
        static void Main(string[] args)
        {
            int total, gradecounter, gradevalue, average;
            total = 0;
            gradecounter = 1;
            while (gradecounter <= 10) 
            {
                Console.Write("Enter integer grade:");
                gradevalue = Int32.Parse(Console.ReadLine());
                total = total + gradevalue;
                gradecounter = gradecounter + 1;
            }
            average = total / 10;
            Console.WriteLine("\nclass average is " + average);
            Console.Read();
        }
    }
}
