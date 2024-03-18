namespace HOT_6_2
{
    partial class frmNetworkScanner
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblIPAddress = new Label();
            txtIPAddress = new TextBox();
            btnScan = new Button();
            lblComputerName = new Label();
            lblResult = new TextBox();
            lblServices = new Label();
            SuspendLayout();
            // 
            // lblIPAddress
            // 
            lblIPAddress.BackColor = Color.Pink;
            lblIPAddress.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblIPAddress.Location = new Point(50, 41);
            lblIPAddress.Name = "lblIPAddress";
            lblIPAddress.Size = new Size(152, 29);
            lblIPAddress.TabIndex = 4;
            lblIPAddress.Text = "IP Address";
            lblIPAddress.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtIPAddress
            // 
            txtIPAddress.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtIPAddress.Location = new Point(50, 86);
            txtIPAddress.Name = "txtIPAddress";
            txtIPAddress.Size = new Size(408, 38);
            txtIPAddress.TabIndex = 0;
            // 
            // btnScan
            // 
            btnScan.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnScan.Location = new Point(481, 86);
            btnScan.Name = "btnScan";
            btnScan.Size = new Size(116, 38);
            btnScan.TabIndex = 1;
            btnScan.Text = "Scan";
            btnScan.UseVisualStyleBackColor = true;
            btnScan.Click += btnScan_Click;
            // 
            // lblComputerName
            // 
            lblComputerName.BackColor = Color.Pink;
            lblComputerName.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblComputerName.Location = new Point(50, 143);
            lblComputerName.Name = "lblComputerName";
            lblComputerName.Size = new Size(547, 57);
            lblComputerName.TabIndex = 2;
            lblComputerName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.Pink;
            lblResult.Font = new Font("Arial Narrow", 18.25F, FontStyle.Bold);
            lblResult.Location = new Point(50, 267);
            lblResult.Multiline = true;
            lblResult.Name = "lblResult";
            lblResult.ReadOnly = true;
            lblResult.Size = new Size(547, 298);
            lblResult.TabIndex = 3;
            // 
            // lblServices
            // 
            lblServices.BackColor = Color.Pink;
            lblServices.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblServices.Location = new Point(50, 218);
            lblServices.Name = "lblServices";
            lblServices.Size = new Size(152, 36);
            lblServices.TabIndex = 5;
            lblServices.Text = "Services:";
            lblServices.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmNetworkScanner
            // 
            AcceptButton = btnScan;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(653, 591);
            Controls.Add(lblServices);
            Controls.Add(lblResult);
            Controls.Add(lblComputerName);
            Controls.Add(btnScan);
            Controls.Add(txtIPAddress);
            Controls.Add(lblIPAddress);
            Name = "frmNetworkScanner";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIPAddress;
        private TextBox txtIPAddress;
        private Button btnScan;
        private Label lblComputerName;
        private TextBox lblResult;
        private Label lblServices;
    }
}
