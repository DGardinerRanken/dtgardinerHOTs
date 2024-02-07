namespace HOT_03_02
{
    partial class frmTestScores
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
            lblEnterTestScore = new Label();
            txtEnterTestScore = new TextBox();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // lblEnterTestScore
            // 
            lblEnterTestScore.BackColor = Color.LightSkyBlue;
            lblEnterTestScore.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblEnterTestScore.Location = new Point(41, 20);
            lblEnterTestScore.Name = "lblEnterTestScore";
            lblEnterTestScore.Size = new Size(301, 51);
            lblEnterTestScore.TabIndex = 5;
            lblEnterTestScore.Text = "Please Enter A Test Score:";
            lblEnterTestScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtEnterTestScore
            // 
            txtEnterTestScore.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtEnterTestScore.Location = new Point(41, 86);
            txtEnterTestScore.Name = "txtEnterTestScore";
            txtEnterTestScore.Size = new Size(301, 38);
            txtEnterTestScore.TabIndex = 0;
            txtEnterTestScore.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.LightBlue;
            btnCalculate.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnCalculate.Location = new Point(41, 137);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(210, 62);
            btnCalculate.TabIndex = 1;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.LightBlue;
            btnClear.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnClear.Location = new Point(296, 137);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(210, 62);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.LightBlue;
            btnExit.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnExit.Location = new Point(549, 137);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(210, 62);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.LightSkyBlue;
            lblResult.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblResult.Location = new Point(41, 224);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(718, 184);
            lblResult.TabIndex = 4;
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmTestScores
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            BackgroundImageLayout = ImageLayout.Center;
            CancelButton = btnClear;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(txtEnterTestScore);
            Controls.Add(lblEnterTestScore);
            Name = "frmTestScores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Test Scores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEnterTestScore;
        private TextBox txtEnterTestScore;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
        private Label lblResult;
    }
}
