using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int locX, locY;
        private void Form1_Load(object sender, EventArgs e)
        {
            locX = picTank.Location.X;
            locY = picTank.Location.Y;
            lblX.Text = "X座標: " + picTank.Location.X;
            lblY.Text = "Y座標: " + picTank.Location.Y;
            lblMsg.Text = "請按上下左右控制坦克!";
            label1.Text = "請按小雞開始遊戲吧!!";
            picTank.SizeMode = PictureBoxSizeMode.AutoSize;
            picTank.Image = picTankU.Image;
            picTankU.Visible = false;
            picTankD.Visible = false;
            picTankL.Visible = false;
            picTankR.Visible = false;
        }
        private void Form1_KeyDown(object sender,KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    picTank.Image = picTankU.Image;

                    if ((picTank.Top + picTank.Height) <= 0)
                    {
                        picTank.Top = this.Height;
                    }
                    else
                    {
                        picTank.Top -= 10;
                    }
                    break;

                case Keys.Down:
                    picTank.Image = picTankD.Image;
                    if (picTank.Top >= this.Height)
                    {
                        picTank.Top = 0 - picTank.Height;
                    }
                    else
                    {
                        picTank.Top += 10;
                    }
                    break;
                case Keys.Left:
                    picTank.Image = picTankL.Image;
                    if (picTank.Width + picTank.Left <= 0)
                    {
                        picTank.Left = this.Width;
                    }
                    else
                    {
                        picTank.Left -= 10;
                    }
                    break;
                case Keys.Right:
                    picTank.Image = picTankR.Image;
                    if (picTank.Left >= this.Width)
                    {
                        picTank.Left = 0 - picTank.Width;
                    }
                    else
                    {
                        picTank.Left += 10;
                    }
                    break;

            }
            lblX.Text = "X座標:" + picTank.Location.X;
            lblY.Text = "Y座標:" + picTank.Location.Y;
            lblMsg.Text = "現在按下"+e.KeyCode.ToString()+"鍵, 鍵值為: "+e.KeyValue.ToString()+"!!";



        }

                
        

        private void timer1_Tick(object sender, EventArgs e)
        {

            int a = 0;

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
            {
                if (this.Left >= pictureBox2.Left)
                {
                    a = 1;
                }
                else if (this.Right <= pictureBox2.Left + pictureBox2.Width)
                {
                    a = 0;
                }
                if (a == 0)
                    pictureBox2.Left -= 25;
                else if (a == 1)
                    pictureBox2.Left += 25;
            }
            {
                if (this.Left >= pictureBox3.Left)
                {
                    a = 1;
                }
                else if (this.Right <= pictureBox3.Left + pictureBox3.Width)
                {
                    a = 0;
                }
                if (a == 0)
                    pictureBox3.Left -= 25;
                else if (a == 1)
                    pictureBox3.Left += 25;
            }
            {
                if (this.Left >= pictureBox4.Left)
                {
                    a = 1;
                }
                else if (this.Right <= pictureBox4.Left + pictureBox4.Width)
                {
                    a = 0;
                }
                if (a == 0)
                    pictureBox4.Left -= 25;
                else if (a == 1)
                    pictureBox4.Left += 25;
            }
            {
                if (this.Left >= pictureBox5.Left)
                {
                    a = 1;
                }
                else if (this.Right <= pictureBox5.Left + pictureBox5.Width)
                {
                    a = 0;
                }
                if (a == 0)
                    pictureBox5.Left -= 25;
                else if (a == 1)
                    pictureBox5.Left += 25;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            if (picTank.Top == pictureBox1.Bottom)
            {
                pictureBox1.Visible = false;
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void picTank_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblMsg_Click(object sender, EventArgs e)
        {

        }

        private void lblY_Click(object sender, EventArgs e)
        {

        }

        private void picTankL_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Up(object sender, KeyEventArgs e)
        {
            lblX.Text = "X座標:" + picTank.Location.X;
            lblY.Text = "Y座標:" + picTank.Location.Y;
            lblMsg.Text = "請按上下左右控制坦克!";

        }

    }

}
