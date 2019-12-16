using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppHelloWorld
{
    public partial class Form1 : Form
    {
        double firstNumber;
        string signe;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (result_screen.Text == "0" && result_screen.Text != null)
            {
                result_screen.Text = "0";
            }
            else
            {
                result_screen.Text += "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (result_screen.Text == "0" && result_screen.Text != null)
            {
                result_screen.Text = "1";
            } else
            {
                result_screen.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (result_screen.Text == "0" && result_screen.Text != null)
            {
                result_screen.Text = "2";
            }
            else
            {
                result_screen.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (result_screen.Text == "0" && result_screen.Text != null)
            {
                result_screen.Text = "3";
            }
            else
            {
                result_screen.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (result_screen.Text == "0" && result_screen.Text != null)
            {
                result_screen.Text = "4";
            }
            else
            {
                result_screen.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (result_screen.Text == "0" && result_screen.Text != null)
            {
                result_screen.Text = "5";
            }
            else
            {
                result_screen.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (result_screen.Text == "0" && result_screen.Text != null)
            {
                result_screen.Text = "6";
            }
            else
            {
                result_screen.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (result_screen.Text == "0" && result_screen.Text != null)
            {
                result_screen.Text = "7";
            }
            else
            {
                result_screen.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (result_screen.Text == "0" && result_screen.Text != null)
            {
                result_screen.Text = "8";
            }
            else
            {
                result_screen.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (result_screen.Text == "0" && result_screen.Text != null)
            {
                result_screen.Text = "9";
            }
            else
            {
                result_screen.Text += "9";
            }
        }

        private void button_ce_Click(object sender, EventArgs e)
        {
            result_screen.Text = "0";
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            result_screen.Text = "0";
        }

        private void button_virgule_Click(object sender, EventArgs e)
        {
            if (result_screen.Text == "0" && result_screen.Text != null)
            {
                result_screen.Text += ",";
            }
        }

        private void button_addition_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(result_screen.Text);
            result_screen.Text = "0";
            signe = "+";
        }

        private void button_soustraction_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(result_screen.Text);
            result_screen.Text = "0";
            signe = "-";
        }

        private void button_multiplication_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(result_screen.Text);
            result_screen.Text = "0";
            signe = "*";
        }

        private void button_division_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(result_screen.Text);
            result_screen.Text = "0";
            signe = "/";
        }

        private void button_egale_Click(object sender, EventArgs e)
        {
            double secondNumber;
            double result;

            if (signe == "+")
            {
                secondNumber = Convert.ToDouble(result_screen.Text);
                result = firstNumber + secondNumber;
                result_screen.Text = firstNumber + " + " + secondNumber + " = " + result;
            }
            
            else if (signe == "-")
            {
                secondNumber = Convert.ToDouble(result_screen.Text);
                result = firstNumber - secondNumber;
                result_screen.Text = firstNumber + " - " + secondNumber + " = " + result;
            }

            else if (signe == "*")
            {
                secondNumber = Convert.ToDouble(result_screen.Text);
                result = firstNumber * secondNumber;
                result_screen.Text = firstNumber + " * " + secondNumber + " = " + result;
            }

            else if (signe == "/")
            {
                secondNumber = Convert.ToDouble(result_screen.Text);
                if (firstNumber == 0 || secondNumber == 0)
                {
                    MessageBox.Show(
                        "Vous avez essaye de faire une division par 0 !", "Warning");
                } else
                {
                    result = firstNumber / secondNumber;
                    result_screen.Text = firstNumber + " / " + secondNumber + " = " + result;
                }
                
            }
        }
    }
}
