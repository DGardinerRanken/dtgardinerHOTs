namespace HOT_04_02
{
    partial class frmNameList
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
            lblEnterAName = new Label();
            lblNameList = new Label();
            txtEnterAName = new TextBox();
            btnAddName = new Button();
            btnUpdateName = new Button();
            btnDeleteName = new Button();
            btnExit = new Button();
            btnClear = new Button();
            lb_Names = new ListView();
            SuspendLayout();
            // 
            // lblEnterAName
            // 
            lblEnterAName.BackColor = Color.Snow;
            lblEnterAName.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblEnterAName.Location = new Point(98, 39);
            lblEnterAName.Name = "lblEnterAName";
            lblEnterAName.Size = new Size(207, 36);
            lblEnterAName.TabIndex = 0;
            lblEnterAName.Text = "Enter A Name";
            lblEnterAName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNameList
            // 
            lblNameList.BackColor = Color.Snow;
            lblNameList.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblNameList.Location = new Point(427, 39);
            lblNameList.Name = "lblNameList";
            lblNameList.Size = new Size(207, 36);
            lblNameList.TabIndex = 1;
            lblNameList.Text = "Name List";
            lblNameList.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtEnterAName
            // 
            txtEnterAName.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold);
            txtEnterAName.Location = new Point(98, 101);
            txtEnterAName.Name = "txtEnterAName";
            txtEnterAName.Size = new Size(207, 32);
            txtEnterAName.TabIndex = 2;
            // 
            // btnAddName
            // 
            btnAddName.BackColor = Color.PeachPuff;
            btnAddName.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            btnAddName.Location = new Point(98, 161);
            btnAddName.Name = "btnAddName";
            btnAddName.Size = new Size(207, 35);
            btnAddName.TabIndex = 4;
            btnAddName.Text = "Add Name";
            btnAddName.UseVisualStyleBackColor = false;
            btnAddName.Click += btnAddName_Click;
            // 
            // btnUpdateName
            // 
            btnUpdateName.BackColor = Color.PeachPuff;
            btnUpdateName.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            btnUpdateName.Location = new Point(98, 214);
            btnUpdateName.Name = "btnUpdateName";
            btnUpdateName.Size = new Size(207, 35);
            btnUpdateName.TabIndex = 5;
            btnUpdateName.Text = "Update Name";
            btnUpdateName.UseVisualStyleBackColor = false;
            btnUpdateName.Click += btnUpdateName_Click;
            // 
            // btnDeleteName
            // 
            btnDeleteName.BackColor = Color.PeachPuff;
            btnDeleteName.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            btnDeleteName.Location = new Point(98, 273);
            btnDeleteName.Name = "btnDeleteName";
            btnDeleteName.Size = new Size(207, 35);
            btnDeleteName.TabIndex = 6;
            btnDeleteName.Text = "Delete Name";
            btnDeleteName.UseVisualStyleBackColor = false;
            btnDeleteName.Click += btnDeleteName_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.PeachPuff;
            btnExit.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            btnExit.Location = new Point(98, 384);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(207, 35);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.PeachPuff;
            btnClear.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            btnClear.Location = new Point(98, 328);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(207, 35);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // lb_Names
            // 
            lb_Names.Alignment = ListViewAlignment.Left;
            lb_Names.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Names.LabelWrap = false;
            lb_Names.Location = new Point(427, 101);
            lb_Names.MultiSelect = false;
            lb_Names.Name = "lb_Names";
            lb_Names.Size = new Size(207, 305);
            lb_Names.TabIndex = 9;
            lb_Names.UseCompatibleStateImageBehavior = false;
            
            // 
            // frmNameList
            // 
            AcceptButton = btnAddName;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            CancelButton = btnClear;
            ClientSize = new Size(744, 431);
            Controls.Add(lb_Names);
            Controls.Add(btnClear);
            Controls.Add(btnExit);
            Controls.Add(btnDeleteName);
            Controls.Add(btnUpdateName);
            Controls.Add(btnAddName);
            Controls.Add(txtEnterAName);
            Controls.Add(lblNameList);
            Controls.Add(lblEnterAName);
            Name = "frmNameList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hot 04 - #2 Name List";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEnterAName;
        private Label lblNameList;
        private TextBox txtEnterAName;
        private Button btnAddName;
        private Button btnUpdateName;
        private Button btnDeleteName;
        private Button btnExit;
        private Button btnClear;
        private ListView lb_Names;
    }
}
