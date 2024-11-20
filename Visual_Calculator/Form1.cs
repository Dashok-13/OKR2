using CustomControls.RJControls;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Visual_Calculator
{
    public partial class FrmCalculator : Form
    {
        public FrmCalculator()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyPress += FrmCalculator_KeyPress;
            this.KeyDown += FrmCalculator_KeyDown;
        }

        Double result = 0, fstval;
        string operation = string.Empty, operation2 = string.Empty;
        string fstNum, secNum;
        bool enterValue = false;
        double memoryValue = 0;


        private double GetDisplayValue()
        {
            double displayValue = 0;
            if (double.TryParse(textBox1.Text, out displayValue))
            {
                return displayValue;
            }
            else
            {
                return 0;
            }
        }



        private void AdditionButton(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                fstval = Double.Parse(textBox1.Text);

            if (result != 0 && operation != string.Empty) 
                btnEnter.PerformClick();
            else
            { 
                result = Double.Parse(textBox1.Text);
            }

            Button button = (Button)sender;
            operation = button.Text;
            enterValue = true;

            
                textBox2.Text = fstNum = $"{result} {operation}";
                textBox1.Text = string.Empty;
            
            
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            secNum = textBox1.Text;

            if (textBox1.Text != string.Empty)
            {
                if (textBox1.Text == "0") textBox2.Text = string.Empty;

                try
                {

                    double num = Double.Parse(textBox1.Text);

                    switch (operation)
                    {
                        case "+":
                            textBox2.Text = $"{fstval} {operation}{textBox1.Text}";
                            textBox1.Text = (result + num).ToString();
                            RtBoxDisplayHistory.AppendText($"{fstNum}{secNum}={textBox1.Text}\n");
                            break;
                        case "-":
                            textBox2.Text = $"{fstval} {operation} {textBox1.Text}";
                            textBox1.Text = (result - num).ToString();
                            RtBoxDisplayHistory.AppendText($"{fstNum}{secNum}={textBox1.Text}\n");

                            break;
                        case "×":
                            textBox2.Text = $"{fstval} {operation}{textBox1.Text}";
                            textBox1.Text = (result * num).ToString();
                            RtBoxDisplayHistory.AppendText($"{fstNum}{secNum}={textBox1.Text}\n");
                            break;
                        case "÷":
                            if (num == 0)
                            {
                                textBox1.Text = "Не можна ділити на 0!";
                                textBox2.Text = string.Empty;
                                return;
                            }
                            textBox2.Text = $"{fstval} {operation}{textBox1.Text}";
                            textBox1.Text = (result / num).ToString();
                            RtBoxDisplayHistory.AppendText($"{fstNum}{secNum}={textBox1.Text}\n");
                            break;

                        default:
                            textBox2.Text = $"{textBox1.Text}";
                            break;
                    }
                    result = Double.Parse(textBox1.Text);
                    textBox2.Text += " =";
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

        private void Btn2__Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";

        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            panelHistory.Height = (panelHistory.Height == 0) ? panelHistory.Height = 400 : 0;
        }

        private void buttonClearHistory_Click(object sender, EventArgs e)
        {
            RtBoxDisplayHistory.Clear();
            if (RtBoxDisplayHistory.Text == string.Empty) RtBoxDisplayHistory.Text = "";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string rawText = textBox1.Text.Replace(" ", "");
            if (rawText.Length > 23)
            {
                rawText = rawText.Substring(0, 23);
                textBox1.Text = FormatWithSpaces(rawText);
                textBox1.SelectionStart = textBox1.Text.Length;
                return;
            }

            textBox1.Text = FormatWithSpaces(rawText);
            textBox1.SelectionStart = textBox1.Text.Length;
            AdjustFontSize();
        }

        private string FormatWithSpaces(string input)
        {
            if (string.IsNullOrEmpty(input)) return string.Empty;
            var parts = Enumerable.Range(0, input.Length / 3 + (input.Length % 3 == 0 ? 0 : 1))
                                  .Select(i => input.Substring(Math.Max(0, input.Length - (i + 1) * 3), Math.Min(3, input.Length - i * 3)))
                                  .Reverse();
            return string.Join(" ", parts);
        }

        private void AdjustFontSize()
        {
            int length = textBox1.Text.Replace(" ", "").Length;

            float minFontSize = 16;
            float maxFontSize = 30;
            float fontSize = maxFontSize;

            if (length < 10)
                fontSize = maxFontSize;
            else if (length < 20)
                fontSize = 24;
            else if (length < 30)
                fontSize = 20;
            else
                fontSize = minFontSize;

            textBox1.Font = new Font(textBox1.Font.FontFamily, fontSize);

        }

       

        private void BtnPlusMinus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.StartsWith("-"))
                textBox1.Text = textBox1.Text.Substring(1);
            else if (textBox1.Text != "0")
                textBox1.Text = "-" + textBox1.Text;
        }

        private void Btn1__Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation2 = button.Text;

            switch (operation2)
            {
                case "²√x":
                    textBox2.Text = $"{fstval} {operation} ²√({textBox1.Text})";
                    textBox1.Text = Convert.ToString(Math.Sqrt(Double.Parse(textBox1.Text)));
                    break;
                case "x²":
                    textBox2.Text = $"{fstval} {operation} ({textBox1.Text})²";
                    textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text));
                    break;
                case "⅟x":
                    textBox2.Text = $"{fstval} {operation} ⅟({textBox1.Text})";
                    textBox1.Text = Convert.ToString(1.0 / Convert.ToDouble(textBox1.Text));
                    break;
                case "%":
                    double percentage = Double.Parse(textBox1.Text);
                    double percentageValue = fstval * (percentage / 100);
                    double percentageValue2 = percentage / 100;

                    switch (operation)
                    {
                        case "+":
                            textBox2.Text = $"{fstval} {operation} {percentage}%";
                            textBox1.Text = percentageValue.ToString();
                            break;
                        case "-":
                            textBox2.Text = $"{fstval} {operation} {percentage}%";
                            textBox1.Text = percentageValue.ToString();
                            break;
                        case "×":
                            textBox2.Text = $"{fstval} {operation} {percentage}%";
                            textBox1.Text = percentageValue2.ToString();
                            break;

                        case "÷":
                            textBox2.Text = $"{fstval} {operation} {percentage}%";
                            if (percentageValue2 == 0)
                                textBox1.Text = "Не можна ділити на 0!";
                            else
                                textBox1.Text = percentageValue2.ToString();
                            break;
                    }



                    break;

            }
        }

        private void CosButton_Click(object sender, EventArgs e)
        {
            try
            {
                double value = Double.Parse(textBox1.Text);
                textBox2.Text = $"cos({value})";
                textBox1.Text = Math.Cos(value * Math.PI / 180).ToString(); 
            }
            catch (FormatException)
            {
                textBox1.Text = "Invalid input!";
                textBox2.Text = string.Empty;
            }
        }

        private void SinButton_Click(object sender, EventArgs e)
        {
            try
            {
                double value = Double.Parse(textBox1.Text);
                textBox2.Text = $"sin({value})";
                textBox1.Text = Math.Sin(value * Math.PI / 180).ToString(); 
            }
            catch (FormatException)
            {
                textBox1.Text = "Invalid input!";
                textBox2.Text = string.Empty;
            }
        }

        private void TanButton_Click(object sender, EventArgs e)
        {
            try
            {
                double value = Double.Parse(textBox1.Text);
                textBox2.Text = $"tan({value})";
                textBox1.Text = Math.Tan(value * Math.PI / 180).ToString(); 
            }
            catch (FormatException)
            {
                textBox1.Text = "Invalid input!";
                textBox2.Text = string.Empty;
            }
        }

        private void CtgButton_Click(object sender, EventArgs e)
        {
            try
            {
                double value = Double.Parse(textBox1.Text);
                textBox2.Text = $"ctg({value})";
                if (Math.Tan(value * Math.PI / 180) != 0)
                    textBox1.Text = (1 / Math.Tan(value * Math.PI / 180)).ToString();
                else
                    textBox1.Text = "Undefined"; 
            }
            catch (FormatException)
            {
                textBox1.Text = "Invalid input!";
                textBox2.Text = string.Empty;
            }
        }

        
