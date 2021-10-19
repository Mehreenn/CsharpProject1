
namespace AccountsApp
{
    partial class frmAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpAccDetails = new System.Windows.Forms.GroupBox();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.lblDailyWithdrawLimit = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblAccNumber = new System.Windows.Forms.Label();
            this.tbClientName = new System.Windows.Forms.TextBox();
            this.tbBalance = new System.Windows.Forms.TextBox();
            this.tbDailyWithdrawLimit = new System.Windows.Forms.TextBox();
            this.tbInterestRate = new System.Windows.Forms.TextBox();
            this.tbAccNumber = new System.Windows.Forms.TextBox();
            this.grpAccType = new System.Windows.Forms.GroupBox();
            this.rbtnVisa = new System.Windows.Forms.RadioButton();
            this.rbtnChecking = new System.Windows.Forms.RadioButton();
            this.btnCreateAcc = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.grpAccDetails.SuspendLayout();
            this.grpAccType.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAccDetails
            // 
            this.grpAccDetails.Controls.Add(this.lblInterestRate);
            this.grpAccDetails.Controls.Add(this.lblDailyWithdrawLimit);
            this.grpAccDetails.Controls.Add(this.lblBalance);
            this.grpAccDetails.Controls.Add(this.lblClientName);
            this.grpAccDetails.Controls.Add(this.lblAccNumber);
            this.grpAccDetails.Controls.Add(this.tbClientName);
            this.grpAccDetails.Controls.Add(this.tbBalance);
            this.grpAccDetails.Controls.Add(this.tbDailyWithdrawLimit);
            this.grpAccDetails.Controls.Add(this.tbInterestRate);
            this.grpAccDetails.Controls.Add(this.tbAccNumber);
            this.grpAccDetails.Controls.Add(this.grpAccType);
            this.grpAccDetails.Location = new System.Drawing.Point(45, 111);
            this.grpAccDetails.Name = "grpAccDetails";
            this.grpAccDetails.Size = new System.Drawing.Size(992, 456);
            this.grpAccDetails.TabIndex = 0;
            this.grpAccDetails.TabStop = false;
            this.grpAccDetails.Text = "Account Details";
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Location = new System.Drawing.Point(74, 372);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(107, 20);
            this.lblInterestRate.TabIndex = 11;
            this.lblInterestRate.Text = "Interest Rate:";
            // 
            // lblDailyWithdrawLimit
            // 
            this.lblDailyWithdrawLimit.AutoSize = true;
            this.lblDailyWithdrawLimit.Location = new System.Drawing.Point(74, 290);
            this.lblDailyWithdrawLimit.Name = "lblDailyWithdrawLimit";
            this.lblDailyWithdrawLimit.Size = new System.Drawing.Size(154, 20);
            this.lblDailyWithdrawLimit.TabIndex = 10;
            this.lblDailyWithdrawLimit.Text = "Daily Withdraw Limit:";
            this.lblDailyWithdrawLimit.Click += new System.EventHandler(this.lblDailyWithdrawLimit_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(74, 209);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(71, 20);
            this.lblBalance.TabIndex = 9;
            this.lblBalance.Text = "Balance:";
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(74, 131);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(99, 20);
            this.lblClientName.TabIndex = 8;
            this.lblClientName.Text = "Client Name:";
            // 
            // lblAccNumber
            // 
            this.lblAccNumber.AutoSize = true;
            this.lblAccNumber.Location = new System.Drawing.Point(74, 59);
            this.lblAccNumber.Name = "lblAccNumber";
            this.lblAccNumber.Size = new System.Drawing.Size(132, 20);
            this.lblAccNumber.TabIndex = 7;
            this.lblAccNumber.Text = "Account Number:";
            // 
            // tbClientName
            // 
            this.tbClientName.Location = new System.Drawing.Point(292, 125);
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.Size = new System.Drawing.Size(347, 26);
            this.tbClientName.TabIndex = 6;
            // 
            // tbBalance
            // 
            this.tbBalance.Location = new System.Drawing.Point(292, 203);
            this.tbBalance.Name = "tbBalance";
            this.tbBalance.Size = new System.Drawing.Size(168, 26);
            this.tbBalance.TabIndex = 5;
            // 
            // tbDailyWithdrawLimit
            // 
            this.tbDailyWithdrawLimit.Location = new System.Drawing.Point(292, 284);
            this.tbDailyWithdrawLimit.Name = "tbDailyWithdrawLimit";
            this.tbDailyWithdrawLimit.Size = new System.Drawing.Size(168, 26);
            this.tbDailyWithdrawLimit.TabIndex = 4;
            // 
            // tbInterestRate
            // 
            this.tbInterestRate.Location = new System.Drawing.Point(292, 366);
            this.tbInterestRate.Name = "tbInterestRate";
            this.tbInterestRate.Size = new System.Drawing.Size(168, 26);
            this.tbInterestRate.TabIndex = 3;
            // 
            // tbAccNumber
            // 
            this.tbAccNumber.Location = new System.Drawing.Point(292, 53);
            this.tbAccNumber.Name = "tbAccNumber";
            this.tbAccNumber.Size = new System.Drawing.Size(168, 26);
            this.tbAccNumber.TabIndex = 1;
            // 
            // grpAccType
            // 
            this.grpAccType.Controls.Add(this.rbtnVisa);
            this.grpAccType.Controls.Add(this.rbtnChecking);
            this.grpAccType.Location = new System.Drawing.Point(690, 53);
            this.grpAccType.Name = "grpAccType";
            this.grpAccType.Size = new System.Drawing.Size(246, 229);
            this.grpAccType.TabIndex = 0;
            this.grpAccType.TabStop = false;
            this.grpAccType.Text = "Type Of Account";
            // 
            // rbtnVisa
            // 
            this.rbtnVisa.AutoSize = true;
            this.rbtnVisa.Location = new System.Drawing.Point(38, 140);
            this.rbtnVisa.Name = "rbtnVisa";
            this.rbtnVisa.Size = new System.Drawing.Size(65, 24);
            this.rbtnVisa.TabIndex = 2;
            this.rbtnVisa.TabStop = true;
            this.rbtnVisa.Text = "Visa";
            this.rbtnVisa.UseVisualStyleBackColor = true;
            // 
            // rbtnChecking
            // 
            this.rbtnChecking.AutoSize = true;
            this.rbtnChecking.Location = new System.Drawing.Point(38, 72);
            this.rbtnChecking.Name = "rbtnChecking";
            this.rbtnChecking.Size = new System.Drawing.Size(100, 24);
            this.rbtnChecking.TabIndex = 1;
            this.rbtnChecking.TabStop = true;
            this.rbtnChecking.Text = "Checking";
            this.rbtnChecking.UseVisualStyleBackColor = true;
            this.rbtnChecking.CheckedChanged += new System.EventHandler(this.rbtnChecking_CheckedChanged);
            // 
            // btnCreateAcc
            // 
            this.btnCreateAcc.Location = new System.Drawing.Point(879, 587);
            this.btnCreateAcc.Name = "btnCreateAcc";
            this.btnCreateAcc.Size = new System.Drawing.Size(158, 52);
            this.btnCreateAcc.TabIndex = 1;
            this.btnCreateAcc.Text = "Create Account";
            this.btnCreateAcc.UseVisualStyleBackColor = true;
            this.btnCreateAcc.Click += new System.EventHandler(this.btnCreateAcc_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(879, 46);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(157, 40);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(670, 53);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(189, 26);
            this.tbSearch.TabIndex = 3;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(455, 56);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(209, 20);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Search By Account Number:";
            // 
            // frmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 665);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnCreateAcc);
            this.Controls.Add(this.grpAccDetails);
            this.Name = "frmAccount";
            this.Text = "Accounts";
            this.grpAccDetails.ResumeLayout(false);
            this.grpAccDetails.PerformLayout();
            this.grpAccType.ResumeLayout(false);
            this.grpAccType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAccDetails;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.Label lblDailyWithdrawLimit;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblAccNumber;
        private System.Windows.Forms.TextBox tbClientName;
        private System.Windows.Forms.TextBox tbBalance;
        private System.Windows.Forms.TextBox tbDailyWithdrawLimit;
        private System.Windows.Forms.TextBox tbInterestRate;
        private System.Windows.Forms.TextBox tbAccNumber;
        private System.Windows.Forms.GroupBox grpAccType;
        private System.Windows.Forms.RadioButton rbtnVisa;
        private System.Windows.Forms.RadioButton rbtnChecking;
        private System.Windows.Forms.Button btnCreateAcc;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lblSearch;
    }
}

