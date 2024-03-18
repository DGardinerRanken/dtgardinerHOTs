namespace HOT_6_1
{
    public partial class frmPasswordCracker : Form
    {
        const string HNF = "* FAIL *";
        public string[] passwords = { "123456", "123456789", "qwerty", "111111",
                                      "password","qwertyuiop","123321","google",
                                      "P@ssw0rd","Tr0ub4dor&3" };
        public string[] hashes = { "e10adc3949ba59abbe56e057f20f883e",
                                 "25f9e794323b453885f5181f1b624d0b",
                                 "d8578edf8458ce06fbc5bb76a58c5ca4",
                                 "96e79218965eb72c92a549dd5a330112",
                                 "5f4dcc3b5aa765d61d8327deb882cf99",
                                 "6eea9b7ef19179a06954edd0f6c05ceb",
                                 "c8837b23ff8aaa8a2dde915473ce0991",
                                 "c822c1b63853ed273b89687ac505f9fa",
                                 "161ebd7d45089b3446ee4e0d86dbcf92",
                                 "4ece57a61323b52ccffdbef021956754" };


        public frmPasswordCracker()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        private void ClearAll()
        {
            txtMD5Hash.Text = string.Empty;
            txtMD5Hash.Focus();
            lblResult.Text = string.Empty;
        }
        private void btnCrack_Click(object sender, EventArgs e)
        {
            PasswordCracker();
        }

        private void PasswordCracker()
        {
            string hashGuessStr = txtMD5Hash.Text.Trim();
            bool isFound = false;
            int ind = -1;
            string outputStr = string.Empty;
            //Check for No Input

            if (string.IsNullOrEmpty(hashGuessStr))
            {
                ShowErrorMessage("You Must Enter An MD5 Hash Code", "NO HASH CODE ENTERED");
                return;
            }

            //Input Detected

            for (int lcv = 0; lcv < hashes.Length; lcv++)
            {
                //Searching array for a match
                if (hashes[lcv].ToLower().Contains(hashGuessStr.ToLower()))
                {
                    isFound = true;
                    ind = lcv;
                    break;
                }
            }
            

            if (isFound)
            {
                outputStr += passwords[ind];
            }
            else
            {
                outputStr += HNF;
            }

            lblResult.Text = outputStr;
           
        }
        private void ShowErrorMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

    }
}
