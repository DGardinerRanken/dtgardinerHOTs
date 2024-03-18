namespace HOT_6_2
{
    public partial class frmNetworkScanner : Form
    {
        string[] ipAddresses = {"127.0.0.1","8.8.8.8","47.44.246.80"};
        string[] services = {"20: FTP_DATA\r\n21: FTP_CONTROL\r\n23: TELNET\r\n25: SMTP\r\n53: DNS\r\n80: HTTP\r\n123: NTP\r\n398: LDAP\r\n443:HTTPS",
                             "53: DNS", "25: SMTP\r\n80: HTTP\r\n443: HTTPS" };
        string[] names = { "My-Desktop - 127.0.0.1", "google-public-dns-a - 8.8.8.8", "ranken.edu - 47.44.246.80" };

        string outputStr = "";
        string headingStr = "";
        public frmNetworkScanner()
        {
            InitializeComponent();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            ScanIpAddress();
            
        }
      
        private void ScanIpAddress()
        {
            string IpAddressStr = txtIPAddress.Text.Trim();
            bool isFound = false;
            int ind = -1;

            if (string.IsNullOrEmpty(IpAddressStr)) 
            {
                ShowErrorMessage("IP Address Must Not Be Empty", "NO IP ADDRESS ENTERED");
                return;
            }

            for (int lcv = 0; lcv < ipAddresses.Length; lcv++)
            {
                //Searching array for a match
                if (ipAddresses[lcv].ToLower().Contains(IpAddressStr.ToLower()))
                {
                    isFound = true;
                    ind = lcv;
                    break;
                }
            }

            if (isFound)
            {
                outputStr += services[ind];
                headingStr += names[ind];
            }
            else
            {
                outputStr += "NONE";
            }

            lblResult.Text = outputStr;
            lblComputerName.Text = headingStr;
        }

        private void ShowComputer()
        {

        }

        private void ShowErrorMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

    }
}
