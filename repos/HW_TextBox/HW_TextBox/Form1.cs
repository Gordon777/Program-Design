﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_TextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            int a;
            a = int.Parse(textBox1.Text);
            int b;
            b = int.Parse(textBox2.Text);
            int c;
            c = a - b;
            label3.Text = "" + c;
        }
        public void label1_Click(object sender, EventArgs e)
        {

        }      
    }
}
