namespace LoanCompany
{
    partial class frmLoanCompany
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
            groupBox1 = new GroupBox();
            rbLongTerm = new RadioButton();
            rbShortTerm = new RadioButton();
            btnCreate = new Button();
            txtAmount = new TextBox();
            txtName = new TextBox();
            lblType = new Label();
            lblAmount = new Label();
            lblName = new Label();
            groupBox2 = new GroupBox();
            btnMakePayment = new Button();
            lblAmountAfterInterest = new Label();
            lblLoanAmountRemaining = new Label();
            lblLoanType = new Label();
            lblLoanName = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.AliceBlue;
            groupBox1.Controls.Add(rbLongTerm);
            groupBox1.Controls.Add(rbShortTerm);
            groupBox1.Controls.Add(btnCreate);
            groupBox1.Controls.Add(txtAmount);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(lblType);
            groupBox1.Controls.Add(lblAmount);
            groupBox1.Controls.Add(lblName);
            groupBox1.Font = new Font("Arial Narrow", 14F, FontStyle.Bold);
            groupBox1.Location = new Point(88, 51);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(603, 307);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Create Loan";
            // 
            // rbLongTerm
            // 
            rbLongTerm.AutoSize = true;
            rbLongTerm.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            rbLongTerm.Location = new Point(224, 211);
            rbLongTerm.Name = "rbLongTerm";
            rbLongTerm.Size = new Size(187, 33);
            rbLongTerm.TabIndex = 7;
            rbLongTerm.TabStop = true;
            rbLongTerm.Text = "Long-Term Loan";
            rbLongTerm.UseVisualStyleBackColor = true;
            // 
            // rbShortTerm
            // 
            rbShortTerm.AutoSize = true;
            rbShortTerm.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            rbShortTerm.Location = new Point(224, 172);
            rbShortTerm.Name = "rbShortTerm";
            rbShortTerm.Size = new Size(191, 33);
            rbShortTerm.TabIndex = 6;
            rbShortTerm.TabStop = true;
            rbShortTerm.Text = "Short-Term Loan";
            rbShortTerm.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            btnCreate.Location = new Point(58, 242);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(142, 41);
            btnCreate.TabIndex = 5;
            btnCreate.Text = "Create Loan";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            txtAmount.Location = new Point(213, 113);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(354, 35);
            txtAmount.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            txtName.Location = new Point(213, 44);
            txtName.Name = "txtName";
            txtName.Size = new Size(354, 35);
            txtName.TabIndex = 3;
            // 
            // lblType
            // 
            lblType.BackColor = Color.PaleTurquoise;
            lblType.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            lblType.Location = new Point(60, 185);
            lblType.Name = "lblType";
            lblType.Size = new Size(111, 34);
            lblType.TabIndex = 2;
            lblType.Text = "Type";
            lblType.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAmount
            // 
            lblAmount.BackColor = Color.PaleTurquoise;
            lblAmount.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            lblAmount.Location = new Point(60, 113);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(111, 34);
            lblAmount.TabIndex = 1;
            lblAmount.Text = "Amount";
            lblAmount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            lblName.BackColor = Color.PaleTurquoise;
            lblName.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            lblName.Location = new Point(60, 44);
            lblName.Name = "lblName";
            lblName.Size = new Size(111, 34);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.AliceBlue;
            groupBox2.Controls.Add(btnMakePayment);
            groupBox2.Controls.Add(lblAmountAfterInterest);
            groupBox2.Controls.Add(lblLoanAmountRemaining);
            groupBox2.Controls.Add(lblLoanType);
            groupBox2.Controls.Add(lblLoanName);
            groupBox2.Font = new Font("Arial Narrow", 14F, FontStyle.Bold);
            groupBox2.Location = new Point(88, 402);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(603, 307);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Manage Loan";
            // 
            // btnMakePayment
            // 
            btnMakePayment.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            btnMakePayment.Location = new Point(58, 140);
            btnMakePayment.Name = "btnMakePayment";
            btnMakePayment.Size = new Size(166, 41);
            btnMakePayment.TabIndex = 6;
            btnMakePayment.Text = "Make Payment";
            btnMakePayment.UseVisualStyleBackColor = true;
            btnMakePayment.Click += btnMakePayment_Click;
            // 
            // lblAmountAfterInterest
            // 
            lblAmountAfterInterest.BackColor = Color.PaleTurquoise;
            lblAmountAfterInterest.Font = new Font("Arial Narrow", 14F, FontStyle.Bold);
            lblAmountAfterInterest.Location = new Point(58, 247);
            lblAmountAfterInterest.Name = "lblAmountAfterInterest";
            lblAmountAfterInterest.Size = new Size(509, 34);
            lblAmountAfterInterest.TabIndex = 4;
            lblAmountAfterInterest.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLoanAmountRemaining
            // 
            lblLoanAmountRemaining.BackColor = Color.PaleTurquoise;
            lblLoanAmountRemaining.Font = new Font("Arial Narrow", 14F, FontStyle.Bold);
            lblLoanAmountRemaining.Location = new Point(58, 194);
            lblLoanAmountRemaining.Name = "lblLoanAmountRemaining";
            lblLoanAmountRemaining.Size = new Size(509, 34);
            lblLoanAmountRemaining.TabIndex = 3;
            lblLoanAmountRemaining.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLoanType
            // 
            lblLoanType.BackColor = Color.PaleTurquoise;
            lblLoanType.Font = new Font("Arial Narrow", 16F, FontStyle.Bold);
            lblLoanType.Location = new Point(58, 92);
            lblLoanType.Name = "lblLoanType";
            lblLoanType.Size = new Size(509, 34);
            lblLoanType.TabIndex = 2;
            lblLoanType.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLoanName
            // 
            lblLoanName.BackColor = Color.PaleTurquoise;
            lblLoanName.Font = new Font("Arial Narrow", 16F, FontStyle.Bold);
            lblLoanName.Location = new Point(58, 40);
            lblLoanName.Name = "lblLoanName";
            lblLoanName.Size = new Size(509, 34);
            lblLoanName.TabIndex = 1;
            lblLoanName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmLoanCompany
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(800, 751);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmLoanCompany";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rbLongTerm;
        private RadioButton rbShortTerm;
        private Button btnCreate;
        private TextBox txtAmount;
        private TextBox txtName;
        private Label lblType;
        private Label lblAmount;
        private Label lblName;
        private GroupBox groupBox2;
        private Button btnMakePayment;
        private Label lblAmountAfterInterest;
        private Label lblLoanAmountRemaining;
        private Label lblLoanType;
        private Label lblLoanName;
    }
}
