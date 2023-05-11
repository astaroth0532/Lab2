using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Lab2.Program;
namespace Lab2
{
    public partial class Form1 : Form
    {
        private readonly Complex _complex = new Complex();
        public Form1()
        {
            InitializeComponent();
        }
        int a1;
        int bi1;
        int a2;
        int bi2;
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 39 ||
                e.KeyChar >= 46) && number != 47 && number != 61) // цифры, клавиша BackSpace, запятая и математические знаки
            {
                e.Handled = true;
            }
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 39 ||
                e.KeyChar >= 46) && number != 47 && number != 61) // цифры, клавиша BackSpace, запятая и математические знаки
            {
                e.Handled = true;
            }
        }

        private void _normBtn_MouseClick(object sender, MouseEventArgs e)
        {
            try {
                a1 = Int32.Parse(textBox1.Text);
                bi1 = Int32.Parse(textBox2.Text);
                //ініціалізація змінних 
                
            }
            catch
            {

            }
            finally
            {
                _resLbl.Text = "Норма комплексного числа дорівнює: " + Convert.ToString(_complex.NORM(a1, bi1));
            }
        }

        private void _AbsBtn_MouseClick(object sender, MouseEventArgs e)
        {
           
           
            
            try
            {
                a1 = Int32.Parse(textBox1.Text);
                bi1 = Int32.Parse(textBox2.Text); //ініціалізація змінних
            }
            catch
            {

            }
            finally
            {
                _resLbl.Text = "Модуль комплексного числа дорівнює: " + Convert.ToString(_complex.ABS(a1, bi1));
            }
        }
    }
    
}

