﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hw_move
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Top -= 50;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Top += 50;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
        int a = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {

            {
                if (this.Left >= pictureBox1.Left)
                {
                    a = 1;
                }
                else if (this.Right <= pictureBox1.Left + pictureBox1.Width)
                {
                    a = 0;
                }
                if (a == 0)
                    pictureBox1.Left -= 25;
                else if (a == 1)
                    pictureBox1.Left += 25;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Left -= 50;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Left += 50;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    pictureBox1.Left -= 20;
                    break;
                case Keys.Right:
                    pictureBox1.Left += 20;
                    break;
                case Keys.Up:
                    pictureBox1.Top -= 20;
                    break;
                case Keys.Down:
                    pictureBox1.Top += 20;
                    break;
            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button7_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();


        }
    }
}
