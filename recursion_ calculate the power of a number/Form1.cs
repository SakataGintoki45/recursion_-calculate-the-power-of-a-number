namespace recursion__calculate_the_power_of_a_number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double PowerRecursive(double baseNumber, int exponent)
        {
            if (exponent == 0) 
                return 1;
            if (exponent < 0) 
                return 1 / PowerRecursive(baseNumber, -exponent);

            return baseNumber * PowerRecursive(baseNumber, exponent - 1);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtBase.Text, out double baseNumber) &&
               int.TryParse(txtExponent.Text, out int exponent)) 
            {
                double result = PowerRecursive(baseNumber, exponent);
                lblResult.Text = $"Result: {baseNumber}^{exponent} = {result}";
            }
            else
            {
                MessageBox.Show("Please enter valid numbers.");
            }
        }
    }
}
