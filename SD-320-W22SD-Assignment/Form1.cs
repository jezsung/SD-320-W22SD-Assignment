namespace SD_320_W22SD_Assignment
{
    public partial class Form1 : Form
    {
        private string _numberDisplay = "100";
        public string NumberDisplay
        {
            get
            {
                return _numberDisplay;
            }
            set
            {
                label_NumberDisplay.Text = value;
                _numberDisplay = value;
            }
        }

        public Form1()
        {
            InitializeComponent();
            label_NumberDisplay.Text = NumberDisplay;
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (NumberDisplay.Length > 0)
            {
                NumberDisplay = NumberDisplay.Remove(NumberDisplay.Length - 1);
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {

        }

        private void button_Subtract_Click(object sender, EventArgs e)
        {

        }

        private void button_Multiply_Click(object sender, EventArgs e)
        {

        }

        private void button_Divide_Click(object sender, EventArgs e)
        {

        }

        private void button_Equal_Click(object sender, EventArgs e)
        {

        }

        private void button_Number1_Click(object sender, EventArgs e)
        {

        }

        private void button_Number2_Click(object sender, EventArgs e)
        {

        }

        private void button_Number3_Click(object sender, EventArgs e)
        {

        }

        private void button_Number4_Click(object sender, EventArgs e)
        {

        }

        private void button_Number5_Click(object sender, EventArgs e)
        {

        }

        private void button_Number6_Click(object sender, EventArgs e)
        {

        }

        private void button_Number7_Click(object sender, EventArgs e)
        {

        }

        private void button_Number8_Click(object sender, EventArgs e)
        {

        }

        private void button_Number9_Click(object sender, EventArgs e)
        {

        }
        private void button_Number0_Click(object sender, EventArgs e)
        {

        }

        private void button_Sign_Click(object sender, EventArgs e)
        {

        }

        private void button_Point_Click(object sender, EventArgs e)
        {

        }

        private void label_StoredOperand_Click(object sender, EventArgs e)
        {

        }

        private void label_NumberDisplay_Click(object sender, EventArgs e)
        {

        }
    }
}