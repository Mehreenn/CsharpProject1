using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountsApp
{
    public partial class frmAccount : Form
    {
        private List<Account> accounts = new List<Account>();
        public frmAccount()
        {
            InitializeComponent();

        }

        private void lblDailyWithdrawLimit_Click(object sender, EventArgs e)
        {

        }

        private void rbtnChecking_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnChecking.Checked == true)
            {
                tbDailyWithdrawLimit.Enabled = true;
                tbInterestRate.Enabled = false;
            }
            else
            {
                tbDailyWithdrawLimit.Enabled = false;
                tbInterestRate.Enabled = true;
            }
        }

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbtnChecking.Checked)
                {
                    CheckingAccount myCheckingAccount = new CheckingAccount(int.Parse(tbAccNumber.Text),
                        tbClientName.Text, double.Parse(tbBalance.Text), double.Parse(tbDailyWithdrawLimit.Text));
                    accounts.Add(myCheckingAccount);
                }
                else
                {
                    VisaAccount myVisaAccount = new VisaAccount(int.Parse(tbAccNumber.Text),
                        tbClientName.Text, double.Parse(tbBalance.Text), double.Parse(tbInterestRate.Text));
                    accounts.Add(myVisaAccount);
                }
                tbAccNumber.Text = "";
                tbClientName.Text = "";
                tbBalance.Text = "";

                tbDailyWithdrawLimit.Text = "";
                tbInterestRate.Text = "";

                rbtnChecking.Checked = true;

                MessageBox.Show($"Total Number of Accounts Stored: {accounts.Count}");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool accFound = false;
            foreach (Account a in accounts)
            {
                if (a.Number == double.Parse(tbSearch.Text))
                {
                    accFound = true;
                    tbAccNumber.Text = a.Number.ToString();
                    tbClientName.Text = a.ClientName;
                    tbBalance.Text = a.Balance.ToString();
                }

                if (a is CheckingAccount)
                {
                    tbDailyWithdrawLimit.Text = (a as CheckingAccount).WithdrawLimit.ToString();

                    rbtnChecking.Checked = true;
                    rbtnVisa.Checked = false;
                }
                else
                    if (a is VisaAccount)
                {
                    tbInterestRate.Text = (a as VisaAccount).InterestRate.ToString();
                    rbtnChecking.Checked = false;
                    rbtnVisa.Checked = true;
                }
                break;
            }
            if (!accFound)
                MessageBox.Show("No such Account has been found!");
        }
    }
}

