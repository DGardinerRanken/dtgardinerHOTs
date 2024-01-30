//  Write a GUI-based program that converts distances between inches and yards.
//  The program must contain a constant named INCHES_PER_YD which holds the number of inches per yard (36 inches = 1 yard).
//	Prompt the user for a distance in inches.
//	Once the user presses a button, display the distance in both inches and yards as follows: 
//  72 inches = 2 yards(make both inches and yards decimal values).NOT SHOWN BELOW but please format each value to 2 decimal places. Thank you.


namespace HOT_02_01
{
    public partial class frmInchYardConverter : Form
    {

        //Declare and Initialize Program Constants
        const decimal INCHES_PER_YARD = 36m;
        const string FCBN = "Field must be numerical and not negative";
        const string EII = "Error in Input";
        const string EI = "Input is Empty";

        //Declare and Initialize Program Variables
        decimal inches = 0m;
        decimal yards = 0m;
        public frmInchYardConverter()
        {
            InitializeComponent();
        }

        private void btnConvertToYards_Click(object sender, EventArgs e)
        {
            CalculateYards();
        }

        private void CalculateYards()
        {
            bool result;
            string inchesStr = txtDistanceInches.Text.Trim();

            //Check for No Input

            if (inchesStr == "")
            {
                ShowErrorMessage(EI, EII);
                return;
            }

            //Validate Input, checking for numeric and positive
            result = decimal.TryParse(inchesStr, out inches);
            if (!result || inches < 0) 
            {
                ShowErrorMessage(FCBN, EII);
                txtDistanceInches.Text = string.Empty;
                txtDistanceInches.Focus();
                return;
            }

            //Calculate Yards
            yards = inches / INCHES_PER_YARD;

            lblResult.Text = ($"{inches:n2} inches is {yards:n2} yards.");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDistanceInches.Text = string.Empty;
            txtDistanceInches.Focus();
            lblResult.Text = string.Empty;
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
