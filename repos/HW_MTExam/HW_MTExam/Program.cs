﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_MTExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int chinese, math, english ;
            int average,sum;
            int ok;
            string pass, unpass;
            chinese = 90;
            math = 30;
            english = 70;
            pass = "及格";
            unpass = "不及格";
            average = (chinese+math+english)/3;
            sum = (chinese + math + english);
            ok = 60;
            if (chinese > ok) 
            {
                Console.WriteLine("國文"+pass);
            }
            else
            {
                Console.WriteLine("國文"+unpass);
            }
            if (math > ok)
            {
                Console.WriteLine("數學" + pass);
            }
            else
            {
                Console.WriteLine("數學" + unpass);
            }
            if (english > ok)
            {
                Console.WriteLine("英文" + pass);
            }
            else
            {
                Console.WriteLine("英文" + unpass);
            }
            Console.WriteLine("國文=" + chinese);
            Console.WriteLine("數學=" + math);
            Console.WriteLine("英文=" + english);
            Console.WriteLine("平均="+average);
            Console.WriteLine("總分=" +sum);
            Console.Read();
            


        }
        
        }
            

        }
   

