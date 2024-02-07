using Microsoft.VisualBasic;
using System.Drawing.Text;

namespace HOT_03_01
{
    public partial class frmCustomDesks : Form
    {
        int CostOfWood = 0;
        int CostOfDrawers = 0;
        int NumOfDrawers = 0;
        string woodInitialStr = "";
        string woodTypeStr = "";
        string DrawerAmountStr = "";
        decimal TotalCost = 0m;

        //I apolgize for having to use Global variables, I could not see a way to do it without.
        public frmCustomDesks()
        {
            InitializeComponent();
        }

        private void btnEstimate_Click(object sender, EventArgs e)
        {
            GetWood();
            GetDrawers();
        }
        private void GetWood()
        {
            woodInitialStr = txtTypeOfWood.Text.Trim().ToUpper();
            IsValidWoodType();
            
        }
        private void GetDrawers()
        {
            DrawerAmountStr = txtNumberOfDrawers.Text;
            
            IsValidDrawers();
        }
        private bool IsValidDrawers()
        {
            bool success = true;
            string errorMessage = "";
            errorMessage += IsPresent2(txtNumberOfDrawers.Text, "Entry Error");
            errorMessage += IsInt32(txtNumberOfDrawers.Text, "Entry Error");
            errorMessage += IsWithinRange(txtNumberOfDrawers.Text, "Entry Error");

            if (errorMessage != "")
            {
                success = false;
                ShowErrorMessage(errorMessage, "Drawer Entry Error");
            }
            

            CalculateDrawerCost();
            return success;
        }

        private bool IsValidWoodType()
        {

            bool success = true;
            string errorMessage = "";
            errorMessage += IsPresent(txtTypeOfWood.Text, "Type Of Wood");
            errorMessage += IsValidatedLetter(txtTypeOfWood.Text, "Type of Wood");

            if (errorMessage != "")
            {
                success = false;
                ShowErrorMessage(errorMessage, "Wood Entry Error");
            }
            CalculateWoodCost();
            CalculateTotalCost();
            return success;
        }


        private string IsPresent(string value, string name)
        {
            string msg = "";
            if (value == "")
            {
                msg = name + " is a required field. Please Enter an Initial\n";
            }

            return msg;
        }

        private string IsPresent2(string value, string name)
        {
            string msg = "";
            if (value == "")
            {
                msg = "Number of drawers is a required field. Please enter an Integer between 1-9.";
            }
            return msg;
        }

        private string IsValidatedLetter(string value, string name)
        {

            string msg = "";
            
            if (woodInitialStr == "C")
            {
                woodTypeStr = "Cherry";
            } else if (woodInitialStr == "M")
            {
                woodTypeStr = "Maple";
            } else if (woodInitialStr == "O")
            {
                woodTypeStr = "Oak";
            } else if (woodInitialStr == "P")
            {
                woodTypeStr = "Pine";
            } else
            {
                ShowErrorMessage("Please enter the Initial of the wood you would like. 'C', 'M', 'O', or 'P'", "Invalid Entry Wood Type");
            }

            
            return msg;

        }
        private string IsInt32(string value, string name)
        {
            string msg = "";
            if (!Int32.TryParse(value, out _))
            {
                msg = "Number of drawers must be a valid integer value.";
            }
            return msg;
        }

        private string IsWithinRange(string value, string name)
        {
            string msg = "";
            if (Int32.TryParse(value, out int number))
            {
                if (number < 1 || number > 9)
                {
                    msg = "Integer must be between 1 and 9.";
                }
            }
            return msg;
        }


        private void CalculateWoodCost()
        {

            if (woodTypeStr == "Cherry")
            {
                CostOfWood = 125;
            } else if (woodTypeStr == "Maple")
            {
                CostOfWood = 150;
            } else if (woodTypeStr == "Oak")
            {
                CostOfWood = 140;
            } else if (woodTypeStr == "Pine")
            {
                CostOfWood = 100;
            }

            txtCostOfWood.Text = ($"${CostOfWood}");
        }
        private void CalculateDrawerCost()
        {
            NumOfDrawers = Convert.ToInt32(DrawerAmountStr);
            CostOfDrawers = (NumOfDrawers * 30);
            txtCostOfDrawers.Text = ($"${CostOfDrawers}");
        }
          
        private void CalculateTotalCost()
        {
            decimal TotalCost = (CostOfDrawers + CostOfWood);

            txtTotalCost.Text = ($"${TotalCost}");
        }
           
    
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        private void ClearAll()
        {
            txtCostOfWood.Text = string.Empty;
            txtCostOfDrawers.Text = string.Empty;
            txtNumberOfDrawers.Text = string.Empty;
            txtTotalCost.Text = string.Empty;
            txtTypeOfWood.Text = string.Empty;
            txtTypeOfWood.Focus();
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
