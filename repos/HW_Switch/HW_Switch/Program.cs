using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("請輸入月份");
            num = Int32.Parse(Console.ReadLine());
            int i = num;
            switch (i)
            {
                case 3:
                    {
                       
                        Console.WriteLine("春");
                        break;
                    }
                case 4:
                    {

                        Console.WriteLine("春");
                        break;
                    }
                case 5:
                    {

                        Console.WriteLine("春");
                        break;
                    }

                case 6:
                    {
                        Console.WriteLine("夏");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("夏");
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine("夏");
                        break;
                    }
                case 9:
                    {
                        Console.WriteLine("秋");
                        break;
                    }
                case 10:
                    {
                        Console.WriteLine("秋");
                        break;
                    }
                case 11:
                    {
                        Console.WriteLine("秋");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("冬");
                        break;
                    }

                    
            }
            Console.Read();
        }

    }
}
