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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (enterValue)
            {
                btnEnter.PerformClick();
            }
            result = Double.Parse(textBox1.Text);

            Button button = (Button)sender;
            operation = button.Text;
            enterValue = true;

            textBox2.Text = fstNum = $"{result}{operation}";
            textBox1.Text = string.Empty;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            secNum = textBox1.Text;
            textBox2.Text = $"{textBox2.Text}{textBox1.Text}";

            if (textBox1.Text != string.Empty)
            {
                if (textBox1.Text == "0" && operation == "/")
                {
                    textBox1.Text = "Error!";
                    textBox2.Text = string.Empty;
                    return;
                }

                switch (operation)
                {
                    case "+":
                        textBox1.Text = (result + Double.Parse(textBox1.Text)).ToString();
                        break;
                    case "-":
                        textBox1.Text = (result - Double.Parse(textBox1.Text)).ToString();
                        break;
                    case "X":
                        textBox1.Text = (result * Double.Parse(textBox1.Text)).ToString();
                        break;
                    case "/":
                        if (Double.Parse(textBox1.Text) == 0)
                        {
                            textBox1.Text = "Error!";
                            textBox2.Text = string.Empty;
                            return;
                        }
                        textBox1.Text = (result / Double.Parse(textBox1.Text)).ToString();
                        break;
                }

                result = Double.Parse(textBox1.Text);
                operation = string.Empty;
            }
        }


        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            if (textBox1.Text == string.Empty) textBox1.Text = "";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = string.Empty;
            result = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.StartsWith("-"))
                textBox1.Text = textBox1.Text.Substring(1);
            else if (textBox1.Text != "0")
                textBox1.Text = "-" + textBox1.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (textBox1.Text == "0" && button.Text != ".")
            {
                textBox1.Text = button.Text;
            }
            else
            {
                if (button.Text == ".")
                {
                    if (!textBox1.Text.Contains("."))
                        textBox1.Text += button.Text;
                }
                else
                {
                    textBox1.Text += button.Text;
                }
            }

            enterValue = false;
        }

    }
}