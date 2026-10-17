
using MyBankProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class frmTransactions : Form
    {
        private frmTransferLog transferLogForm;

        public frmTransactions()
        {
            InitializeComponent();

            this.Load += frmTransactions_Load;

            tabTransactions.SelectedIndexChanged +=
                tabTransactions_SelectedIndexChanged;
        }

        private void frmTransactions_Load(object sender, EventArgs e)
        {
            // Deposit
            frmDepositScreen depositForm = new frmDepositScreen();

            depositForm.TopLevel = false;
            depositForm.FormBorderStyle = FormBorderStyle.None;
            depositForm.Dock = DockStyle.Fill;

            tbDeposite.Controls.Clear();
            tbDeposite.Controls.Add(depositForm);

            depositForm.Show();


            // Withdraw
            frmWithdraw withdrawForm = new frmWithdraw();

            withdrawForm.TopLevel = false;
            withdrawForm.FormBorderStyle = FormBorderStyle.None;
            withdrawForm.Dock = DockStyle.Fill;

            tbWithdraw.Controls.Clear();
            tbWithdraw.Controls.Add(withdrawForm);

            withdrawForm.Show();


            // Total Balances
            frmTotalBalances totalBalancesForm = new frmTotalBalances();

            totalBalancesForm.TopLevel = false;
            totalBalancesForm.FormBorderStyle = FormBorderStyle.None;
            totalBalancesForm.Dock = DockStyle.Fill;

            tbTotalBalance.Controls.Clear();
            tbTotalBalance.Controls.Add(totalBalancesForm);

            totalBalancesForm.Show();


            // Transfer
            frmTransferScreen transferForm = new frmTransferScreen();

            transferForm.TopLevel = false;
            transferForm.FormBorderStyle = FormBorderStyle.None;
            transferForm.Dock = DockStyle.Fill;

            tbTransfer.Controls.Clear();
            tbTransfer.Controls.Add(transferForm);

            transferForm.Show();


            // Transfer Log
            transferLogForm = new frmTransferLog();

            transferLogForm.TopLevel = false;
            transferLogForm.FormBorderStyle = FormBorderStyle.None;
            transferLogForm.Dock = DockStyle.Fill;

            tbTransferLog.Controls.Clear();
            tbTransferLog.Controls.Add(transferLogForm);

            transferLogForm.Show();
        }

        private void tabTransactions_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            if (tabTransactions.SelectedTab == tbTransferLog &&
                transferLogForm != null)
            {
                transferLogForm.RefreshTransferLog();
            }
        }

        private void tbTotalBalance_Click(object sender, EventArgs e)
        {
        }
    }
}
