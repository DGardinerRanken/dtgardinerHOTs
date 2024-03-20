namespace HOT_6_1
{
    partial class frmPasswordCracker
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
            lblMD5Hash = new Label();
            lblResult = new Label();
            txtMD5Hash = new TextBox();
            btnCrack = new Button();
            btnClear = new Button();
            lblAssociatedPassword = new Label();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblMD5Hash
            // 
            lblMD5Hash.BackColor = Color.LightSkyBlue;
            lblMD5Hash.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblMD5Hash.Location = new Point(43, 34);
            lblMD5Hash.Name = "lblMD5Hash";
            lblMD5Hash.Size = new Size(159, 34);
            lblMD5Hash.TabIndex = 5;
            lblMD5Hash.Text = "MD5 Hash:";
            lblMD5Hash.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.LightSkyBlue;
            lblResult.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblResult.Location = new Point(43, 207);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(714, 34);
            lblResult.TabIndex = 4;
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtMD5Hash
            // 
            txtMD5Hash.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtMD5Hash.Location = new Point(43, 94);
            txtMD5Hash.Name = "txtMD5Hash";
            txtMD5Hash.Size = new Size(608, 38);
            txtMD5Hash.TabIndex = 0;
            // 
            // btnCrack
            // 
            btnCrack.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnCrack.Location = new Point(665, 28);
            btnCrack.Name = "btnCrack";
            btnCrack.Size = new Size(92, 52);
            btnCrack.TabIndex = 1;
            btnCrack.Text = "Crack";
            btnCrack.UseVisualStyleBackColor = true;
            btnCrack.Click += btnCrack_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnClear.Location = new Point(665, 86);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(92, 52);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblAssociatedPassword
            // 
            lblAssociatedPassword.BackColor = Color.LightSkyBlue;
            lblAssociatedPassword.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblAssociatedPassword.Location = new Point(43, 153);
            lblAssociatedPassword.Name = "lblAssociatedPassword";
            lblAssociatedPassword.Size = new Size(260, 34);
            lblAssociatedPassword.TabIndex = 6;
            lblAssociatedPassword.Text = "Associated Password:";
            lblAssociatedPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnExit.Location = new Point(665, 144);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(92, 52);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmPasswordCracker
            // 
            AcceptButton = btnCrack;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            CancelButton = btnClear;
            ClientSize = new Size(800, 270);
            Controls.Add(btnExit);
            Controls.Add(lblAssociatedPassword);
            Controls.Add(btnClear);
            Controls.Add(btnCrack);
            Controls.Add(txtMD5Hash);
            Controls.Add(lblResult);
            Controls.Add(lblMD5Hash);
            Name = "frmPasswordCracker";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HOT 6 #1 -  Password Cracker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMD5Hash;
        private Label lblResult;
        private TextBox txtMD5Hash;
        private Button btnCrack;
        private Button btnClear;
        private Label lblAssociatedPassword;
        private Button btnExit;
    }
}
