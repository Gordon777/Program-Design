using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textbook_L7
{
    class Program
    {
        static void Main(string[] args)
        {
            string output = "";
            int[] x;
            x = new int[10];
            int[] y = { 32, 27, 64, 18, 95, 14, 90, 70, 60, 37 };
            const int ArraySize = 10;
            int[] z;
            z = new int[ArraySize];
            for (int i = 0; i < z.Length; i++)
                z[i] = 2 + 2 * i;
            Console.Write("Subscript\tArray x\tArray y\tArray z\n");
            for (int i = 0; i < ArraySize; i++)
                Console.Write(output += i + "\t" + x[i] + "\t" + y[i] + "\t" + z[i] + "\n");
            Console.Read();
        }
    }
}
