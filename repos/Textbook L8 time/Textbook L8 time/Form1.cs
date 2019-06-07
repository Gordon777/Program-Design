using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Textbook_L8_time
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public class Time1 : Object
        {
            private int hour;
            private int minute;
            private int second;
            public Time1()
            {
                SetTime(0, 0, 0);
            }
            public void SetTime(int hourValue,int minuteValue,int secondValue)
            {
                hour = (hourValue >= 0 && hourValue < 24) ? hourValue : 0;
                minute = (minuteValue >= 0 && minuteValue < 60) ? minuteValue : 0;
                second = (secondValue >= 0 && secondValue < 60) ? secondValue : 0;
            }
            public string ToUniversalString()
            {
                return String.Format("{0:D2}:{1:D2}:{2:D2}", hour, minute, second);
            }
            public string ToStandardString()
            {
                return String.Format("{0}:{1:D2}:{2:D2}{3}", ((hour == 12 || hour == 0) ? 12 : hour % 12), minute, second, (hour < 12 ? "AM" : "PM"));
            }
        }
        class TimeTest1
        {
            static void Main(string[] args)
            {
                Time1 time = new Time1();
                string output;
                output = "Initial universal time is: " + time.ToStandardString() + "\nInitial standard time is:" + time.ToStandardString();
                time.SetTime(13, 27, 6);
                output += "\n\nUniversal time after SetTime is: " + time.ToUniversalString() + "\nStandard time after SetTime is: " + time.ToStandardString();
                time.SetTime(99, 99, 99);
                output += "\n\nAfter attempting invalid settings: " + "\nUniversal time" + time.ToUniversalString();
                MessageBox.Show(output, "Testing Class Time1");

            }
        }
    }
}
