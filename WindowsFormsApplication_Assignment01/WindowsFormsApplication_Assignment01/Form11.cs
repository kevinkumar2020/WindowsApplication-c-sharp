﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication_Assignment01
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
           
        }

        private void oNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Label lable = new Label();
            panel1.Controls.Add(lable);
            lable.Name = "ON";
        }
    }
}
