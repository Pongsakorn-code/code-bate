using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
      
    {
        decimal num1, num2, result;
        string operate = "";
        bool isOperand = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(isOperand)
                textBox1.Text = "";
            textBox1.Text = textBox1.Text + "1";
            isOperand = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0) 
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isOperand)
                textBox1.Text = "";
            textBox1.Text = textBox1.Text +"2";
            isOperand = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isOperand)
                textBox1.Text = "";
            textBox1.Text = textBox1.Text + "3";
            isOperand = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (isOperand)
                textBox1.Text = "";
            textBox1.Text = textBox1.Text + "4";
            isOperand = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (isOperand)
                textBox1.Text = "";
            textBox1.Text = textBox1.Text +"5";
            isOperand = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (isOperand)
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + "6";
            isOperand = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (isOperand)
                textBox1.Text = "";
            textBox1.Text = textBox1.Text + "7";
            isOperand = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (isOperand)
                textBox1.Text = "";
            textBox1.Text = textBox1.Text + "8";
            isOperand = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (isOperand)
                textBox1.Text = "";
            textBox1.Text = textBox1.Text + "9";
            isOperand = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (isOperand)
                textBox1.Text = "";
            textBox1.Text = textBox1.Text + "0";
            isOperand = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            
            
                if (textBox1.Text.Length > 0)
                {
                    if (operate == "" || operate == "=")
                    {
                        label1.Text += textBox1.Text + " + ";
                        num1 = Decimal.Parse(textBox1.Text);
                        operate = "+";
                        isOperand = true;
                    }
                    else
                    {
                        label1.Text += textBox1.Text + " + ";
                        this.Calculate();
                        operate = "+";
                    }
                }
            

        }
        private void Calculate()
        {
            //     true  && true  = true
            //     true  && false = false
            //     false && false = false

            //     true   true  = true
            //     true   false = true
            //     false || false = false

            //     !true = false
            //     !false = true

            if (textBox1.Text == "0" && operate == "/")
            {
                MessageBox.Show("ไม่สามารถหารด้วย 0 ได้");
                return;
            }
            switch (operate)
            {
                case "+":
                    result = num1 + Decimal.Parse(textBox1.Text);
                    break;
                case "-":
                    result = num1 - Decimal.Parse(textBox1.Text);
                    break;
                case "*":
                    result = num1 * Decimal.Parse(textBox1.Text);
                    break;
                case "/":
                    result = num1 / Decimal.Parse(textBox1.Text);
                    break;
            }
            num1 = result;
            isOperand = true;
            textBox1.Text = result.ToString();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text + ".";
            num1 = Decimal.Parse(textBox1.Text);
            operate = ".";
            isOperand = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && operate == "/")
            {
                MessageBox.Show("ไม่สามารถหารด้วย 0 ได้");
                return;
            }

                label1.Text += textBox1.Text + "=";
            switch(operate)
            {
                case "+":
                    result = num1 + Decimal.Parse(textBox1.Text);
                    break;
                case "-":
                    result = num1 - Decimal.Parse(textBox1.Text);
                    break;
                case "*":
                    result = num1 * Decimal.Parse(textBox1.Text);
                    break;
                case "/":
                    if (textBox1.Text == "0")
                    {
                        MessageBox.Show("ไม่สามารถหาร 0 ได้");
                        return;
                    }
                    result = num1 / Decimal.Parse(textBox1.Text);
                    break;

            }
            num1 = result;
            isOperand = true;
            textBox1.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text + "/";
            num1 = Decimal.Parse(textBox1.Text);
            operate = "/";
            isOperand = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text + "x";
            num1 = Decimal.Parse(textBox1.Text);
            operate = "x";
            isOperand = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text + "-";
            num1 = Decimal.Parse(textBox1.Text);
            operate = "-";
            isOperand = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
            operate = "";
            isOperand = false;
            num1 = num2 = result = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
