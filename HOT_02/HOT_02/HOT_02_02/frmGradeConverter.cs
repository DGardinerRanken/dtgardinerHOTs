//Write a GUI-based program that asks the user for a GPA between 0.0-4.0 (use constants)
//and converts it to a letter grade using the following conversion table (make GPA a decimal value):

namespace HOT_02_02
{
    public partial class frmGradeConverter : Form
    {

        //Declare and initilize program constants
        const decimal GRADEA = 3.01m;
        const decimal GRADEB = 2.01m;
        const decimal GRADEC = 1.01m;
        const decimal GRADED = 0.01m;
        const decimal GRADEF = 0.0m;
        const decimal MAXGRADE = 4.0m;
        const decimal MINGRADE = 0.0m;
        const string FCBN = "Field must be numerical and not negative";
        const string EII = "Error in Input";
        const string EI = "Input is Empty";
        const string OORI = "Input is Out of Range (4.0 - 0.0)";
        
        //Declare and Initialize program variables
        decimal Gpa = 0m;
        decimal Grade = 0m;

        public frmGradeConverter()
        {
            InitializeComponent();
        }

        private void btnLetterGrade_Click(object sender, EventArgs e)
        {
            CalculateLetterGrade();
        }
        private void CalculateLetterGrade()
        {
            bool result;
            string GPAStr = txtGPA.Text.Trim();

            //Checking for no input
            if (GPAStr == "")
            {
                ShowErrorMessage(EI, EII);
                return;
            }

            //Validating the input is numeric
            result = decimal.TryParse(GPAStr, out Gpa);
            if (!result)
            {
                ShowErrorMessage(FCBN, EII);
                txtGPA.Text = string.Empty;
                txtGPA.Focus();
                return;
            }

            //Validating GPA is within 4.0-0.0

            if (Gpa < MINGRADE || Gpa > MAXGRADE)
            {
                ShowErrorMessage(OORI, EII);
                txtGPA.Text = string.Empty;
                txtGPA.Focus();
            }

            //Calculate Letter Grade

            if (Gpa >= GRADEA)
            {
                lblResult.Text = ($"GPA: {Gpa} Letter Grade: A");
            }
            else if (Gpa >= GRADEB) 
            {
                lblResult.Text = ($"GPA: {Gpa} Letter Grade: B");
            }
            else if ( Gpa >= GRADEC)
            {
                lblResult.Text = ($"GPA: {Gpa} Letter Grade: C ");
            }
            else if (Gpa >= GRADED)
            {
                lblResult.Text = ($"GPA: {Gpa} Letter Grade: D ");
            } 
            else
            {
                lblResult.Text = ($"GPA: {Gpa} Letter Grade: F ");
            }

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            txtGPA.Text = string.Empty;
            txtGPA.Focus();
            lblResult.Text = string.Empty;
        }
    }
}
