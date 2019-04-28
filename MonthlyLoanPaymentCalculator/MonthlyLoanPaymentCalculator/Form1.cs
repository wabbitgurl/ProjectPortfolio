using System;
using System.Drawing;
using System.Windows.Forms;

namespace MonthlyLoanPaymentCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            /*Conversion of strings to numeric values using TryParse...*/
            string purchasePrice = txtPurchasePrice.Text;
            string downPymt = DownPayment();
            string interest = Interest();
            string term = LoanTerm();

            double.TryParse(purchasePrice, out double userLoanAmt);
            double.TryParse(downPymt, out double userDownPymt);
            double.TryParse(interest, out double userInterest);
            int.TryParse(term, out int userTerm);

            //Variables declared...
            double financeAmt = userLoanAmt - userDownPymt;
            double monthlyPymt;
            double monthlyRate = ((userInterest / 12) / 100);

        //Checking for invalid or absent input...
        if (txtPurchasePrice.Text == "" || !double.TryParse(purchasePrice, out userLoanAmt))
        {
            txtPurchasePrice.BackColor = Color.Red;
            MessageBox.Show("INVALID OR EMPTY FIELD! PLEASE TRY AGAIN!");
        }
        else if (txtInterestRate.Text == "" || !double.TryParse(interest, out userInterest))
        {
            txtInterestRate.BackColor = Color.Red;
            MessageBox.Show("INVALID OR EMPTY FIELD! PLEASE TRY AGAIN!");
        }
        else if (txtLoanTerm.Text == "" || !int.TryParse(term, out userTerm))
        {
            txtLoanTerm.BackColor = Color.Red;
            MessageBox.Show("INVALID OR EMPTY FIELD! PLEASE TRY AGAIN!");
        }

         monthlyPymt = (monthlyRate * financeAmt) / (1 - Math.Pow(1 + monthlyRate, userTerm * -1));

        /*Converting numeric values to string values for output
        and formatting output to currency...*/
        txtAmountToFinance.Text = financeAmt.ToString("c2");
        txtMonthlyPayment.Text = monthlyPymt.ToString("c2");
    }

        /*Just thought I'd give a few simple methods a try..
         They're not too much to write home about, but just
         gave it a whirl!*/

        private string DownPayment()
        {
            return txtDownPaymentAmount.Text;
        }
        private string Interest()
        {
            return txtInterestRate.Text;
        }
        private string LoanTerm()
        {
            return txtLoanTerm.Text;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for stopping by! Have a great day!");
            Application.Exit();
        }

        //Okay...this is a whoopsie and I'm not messing with it right now!
        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}

