namespace MyCalculator
{
    public partial class Form1 : Form
    {
        ICalculator calculate;
        public Form1()
        {
            InitializeComponent();
            calculate = new Calculate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPlusClick(object sender, EventArgs e)
        {
            if (validateInput())
            {
                int sum = calculate.plus((int)txtNum1.Value, (int)txtNum2.Value);
                MessageBox.Show("Sum is : " + sum);
            }
        }

        private void btnMinusClick(object sender, EventArgs e)
        {
            if (validateInput())
            {
                int sum = calculate.minus((int)txtNum1.Value, (int)txtNum2.Value);
                MessageBox.Show("Sum is : " + sum);
            }
        }

        private void btnMultiplyClick(object sender, EventArgs e)
        {
            if (validateInput())
            {
                int sum = calculate.multiple((int)txtNum1.Value, (int)txtNum2.Value);
                MessageBox.Show("Sum is : " + sum);
            }
        }

        private void btnDivideClick(object sender, EventArgs e)
        {
            if (validateInput())
            {
                int sum = calculate.divide((int)txtNum1.Value, (int)txtNum2.Value);
                MessageBox.Show("Sum is : " + sum);
            }
        }

        bool validateInput()
        {
            bool isValidate = true;

            if (txtNum1.Value == 0)
            {
                isValidate = false;
                MessageBox.Show("لطفا عدد اول را وارد کنید");
            }
            else if (txtNum2.Value == 0)
            {
                isValidate = false;
                MessageBox.Show("لطفا عدد دوم را وارد کنید");
            }

            return isValidate;
        }
    }
}