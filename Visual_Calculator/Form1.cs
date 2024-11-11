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
        string operation = string.Empty, operation2 = string.Empty;
        string fstNum, secNum;
        bool enterValue = false;

        private void AdditionButton(object sender, EventArgs e)
        {
            if (result != 0) btnEnter.PerformClick();
            else result = Double.Parse(textBox1.Text);

            Button button = (Button)sender;
            operation = button.Text;
            enterValue = true;
            
                textBox2.Text = fstNum = $"{result}{operation}";
                textBox1.Text = string.Empty;
<<<<<<< HEAD
            }

=======
            
>>>>>>> 047cddf (Functionality Updated sptint 2)
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
                                textBox1.Text = "Error!";
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
<<<<<<< HEAD
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            if (textBox1.Text == string.Empty) textBox1.Text = "0";

=======
            {
                if ("+-×÷".Contains(textBox1.Text.Last()))
                {
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                    textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 1);
                }
                else
                {
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                }

                if (textBox1.Text == string.Empty && textBox2.Text != string.Empty)
                {
                    textBox1.Text = string.Empty; 
                }
                else if (textBox1.Text == string.Empty) 
                {
                    textBox1.Text = "0"; 
                }
            }
            else if (textBox2.Text.Length > 0) 
            {
               
                textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 1);
                if (textBox2.Text == string.Empty)
                {
                    textBox1.Text = "0";
                }
            }
>>>>>>> 047cddf (Functionality Updated sptint 2)
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
<<<<<<< HEAD

        private void btnDigit(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || enterValue) textBox1.Text = string.Empty;
=======
        private void Btn5__Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation2 = button.Text;
            switch (operation2)
            {
                case "²√x":
                    textBox2.Text = $"²√({textBox1.Text})";
                    textBox1.Text = Math.Sqrt(Double.Parse(textBox1.Text)).ToString();
                    break;
                case "x²":
                    textBox2.Text = $"({textBox1.Text})²";
                    textBox1.Text = (Double.Parse(textBox1.Text) * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "⅟x":
                    textBox2.Text = $"⅟({textBox1.Text})";
                    textBox1.Text = (1.0 / Double.Parse(textBox1.Text)).ToString();
                    break;
                case "%":
                    textBox2.Text = $"%({textBox1.Text})";
                    textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) / Convert.ToDouble(100));
                    break;


            }
        }
        private void btnDigit(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || enterValue)
            {
                textBox1.Text = string.Empty;
                enterValue = false; 
            }
>>>>>>> 047cddf (Functionality Updated sptint 2)

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