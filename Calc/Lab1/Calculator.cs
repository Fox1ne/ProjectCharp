using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Calculator : Form
    {
        public string Action;
        public string Numb1;
        public bool Numb2;
        public string Numb3;
        public Calculator()
        {
            Numb2 = false;
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
        
        private void button19_Click(object sender, EventArgs e)
        {
            double sohr;
            double dn1, dn2;
            double res = 0;

            if (textBox2.Text == "")
                dn1 = Convert.ToDouble(Numb1);
            else
                dn1 = Convert.ToDouble(textBox2.Text);
            
            dn2 = Convert.ToDouble(textBox1.Text);
            
            if (Action == "+" )
            {
                res = dn1 + dn2;
                
            }
            if (Action == "-")
            {
                res = dn1 - dn2;
                
            }
            if (Action == "/")
            {
                res = dn1 / dn2;
                
            }
            if (Action == "*")
            {
                res = dn1 * dn2;
                
            }
            if (Action == "%")
            {
                res = dn1 * dn2 / 100;
               
            }

            textBox2.Text = res.ToString();
            dn1 = Convert.ToDouble(textBox2.Text);
            Action = "=";
            Numb2 = true;
            textBox1.Text = res.ToString();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if(Numb2 == true)
            {
                Numb2 = false;
                textBox1.Text = "0";
            } 
            Button b =(Button)sender;
            if (textBox1.Text == "0")
            {

                textBox1.Text = b.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + b.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender; // сохранение последней нажатой кнопки
            Action = B.Text; // зоминаем действие
            Numb1 = textBox1.Text; // запоминаем числ
            Numb3 = textBox2.Text;
            Numb2 = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
            {
                textBox1.Text = textBox1.Text + ",";
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            double dn, res;
            dn = Convert.ToDouble(textBox1.Text);
            res = Math.Sqrt(dn);
            Action = "√";
            Numb2 = true;
            textBox1.Text = res.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            double dn, res;
            dn = Convert.ToDouble(textBox1.Text);
             res = Math.Pow(dn, 2);
            Action = "x^2";
            Numb2 = true;
            textBox1.Text = res.ToString();
            
            
        }

        private void button23_Click(object sender, EventArgs e)
        {
            double dn, res;
            dn = Convert.ToDouble(textBox1.Text);
             res = 1/dn;
            textBox1.Text = res.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double dn, res;
            dn = Convert.ToDouble(textBox1.Text);
             res = -dn;
            textBox1.Text = res.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text =textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
