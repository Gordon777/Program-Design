﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textbook_L4_IF
{
    class Program
    {
        static void Main(string[] args)
        {
            string output="";
            int count;
            for (count = 1; count <= 10; count++)
            {
                if (count == 5)
                    break;
                output = output + count;
            }
            Console.Write(output = output + "\nBroke out of loop at count= " + count);
            Console.Read();
        }
    }
}