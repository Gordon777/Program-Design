﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            int activity;
            int shopping;
            string yes,no;
            yes = "是";
            no = "不是";
            activity = 2000;
            shopping = 5000;
            if (shopping > activity)
                Console.WriteLine("是否享有優惠活動?" + yes);
            else
                Console.WriteLine("是否享有優惠活動?" + no);
            if (shopping > activity)
                Console.WriteLine("結帳金額:" + shopping*0.8);
            else
                Console.WriteLine("結帳金額:" + shopping);
            Console.Read();

        }
    }
}
