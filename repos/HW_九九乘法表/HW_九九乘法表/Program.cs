﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_九九乘法表
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 2; j <= 5; j++)
                {
                    Console.Write("{0}*{1}={2,2}\t",j,i,j*i);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 6; j <= 9; j++)
                {
                    Console.Write("{0}*{1}={2,2}\t", j, i, j * i);
                }
                Console.WriteLine();
            }
            Console.Read();
        }

    }
}
