using System.Xml.Serialization;

namespace HOT_02_03
{
    public partial class frmGregsLawncare : Form
    {
        //Declare and Initialize Program Constants
        const decimal HIGHEST = 600m;
        const decimal MIDDLE = 400m;
        const decimal LOWEST = 399m;
        const string LFCBN = "Length Field must be numerical and not negative";
        const string WFCBN = "Width Field must be numerical and not negative";
        const string EII = "Error in Input";
        const string WIE = "Width Input is Empty";
        const string LIE = "Length Input is Empty";

        //Declare and Initialize class Variables
        decimal length = 0m;
        decimal width = 0m;
        decimal squareFeet = 0m;
        public frmGregsLawncare()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            CalculatePricing();
        }
        private void CalculatePricing()
        {
            bool result;
            string lengthStr = txtLength.Text.Trim();
            string widthStr = txtWidth.Text.Trim();

            //Checking for no input
            if (lengthStr == "")
            {
                ShowErrorMessage(LIE, EII);
                return;
            }
            if (widthStr == "")
            {
                ShowErrorMessage(WIE, EII);
                return;
            }

            //Validating values are numerical and positive

            result = decimal.TryParse(lengthStr, out length);
            if (!result || length < 0)
            {
                ShowErrorMessage(LFCBN, EII);
                txtLength.Text = string.Empty;
                txtLength.Focus();
                return;
            }
            result = decimal.TryParse(widthStr, out width);
            if (!result || width < 0)
            {
                ShowErrorMessage(WFCBN, EII);
                txtWidth.Text = string.Empty;
                txtWidth.Focus();
                return;
            }

            //Calculate Pricing
            squareFeet = length * width;
            if (squareFeet >= HIGHEST)
            {
                lblArea.Text = ($"Area: {squareFeet} sq feet");
                lblWeeklyFee.Text = ($"Weekly Fee: $50");
                lblSeasonLength.Text = ("Season Length: 20 Weeks");
                lblTotalCost.Text = "Total Cost: $1000";
            }
            else if (squareFeet >= MIDDLE) 
            {
                lblArea.Text = ($"Area: {squareFeet} sq feet");
                lblWeeklyFee.Text = ($"Weekly Fee: $35");
                lblSeasonLength.Text = ("Season Length: 20 Weeks");
                lblTotalCost.Text = "Total Cost: $700";
            } 
            else
            {
                lblArea.Text = ($"Area: {squareFeet} sq feet");
                lblWeeklyFee.Text = ($"Weekly Fee: $25");
                lblSeasonLength.Text = ("Season Length: 20 Weeks");
                lblTotalCost.Text = "Total Cost: $500";
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        private void ClearAll()
        {
            txtLength.Text = string.Empty;
            txtWidth.Text = string.Empty;  
            txtLength.Focus();
            lblArea.Text = string.Empty;
            lblSeasonLength.Text = string.Empty;
            lblTotalCost.Text = string.Empty;
            lblWeeklyFee.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitProgramOrNot();
        }
        private void ExitProgramOrNot()
        {
            DialogResult dialog = MessageBox.Show(
            "Are You Sure You Want To Exit The Program?",
            "EXIT NOW?",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void ShowErrorMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }
    }
}
