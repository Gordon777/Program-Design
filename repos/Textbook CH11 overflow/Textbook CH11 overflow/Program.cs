using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textbook_L11_overflow
{
   
        
    }
    class Overflow
    {
        static void Main(string[] args)
        {
            int number1 = Int32.MaxValue;
            int number2 = Int32.MaxValue;
            int sum = 0;
            Console.WriteLine("number: {0}\nnumber2: {1}", number1, number2);
            sum = checked(number1 + number2);

            try
            {
                Console.WriteLine("\nSum integers in checked context:");
                sum = checked(number1 + number2);
            }
            catch (OverflowException overflowException)
            {
                Console.WriteLine(overflowException.ToString());
            }
            Console.WriteLine("\nsum after checked operation: {0}", sum);
            Console.WriteLine("\nSum integers in unchecked context:");
            sum = unchecked(number1 + number2);
            Console.WriteLine("sum after unchecked operation: {0}", sum);


        }
    }



