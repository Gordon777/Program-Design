﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_IF季節
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("請輸入月份");
            num = Int32.Parse(Console.ReadLine());
            int i = num;
            if (3<=i &i <= 5)
            {
                Console.WriteLine("春天");
            }
            else if (6<=i&i <= 8)
            {
                Console.WriteLine("夏天");
            }
            else if (9<=i&i <= 11)
            {
                Console.WriteLine("秋天");
            }
            else  
            {
                Console.WriteLine("冬天");
            }
            Console.Read();
        }
    }
}