private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text == "⇛")
            {
                button1.Text = "⇚";
                panel2.Visible = true;
            }
            else
            {
                button1.Text = "⇛";
                panel2.Visible = false;
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            memoryValue += GetDisplayValue(); MessageBox.Show($"До пам'яті додано: {GetDisplayValue()}");
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            memoryValue -= GetDisplayValue(); MessageBox.Show($"З пам'яті віднято: {GetDisplayValue()}");
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            textBox1.Text = memoryValue.ToString();
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            memoryValue = 0; MessageBox.Show("Пам'ять очищено");
        }

        private void btnDigit(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || enterValue)
            {
                textBox1.Text = string.Empty;
                enterValue = false;
            }

            Button button = (Button)sender;
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
        private void FrmCalculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '.')
            {
                if (textBox1.Text == "0" || enterValue)
                {
                    textBox1.Text = string.Empty;
                    enterValue = false;
                }

                if (e.KeyChar == '.' && !textBox1.Text.Contains("."))
                {
                    textBox1.Text += e.KeyChar;
                }
                else if (char.IsDigit(e.KeyChar))
                {
                    textBox1.Text += e.KeyChar;
                }

                e.Handled = true;
            }
        }

        private void FrmCalculator_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Add:
                case Keys.Oemplus:
                    AdditionButton(new Button { Text = "+" }, e);
                    break;
                case Keys.Subtract:
                case Keys.OemMinus:
                    AdditionButton(new Button { Text = "-" }, e);
                    break;
                case Keys.Multiply:
                case Keys.D8: // Shift + 8 для "*"
                    AdditionButton(new Button { Text = "×" }, e);
                    break;
                case Keys.Divide:
                case Keys.OemQuestion: // "/" на клавіатурі
                    AdditionButton(new Button { Text = "÷" }, e);
                    break;
                case Keys.Enter:
                    btnEnter.PerformClick();
                    break;
                case Keys.Back:
                    RemoveLastChar(sender, e);
                    break;
                case Keys.Escape:
                    btnClear.PerformClick();
                    break;
            }
        }
    }
}
