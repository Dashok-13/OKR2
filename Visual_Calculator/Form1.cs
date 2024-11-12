using System;
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

        private void AdditionButton(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                fstval = Double.Parse(textBox1.Text);

            if (result != 0) btnEnter.PerformClick();
            else result = Double.Parse(textBox1.Text);

            Button button = (Button)sender;
            operation = button.Text;
            enterValue = true;

            textBox2.Text = fstNum = $"{result} {operation}";
            textBox1.Text = string.Empty;

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";


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
                            break;
                        case "-":
                            textBox2.Text = $"{fstval} {operation} {textBox1.Text}";
                            textBox1.Text = (result - num).ToString();
                            break;
                        case "×":
                            textBox2.Text = $"{fstval} {operation}{textBox1.Text}";
                            textBox1.Text = (result * num).ToString();
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
                textBox1.Text = Math.Cos(value * Math.PI / 180).ToString(); // Переводимо градуси в радіани
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
                textBox1.Text = Math.Sin(value * Math.PI / 180).ToString(); // Переводимо градуси в радіани
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
                textBox1.Text = Math.Tan(value * Math.PI / 180).ToString(); // Переводимо градуси в радіани
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
                if (Math.Tan(value * Math.PI / 180) != 0) // Перевірка на дільник 0
                    textBox1.Text = (1 / Math.Tan(value * Math.PI / 180)).ToString(); // Переводимо градуси в радіани
                else
                    textBox1.Text = "Undefined"; // Якщо ctg не визначено
            }
            catch (FormatException)
            {
                textBox1.Text = "Invalid input!";
                textBox2.Text = string.Empty;
            }
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
        // Подія для обробки натискання цифр і десяткової точки
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

                e.Handled = true; // Забороняє передачу символу іншим елементам
            }
        }

        // Подія для обробки операцій і спеціальних клавіш
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
