﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phonecall
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

  



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            label2.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string newStr = label2.Text.Substring(0, label2.Text.Length - 1);
            label2.Text = newStr;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("正在撥打給"+label2.Text+"中.....");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button30_Click(object sender, EventArgs e)
        {
            label2.Text += button30.Text;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            label2.Text += button29.Text;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            label2.Text += button28.Text;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            label2.Text += button27.Text;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            label2.Text += button26.Text;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            label2.Text += button25.Text;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            label2.Text += button24.Text;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            label2.Text += button23.Text;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            label2.Text += button22.Text;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            label2.Text += button21.Text;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            label2.Text += button20.Text;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            label2.Text += button19.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string newStr = label2.Text.Substring(0, label2.Text.Length - 1);
            label2.Text = newStr;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            
            if(label4.Text!="")
            MessageBox.Show("正在撥打給" + label4.Text + "中.....");
            else
            MessageBox.Show("正在撥打給" + label2.Text + "中.....");
            System.Media.SystemSounds.Beep.Play();
            label2.Text = "";


        }

        private void button16_Click(object sender, EventArgs e)
        {
            label2.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("已加入聯絡人!!");
            label4.Text = textBox2.Text +" "+ textBox1.Text;
            textBox1.Text = "";
            textBox2.Text = "";
            MessageBox.Show("小提醒:可以將聯絡人加入後直接到CALL撥打");

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label4.Text = "";

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
