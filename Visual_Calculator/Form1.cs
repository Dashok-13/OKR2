using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
namespace Visual_Calculator
{


    public partial class FrmCalculator : Form
    {

        public FrmCalculator()
        {
            InitializeComponent();
        }
        Double result = 0;
        string operation = string.Empty;
        string fstNum, secNum;
        bool enterValue = false;

        private void AdditionButton(object sender, EventArgs e)
        {
            if (result != 0) btnEnter.PerformClick();
            else result = Double.Parse(textBox1.Text);

            Button button = (Button)sender;
            operation = button.Text;
            enterValue = true;
            if (textBox1.Text != "0")
            {
                textBox2.Text = fstNum = $"{result}{operation}";
                textBox1.Text = string.Empty;
            }

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            secNum = textBox1.Text;
            textBox2.Text = $"{textBox2.Text}{textBox1.Text}";

            if (textBox1.Text != string.Empty)
            {
                if (textBox1.Text == "0") textBox2.Text = string.Empty;

                try
                {
                    double num = Double.Parse(textBox1.Text);

                    switch (operation)
                    {
                        case "+":
                            textBox1.Text = (result + num).ToString();
                            break;
                        case "-":
                            textBox1.Text = (result - num).ToString();
                            break;
                        case "×":
                            textBox1.Text = (result * num).ToString();
                            break;
                        case "÷":
                            if (num == 0)
                            {
                                textBox1.Text = "Не можна ділити на 0!";
                                textBox2.Text = string.Empty;
                                return;
                            }
                            textBox1.Text = (result / num).ToString();
                            break;
                        default:
                            textBox2.Text = $"{textBox1.Text}";
                            break;
                    }
                    result = Double.Parse(textBox1.Text);
                }
                catch (FormatException)
                {
                    textBox1.Text = "Invalid input!";
                    textBox2.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    textBox1.Text = "Error!";
                    textBox2.Text = string.Empty;
                    Console.WriteLine(ex.Message);
                }

                operation = string.Empty;
            }



        }

        private void RemoveLastChar(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            if (textBox1.Text == string.Empty) textBox1.Text = "0";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = string.Empty;
            result = 0;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnPlusMinus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.StartsWith("-"))
                textBox1.Text = textBox1.Text.Substring(1);
            else if (textBox1.Text != "0")
                textBox1.Text = "-" + textBox1.Text;
        }

        private void Btn5__Click(object sender, EventArgs e)
        {
            try
            {
                double num = Double.Parse(textBox1.Text);
                if (num != 0)
                {
                    textBox1.Text = (1 / num).ToString();
                }
                else
                {
                    textBox1.Text = "Cannot divide by zero!";
                }
            }
            catch
            {
                textBox1.Text = "Error!";
            }
        }

        private void Btn1__Click(object sender, EventArgs e)
        {
            try
            {
                double num = Double.Parse(textBox1.Text);
                textBox1.Text = (num / 100).ToString();
            }
            catch
            {
                textBox1.Text = "Error!";
            }
        }

        private void Btn23_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
            {
                textBox1.Text += ",";
            }
        }

        private void Btn__Click(object sender, EventArgs e)
        {
            try
            {
                double num = Double.Parse(textBox1.Text);
                if (num >= 0)
                {
                    textBox1.Text = Math.Sqrt(num).ToString();
                }
                else
                {
                    textBox1.Text = "Invalid input!";
                }
            }
            catch
            {
                textBox1.Text = "Error!";
            }
        }   

        private void btnDigit(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || enterValue) textBox1.Text = string.Empty;

            enterValue = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + button.Text;
            }
            else textBox1.Text = textBox1.Text + button.Text;
        }
    }
}