
using BankBusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace Bank
{
    public partial class frmWithdraw : Form
    {
        private clsClient Client = null;

        public  frmWithdraw()
        {
            InitializeComponent();
        }
        private void _FillAccountNumbersComboBox()
        {
            cbAccountsNumber.Items.Clear();

            DataTable dt = clsClient.GetAllClients();

            foreach (DataRow row in dt.Rows)
            {
                if (Convert.ToDecimal(row["Balance"]) > 0)
                {
                    cbAccountsNumber.Items.Add(row["AccountNumber"]);
                }
            }
        }

        private void _ReloadPage()
        {
            if (string.IsNullOrWhiteSpace(cbAccountsNumber.Text))
            {
                Client = null;
                lblBalanceAmount.Text = "0$";
                return;
            }

            Client = clsClient.GetClientInfoByAccountNum(
                cbAccountsNumber.Text);

            if (Client == null)
            {
                lblBalanceAmount.Text = "0$";
                return;
            }

            lblBalanceAmount.Text = Client.Balance.ToString("0") + "$";
        }
        private void frmWithdraw_Load_1(object sender, EventArgs e)
        {
            _FillAccountNumbersComboBox();

            if (cbAccountsNumber.Items.Count > 0)
            {
                cbAccountsNumber.SelectedIndex = 0;
            }
            else
            {
                Client = null;
                lblBalanceAmount.Text = "0$";

                MessageBox.Show(
                    "No accounts with available balance.",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void cbAccountsNumber_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            _ReloadPage();
        }

        private void btnWithdraw_Click_1(object sender, EventArgs e)
        {
            if (Client == null)
            {
                MessageBox.Show(
                    "Please select an account first.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            decimal amount = nudWithdrawAmount.Value;

            if (amount <= 0)
            {
                MessageBox.Show(
                    "Please enter an amount greater than zero.",
                    "Invalid Amount",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (amount > Client.Balance)
            {
                MessageBox.Show(
                    "Insufficient balance.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to withdraw [" + amount +
                "]$ from account [" + Client.AccountNumber + "]?",
                "Confirm Withdrawal",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            if (Client.Withdraw(amount))
            {
                MessageBox.Show(
                    "Withdrawal completed successfully.",
                    "Done",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                _FillAccountNumbersComboBox();

                if (cbAccountsNumber.Items.Count > 0)
                {
                    cbAccountsNumber.SelectedIndex = 0;
                }
                else
                {
                    Client = null;
                    lblBalanceAmount.Text = "0$";

                    MessageBox.Show(
                        "No accounts with available balance.",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(
                    "Withdrawal failed. Please check the account balance and try again.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            _FillAccountNumbersComboBox();

            if (cbAccountsNumber.Items.Count > 0)
            {
                cbAccountsNumber.SelectedIndex = 0;
            }
            else
            {
                Client = null;
                lblBalanceAmount.Text = "0$";

                MessageBox.Show(
                    "No accounts with available balance.",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
