namespace Calculator
{
    public partial class Form1 : Form
    {

       public enum ButtonType
        {
            Add,
            Subtract,
            Multiply,
            Divide,
            Equals,
            Clear,
            Zero,
            One,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine
        }

        string currentInput = "";
        double firstOperand = 0;
        string operation = "";
        double secondOperand = 0;
        double result = 0;
        public Form1()
        {
            InitializeComponent();
            ButtonAssignments();
        }

        public static class ButtonHelper
        {
            public static string SetButtonText(ButtonType buttonType)
            {
                // This should work if 
                return buttonType switch
                {
                    ButtonType.Add => "+",
                    ButtonType.Subtract => "-",
                    ButtonType.Multiply => "*",
                    ButtonType.Divide => "/",
                    ButtonType.Equals => "=",
                    ButtonType.Clear => "Clear",
                    ButtonType.Zero => "0",
                    ButtonType.One => "1",
                    ButtonType.Two => "2",
                    ButtonType.Three => "3",
                    ButtonType.Four => "4",
                    ButtonType.Five => "5",
                    ButtonType.Six => "6",
                    ButtonType.Seven => "7",
                    ButtonType.Eight => "8",
                    ButtonType.Nine => "9",
                    _ => throw new ArgumentOutOfRangeException(nameof(buttonType), buttonType, null)
                };
            }
        }

        private void ButtonAssignments()
        {
            // Button operator text assignment
            btnAdd.Text = ButtonHelper.SetButtonText(ButtonType.Add);
            btnSubtract.Text = ButtonHelper.SetButtonText(ButtonType.Subtract);
            btnMultiply.Text = ButtonHelper.SetButtonText(ButtonType.Multiply);
            btnDivide.Text = ButtonHelper.SetButtonText(ButtonType.Divide);
            btnEquals.Text = ButtonHelper.SetButtonText(ButtonType.Equals);
            btnClear.Text = ButtonHelper.SetButtonText(ButtonType.Clear);

            // Number button assignment
            btnZero.Text = ButtonHelper.SetButtonText(ButtonType.Zero);
            btnOne.Text = ButtonHelper.SetButtonText(ButtonType.One);
            btnTwo.Text = ButtonHelper.SetButtonText(ButtonType.Two);
            btnThree.Text = ButtonHelper.SetButtonText(ButtonType.Three);
            btnFour.Text = ButtonHelper.SetButtonText(ButtonType.Four);
            btnFive.Text = ButtonHelper.SetButtonText(ButtonType.Five);
            btnSix.Text = ButtonHelper.SetButtonText(ButtonType.Six);
            btnSeven.Text = ButtonHelper.SetButtonText(ButtonType.Seven);
            btnEight.Text = ButtonHelper.SetButtonText(ButtonType.Eight);
            btnNine.Text = ButtonHelper.SetButtonText(ButtonType.Nine);
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

        // Clear button logic
        private void BtnClear_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (sender is Button)
            {
                if (button.Text == "Clear")
                {
                    ClearCalculator();
                }
                else
                {
                    // Update the display
                    currentInput += button.Text; // Append the button's text to currentInput
                    textBox1.Text = currentInput;
                }
            }
        }

        // Clear button
        private void ClearCalculator()
        {

            currentInput = "";
            result = 0;
            operation = "";
            textBox1.Text = "0";
            firstOperand = 0;
            secondOperand = 0;

        }

        private void BtnOperand(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {

                // Check if the buttonis an operator
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
        private void DisplayUpdate(string text)
        {
            textBox1.Text = text; // Update the display with the result
        }
    }
}
