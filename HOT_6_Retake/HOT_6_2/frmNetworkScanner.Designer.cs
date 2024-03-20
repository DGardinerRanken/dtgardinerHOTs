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
            lblTheIP = new Label();
            lblResult = new TextBox();
            lblServices = new Label();
            btnClear = new Button();
            lblMessage = new Label();
            SuspendLayout();
            // 
            // lblIPAddress
            // 
            lblIPAddress.BackColor = Color.Pink;
            lblIPAddress.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblIPAddress.Location = new Point(50, 41);
            lblIPAddress.Name = "lblIPAddress";
            lblIPAddress.Size = new Size(152, 29);
            lblIPAddress.TabIndex = 6;
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
            btnScan.Location = new Point(481, 41);
            btnScan.Name = "btnScan";
            btnScan.Size = new Size(116, 38);
            btnScan.TabIndex = 1;
            btnScan.Text = "Scan";
            btnScan.UseVisualStyleBackColor = true;
            btnScan.Click += btnScan_Click;
            // 
            // lblTheIP
            // 
            lblTheIP.BackColor = Color.Pink;
            lblTheIP.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblTheIP.Location = new Point(50, 225);
            lblTheIP.Name = "lblTheIP";
            lblTheIP.Size = new Size(547, 57);
            lblTheIP.TabIndex = 5;
            lblTheIP.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.Pink;
            lblResult.Font = new Font("Arial Narrow", 18.25F, FontStyle.Bold);
            lblResult.Location = new Point(50, 351);
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
            lblServices.Location = new Point(50, 298);
            lblServices.Name = "lblServices";
            lblServices.Size = new Size(152, 36);
            lblServices.TabIndex = 7;
            lblServices.Text = "Services:";
            lblServices.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnClear.Location = new Point(481, 86);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(116, 38);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblMessage
            // 
            lblMessage.BackColor = Color.Pink;
            lblMessage.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblMessage.Location = new Point(50, 148);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(547, 57);
            lblMessage.TabIndex = 4;
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmNetworkScanner
            // 
            AcceptButton = btnScan;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            CancelButton = btnClear;
            ClientSize = new Size(653, 672);
            Controls.Add(lblMessage);
            Controls.Add(btnClear);
            Controls.Add(lblServices);
            Controls.Add(lblResult);
            Controls.Add(lblTheIP);
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
        private Label lblTheIP;
        private TextBox lblResult;
        private Label lblServices;
        private Button btnClear;
        private Label lblMessage;
    }
}
