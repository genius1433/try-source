using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace калькулятор
{
    public partial class Form1 : Form
    {
        private float a;
        private float b;
        private int numberOfOperation;
        public Form1()
        {
            InitializeComponent();
        }
        private void ButtonDoing(object sender)
        {
            //textBox1.Text = textBox1.Text + ((Button)(sender)).Text;
            if (textBox1.Text != "error,press begin")
            {
                textBox1.Text = textBox1.Text + ((Button)(sender)).Text;
            }
        }
        private void Remembering(object sender)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            label1.Text = a.ToString() + ((Button)(sender)).Text;
        }
        private void button15_Click(object sender, EventArgs e)
        {
            ButtonDoing(sender);
        }
        private void button14_Click(object sender, EventArgs e)
        {
            //,
            if (textBox1.Text.IndexOf(",") == -1 && textBox1.Text != "")
            {
                ButtonDoing(sender);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ButtonDoing(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ButtonDoing(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ButtonDoing(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ButtonDoing(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ButtonDoing(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ButtonDoing(sender);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ButtonDoing(sender);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            ButtonDoing(sender);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            ButtonDoing(sender);
        }
        
        private void button10_Click(object sender, EventArgs e)
        {
            if (label1.Text.IndexOf("+") == -1 && textBox1.Text != "" && textBox1.Text != "error,press begin")
            {
                Remembering(sender);
                numberOfOperation = 1;
            }
            if (label1.Text.IndexOf("-") != -1)
            {
                label1.Text = a + "+";
                numberOfOperation = 1;
            }
            if (label1.Text.IndexOf("*") != -1)
            {
                label1.Text = a + "+";
                numberOfOperation = 1;
            }
            if (label1.Text.IndexOf(":") != -1)
            {
                label1.Text = a + "+";
                numberOfOperation = 1;
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (label1.Text.IndexOf("-") == -1 && textBox1.Text != "" && textBox1.Text != "error,press begin")
            {
                Remembering(sender);
                numberOfOperation = 2;
            }
            if (label1.Text.IndexOf(":") != -1)
            {
                label1.Text = a + "-";
                numberOfOperation = 2;
            }
            if (label1.Text.IndexOf("+") != -1)
            {
                label1.Text = a + "-";
                numberOfOperation = 2;
            }
            if (label1.Text.IndexOf("*") != -1)
            {
                label1.Text = a + "-";
                numberOfOperation = 2;
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            if (label1.Text.IndexOf("*") == -1 && textBox1.Text != "" && textBox1.Text != "error,press begin")
            {
                Remembering(sender);
                numberOfOperation = 3;
            }
            if (label1.Text.IndexOf(":") != -1)
            {
                label1.Text = a + "*";
                numberOfOperation = 3;
            }
            if (label1.Text.IndexOf("+") != -1)
            {
                label1.Text = a + "*";
                numberOfOperation = 3;
            }
            if (label1.Text.IndexOf("-") != -1)
            {
                label1.Text = a + "*";
                numberOfOperation = 3;
            }
        }
        private void button16_Click(object sender, EventArgs e)
        {
            if (label1.Text.IndexOf(":") == -1 && textBox1.Text != "" && textBox1.Text != "error,press begin")
            {
                Remembering(sender);
                numberOfOperation = 4;
            }
            if (label1.Text.IndexOf("+") != -1)
            {
                label1.Text = a + ":";
                numberOfOperation = 4;
            }
            if (label1.Text.IndexOf("-") != -1)
            {
                label1.Text = a + ":";
                numberOfOperation = 4;
            }
            if (label1.Text.IndexOf("*") != -1)
            {
                label1.Text = a + ":";
                numberOfOperation = 4;
            }
        }
        private void button13_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" && textBox1.Text != "error,press begin")
            {
                b = float.Parse(textBox1.Text);
                if (numberOfOperation == 1)
                {
                    textBox1.Text = (a + b).ToString();

                }
                else if (numberOfOperation == 2)
                {
                    textBox1.Text = (a - b).ToString();
                }
                else if (numberOfOperation == 3)
                {
                    textBox1.Text = (a * b).ToString();
                }
                else if (numberOfOperation == 4 && b != 0)
                {
                    textBox1.Text = (a / b).ToString();
                }
                else textBox1.Text = "error,press begin";
                a = 0;
                b = 0;
                label1.Text = "";
            }
        }
        private void button17_Click(object sender, EventArgs e)
        {
            //string t = "";
            //for (int i = 0; i < textBox1.TextLength - 1; i++)
            //{
            //    t = t + textBox1.Text[i];
            //}
            //textBox1.Text = t;
            if (textBox1.Text != "error,press begin")
            {
                string t = "";
                for (int i = 0; i < textBox1.TextLength - 1; i++)
                {
                    t = t + textBox1.Text[i];
                }
                textBox1.Text = t;
            }
        }
        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            a = 0;
            b = 0;
            label1.Text = "";
        }
    }
}
