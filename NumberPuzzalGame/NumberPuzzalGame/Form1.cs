﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberPuzzalGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int n = 6;
        Button[,] btns;
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            int i, j, wd = 80;
            btns = new Button[n, n];
            Random r = new Random();
            System.Collections.ArrayList arrayList = new System.Collections.ArrayList();

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    btns[i, j] = new Button();
                    btns[i, j].Location = new Point(wd * (j + 1), wd * (i + 1));
                    btns[i, j].Font = new Font("Arial", 20);
                    btns[i, j].BackColor = Color.Gray;
                    btns[i, j].TextAlign = ContentAlignment.MiddleCenter;
                    if (i != n - 1 || j != n - 1)
                    {
                        int x = r.Next(n * n - 1);
                        while (arrayList.Contains(x))
                        {
                            x = r.Next(n * n - 1) + 1;
                        }
                        arrayList.Add(x);
                        btns[i, j].Text = x.ToString();
                    }
                    btns[i, j].Click += btn_Click;
                    this.Controls.Add(btns[i, j]);
                    this.Width = (n + 2) * wd;
                    this.Height = (n + 2) * wd;
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (btns[i, j] == sender)
                    {
                        if (i > 0)
                        {
                            if (btns[i - 1, j].Text == "")
                            {
                                btns[i - 1, j].Text = btns[i, j].Text;
                                btns[i, j].Text = "";
                            }
                        }
                        if (i < n - 1)
                        {
                            if (btns[i + 1, j].Text == "")
                            {
                                btns[i + 1, j].Text = btns[i, j].Text;
                                btns[i, j].Text = "";
                            }
                        }
                        if (j > 0)
                        {
                            if (btns[i, j + 1].Text == "")
                            {
                                btns[i, j + 1].Text = btns[i, j].Text;
                                btns[i, j].Text = "";
                            }
                        }
                    }
                }
            }
            int k = 1;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (btns[i, j].Text == "")
                    {
                        break;
                    }
                    if (Convert.ToInt32(btns[i, j].Text) != k)
                    {
                        break;
                    }
                    k++;
                }
            }
            if (k == (n * n - 1))
            {
                MessageBox.Show("win");
            }
        }
    }
}
