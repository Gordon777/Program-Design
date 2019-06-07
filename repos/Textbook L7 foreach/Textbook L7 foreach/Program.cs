﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textbook_L7_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] gradeArray = { { 77, 68, 86, 73 }, { 98, 87, 89, 81 }, { 70, 90, 86, 81 } };
            int lowGrade = 100;
            foreach(int grade in gradeArray)
            {
                if (grade < lowGrade)
                    lowGrade = grade;
            }
            Console.WriteLine("The minmum grade is:" + lowGrade);
            Console.Read();
        }
    }
}