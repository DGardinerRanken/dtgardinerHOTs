using System;

namespace HOT_6_2
{
    public partial class frmNetworkScanner : Form
    {
        //Declare and initialize program constants
        const int MAXLEN = 3;
        const string RTO = "Request Timed Out";

        //Declare and initialize class variables
        string[] services = 
        { 
        "20: FTP_DATA", "21: FTP_CONTROL","23: TELNET",
        "25: SMTP", "53: DNS", "80: HTTP", "123: NTP",
        "389: LDAP", "443: HTTPS"
        };

        int lcv = 0;

        List<Computer> computers = new List<Computer>()
        {
            new Computer("My-Desktop", "127.0.0.1", "012345678"),
            new Computer("google-public-dna-a", "8.8.8.8", "4"),
            new Computer("ranken.edu", "47.44.246.89", "358")
        };

        public frmNetworkScanner()
        {
            InitializeComponent();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            int position = ScanIPAddress(txtIPAddress.Text.Trim());
            ShowComputer(position);
        }
        private int ScanIPAddress(string ipAddress)
        {
            //Checking for an empty IP Address Textbox
            if (ipAddress == string.Empty)
            {
                return -2;
            }

            //Search the list for a matching IP Address
            //If found, return the associated lcv value
            //If not found, return -1

            for (lcv = 0; lcv < computers.Count(); lcv++)
            {
                if (computers[lcv].GetIpAddress() == ipAddress)
                {
                    //Match found
                    return lcv;
                }
            }
            //No Match found
            return -1;
        }      
        
        private void ShowComputer(int p)
        {
            bool returnNow = false;
            string theServices = string.Empty;

            ClearSome();

            switch(p)
            {               
                case 0:     //127.0.0.1 My-Desktop
                    for (int x = 0; x < services.Length; x++)
                    {
                        theServices += services[x] + "\r\n";
                    }break;
                case 1:     //8.8.8.8 google-public-dns-a
                    theServices = services[4];
                    break;
                case 2:     //47.44.246.80 ranken.edu
                    theServices = services[3] + "\r\n" + 
                                  services[5] + "\r\n" + 
                                  services[8];
                    break;
    
                    //Empty or Invalid IP Address
                case -1:
                case -2:
                default: 
                    lblMessage.Text = RTO;
                    lblTheIP.Text = string.Empty;
                    lblResult.Text = "NONE";
                    returnNow = true;
                    break;
            }

            if (returnNow)
            {
                return;
            }

            lblMessage.Text = computers[lcv].GetName();
            lblTheIP.Text = computers[lcv].GetIpAddress();
            lblResult.Text = theServices;
        }

        
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearSome();
            ClearTheRest();
        }
        private void ClearSome()
        {
            txtIPAddress.Text = string.Empty;
            lblMessage.Text = string.Empty;
            lblTheIP.Text = string.Empty;
        }
        private void ClearTheRest()
        {
            txtIPAddress.Text = string.Empty;
            txtIPAddress.Focus();
            lblResult.Text = string.Empty;
        }

        private void ShowErrorMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

        
    }
}
