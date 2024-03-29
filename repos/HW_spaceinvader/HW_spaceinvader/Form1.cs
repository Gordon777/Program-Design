﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_spaceinvader
{
    public partial class Form1 : Form

    {
        int speed = 5;
        int score = 0;
        bool isPressed;
        int totalEnemies = 17;
        int leftSpeed, rightSpeed;

        public Form1()
        {
            InitializeComponent();
        }
      

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void pressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                player.Left -= leftSpeed;
            }

            if (e.KeyCode == Keys.Right)
            {
                player.Left += rightSpeed;
            }

            if (e.KeyCode == Keys.Space && !isPressed)
            {
                isPressed = true;
                makeBullet();
            }


        }
        private void notPressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                leftSpeed = 0;
            }

            if (e.KeyCode == Keys.Right)
            {
                leftSpeed = 0;
            }
            if (isPressed)
            {
                isPressed = false;
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            leftSpeed = 5;
            rightSpeed = 5;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "invader")
                {
                    if (((PictureBox)x).Bounds.IntersectsWith(player.Bounds))
                    {
                        gameOver();
                    }
                    ((PictureBox)x).Left += speed;
                    if (((PictureBox)x).Left > 580)
                    {
                        ((PictureBox)x).Top += ((PictureBox)x).Height + speed;

                        ((PictureBox)x).Left = -50;
                    }
                }
            }
            foreach (Control y in this.Controls)
            {
                if (y is PictureBox && y.Tag == "bullet")
                {
                    y.Top -= 20;
                    if (((PictureBox)y).Top < this.Height - 490)
                    {
                        this.Controls.Remove(y);
                    }
                }
            }
            foreach (Control i in this.Controls)
            {
                foreach (Control j in this.Controls)
                {
                    if (i is PictureBox && j.Tag == "invader")
                    {
                        if (j is PictureBox && j.Tag == "bullet")
                        {
                            if (i.Bounds.IntersectsWith(j.Bounds))
                            {
                                score++;
                                this.Controls.Remove(i);
                                this.Controls.Remove(j);
                            }

                        }

                    }
                }
            }
        }



            


     private void gameOver()
        {
            timer1.Stop();
            label1.Text = "Game Over";
        }
        private void makeBullet()
        {
            PictureBox bullet = new PictureBox();
            bullet.Image = Properties.Resources.bullet;
            bullet.Size = new Size(5, 20);
            bullet.Tag = "bullet";
            bullet.Left=player,Left + player.Width / 2;
            bullet.Top = play.Top - 20;
            this.Controls.Add(bullet);
            bullet.BringToFront();
        }
        private void bullet(object sender, KeyEventArgs e)
        {

        }

        private void player_Click(object sender, EventArgs e)
        {

        }


    }
}
