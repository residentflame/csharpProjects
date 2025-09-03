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

        private void NumberButton_Click(object sender, EventArgs e)
        {

            Button button = sender as Button;
            if (button != null)
            {
                currentInput += button.Text; 

                if (string.IsNullOrEmpty(operation))
                {
                    CalculatorInputTextBox.Text = currentInput;
                }
                else
                {
                    CalculatorInputTextBox.Text = $"{firstOperand} {operation} {currentInput}";
                }
            }
        }

        // Clear button logic
        private void BtnClear_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (sender is Button)
            {
                switch (button.Text)
                {
                    case "Clear":
                        currentInput = "";
                        result = 0;
                        operation = "";
                        CalculatorInputTextBox.Text = "0";
                        firstOperand = 0;
                        secondOperand = 0;
                        MessageBox.Show("Calculator cleared!");
                        break;
                    default:
                        currentInput += button.Text; 
                        CalculatorInputTextBox.Text = currentInput;
                        break;
                }
            }
        }

        private void BtnOperand_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button != null)
            {


                if (button.Text.Equals("+") || button.Text.Equals("-") || button.Text.Equals("*") || button.Text.Equals("/"))
                {
                    if (string.IsNullOrEmpty(currentInput))
                    {
                        MessageBox.Show("Please enter a number first.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    if (!double.TryParse(currentInput, out firstOperand))
                    {
                        MessageBox.Show("Invalid number entered.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    operation = button.Text;
                    CalculatorInputTextBox.Text = firstOperand + " " + operation;
                    currentInput = "";
                }
            }

            if (!button.Text.Equals("=") || string.IsNullOrEmpty(currentInput))
            {
                return;
            }
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
                    MessageBox.Show("Invalid can't divide by 0.");
                    return;
                }
                result = firstOperand / secondOperand;
                DisplayUpdate(result.ToString());
            }
        }
        private void DisplayUpdate(string text)
        {
            CalculatorInputTextBox.Text = text; 
        }
    }
}
