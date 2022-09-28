namespace SD_320_W22SD_Assignment
{
    public partial class Form1 : Form
    {
        private string? _numberDisplay = "0";
        public string? NumberDisplay
        {
            get
            {
                return _numberDisplay;
            }
            set
            {
                if (value == null)
                {
                    _numberDisplay = value;
                }
                else if (value.Length > 1 && value[1] != '.' && value.StartsWith("0"))
                {
                    label_NumberDisplay.Text = value.Substring(1);
                    _numberDisplay = value.Substring(1);
                }
                else
                {
                    label_NumberDisplay.Text = value;
                    _numberDisplay = value;
                }
            }
        }

        private string _storedOperandDisplay = "";
        public string StoredOperandDisplay
        {
            get
            {
                return _storedOperandDisplay;
            }
            set
            {
                label_StoredOperand.Text = value;
                _storedOperandDisplay = value;
            }
        }

        private double _storedOperand = 0;
        private string _storedOperation = "";

        public Form1()
        {
            InitializeComponent();
            label_NumberDisplay.Text = NumberDisplay;
            label_StoredOperand.Text = StoredOperandDisplay;
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (NumberDisplay.Length == 1)
            {
                NumberDisplay = "0";
            }
            else if (NumberDisplay.Length > 0)
            {
                NumberDisplay = NumberDisplay.Remove(NumberDisplay.Length - 1);
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (NumberDisplay == null)
            {
                _storedOperation = "+";
                StoredOperandDisplay = $"{_storedOperand} {_storedOperation}";
                return;
            }

            double number = double.Parse(NumberDisplay);

            switch (_storedOperation)
            {
                case "+":
                    _storedOperand += number;
                    break;
                case "-":
                    _storedOperand -= number;
                    break;
                case "×":
                    _storedOperand *= number;
                    break;
                case "÷":
                    _storedOperand /= number;
                    break;
                default:
                    _storedOperand = number;
                    break;
            }
            _storedOperation = "+";

            StoredOperandDisplay = $"{_storedOperand} {_storedOperation}";
            NumberDisplay = null;
        }

        private void button_Subtract_Click(object sender, EventArgs e)
        {
            if (NumberDisplay == null)
            {
                _storedOperation = "-";
                StoredOperandDisplay = $"{_storedOperand} {_storedOperation}";
                return;
            }

            double number = double.Parse(NumberDisplay);

            switch (_storedOperation)
            {
                case "+":
                    _storedOperand += number;
                    break;
                case "-":
                    _storedOperand -= number;
                    break;
                case "×":
                    _storedOperand *= number;
                    break;
                case "÷":
                    _storedOperand /= number;
                    break;
                default:
                    _storedOperand = number;
                    break;
            }
            _storedOperation = "-";

            StoredOperandDisplay = $"{_storedOperand} {_storedOperation}";
            NumberDisplay = null;
        }

        private void button_Multiply_Click(object sender, EventArgs e)
        {
            if (NumberDisplay == null)
            {
                _storedOperation = "×";
                StoredOperandDisplay = $"{_storedOperand} {_storedOperation}";
                return;
            }

            double number = double.Parse(NumberDisplay);

            switch (_storedOperation)
            {
                case "+":
                    _storedOperand += number;
                    break;
                case "-":
                    _storedOperand -= number;
                    break;
                case "×":
                    _storedOperand *= number;
                    break;
                case "÷":
                    _storedOperand /= number;
                    break;
                default:
                    _storedOperand = number;
                    break;
            }
            _storedOperation = "×";

            StoredOperandDisplay = $"{_storedOperand} {_storedOperation}";
            NumberDisplay = null;
        }

        private void button_Divide_Click(object sender, EventArgs e)
        {
            if (NumberDisplay == null)
            {
                _storedOperation = "÷";
                StoredOperandDisplay = $"{_storedOperand} {_storedOperation}";
                return;
            }

            double number = double.Parse(NumberDisplay);

            switch (_storedOperation)
            {
                case "+":
                    _storedOperand += number;
                    break;
                case "-":
                    _storedOperand -= number;
                    break;
                case "×":
                    _storedOperand *= number;
                    break;
                case "÷":
                    _storedOperand /= number;
                    break;
                default:
                    _storedOperand = number;
                    break;
            }
            _storedOperation = "÷";

            StoredOperandDisplay = $"{_storedOperand} {_storedOperation}";
            NumberDisplay = null;
        }

        private void button_Equal_Click(object sender, EventArgs e)
        {

        }

        private void button_Number1_Click(object sender, EventArgs e)
        {
            NumberDisplay += "1";
        }

        private void button_Number2_Click(object sender, EventArgs e)
        {
            NumberDisplay += "2";
        }

        private void button_Number3_Click(object sender, EventArgs e)
        {
            NumberDisplay += "3";
        }

        private void button_Number4_Click(object sender, EventArgs e)
        {
            NumberDisplay += "4";
        }

        private void button_Number5_Click(object sender, EventArgs e)
        {
            NumberDisplay += "5";
        }

        private void button_Number6_Click(object sender, EventArgs e)
        {
            NumberDisplay += "6";
        }

        private void button_Number7_Click(object sender, EventArgs e)
        {
            NumberDisplay += "7";
        }

        private void button_Number8_Click(object sender, EventArgs e)
        {
            NumberDisplay += "8";
        }

        private void button_Number9_Click(object sender, EventArgs e)
        {
            NumberDisplay += "9";
        }
        private void button_Number0_Click(object sender, EventArgs e)
        {
            if (NumberDisplay.Length > 0 && NumberDisplay != "0")
            {
                NumberDisplay += "0";
            }
        }

        private void button_Sign_Click(object sender, EventArgs e)
        {
            if (NumberDisplay == "0")
            {
                return;
            }

            if (NumberDisplay.First() != '-')
            {
                NumberDisplay = '-' + NumberDisplay;
            }
            else
            {
                NumberDisplay = NumberDisplay.Remove(0, 1);
            }
        }

        private void button_Point_Click(object sender, EventArgs e)
        {
            if (!NumberDisplay.Contains('.'))
            {
                NumberDisplay += '.';
            }
        }

        private void label_StoredOperand_Click(object sender, EventArgs e)
        {

        }

        private void label_NumberDisplay_Click(object sender, EventArgs e)
        {

        }
    }
}