using System.Runtime.InteropServices.JavaScript;
using System.Xml.Linq;
using System;
using System.Windows.Forms;

namespace LoanCompany
{

    //1.	The lender provides two types of loans.Short-Term and Long-Term loans.
    //2.	Short-Term loans have a monthly payment of $450 and an interest rate of 10%.
    //3.	Long-Term loans have a monthly payment of $200 and an interest rate of 5%.
    //4.	The program will allow the user to enter a loan name, amount, and type.
    //5.	Once the loan has been created the user can make payments on the loan and see
    //      the current balance before and after interest is applied
    //6.	The program should display an error message if a negative loan amount is entered.


    //I'm going to have to redo this test as I'm not happy whatsoever with how it has ended up,
    //I have been in seattle over this past week and it has kind of thrown me off, not that that is a good excuse.
    public partial class frmLoanCompany : Form
    {
        //Declare and Initialize Program Constants
        const decimal SHORTTERMLOANPAYMENT = 450m;
        const decimal LONGTERMLOANPAYMENT = 200m;

        //
        private string name = string.Empty;
        private string type = string.Empty;
        private decimal balance = 0m;
        private decimal newBalance = 0m;
        private decimal newBalanceWInterest = 0m;

        public frmLoanCompany()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateLoan();

        }
        private void CreateLoan()
        {
            balance = Convert.ToDecimal(txtAmount.Text.Trim());
           
            if (rbShortTerm.Checked )
            {
                type = "Short-Term Loan";
            }
            else if (rbLongTerm.Checked )
            {
                type = "Long-Term Loan";
            }

            lblLoanName.Text = ($"{txtName.Text}");
            lblLoanType.Text = ($"{type} of {balance:c}");
        }

        private void btnMakePayment_Click(object sender, EventArgs e)
        {
            ClearLabels();
            MakeAPayment();
            
        }

        private void ClearLabels()
        {
            lblLoanAmountRemaining.Text = "";
            lblAmountAfterInterest.Text = "";
        }
        private void MakeAPayment()
        {

            if (type == "Short-Term Loan")
            {
                balance = balance - SHORTTERMLOANPAYMENT;
                
                newBalanceWInterest = (balance * 1.10m);
                
                
                
            }
            else if (type == "Long-Term Loan")
            {
                balance = balance - LONGTERMLOANPAYMENT;
                newBalanceWInterest = (balance * 1.05m);
                
            }

            lblLoanAmountRemaining.Text = ($"After the last payment the loan is down to {balance:c}");
            lblAmountAfterInterest.Text = ($"After the last interest accumulation the loan is now {newBalanceWInterest:c}");
        }

        private void ShowErrorMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }
    }
}
