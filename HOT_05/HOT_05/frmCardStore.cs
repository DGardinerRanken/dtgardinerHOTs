using Microsoft.VisualBasic.ApplicationServices;
using System.Drawing.Imaging;
namespace HOT_05
{

    /*
      * Write a GUI application that allows the user to design a card.
    ●	The user can select from at least 3 different occasions.
    ●	The user can select from at least 3 different styles for each occasion.
    ●	Each card style must have a different base cost.
    ●	The user can choose to add an envelope for 25 cents.
    ●	The user can choose to add a stamp for 50 cents.
    ●	The user can choose to add a custom message for 25 cents.
    ●	The user can only enter a custom message if the checkbox is checked.
    ●	The user can preview their custom message on the card.
     */

    public partial class frmCardStore : Form
    {

        //Declare and Initialize program constants
        const decimal BIRTHDAYCARDCOST = 2.00m;
        const decimal THANKYOUCARDCOST = 2.25m;
        const decimal GRADUATIONCARDCOST = 1.75m;
        const decimal ENVELOPECOST = .25m;
        const decimal STAMPCOST = .50m;
        const decimal CUSTOMMESSAGECOST = .30m;

        //Declare and Initialize program arrays

        string[] occasions = { "Birthday ($2.00 Each)", "Thank You ($2.25 Each)", "Graduation ($1.75 Each)" };
        string[] birthdayCards = { "Birthday Card #1", "Birthday Card #2", "Birthday Card #3" };
        string[] thankYouCards = { "Thank You Card #1", "Thank You Card #2", "Thank You Card #3" };
        string[] graduationCards = { "Graduation Card #1", "Graduation Card #2", "Graduation Card #3" };
        string[] birthdayImages = { @"C:\Users\danny\OneDrive\Desktop\AWD1100\dtgardinerHOTs\HOT_05\images\BirthdayCard1.jpg",
                                    @"C:\Users\danny\OneDrive\Desktop\AWD1100\dtgardinerHOTs\HOT_05\images\BirthdayCard2.png",
                                    @"C:\Users\danny\OneDrive\Desktop\AWD1100\dtgardinerHOTs\HOT_05\images\BirthdayCard3.jpg"};
        string[] graduationImages = { @"C:\Users\danny\OneDrive\Desktop\AWD1100\dtgardinerHOTs\HOT_05\images\gradCard1.jpg",
                                    @"C:\Users\danny\OneDrive\Desktop\AWD1100\dtgardinerHOTs\HOT_05\images\gradCard2.jpg",
                                    @"C:\Users\danny\OneDrive\Desktop\AWD1100\dtgardinerHOTs\HOT_05\images\gradCard3.jpg"};
        string[] thankYouImages ={@"C:\Users\danny\OneDrive\Desktop\AWD1100\dtgardinerHOTs\HOT_05\images\thankyoucard1.jpg",
                                    @"C:\Users\danny\OneDrive\Desktop\AWD1100\dtgardinerHOTs\HOT_05\images\thankyoucard2.jpg",
                                    @"C:\Users\danny\OneDrive\Desktop\AWD1100\dtgardinerHOTs\HOT_05\images\thankyoucard3.jpg"};

        //Declare and Initialize program variables
        decimal baseCost = 0m;
        decimal totalCost = 0m;
        decimal extraCosts = 0m;
        public frmCardStore()
        {
            InitializeComponent();
        }
        private void frmCardStore_Load(object sender, EventArgs e)
        {
            //Populating Occasion Drop Down
            populateDropDowns();
            picCardDisplay.Visible = false;
        }
        private void ddlOccasion_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Choosing Which Set of Styles to Use
            if (ddlOccasion.SelectedIndex == 0)
            {
                populateStyleBirthday();
                baseCost = 2.00m;
            }
            else if (ddlOccasion.SelectedIndex == 1)
            {
                populateStyleThankYou();
                baseCost = 2.25m;
            }
            else
            {
                populateStyleGraduation();
                baseCost = 1.75m;
            }
        }
        
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            CalculateCardCost();
            choosePhoto();
        }
        private void CalculateCardCost()
        {
            totalCost = extraCosts + baseCost;
            lblTotalCost.Text = ($"Total Cost: ${totalCost}");
            string customMessage = txtCustomMessage.Text.Trim();

            if (txtCustomMessage.Text == "")
            {
                return;
            } else if (txtCustomMessage.Text != "")
            {
                ShowMessage($"Custom Message: {customMessage}", "YOUR CUSTOM MESSAGE");
            }
            
        }
        private void choosePhoto()
        {
            //Choosing the photo based on Users input. I tried for over an hour on just getting this to work right,
            // But I could only figure out a way to have the image displayed after Calculate button was hit,
            // rather than how you showed yours working in class where it changed immediately after selecting the index, I apologize
            if (ddlOccasion.SelectedIndex == 0)
            {
                if (ddlStyle.SelectedIndex == 0)
                {
                    picCardDisplay.ImageLocation = birthdayImages[0];
                    picCardDisplay.Visible = true;
                }
                else if (ddlStyle.SelectedIndex == 1)
                {
                    picCardDisplay.ImageLocation = birthdayImages[1];
                    picCardDisplay.Visible = true;
                }
                else
                {
                    picCardDisplay.ImageLocation = birthdayImages[2];
                    picCardDisplay.Visible = true;
                }
            }
            else if (ddlOccasion.SelectedIndex == 1)
            {
                if (ddlStyle.SelectedIndex == 0)
                {
                    picCardDisplay.ImageLocation = thankYouImages[0];
                    picCardDisplay.Visible = true;
                }
                else if (ddlStyle.SelectedIndex == 1)
                {
                    picCardDisplay.ImageLocation = thankYouImages[1];
                    picCardDisplay.Visible = true;
                }
                else
                {
                    picCardDisplay.ImageLocation = thankYouImages[2];
                    picCardDisplay.Visible = true;
                }
            }
            else if (ddlOccasion.SelectedIndex == 2)
            {
                if (ddlStyle.SelectedIndex == 0)
                {
                    picCardDisplay.ImageLocation = graduationImages[0];
                    picCardDisplay.Visible = true;
                }
                else if (ddlStyle.SelectedIndex == 1)
                {
                    picCardDisplay.ImageLocation = graduationImages[1];
                    picCardDisplay.Visible = true;
                }
                else
                {
                    picCardDisplay.ImageLocation = graduationImages[2];
                    picCardDisplay.Visible = true;
                }
            }
        }
        private void populateDropDowns()
        {
            ddlOccasion.DataSource = occasions;
        }
        private void populateStyleBirthday()
        {
            ddlStyle.DataSource = birthdayCards;
            
        }
        
        private void populateStyleThankYou()
        {
            ddlStyle.DataSource = thankYouCards;
        }
        private void populateStyleGraduation()
        {
            ddlStyle.DataSource = graduationCards;
        }
        private void chkEnvelope_CheckedChanged(object sender, EventArgs e)
        {
            extraCosts = extraCosts + ENVELOPECOST;
        }

        private void chkStamp_CheckedChanged(object sender, EventArgs e)
        {
            extraCosts = extraCosts + STAMPCOST;
        }

        private void chkCustomMessage_CheckedChanged(object sender, EventArgs e)
        {
            extraCosts = extraCosts + CUSTOMMESSAGECOST;
            txtCustomMessage.ReadOnly = false;
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

        private void ShowMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }
    }
}
