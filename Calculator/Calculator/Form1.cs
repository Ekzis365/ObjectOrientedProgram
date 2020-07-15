using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        bool plus = false, minus = false, multiply = false, divide = false, exp = false, tang = false, atang = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void Changed(string value) //Обработка нажатия любой клавиши
        {
            textBox1.Text += value;
            label1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string v = "1";
            Changed(v);
        }

       private void TextChang()
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Tag = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string v = "2";
            Changed(v);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string v = "3";
            Changed(v);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string v = "4";
            Changed(v);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string v = "5";
            Changed(v);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string v = "6";
            Changed(v);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string v = "7";
            Changed(v);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string v = "8";
            Changed(v);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string v = "9";
            Changed(v);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            divide = true;
            if (divide)
            {
                textBox1.Tag = textBox1.Text;
                textBox1.Text = "";
                plus = false;
                multiply = false;
                minus = false;
                exp = false;
                tang = false;
                atang = false;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            multiply = true;
            if (multiply)
            {
                textBox1.Tag = textBox1.Text;
                textBox1.Text = "";
                plus = false;
                minus = false;
                divide = false;
                exp = false;
                tang = false;
                atang = false;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            atang = true;
            if (atang)
            {
                textBox1.Tag = textBox1.Text;
                textBox1.Text = "";
                multiply = false;
                plus = false;
                minus = false;
                divide = false;
                exp = false;
                tang = false;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            exp = true;
            if (exp)
            {
                textBox1.Tag = textBox1.Text;
                textBox1.Text = "";
                plus = false;
                minus = false;
                divide = false;
                multiply = false;
                tang = false;
                atang = false;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            tang = true;
            if (tang)
            {
                textBox1.Tag = textBox1.Text;
                textBox1.Text = "";
                plus = false;
                minus = false;
                divide = false;
                multiply = false;
                exp = false;
                atang = false;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string v = ",";
            Changed(v);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            minus = true;
            if (minus)
            {
                textBox1.Tag = textBox1.Text;
                textBox1.Text = "";
                plus = false;
                multiply = false;
                divide = false;
                exp = false;
                tang = false;
                atang = false;
            }
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string v = "0";
            Changed(v);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            plus = true;
            if (plus)
            {
                textBox1.Tag = textBox1.Text;
                textBox1.Text = "";
                minus = false;
                multiply = false;
                divide = false;
                exp = false;
                tang = false;
                atang = false;
            }
           
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (plus)
            {
                if(textBox1.Text == "")
                {
                    label1.Text = "Введите 2 число!";
                    label1.Visible = true;
                    return;
                }
                double S = Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox1.Tag);
                textBox1.Text = S.ToString();
            }
            if(minus)
            {
                if (textBox1.Text == "")
                {
                    label1.Text = "Введите 2 число!";
                    label1.Visible = true;
                    return;
                }
                double S = Convert.ToDouble(textBox1.Tag) - Convert.ToDouble(textBox1.Text);
                textBox1.Text = S.ToString();
            }
            if (multiply)
            {
                if (textBox1.Text == "")
                {
                    label1.Text = "Введите 2 число!";
                    label1.Visible = true;
                    return;
                }
                double S = Convert.ToDouble(textBox1.Tag) * Convert.ToDouble(textBox1.Text);
                textBox1.Text = S.ToString();
            }
            if (divide)
            {
                if (textBox1.Text == "")
                {
                    label1.Text = "Введите 2 число!";
                    label1.Visible = true;
                    return;
                }
                double S = Convert.ToDouble(textBox1.Tag) / Convert.ToDouble(textBox1.Text);
                textBox1.Text = S.ToString();
            }
            if(exp)
            {
                double expanent = 2.7;
                double S = Math.Pow(Convert.ToDouble(expanent), Convert.ToDouble(textBox1.Tag));
                textBox1.Text = S.ToString();
            }
            if(tang)
            {
                double S = Math.Tan(Convert.ToDouble(textBox1.Tag));
                textBox1.Text = S.ToString();
            }
            if(atang)
            {
                double S = Math.Atan(Convert.ToDouble(textBox1.Tag));
                textBox1.Text = S.ToString();
            }
        }
    }
}
