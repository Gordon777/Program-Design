using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gomoku
{
    public partial class Form1 : Form
    {
        private board board = new board();
        private bool isblack = true;///黑棋接白棋
        public Form1()
        {
            InitializeComponent();
            this.Controls.Add(new blackpiece(10, 20));
            this.Controls.Add(new whitepiece(100, 200));

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (isblack)///黑棋接白棋
            {
                this.Controls.Add(new blackpiece(e.X, e.Y));///指定滑鼠按下去的位置
                isblack = false;


            }
            else
            {
                this.Controls.Add(new whitepiece(e.X, e.Y));///指定滑鼠按下去的位置
                isblack = true;
            }

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
           if (board.Canbeplace(e.X, e.Y))
            {
                this.Cursor = Cursors.Hand;
            }
            else
            {
                this.Cursor = Cursors.Default;
            }
        }
    }
}
