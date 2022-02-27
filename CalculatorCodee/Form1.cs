namespace CalculatorCodee
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPreformed = "";
        bool isOperationPreformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || (isOperationPreformed))
                textBox_Result.Clear();

            isOperationPreformed = false;
            Button button = (Button)sender;
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            
            Button button = (Button)sender;
            operationPreformed = button.Text;
            resultValue = Double.Parse(textBox_Result.Text);
            labelCurrentOpertaion.Text = resultValue + " " + operationPreformed;
            isOperationPreformed = true;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
             
            if (!string.IsNullOrWhiteSpace(textBox_Result.Text))
            {
                textBox_Result.Text = textBox_Result.Text.Remove(textBox_Result.Text.Length - 1);

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            switch(operationPreformed)
            {
                case "+":
                    textBox_Result.Text = (resultValue + Double.Parse(textBox_Result.Text)).ToString();
                    break;

                case "-":
                    textBox_Result.Text = (resultValue - Double.Parse(textBox_Result.Text)).ToString();
                    break;

                case "*":
                    textBox_Result.Text = (resultValue * Double.Parse(textBox_Result.Text)).ToString();
                    break;

                case "/":
                    textBox_Result.Text = (resultValue / Double.Parse(textBox_Result.Text)).ToString();
                    break;

                default:
                    break;

            }
        }
    }
}