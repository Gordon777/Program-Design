﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1129HW
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

        private void 開啟ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("開啟");
        }

        private void 存檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("存檔");
        }

        private void 移至ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("移至");
        }

        private void 搜尋與取代ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("搜尋與取代");
        }

        private void 程式碼ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("程式碼");
        }

        private void 設計工具ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("設計工具");
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count != 0)
            {
                string s = "";
                for (int x = 0; x <= checkedListBox1.CheckedItems.Count - 1; x++)
                { s = s + checkedListBox1.CheckedItems[x].ToString() + "\n"; }
                label1.Text = s;
            }
            else
            {
                string s = "";
                s = "";
                label1.Text = s;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com.tw/");

        }
    }
}
