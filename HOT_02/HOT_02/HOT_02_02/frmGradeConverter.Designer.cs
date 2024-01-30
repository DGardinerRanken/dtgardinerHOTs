namespace HOT_02_02
{
    partial class frmGradeConverter
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
            txtGPA = new TextBox();
            lblGPA = new Label();
            lblResult = new Label();
            btnLetterGrade = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // txtGPA
            // 
            txtGPA.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtGPA.Location = new Point(301, 131);
            txtGPA.Name = "txtGPA";
            txtGPA.Size = new Size(207, 38);
            txtGPA.TabIndex = 0;
            txtGPA.TextAlign = HorizontalAlignment.Center;
            // 
            // lblGPA
            // 
            lblGPA.BackColor = Color.MistyRose;
            lblGPA.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblGPA.Location = new Point(335, 67);
            lblGPA.Name = "lblGPA";
            lblGPA.Size = new Size(133, 45);
            lblGPA.TabIndex = 1;
            lblGPA.Text = "GPA:";
            lblGPA.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.MistyRose;
            lblResult.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblResult.Location = new Point(244, 323);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(321, 74);
            lblResult.TabIndex = 2;
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLetterGrade
            // 
            btnLetterGrade.BackColor = Color.PeachPuff;
            btnLetterGrade.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnLetterGrade.Location = new Point(113, 216);
            btnLetterGrade.Name = "btnLetterGrade";
            btnLetterGrade.Size = new Size(166, 77);
            btnLetterGrade.TabIndex = 3;
            btnLetterGrade.Text = "Find Letter &Grade";
            btnLetterGrade.UseVisualStyleBackColor = false;
            btnLetterGrade.Click += btnLetterGrade_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.PeachPuff;
            btnClear.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnClear.Location = new Point(323, 216);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(166, 77);
            btnClear.TabIndex = 4;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.PeachPuff;
            btnExit.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnExit.Location = new Point(528, 216);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(166, 77);
            btnExit.TabIndex = 5;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // frmGradeConverter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnLetterGrade);
            Controls.Add(lblResult);
            Controls.Add(lblGPA);
            Controls.Add(txtGPA);
            Name = "frmGradeConverter";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtGPA;
        private Label lblGPA;
        private Label lblResult;
        private Button btnLetterGrade;
        private Button btnClear;
        private Button btnExit;
    }
}
