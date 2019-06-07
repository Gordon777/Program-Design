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
             int d=(a*b) ;
            int temp, temp1 ;
            int lcm, lcm1;
            MessageBox.Show(a + "與" + b + "與" + c + "的最小公倍數");
            
                while (b != 0) //b不等於O
                {
                    temp = a % b; //求a,b相除後的餘數
                    a = b; //將除數b換成除數a
                    b = temp; //將前面除得的餘數，設定除數(b)

                }
                lcm = (d / a);//a,b最小公倍數100
            int e = lcm * c;
            while (c != 0)
            {
                temp1 = (lcm % c);
                lcm = c;
                c = temp1;//lcm和c最大公因數

            }
            lcm1 = e / lcm;//lcm和c最小公倍數
    
                MessageBox.Show("最小公倍數為" + lcm1);

        }





    }
    }

