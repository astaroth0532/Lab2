﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
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
    }
    abstract class Norm
    {
        public void ABS()
        {
            Console.WriteLine("ABS");
        }
        public void NORM()
        {
            Console.WriteLine("NORM");
        }
    }
}