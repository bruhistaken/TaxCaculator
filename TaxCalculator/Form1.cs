namespace TaxCalculator
{
    //
    //  Name: tim 
    //  Date 12/5/23
    //  Assignment:Modified Tax Calculator
    //

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal income = Convert.ToDecimal(txtIncome.Text);
            decimal tax = CalculateTax(income);
            txtTax.Text = tax.ToString();
        }

        private decimal CalculateTax(decimal income)
        {
            decimal tax = 0m;

            if (income <= 11000)
                tax = (decimal)(income * .10m);
            else if (income > 11000 && income <= 44725)
                tax = 1100m + (decimal)((income - 11000) * .12m);
            else if (income > 44725 && income <= 95375)
                tax = 5147m + (decimal)((income - 44725) * .22m);
            else if (income > 95375 && income <= 182100)
                tax = 16290m + (decimal)((income - 95375) * .24m);
            else if (income > 182100 && income <= 231250)
                tax = 37104m + (decimal)((income - 182100) * .32m);
            else if (income > 231250 && income <= 578125)
                tax = 52832m + (decimal)((income - 231250) * .35m);
            else if (income > 578125)
                tax = 174238.25m + (decimal)((income - 578125) * .37m);

            return tax;
        }

        private void txtIncome_TextChanged(object sender, EventArgs e)
        {
            txtTax.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

