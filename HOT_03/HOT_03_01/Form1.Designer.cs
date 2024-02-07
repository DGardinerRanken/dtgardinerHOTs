namespace HOT_03_01
{
    partial class frmCustomDesks
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
            lblTypeOfWood = new Label();
            lblNumberOfDrawers = new Label();
            lblCostOfWood = new Label();
            lblCostOfDrawers = new Label();
            lblTotalCost = new Label();
            txtTypeOfWood = new TextBox();
            txtNumberOfDrawers = new TextBox();
            txtTotalCost = new TextBox();
            btnEstimate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            txtCostOfDrawers = new TextBox();
            txtCostOfWood = new TextBox();
            SuspendLayout();
            // 
            // lblTypeOfWood
            // 
            lblTypeOfWood.BackColor = Color.PaleGoldenrod;
            lblTypeOfWood.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblTypeOfWood.Location = new Point(114, 71);
            lblTypeOfWood.Name = "lblTypeOfWood";
            lblTypeOfWood.Size = new Size(231, 34);
            lblTypeOfWood.TabIndex = 8;
            lblTypeOfWood.Text = "Type of Wood";
            lblTypeOfWood.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNumberOfDrawers
            // 
            lblNumberOfDrawers.BackColor = Color.PaleGoldenrod;
            lblNumberOfDrawers.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblNumberOfDrawers.Location = new Point(451, 71);
            lblNumberOfDrawers.Name = "lblNumberOfDrawers";
            lblNumberOfDrawers.Size = new Size(231, 34);
            lblNumberOfDrawers.TabIndex = 9;
            lblNumberOfDrawers.Text = "Number of Drawers";
            lblNumberOfDrawers.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCostOfWood
            // 
            lblCostOfWood.BackColor = Color.PaleGoldenrod;
            lblCostOfWood.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold);
            lblCostOfWood.Location = new Point(91, 301);
            lblCostOfWood.Name = "lblCostOfWood";
            lblCostOfWood.Size = new Size(145, 34);
            lblCostOfWood.TabIndex = 10;
            lblCostOfWood.Text = "Cost of Wood";
            lblCostOfWood.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCostOfDrawers
            // 
            lblCostOfDrawers.BackColor = Color.PaleGoldenrod;
            lblCostOfDrawers.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold);
            lblCostOfDrawers.Location = new Point(324, 301);
            lblCostOfDrawers.Name = "lblCostOfDrawers";
            lblCostOfDrawers.Size = new Size(153, 34);
            lblCostOfDrawers.TabIndex = 11;
            lblCostOfDrawers.Text = "Cost of Drawers";
            lblCostOfDrawers.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalCost
            // 
            lblTotalCost.BackColor = Color.PaleGoldenrod;
            lblTotalCost.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold);
            lblTotalCost.Location = new Point(557, 301);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(145, 34);
            lblTotalCost.TabIndex = 12;
            lblTotalCost.Text = "Total Cost";
            lblTotalCost.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTypeOfWood
            // 
            txtTypeOfWood.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtTypeOfWood.Location = new Point(114, 118);
            txtTypeOfWood.Name = "txtTypeOfWood";
            txtTypeOfWood.Size = new Size(231, 38);
            txtTypeOfWood.TabIndex = 0;
            txtTypeOfWood.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNumberOfDrawers
            // 
            txtNumberOfDrawers.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtNumberOfDrawers.Location = new Point(451, 118);
            txtNumberOfDrawers.Name = "txtNumberOfDrawers";
            txtNumberOfDrawers.Size = new Size(231, 38);
            txtNumberOfDrawers.TabIndex = 1;
            txtNumberOfDrawers.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTotalCost
            // 
            txtTotalCost.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtTotalCost.Location = new Point(557, 358);
            txtTotalCost.Name = "txtTotalCost";
            txtTotalCost.ReadOnly = true;
            txtTotalCost.Size = new Size(145, 38);
            txtTotalCost.TabIndex = 7;
            txtTotalCost.TextAlign = HorizontalAlignment.Center;
            // 
            // btnEstimate
            // 
            btnEstimate.BackColor = Color.Gold;
            btnEstimate.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnEstimate.Location = new Point(91, 187);
            btnEstimate.Name = "btnEstimate";
            btnEstimate.Size = new Size(145, 59);
            btnEstimate.TabIndex = 2;
            btnEstimate.Text = "&Estimate";
            btnEstimate.UseVisualStyleBackColor = false;
            btnEstimate.Click += btnEstimate_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Gold;
            btnClear.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnClear.Location = new Point(324, 187);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(145, 59);
            btnClear.TabIndex = 3;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Gold;
            btnExit.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnExit.Location = new Point(557, 187);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(145, 59);
            btnExit.TabIndex = 4;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // txtCostOfDrawers
            // 
            txtCostOfDrawers.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtCostOfDrawers.Location = new Point(324, 358);
            txtCostOfDrawers.Name = "txtCostOfDrawers";
            txtCostOfDrawers.ReadOnly = true;
            txtCostOfDrawers.Size = new Size(153, 38);
            txtCostOfDrawers.TabIndex = 6;
            txtCostOfDrawers.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCostOfWood
            // 
            txtCostOfWood.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtCostOfWood.Location = new Point(91, 358);
            txtCostOfWood.Name = "txtCostOfWood";
            txtCostOfWood.ReadOnly = true;
            txtCostOfWood.Size = new Size(145, 38);
            txtCostOfWood.TabIndex = 5;
            txtCostOfWood.TextAlign = HorizontalAlignment.Center;
            // 
            // frmCustomDesks
            // 
            AcceptButton = btnEstimate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            CancelButton = btnClear;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCostOfWood);
            Controls.Add(txtCostOfDrawers);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnEstimate);
            Controls.Add(txtTotalCost);
            Controls.Add(txtNumberOfDrawers);
            Controls.Add(txtTypeOfWood);
            Controls.Add(lblTotalCost);
            Controls.Add(lblCostOfDrawers);
            Controls.Add(lblCostOfWood);
            Controls.Add(lblNumberOfDrawers);
            Controls.Add(lblTypeOfWood);
            Name = "frmCustomDesks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My Custom Desk";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTypeOfWood;
        private Label lblNumberOfDrawers;
        private Label lblCostOfWood;
        private Label lblCostOfDrawers;
        private Label lblTotalCost;
        private TextBox txtTypeOfWood;
        private TextBox txtNumberOfDrawers;
        private TextBox textBox4;
        private TextBox txtTotalCost;
        private Button btnEstimate;
        private Button btnClear;
        private Button btnExit;
        private TextBox txtCostOfDrawers;
        private TextBox txtCostOfWood;
    }
}
