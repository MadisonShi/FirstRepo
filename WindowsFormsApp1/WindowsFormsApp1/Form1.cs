using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private double val1 = 0;
        private double val2 = 0;
        private double result;
        private String input = "";
        private String operation = "";
        private bool negVal = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void outPut(String val)
        {
            textBox1.Text = val;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            input += button1.Text;
            outPut(input);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            input += button2.Text;
            outPut(input);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            input += button3.Text;
            outPut(input);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            input += button4.Text;
            outPut(input);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            input += button5.Text;
            outPut(input);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            input += button6.Text;
            outPut(input);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            input += button7.Text;
            outPut(input);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            input += button8.Text;
            outPut(input);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            input += button9.Text;
            outPut(input);
        }

        private void add_Click(object sender, EventArgs e)
        {
            operation = "add";
            operationFunc();
        }

        private void minus_Click(object sender, EventArgs e)
        {
            operation = "minus";
            operationFunc();
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            operation = "multiply";
            operationFunc();
        }

        private void divide_Click(object sender, EventArgs e)
        {
            operation = "divide";
            operationFunc();
        }

        private void operationFunc()
        {
            val1 = double.Parse(input, CultureInfo.InvariantCulture.NumberFormat);
            input = "";
            textBox1.Text = String.Empty;
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            if(val1 == 0)
            {
                result = double.Parse(input, CultureInfo.InvariantCulture.NumberFormat);
            }
            else
            {
                val2 = double.Parse(input, CultureInfo.InvariantCulture.NumberFormat);
                switch (operation)
                {
                    case "add":
                        result = val1 + val2;
                        break;
                    case "minus":
                        result = val1 - val2;
                        break;
                    case "multiply":
                        result = val1 * val2;
                        break;
                    case "divide":
                        result = val1 / val2;
                        break;
                    default:
                        textBox1.Text = "Error";
                        break;
                }
            }
            textBox1.Text = result.ToString();
            input = "";
            val1 = 0;
            val2 = 0;
            operation = "";
            negVal = false;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            input += button0.Text;
            outPut(input);
        }

        private void dotButton_Click(object sender, EventArgs e)
        {
            input += dotButton.Text;
            outPut(input);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            input = "";
            val1 = 0;
            val2 = 0;
            operation = "";
            textBox1.Text = String.Empty;
            negVal = false;
        }

        private void neg_Click(object sender, EventArgs e)
        {
            if (negVal)
            {
                input = input.Substring(1, input.Length-1);
                negVal = false;
            }
            else
            {
                if(input == "")
                {
                    input += "-";
                }
                else
                {
                    String inputTemp = input;
                    input = "-" + inputTemp; 
                }
                negVal = true;
            }
            outPut(input);
        }
    }
}
