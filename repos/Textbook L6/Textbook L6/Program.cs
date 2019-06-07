using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textbook_L6
{
    class Program
    {
        static void Main(string[] args)
        {
            double result;
            string outString = " ";
            for (int counter = 1; counter <= 10; counter++) 
            {
                result = mysquare(counter);
               Console.WriteLine( outString += "The square of" + counter + "is" + result + "\n");
            }
            Console.Read();
        }
     static int mysquare(int i)
        {
        return(i*i);

        }
    }
}

        
    


