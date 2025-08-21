namespace Calculator
{
    public partial class Form1 : Form
    {
        string currentInput = "";
        double firstOperand = 0;
        string operation = "";
        double secondOperand = 0;
        double result = 0;
        public Form1()
        {
            InitializeComponent();

        }
        // Calculator display clear
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearCalculator();
        }

        // Clear button logic
        private void ClearCalculator()
        {
            currentInput = "";
            result = 0;
            operation = "";
            textBox1.Text = "0";
            firstOperand = 0;
            secondOperand = 0;
        }

        // Update Calculator screen
        private void DisplayUpdate(string text)
        {
            textBox1.Text = text; // Update the display with the result
        }

        // Number Button click method
        private void NumberButton_Click(object sender, EventArgs e)
        {

            Button button = sender as Button;
            if (button != null)
            {
                // Update the display
                currentInput += button.Text; // Append the button's text to currentInput

                if (string.IsNullOrEmpty(operation))
                {
                    textBox1.Text = currentInput;
                }
                else
                {
                    // If an operation is set, display the first operand, operator, and current input (second operand)
                    textBox1.Text = $"{firstOperand} {operation} {currentInput}";
                }
            }
        }

        private void btnOperand(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {

                // Check if the button text is an operator
                if (button.Text == "+" || button.Text == "-" || button.Text == "*" || button.Text == "/")
                {
                    if (string.IsNullOrEmpty(currentInput))
                    {
                        MessageBox.Show("Please enter a number first.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit if no number is entered
                    }

                    // Checks if the button input is a double before converting into double
                    if (!double.TryParse(currentInput, out firstOperand))
                    {
                        MessageBox.Show("Invalid number entered.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit if input is invalid
                    }
                    operation = button.Text;
                    textBox1.Text = firstOperand + " " + operation;
                    currentInput = ""; // Reset current input for the next number
                }
            }

            if (button.Text == "=" && !string.IsNullOrEmpty(currentInput))
            {
                if (!double.TryParse(currentInput, out secondOperand))
                {
                    MessageBox.Show("Invalid number entered.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (operation.Equals("+"))
                {
                    result = firstOperand + secondOperand;
                    DisplayUpdate(result.ToString());
                }
                else if (operation.Equals("-"))
                {
                    result = firstOperand - secondOperand;
                    DisplayUpdate(result.ToString());
                }
                else if (operation.Equals("*"))
                {
                    result = secondOperand * firstOperand;
                    DisplayUpdate(result.ToString());
                }
                else if (operation.Equals("/"))
                {
                    if (secondOperand == 0)
                    {
                        MessageBox.Show("invalid cant divide by 0");
                        return;
                    }
                    result = firstOperand / secondOperand;
                    DisplayUpdate(result.ToString());
                }
            }
        }
    }
}

