namespace Calculator.WindowsFormsApp
{
    public enum Operation
    {
        None,
        Addition,
        Subtraction,
        Multiplication,
        Division,
        Modulus
    }
    public partial class Form1 : Form
    {
        private string _firstValue;
        private string _secondValue;
        private Operation _currentOperation = Operation.None;

        public Form1()
        {
            InitializeComponent();
            tbScreen.Text = "0";
        }
    
        private void Form1_Load(object sender, System.EventArgs e)
        {
        }

        private void OnButtonNumberClick(object sender, EventArgs e)
        {
            var clickedValue = (sender as Button).Text;

            if (tbScreen.Text == "0")
                tbScreen.Text = String.Empty;

            tbScreen.Text += clickedValue;

            if (_currentOperation != Operation.None)
                _secondValue += clickedValue;
        }

        private void OnButtonOperationClick(object sender, EventArgs e)
        {
            _firstValue = tbScreen.Text;

            var clickedOperation = (sender as Button).Text;

            _currentOperation = clickedOperation switch
            {
                "+" => Operation.Addition,
                "-" => Operation.Subtraction,
                "x" => Operation.Multiplication,
                "/" => Operation.Division,
                "%" => Operation.Modulus,
                _ => Operation.None,
            };

            tbScreen.Text += $" {clickedOperation} ";
        }

        private void OnButtonResultClick(object sender, EventArgs e)
        {
            var firstNumber = double.Parse(_firstValue);
            var secondNumber = double.Parse(_secondValue);

            var result = Calculate(firstNumber, secondNumber);

            tbScreen.Text = result.ToString();
            _secondValue = String.Empty;
            _currentOperation = Operation.None;

        }

        private double Calculate (double firstNumber, double secondNumber)
        {
            switch (_currentOperation)
            {
                case Operation.None:
                    return firstNumber;
                case Operation.Addition:
                    return firstNumber + secondNumber;
                case Operation.Subtraction:
                    return firstNumber - secondNumber;
                case Operation.Multiplication:
                    return firstNumber * secondNumber;
                case Operation.Division:
                    if (secondNumber == 0)
                    {
                        MessageBox.Show("Nie mo�na dzieli� przez zero");
                        return 0;
                    }
                    return firstNumber / secondNumber;
                case Operation.Modulus:
                    return firstNumber % secondNumber;
            }
            return 0;
        }

        private void OnButtonClearClick(object sender, EventArgs e)
        {

        }

        private void OnButtonNegativeClick(object sender, EventArgs e)
        {

        }

        private void OnButtonDeleteClick(object sender, EventArgs e)
        {

        }

        private void OnButtonCommaClick(object sender, EventArgs e)
        {

        }
    }
}