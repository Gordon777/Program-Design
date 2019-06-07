using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_GCD
{

     class program
    {
        static void Main(string[] args)
        {

            int a = 100, b = 10, c = 20;//將a.b.c均設為大於0的數
            int temp = 0, temp1 = 0;
            MessageBox.Show(a + "與" + b+"與"+c+"的最大公因數");
            while (b != 0) //b不等於O
            {
                temp = a % b; //求a,b相除後的餘數
                a = b; //將除數b換成除數a
                b = temp; //將前面除得的餘數，設定除數(b)

            }
            temp1 = a % c;
            a = c;
            c = temp1;
            MessageBox.Show("最大公因數為"+c);
            
        }
    }
}
