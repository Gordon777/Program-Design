﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textbook_L4_For
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int number = 2; number <= 100; number += 2)
                sum += number;
            
            Console.WriteLine("Sum Even Integers form 2 to 100 is " + sum);
            Console.Read();
        }
    }
}
