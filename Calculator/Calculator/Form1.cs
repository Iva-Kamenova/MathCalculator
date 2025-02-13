namespace Calculator
{
    public partial class Form1 : Form
    {
        double value = 0.0;
        String operation = "";
        bool op_pressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBox.Clear();
            value = 0;
        }
        private void btnEquality_Click(object sender, EventArgs e)
        {
            string text = txtBox.Text;
            if (txtBox.Text == null || txtBox.Text == "")
            {
                text = "0";
            }
            equation.Text = "";
            switch (operation)
            {
                case "+":
                    value += Double.Parse(text);
                    break;
                case "-":
                    value -= Double.Parse(text);
                    break;
                case "*":
                    value *= Double.Parse(text);
                    break;
                case "/":
                    value /= Double.Parse(text);
                    break;
                case "%":
                    value %= Double.Parse(text);
                    break;
                default:
                    break;
            }

            txtBox.Text = value.ToString();
            op_pressed = false;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0" || op_pressed)
            {
                txtBox.Clear();
                op_pressed = false;
            }

            Button btn = (Button)sender;
            txtBox.Text += btn.Text;

        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtBox.Text = "0";
        }

        private void btnOperation_Click(object sender, EventArgs e)
        {
            Button op = (Button)sender;
            operation = op.Text;

            if(txtBox.Text == null || txtBox.Text == "")
            {
                value = 0;
            }
            else value = Double.Parse(txtBox.Text);

            op_pressed = true;
            equation.Text = value + " " + operation;
        }
    }
}
