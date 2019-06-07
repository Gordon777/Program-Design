using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Textbook_L8_Employ
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
    }
    public class Date
    {
        private int month;
        private int day;
        private int year;
        public Date(int theMonth, int theDay, int theYear)
        {
            if (theMonth > 0 && theMonth <= 12)
                month = theMonth;
            else
            {
                month = 1;
                Console.WriteLine("Month {0} invalid. Set to month1.", theMonth);
            }
            year = theYear;
            day = CheckDay(theDay);

        }
        private int CheckDay(int testDay)
        {
            int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (testDay > 0 && testDay <= daysPerMonth[month])
                return testDay;
            if (month == 2 && testDay == 29 && (year % 400 == 0 || year % 4 == 0 && year % 100 != 0))
                return testDay;
            Console.WriteLine("Day {0} invalid. Set to day 1.", testDay);
            return 1;
        }
        public string ToDateString()
        {
            return month + "/" + day + "/" + year;
        }
        public class Employee
        {
            private string firstName;
            private string lastName;
            private Date birthDate;
            private Date hireDate;
            public Employee(string first, string last, int birthMonth, int birthDay, int birthYear, int hireMonth, int hireDay, int hireYear)
            {
                firstName = first;
                lastName = last;
                birthDate = new Date(birthMonth, birthDay, birthYear);
                hireDate = new Date(hireMonth, hireMonth, hireYear);

            }
            public string ToEmployeeString()
            {
                return lastName + ", " + firstName + " Hired: " + hireDate.ToDateString() + "Birthday: " + birthDate.ToDateString();
            }
        }
        class CompositionTest
        {
            static void Main(string[] args)
            {
                Employee e = new Employee("Bob", "Jones", 7, 24, 1949, 3, 12, 1988);
                MessageBox.Show(e.ToEmployeeString(), "Testing Class Employee");
            }
        }

    }
}
