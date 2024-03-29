﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRace2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Over.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(gamespeed);
            alien(gamespeed);
            gameover();
            coins(gamespeed);
            coinscollection();
        }

        int collectedcoin = 0;

        Random r = new Random();
        int x, y;
        void alien(int speed)
        {
            if (alien1.Top >= 500)
            {
                x = r.Next(0, 200);
                alien1.Location = new Point(x, 0);
            }
            else
            {
                alien1.Top += speed;
            }

            if (alien2.Top >= 500)
            {
                x = r.Next(0, 400);
                alien2.Location = new Point(x, 0);
            }
            else
            {
                alien2.Top += speed;
            }

            if (alien3.Top >= 500)
            {
                x = r.Next(200, 350);
                alien3.Location = new Point(x, 0);
            }
            else
            {
                alien3.Top += speed;
            }
        }

        void coins(int speed)
        {
            if (coin1.Top >= 500)
            {
                x = r.Next(0, 200);
                coin1.Location = new Point(x, 0);
            }
            else
            {
                coin1.Top += speed;
            }

            if (coin2.Top >= 500)
            {
                x = r.Next(0, 200);
                coin2.Location = new Point(x, 0);
            }
            else
            {
                coin2.Top += speed;
            }

            if (coin3.Top >= 500)
            {
                x = r.Next(50, 300);
                coin3.Location = new Point(x, 0);
            }
            else
            {
                coin3.Top += speed;
            }
            if (coin4.Top >= 500)
            {
                x = r.Next(0, 400);
                coin4.Location = new Point(x, 0);
            }
            else
            {
                coin4.Top += speed;
            }
        }


        void gameover()
        {
            if (car.Bounds.IntersectsWith(alien1.Bounds))
            {
                timer1.Enabled = false;
                Over.Visible = true;
            }
            if (car.Bounds.IntersectsWith(alien2.Bounds))
            {
                timer1.Enabled = false;
                Over.Visible = true;
            }
            if (car.Bounds.IntersectsWith(alien3.Bounds))
            {
                timer1.Enabled = false;
                Over.Visible = true;
            }
        }

        void moveline(int speed)
        {
            if (pictureBox5.Top >= 500)
            {
                pictureBox5.Top = 0;
            }
            else
            {
                pictureBox5.Top += speed;
            }

            if (pictureBox2.Top >= 500)
            {
                pictureBox2.Top = 0;
            }
            else
            {
                pictureBox2.Top += speed;
            }

            if (pictureBox3.Top >= 500)
            {
                pictureBox3.Top = 0;
            }
            else
            {
                pictureBox3.Top += speed;
            }

            /*if (pictureBox4.Top >= 500)
            {
                pictureBox4.Top = 0;
            }
            else
            {
                pictureBox4.Top += speed;
            }

            if (pictureBox5.Top >= 500)
            {
                pictureBox5.Top = 0;
            }
            else
            {
                pictureBox5.Top += speed;
            }*/
        }

        void coinscollection()
        {
            if (car.Bounds.IntersectsWith(coin1.Bounds))
            {
                collectedcoin++;
                label1.Text = "Coins =" + collectedcoin.ToString();
                x = r.Next(50, 300);
                coin1.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin2.Bounds))
            {
                collectedcoin++;
                label1.Text = "Coins =" + collectedcoin.ToString();
                x = r.Next(50, 300);
                coin2.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin3.Bounds))
            {
                collectedcoin++;
                label1.Text = "Coins =" + collectedcoin.ToString();
                x = r.Next(50, 300);
                coin3.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin4.Bounds))
            {
                collectedcoin++;
                label1.Text = "Coins =" + collectedcoin.ToString();
                x = r.Next(50, 300);
                coin4.Location = new Point(x, 0);
            }
        }

        int gamespeed = 0;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (car.Left > 0)
                {
                    car.Left += -gamespeed;
                }

            }
            if (e.KeyCode == Keys.Right)
            {
                if (car.Right < 380)
                {
                    car.Left += gamespeed;
                }

            }
            if (e.KeyCode == Keys.Up)
            {
                if (gamespeed < 21)
                {
                    gamespeed++;
                }

            }
            if (e.KeyCode == Keys.Down)
            {
                if (gamespeed > 0)
                {
                    gamespeed--;
                }

            }
        }
    }
}
