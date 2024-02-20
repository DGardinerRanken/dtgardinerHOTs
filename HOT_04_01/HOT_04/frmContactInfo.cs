namespace HOT_04
{
    public partial class frmContactInfo : Form
    {

        const string UNF = "User Not Found";
        const string FN = "First Name:\t";
        const string LN = "Last Name:\t";
        const string PN = "Phone Number:\t";

        string[] firstNames = {"Markel","Luiza","Bryony","Giraldo","Lowri"};
        string[] lastNames = { "Diggory", "Gunnar", "Hester", "Addy", "Hari" };
        string[] phoneNumbers = {"555-8390","555-4618","555-4440","555-1687","555-7763" };
        public frmContactInfo()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool keepGoing = CheckForInput();
            if (keepGoing)
            {
                PerformSearch();
            }
        }
        private bool CheckForInput()
        {
            bool retVal = true;
            string term = txtSearchTerm.Text.Trim();

            //Check for No Input
            if (term == "")
            {
                ShowErrorMessage("You Must Enter A Search Term", "SEARCH TERM EMPTY");

                ClearAll();
                retVal = false;
            }
            return retVal;
        }
        private void PerformSearch()
        {
            string term = txtSearchTerm.Text.Trim();
            bool isFound = false;
            int ind = -1;
            string outputStr = "";

            for (int lcv = 0; lcv < firstNames.Length; lcv++)
            {
                //Searching all arrays to look for search term
                if (firstNames[lcv].ToLower().Contains(term.ToLower())||
                    lastNames[lcv].ToLower().Contains(term.ToLower()))
                {
                    isFound = true;
                    ind = lcv;
                    break;
                } 
            }
            //Match found
            if (isFound)
            {
                outputStr += ($"{FN} {firstNames[ind]}\r\n");
                outputStr += ($"{LN} {lastNames[ind]}\r\n");
                outputStr += ($"{PN} {phoneNumbers[ind]}\r\n");
            }
            else //Match not found
            {
                outputStr += ($"{FN} Error\r\n");
                outputStr += ($"{LN} Error\r\n");
                outputStr += ($"{PN} Error\r\n");

                lblNotFound.Text = "USER NOT FOUND";
            }
            txtResult.Text = outputStr;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        private void ClearAll()
        {
            txtResult.Text = string.Empty;
            txtSearchTerm.Text = string.Empty;
            txtSearchTerm.Focus();
            lblNotFound.Text = string.Empty;
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
