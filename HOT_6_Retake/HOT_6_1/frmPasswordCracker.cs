using System.Security.Policy;

namespace HOT_6_1
{
    public partial class frmPasswordCracker : Form
    {
        //Declare and initialize global constant
        const string F = "* FAIL *";

        //Declare and initialize class variable
        List<Password> passwords = new List<Password>();

        
        


        public frmPasswordCracker()
        {
            //Initialize all MD5 Hashes
            InitializeComponent();
            passwords.Add(new Password("123456", "e10adc3949ba59abbe56e057f20f883e"));
            passwords.Add(new Password("123456789", "25f9e794323b453885f5181f1b624d0b"));
            passwords.Add(new Password("qwerty", "d8578edf8458ce06fbc5bb76a58c5ca4"));
            passwords.Add(new Password("111111", "96e79218965eb72c92a549dd5a330112"));
            passwords.Add(new Password("password", "5f4dcc3b5aa765d61d8327deb882cf99"));
            passwords.Add(new Password("qwertyuiop", "6eea9b7ef19179a06954edd0f6c05ceb"));
            passwords.Add(new Password("123321", "c8837b23ff8aaa8a2dde915473ce0991"));
            passwords.Add(new Password("google", "c822c1b63853ed273b89687ac505f9fa"));
            passwords.Add(new Password("P@ssw0rd", "161ebd7d45089b3446ee4e0d86dbcf92"));
            passwords.Add(new Password("Tr0ub4dor&3", "4ece57a61323b52ccffdbef021956754"));
        }
        private void btnCrack_Click(object sender, EventArgs e)
        {
            int lcv = DoesHashExist();
            CrackPassword(lcv);
        }

        private int DoesHashExist()
        {
            string hash = txtMD5Hash.Text.Trim();
            

            //Search through the list, looking for a match
            for (int lcv = 0; lcv < passwords.Count; lcv++)
            {
                //If a match is found, return the lcv
                if (hash == passwords[lcv].Hash)
                {
                    return lcv;
                }
            }

            //If no match was found, return -1
            return -1;
        }

        private void CrackPassword(int lcv)
        {
            if (lcv == -1) 
            { 
                lblResult.Text = F;
            }
            else
            {
                lblResult.Text = passwords[lcv].Raw;
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            txtMD5Hash.Text = string.Empty;
            lblAssociatedPassword.Text = string.Empty;
            txtMD5Hash.Focus();
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
