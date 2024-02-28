namespace HOT_05
{
    partial class frmCardStore
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
            ddlStyle = new ComboBox();
            ddlOccasion = new ComboBox();
            lblStyle = new Label();
            lblOccasion = new Label();
            btnExit = new Button();
            btnCalculate = new Button();
            lblTotalCost = new Label();
            txtCustomMessage = new TextBox();
            gbAdditionalServices = new GroupBox();
            chkCustomMessage = new CheckBox();
            chkStamp = new CheckBox();
            chkEnvelope = new CheckBox();
            picCardDisplay = new PictureBox();
            gbAdditionalServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCardDisplay).BeginInit();
            SuspendLayout();
            // 
            // ddlStyle
            // 
            ddlStyle.Font = new Font("Arial Narrow", 15F, FontStyle.Bold);
            ddlStyle.FormattingEnabled = true;
            ddlStyle.Location = new Point(205, 96);
            ddlStyle.Name = "ddlStyle";
            ddlStyle.Size = new Size(208, 32);
            ddlStyle.TabIndex = 1;
            // 
            // ddlOccasion
            // 
            ddlOccasion.Font = new Font("Arial Narrow", 15F, FontStyle.Bold);
            ddlOccasion.FormattingEnabled = true;
            ddlOccasion.Location = new Point(205, 43);
            ddlOccasion.Name = "ddlOccasion";
            ddlOccasion.Size = new Size(208, 32);
            ddlOccasion.TabIndex = 0;
            ddlOccasion.SelectedIndexChanged += ddlOccasion_SelectedIndexChanged;
            // 
            // lblStyle
            // 
            lblStyle.BackColor = Color.LightSkyBlue;
            lblStyle.Font = new Font("Arial Narrow", 15F, FontStyle.Bold);
            lblStyle.Location = new Point(49, 93);
            lblStyle.Name = "lblStyle";
            lblStyle.Size = new Size(120, 36);
            lblStyle.TabIndex = 7;
            lblStyle.Text = "Style:";
            lblStyle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOccasion
            // 
            lblOccasion.BackColor = Color.LightSkyBlue;
            lblOccasion.Font = new Font("Arial Narrow", 15F, FontStyle.Bold);
            lblOccasion.Location = new Point(49, 40);
            lblOccasion.Name = "lblOccasion";
            lblOccasion.Size = new Size(120, 36);
            lblOccasion.TabIndex = 6;
            lblOccasion.Text = "Occasion:";
            lblOccasion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Arial Narrow", 15F, FontStyle.Bold);
            btnExit.Location = new Point(321, 555);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(92, 36);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Arial Narrow", 15F, FontStyle.Bold);
            btnCalculate.Location = new Point(223, 555);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(92, 36);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblTotalCost
            // 
            lblTotalCost.BackColor = Color.LightSkyBlue;
            lblTotalCost.Font = new Font("Arial Narrow", 15F, FontStyle.Bold);
            lblTotalCost.Location = new Point(49, 555);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(151, 36);
            lblTotalCost.TabIndex = 8;
            lblTotalCost.Text = "Total Cost: ";
            lblTotalCost.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCustomMessage
            // 
            txtCustomMessage.Font = new Font("Arial Narrow", 15F, FontStyle.Bold);
            txtCustomMessage.Location = new Point(49, 322);
            txtCustomMessage.Multiline = true;
            txtCustomMessage.Name = "txtCustomMessage";
            txtCustomMessage.ReadOnly = true;
            txtCustomMessage.Size = new Size(364, 215);
            txtCustomMessage.TabIndex = 3;
            // 
            // gbAdditionalServices
            // 
            gbAdditionalServices.Controls.Add(chkCustomMessage);
            gbAdditionalServices.Controls.Add(chkStamp);
            gbAdditionalServices.Controls.Add(chkEnvelope);
            gbAdditionalServices.Font = new Font("Arial Narrow", 11F, FontStyle.Bold);
            gbAdditionalServices.Location = new Point(49, 173);
            gbAdditionalServices.Name = "gbAdditionalServices";
            gbAdditionalServices.Size = new Size(364, 128);
            gbAdditionalServices.TabIndex = 2;
            gbAdditionalServices.TabStop = false;
            gbAdditionalServices.Text = "Additional Services";
            // 
            // chkCustomMessage
            // 
            chkCustomMessage.AutoSize = true;
            chkCustomMessage.Font = new Font("Arial Narrow", 15F, FontStyle.Bold);
            chkCustomMessage.Location = new Point(17, 90);
            chkCustomMessage.Name = "chkCustomMessage";
            chkCustomMessage.Size = new Size(219, 28);
            chkCustomMessage.TabIndex = 2;
            chkCustomMessage.Text = "Custom Message ($0.30)";
            chkCustomMessage.UseVisualStyleBackColor = true;
            chkCustomMessage.CheckedChanged += chkCustomMessage_CheckedChanged;
            // 
            // chkStamp
            // 
            chkStamp.AutoSize = true;
            chkStamp.Font = new Font("Arial Narrow", 15F, FontStyle.Bold);
            chkStamp.Location = new Point(17, 56);
            chkStamp.Name = "chkStamp";
            chkStamp.Size = new Size(134, 28);
            chkStamp.TabIndex = 1;
            chkStamp.Text = "Stamp ($0.50)";
            chkStamp.UseVisualStyleBackColor = true;
            chkStamp.CheckedChanged += chkStamp_CheckedChanged;
            // 
            // chkEnvelope
            // 
            chkEnvelope.AutoSize = true;
            chkEnvelope.Font = new Font("Arial Narrow", 15F, FontStyle.Bold);
            chkEnvelope.Location = new Point(17, 22);
            chkEnvelope.Name = "chkEnvelope";
            chkEnvelope.Size = new Size(148, 28);
            chkEnvelope.TabIndex = 0;
            chkEnvelope.Text = "Envelop ($0.25)";
            chkEnvelope.UseVisualStyleBackColor = true;
            chkEnvelope.CheckedChanged += chkEnvelope_CheckedChanged;
            // 
            // picCardDisplay
            // 
            picCardDisplay.BackColor = SystemColors.ButtonHighlight;
            picCardDisplay.Location = new Point(495, 43);
            picCardDisplay.Name = "picCardDisplay";
            picCardDisplay.Size = new Size(461, 548);
            picCardDisplay.SizeMode = PictureBoxSizeMode.StretchImage;
            picCardDisplay.TabIndex = 14;
            picCardDisplay.TabStop = false;
            // 
            // frmCardStore
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1019, 640);
            Controls.Add(picCardDisplay);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(lblTotalCost);
            Controls.Add(txtCustomMessage);
            Controls.Add(gbAdditionalServices);
            Controls.Add(ddlStyle);
            Controls.Add(ddlOccasion);
            Controls.Add(lblStyle);
            Controls.Add(lblOccasion);
            Name = "frmCardStore";
            Text = "Card Designer";
            Load += frmCardStore_Load;
            gbAdditionalServices.ResumeLayout(false);
            gbAdditionalServices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCardDisplay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ddlStyle;
        private ComboBox ddlOccasion;
        private Label lblStyle;
        private Label lblOccasion;
        private Button btnExit;
        private Button btnCalculate;
        private Label lblTotalCost;
        private TextBox txtCustomMessage;
        private GroupBox gbAdditionalServices;
        private CheckBox chkCustomMessage;
        private CheckBox chkStamp;
        private CheckBox chkEnvelope;
        private PictureBox picCardDisplay;
    }
}
