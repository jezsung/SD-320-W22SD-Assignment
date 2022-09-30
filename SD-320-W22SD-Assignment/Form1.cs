namespace SD_320_W22SD_Assignment
{
    public partial class Form1 : Form
    {
        private string _numberDisplay = "";
        private double? _storedOperand = null;
        private string? _storedOperation = null;

        public Form1()
        {
            InitializeComponent();

            KeyPreview = true;
            KeyDown += new KeyEventHandler(Form1_KeyPress);

            label_NumberDisplay.Text = "";
            label_StoredOperand.Text = "";
        }

        void Form1_KeyPress(object sender, KeyEventArgs e)
        {           
            switch (e.KeyCode)
            {
                case Keys.D1:
                    button_Number1_Click(sender, e);
                    break;
                case Keys.D2:
                    button_Number2_Click(sender, e);
                    break;
                case Keys.D3:
                    button_Number3_Click(sender, e);
                    break;
                case Keys.D4:
                    button_Number4_Click(sender, e);
                    break;
                case Keys.D5:
                    button_Number5_Click(sender, e);
                    break;
                case Keys.D6:
                    button_Number6_Click(sender, e);
                    break;
                case Keys.D7:
                    button_Number7_Click(sender, e);
                    break;
                case Keys.D8:
                    button_Number8_Click(sender, e);
                    break;
                case Keys.D9:
                    button_Number9_Click(sender, e);
                    break;
                case Keys.D0:
                    button_Number0_Click(sender, e);
                    break;
                case Keys.OemPeriod:
                    button_Point_Click(sender, e);
                    break;
                case Keys.Oemplus:
                    button_Add_Click(sender, e);
                    break;
                case Keys.OemMinus:
                    button_Subtract_Click(sender, e);
                    break;
                case Keys.X:
                    button_Multiply_Click(sender, e);
                    break;
                case Keys.OemQuestion:
                    button_Divide_Click(sender, e);
                    break;
                case Keys.Enter:
                    button_Equal_Click(sender, e);
                    break;
                case Keys.Back:
                    button_Delete_Click(sender, e);
                    break;
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (_numberDisplay.Length == 0)
            {
                return;
            }

            if (_numberDisplay.Length > 0)
            {
                _numberDisplay = _numberDisplay.Remove(_numberDisplay.Length - 1);
                label_NumberDisplay.Text = _numberDisplay;
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (_numberDisplay.Length == 0)
            {
                _storedOperation = "+";

                label_StoredOperand.Text = $"{_storedOperand} {_storedOperation}";
                label_NumberDisplay.Text = "";

                return;
            }

            double number = double.Parse(_numberDisplay);

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

            _numberDisplay = "";
            _storedOperation = "+";

            label_StoredOperand.Text = $"{_storedOperand} {_storedOperation}";
            label_NumberDisplay.Text = "";
        }

        private void button_Subtract_Click(object sender, EventArgs e)
        {
            if (_numberDisplay.Length == 0)
            {
                _storedOperation = "-";

                label_StoredOperand.Text = $"{_storedOperand} {_storedOperation}";
                label_NumberDisplay.Text = "";

                return;
            }

            double number = double.Parse(_numberDisplay);

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

            _numberDisplay = "";
            _storedOperation = "-";

            label_StoredOperand.Text = $"{_storedOperand} {_storedOperation}";
            label_NumberDisplay.Text = "";
        }

        private void button_Multiply_Click(object sender, EventArgs e)
        {
            if (_numberDisplay.Length == 0)
            {
                _storedOperation = "×";

                label_StoredOperand.Text = $"{_storedOperand} {_storedOperation}";
                label_NumberDisplay.Text = "";

                return;
            }

            double number = double.Parse(_numberDisplay);

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

            _numberDisplay = "";
            _storedOperation = "×";

            label_StoredOperand.Text = $"{_storedOperand} {_storedOperation}";
            label_NumberDisplay.Text = "";
        }

        private void button_Divide_Click(object sender, EventArgs e)
        {
            if (_numberDisplay.Length == 0)
            {
                _storedOperation = "÷";

                label_StoredOperand.Text = $"{_storedOperand} {_storedOperation}";
                label_NumberDisplay.Text = "";

                return;
            }

            double number = double.Parse(_numberDisplay);

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

            _numberDisplay = "";
            _storedOperation = "÷";

            label_StoredOperand.Text = $"{_storedOperand} {_storedOperation}";
            label_NumberDisplay.Text = "";
        }

        private void button_Equal_Click(object sender, EventArgs e)
        {
            if (_storedOperand == null || _storedOperation == null || _numberDisplay.Length == 0)
            {
                return;
            }

            double number = double.Parse(_numberDisplay);
            double result = 0;

            switch (_storedOperation)
            {
                case "+":
                    result = (double)(_storedOperand + number);
                    break;
                case "-":
                    result = (double)(_storedOperand - number);
                    break;
                case "×":
                    result = (double)(_storedOperand * number);
                    break;
                case "÷":
                    result = (double)(_storedOperand / number);
                    break;
            }

            _numberDisplay = "";
            _storedOperand = result;
            _storedOperation = null;

            label_StoredOperand.Text += $" {number} = ";
            label_NumberDisplay.Text = result.ToString();
        }

        private void button_Number1_Click(object sender, EventArgs e)
        {
            if (_storedOperation == null)
            {
                label_StoredOperand.Text = "";
            }

            _numberDisplay = _numberDisplay == "0" ? "1" : _numberDisplay + "1";

            label_NumberDisplay.Text = _numberDisplay;
        }

        private void button_Number2_Click(object sender, EventArgs e)
        {
            if (_storedOperation == null)
            {
                label_StoredOperand.Text = "";
            }

            _numberDisplay = _numberDisplay == "0" ? "2" : _numberDisplay + "2";

            label_NumberDisplay.Text = _numberDisplay;
        }

        private void button_Number3_Click(object sender, EventArgs e)
        {
            if (_storedOperation == null)
            {
                label_StoredOperand.Text = "";
            }

            _numberDisplay = _numberDisplay == "0" ? "3" : _numberDisplay + "3";

            label_NumberDisplay.Text = _numberDisplay;
        }

        private void button_Number4_Click(object sender, EventArgs e)
        {
            if (_storedOperation == null)
            {
                label_StoredOperand.Text = "";
            }

            _numberDisplay = _numberDisplay == "0" ? "4" : _numberDisplay + "4";

            label_NumberDisplay.Text = _numberDisplay;
        }

        private void button_Number5_Click(object sender, EventArgs e)
        {
            if (_storedOperation == null)
            {
                label_StoredOperand.Text = "";
            }

            _numberDisplay = _numberDisplay == "0" ? "5" : _numberDisplay + "5";

            label_NumberDisplay.Text = _numberDisplay;
        }

        private void button_Number6_Click(object sender, EventArgs e)
        {
            if (_storedOperation == null)
            {
                label_StoredOperand.Text = "";
            }

            _numberDisplay = _numberDisplay == "0" ? "6" : _numberDisplay + "6";

            label_NumberDisplay.Text = _numberDisplay;
        }

        private void button_Number7_Click(object sender, EventArgs e)
        {
            if (_storedOperation == null)
            {
                label_StoredOperand.Text = "";
            }

            _numberDisplay = _numberDisplay == "0" ? "7" : _numberDisplay + "7";

            label_NumberDisplay.Text = _numberDisplay;
        }

        private void button_Number8_Click(object sender, EventArgs e)
        {
            if (_storedOperation == null)
            {
                label_StoredOperand.Text = "";
            }

            _numberDisplay = _numberDisplay == "0" ? "8" : _numberDisplay + "8";

            label_NumberDisplay.Text = _numberDisplay;
        }

        private void button_Number9_Click(object sender, EventArgs e)
        {
            if (_storedOperation == null)
            {
                label_StoredOperand.Text = "";
            }

            _numberDisplay = _numberDisplay == "0" ? "9" : _numberDisplay + "9";

            label_NumberDisplay.Text = _numberDisplay;
        }
        private void button_Number0_Click(object sender, EventArgs e)
        {
            if (_storedOperation == null)
            {
                label_StoredOperand.Text = "";
            }

            if (_numberDisplay != "0")
            {
                _numberDisplay += "0";

                label_NumberDisplay.Text = _numberDisplay;
            }
        }

        private void button_Sign_Click(object sender, EventArgs e)
        {
            if (_storedOperation == null)
            {
                label_StoredOperand.Text = "";
            }

            if (_numberDisplay.Length == 0 || _numberDisplay == "0")
            {
                return;
            }

            if (_numberDisplay.First() != '-')
            {
                _numberDisplay = '-' + _numberDisplay;
            }
            else
            {
                _numberDisplay = _numberDisplay.Remove(0, 1);
            }

            label_NumberDisplay.Text = _numberDisplay;
        }

        private void button_Point_Click(object sender, EventArgs e)
        {
            if (_storedOperation == null)
            {
                label_StoredOperand.Text = "";
            }

            if (_numberDisplay.Length == 0)
            {
                _numberDisplay = "0.";

                label_NumberDisplay.Text = _numberDisplay;
            }

            if (!_numberDisplay.Contains('.'))
            {
                _numberDisplay += '.';

                label_NumberDisplay.Text = _numberDisplay;
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