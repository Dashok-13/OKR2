using System;
 
using System.Windows.Forms;
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
            if (result == 0)
            {
                result = Double.Parse(textBox1.Text);
            }
            else
            {
                btnEnter.PerformClick();
            }
            Button button = (Button)sender;
            operation = button.Text;
            enterValue = true;
            if (textBox1.Text != "0")
            {
                textBox2.Text = $"{result}{operation}";
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
                        case "X":
                            textBox1.Text = (result * num).ToString();
                            break;
                        case "/":
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

        private void UndoButton(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddDigit(object sender, EventArgs e)
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