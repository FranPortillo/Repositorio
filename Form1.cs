﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repositorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            double Num1= Convert.ToDouble(txtNum1.Text);
            double Num2 = Convert.ToDouble(txtNum2.Text);
            double total;
            total = Num1 + Num2;
            lbltotal.Text = ("El resultado de la sumar " + Num1 + " mas " + Num2 + " es de " + total + " ");
        }
    }
}
