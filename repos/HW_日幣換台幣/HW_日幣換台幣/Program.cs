﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_日幣換台幣
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("日幣轉台幣請輸入1，台幣轉日幣請輸入2");
            int a;
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("請輸入台幣金額:");
            int num;
            num = Int32.Parse(Console.ReadLine());
            if (a <= 1)
            {
                Console.WriteLine("輸入台幣金額為:" + num);
                Console.WriteLine(num + "台幣轉日幣為:" + exchangeNT(num));
            }
            else
            {
                Console.WriteLine("輸入日幣金額為:" + num);
                Console.WriteLine(num + "日幣轉台幣為:" + exchangeJP(num));
            }
            Console.Read();
        }
        static int exchangeNT(int num)
        {
            return num * 3;

        }
        static int exchangeJP(int num)
        {
            return num / 3;
        }
    }
}
