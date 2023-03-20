using System;
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
        int a;
        int bi;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            a = Int32.Parse(textBox1.Text);
            bi = Int32.Parse(textBox2.Text);
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            a = Int32.Parse(textBox1.Text);
            bi = Int32.Parse(textBox2.Text);
        }
    }
    abstract class Norma
    {
        public double Norm;
        public double Abs;
        public virtual void ABS()
        {
            Console.WriteLine("ABS");
        }
        public virtual void NORM()
        {
            Console.WriteLine("NORM");
        }
    }
    class Complex : Norma
    {
        public override void ABS()
        {
            Math.Sqrt();
        }
        public override void NORM()
        {
            
            Norm = Math.Pow(a, 2) + Math.Pow(bi, 2);
            base.NORM();
        }
    }
}
