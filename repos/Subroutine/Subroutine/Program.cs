using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subroutine
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Please enter one interger");
            n1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the other interger");
            n2 = Int32.Parse(Console.ReadLine());
            add(n1, n2);
            subtract(n1, n2);
            multiply(n1, n2);
            dividend(n1, n2);
            Console.Read();
        }
        static void add(int n1,int n2)
        {
            int add;
            add = n1 + n2;
            Console.WriteLine("add = " + add);
        }
        static void subtract(int n1, int n2)
        {
            int subtract;
            subtract = n1 - n2;
            Console.WriteLine("subtract = " + subtract);
        }
        static void multiply(int n1, int n2)
        {
            int multiply;
            multiply = n1 * n2;
            Console.WriteLine("multiply = " + multiply);
        }
        static void dividend(int n1, int n2)
        {
            int dividend,remainder;
            dividend = n1 / n2;
            remainder = n1 % n2;
            Console.WriteLine("dividend = " + dividend+"...."+remainder);
        }
    }
}
