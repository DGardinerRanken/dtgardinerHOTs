namespace HOT_02_01
{
    partial class frmInchYardConverter
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
            lblDistanceInches = new Label();
            txtDistanceInches = new TextBox();
            btnClear = new Button();
            btnConvertToYards = new Button();
            btnExit = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // lblDistanceInches
            // 
            lblDistanceInches.BackColor = Color.PaleTurquoise;
            lblDistanceInches.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDistanceInches.Location = new Point(87, 58);
            lblDistanceInches.Name = "lblDistanceInches";
            lblDistanceInches.Size = new Size(199, 43);
            lblDistanceInches.TabIndex = 0;
            lblDistanceInches.Text = "Distance In Inches:";
            lblDistanceInches.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDistanceInches
            // 
            txtDistanceInches.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtDistanceInches.Location = new Point(87, 118);
            txtDistanceInches.Name = "txtDistanceInches";
            txtDistanceInches.Size = new Size(199, 38);
            txtDistanceInches.TabIndex = 1;
            txtDistanceInches.TextAlign = HorizontalAlignment.Center;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnClear.Location = new Point(504, 58);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(214, 67);
            btnClear.TabIndex = 2;
            btnClear.Text = "C&lear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnConvertToYards
            // 
            btnConvertToYards.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnConvertToYards.Location = new Point(87, 170);
            btnConvertToYards.Name = "btnConvertToYards";
            btnConvertToYards.Size = new Size(214, 67);
            btnConvertToYards.TabIndex = 3;
            btnConvertToYards.Text = "Convert to Yards";
            btnConvertToYards.UseVisualStyleBackColor = true;
            btnConvertToYards.Click += btnConvertToYards_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnExit.Location = new Point(504, 170);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(214, 67);
            btnExit.TabIndex = 4;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.PaleTurquoise;
            lblResult.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblResult.Location = new Point(140, 308);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(497, 78);
            lblResult.TabIndex = 5;
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmInchYardConverter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnExit);
            Controls.Add(btnConvertToYards);
            Controls.Add(btnClear);
            Controls.Add(txtDistanceInches);
            Controls.Add(lblDistanceInches);
            Name = "frmInchYardConverter";
            Text = "Distance Converter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDistanceInches;
        private TextBox txtDistanceInches;
        private Button btnClear;
        private Button btnConvertToYards;
        private Button btnExit;
        private Label lblResult;
    }
}
