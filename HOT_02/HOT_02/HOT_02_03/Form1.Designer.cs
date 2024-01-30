namespace HOT_02_03
{
    partial class frmGregsLawncare
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
            lblLength = new Label();
            lblWidth = new Label();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            lblArea = new Label();
            lblWeeklyFee = new Label();
            lblSeasonLength = new Label();
            lblTotalCost = new Label();
            txtLength = new TextBox();
            txtWidth = new TextBox();
            SuspendLayout();
            // 
            // lblLength
            // 
            lblLength.BackColor = Color.Pink;
            lblLength.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            lblLength.Location = new Point(189, 41);
            lblLength.Name = "lblLength";
            lblLength.Size = new Size(119, 47);
            lblLength.TabIndex = 0;
            lblLength.Text = "Length (ft)";
            lblLength.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWidth
            // 
            lblWidth.BackColor = Color.Pink;
            lblWidth.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            lblWidth.Location = new Point(482, 41);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(119, 47);
            lblWidth.TabIndex = 1;
            lblWidth.Text = "Width(ft)";
            lblWidth.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            btnCalculate.Location = new Point(99, 150);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(181, 56);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            btnClear.Location = new Point(304, 150);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(181, 56);
            btnClear.TabIndex = 3;
            btnClear.Text = "C&lear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            btnExit.Location = new Point(508, 150);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(181, 56);
            btnExit.TabIndex = 4;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblArea
            // 
            lblArea.BackColor = Color.Pink;
            lblArea.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            lblArea.Location = new Point(125, 234);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(540, 47);
            lblArea.TabIndex = 5;
            lblArea.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWeeklyFee
            // 
            lblWeeklyFee.BackColor = Color.Pink;
            lblWeeklyFee.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            lblWeeklyFee.Location = new Point(125, 291);
            lblWeeklyFee.Name = "lblWeeklyFee";
            lblWeeklyFee.Size = new Size(540, 47);
            lblWeeklyFee.TabIndex = 6;
            lblWeeklyFee.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSeasonLength
            // 
            lblSeasonLength.BackColor = Color.Pink;
            lblSeasonLength.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            lblSeasonLength.Location = new Point(125, 348);
            lblSeasonLength.Name = "lblSeasonLength";
            lblSeasonLength.Size = new Size(540, 47);
            lblSeasonLength.TabIndex = 7;
            lblSeasonLength.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalCost
            // 
            lblTotalCost.BackColor = Color.Pink;
            lblTotalCost.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            lblTotalCost.Location = new Point(125, 406);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(540, 47);
            lblTotalCost.TabIndex = 8;
            lblTotalCost.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtLength
            // 
            txtLength.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            txtLength.Location = new Point(189, 91);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(119, 35);
            txtLength.TabIndex = 9;
            // 
            // txtWidth
            // 
            txtWidth.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            txtWidth.Location = new Point(482, 91);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(119, 35);
            txtWidth.TabIndex = 10;
            // 
            // frmGregsLawncare
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(814, 482);
            Controls.Add(txtWidth);
            Controls.Add(txtLength);
            Controls.Add(lblTotalCost);
            Controls.Add(lblSeasonLength);
            Controls.Add(lblWeeklyFee);
            Controls.Add(lblArea);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(lblWidth);
            Controls.Add(lblLength);
            Name = "frmGregsLawncare";
            Text = "Greg's Lawncare";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLength;
        private Label lblWidth;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
        private Label lblArea;
        private Label lblWeeklyFee;
        private Label lblSeasonLength;
        private Label lblTotalCost;
        private TextBox txtLength;
        private TextBox txtWidth;
    }
}
