using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Textbook_L10_Employee
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
        public abstract class Employee
        {
            private string firstName;
            private string lastName;
            public Employee(string firstNameValue,string lastNameValue) { FirstName = firstNameValue;LastName = lastNameValue; }
            public string FirstName
            {
                get
                {
                    return firstName;
                }
                set
                {
                    firstName = value;
                }
            }
            public string LastName
            {
                get { return lastName; }
                set { lastName = value; }
            }
            public override string ToString()
            {
                return FirstName + " " + LastName;
            }
            public abstract decimal Earnings();
        }
        public class Boss : Employee
        {
            private decimal salary;
            public Boss(string firstNameValue, string lastNameValue,decimal salaryValue) : base(firstNameValue, lastNameValue) { WeeklySalary = salaryValue; }
            public decimal WeeklySalary
            {
                get
                {
                    return salary;
                }
                set
                {
                    if (value > 0)
                        salary = value;
                }
                
            }
            public override decimal Earnings()
            {
                return WeeklySalary;
            }
            public override string ToString()
            {
                return "Boss: " + base.ToString();
            }


        }
        public class CommissionWorker : Employee
        {
            private decimal salary;
            private decimal commission;
            private int quanity;
            public CommissionWorker(string firstNameValue,string lastNameValue,decimal salaryValue,decimal commissionValue, int quanriryValue) : base(firstNameValue, lastNameValue)
            {
                WeeklySalary = salaryValue;
                commission = commissionValue;
                Quanity = quanriryValue;
            }
            public decimal WeeklySalary
            {
                get
                {
                    return salary;
                }
                set
                {
                    if (value > 0)
                        salary = value;
                }
            }
            public decimal Commission
            {
                get
                {
                    return commission;
                }
                set
                {
                    if (value > 0)
                        commission = value;
                }
            }
            public int Quanity
            {
                get
                {
                    return quanity;
                }
                set
                {
                    if (value > 0)
                        quanity = value;
                }
            }
            public override decimal Earnings()
            {
                return WeeklySalary + Commission * Quanity;
                    }
            public override string ToString()
            {
                return "CommissionWorker: " + base.ToString();
            }
        }
        public class PieceWorker : Employee
        {
            private decimal wagePerPiece;
            private int quanity;
            public PieceWorker(string firstNameValue,string lastNameValue,decimal wagePerPieceValue,int quantityValue) : base(firstNameValue, lastNameValue) { wagePerPiece = wagePerPieceValue;quanity = quantityValue; }
            
        }
        public decimal WagePerPiece
        {
            get
            {
                return WagePerPiece;
            }
            set
            {
                if (value > 0)
                    WagePerPiece = value;
            }
        }
        public int Quantity
        {
            get
            {
                return Quantity;
            }
            set
            {
                if (value > 0)
                    Quantity = value;
            }
        }
        public override decimal Earnings()
        {
            return Quantity * WagePerPiece;
        }
        public override string ToString()
        {
            return "PieceWorker: " + base.ToString();
        }
        public class HourlyWorker : Employee
        {
            private decimal wage;
            private double hoursWorked;
            public HourlyWorker(string firstNameValue,string LastNameValue,decimal wageValue,double hoursWorkedValue)
        }




    }
    
}
