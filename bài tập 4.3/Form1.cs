using System;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        double firstNumber = 0;
        string operation = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = btn.Text;
            }
            else
            {
                txtDisplay.Text += btn.Text;
            }
        }

        private void OperatorButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (double.TryParse(txtDisplay.Text, out firstNumber))
            {
                operation = btn.Text;
                txtDisplay.Text = "";
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double secondNumber;

            if (!double.TryParse(txtDisplay.Text, out secondNumber))
                return;

            double result = 0;

            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;

                case "-":
                    result = firstNumber - secondNumber;
                    break;

                case "*":
                    result = firstNumber * secondNumber;
                    break;

                case "/":
                    if (secondNumber == 0)
                    {
                        MessageBox.Show("Không thể chia cho 0");
                        return;
                    }

                    result = firstNumber / secondNumber;
                    break;
            }

            txtDisplay.Text = result.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            firstNumber = 0;
            operation = "";
        }
    }
}