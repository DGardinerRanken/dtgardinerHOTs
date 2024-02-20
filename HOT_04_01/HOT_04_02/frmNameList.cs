namespace HOT_04_02
{
    public partial class frmNameList : Form
    {
        public frmNameList()
        {
            InitializeComponent();
        }

        private void btnAddName_Click(object sender, EventArgs e)
        {
            AddName();
        }
        private void AddName()
        {
            bool keepGoing = CheckForInput();
            if (keepGoing)
            {
                AddNameToList();
            }

        }
        private bool CheckForInput()
        {
            bool retVal = true;
            string name = txtEnterAName.Text.Trim();

            //Check for No Input
            if (name == "")
            {
                ShowErrorMessage("You Must Enter A Name", "SEARCH TERM EMPTY");

                ClearAll();
                retVal = false;
            }
            return retVal;
        }
        private void AddNameToList()
        {
            //I was working on trying to figure out the duplicate names for a while, though I could not figure anything out.
           

            string name = txtEnterAName.Text.ToUpper();
            

            lb_Names.Items.Add(name);
            txtEnterAName.Text = "";
            txtEnterAName.Focus();
        }
        private void btnUpdateName_Click(object sender, EventArgs e)
        {
            int selectedIndex = lb_Names.SelectedIndices[0];
            lb_Names.Items.RemoveAt(selectedIndex);
            lb_Names.Items.Insert(selectedIndex, txtEnterAName.Text.ToUpper());
              
        }

        private void btnDeleteName_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to delete this name?",
                                             "DELETING A NAME", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                int selectedName = lb_Names.SelectedIndices[0];
                lb_Names.Items.RemoveAt(selectedName);
            }
            else
            {
                return;
            } 
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        private void ClearAll()
        {
            txtEnterAName.Text = string.Empty;
            txtEnterAName.Focus();
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
