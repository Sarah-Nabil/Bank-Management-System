using BankBusinessLayer;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBankProject
{
    public partial class frmDepositScreen : Form
    {
        public frmDepositScreen()
        {
            InitializeComponent();
        }

        clsClient Client = new clsClient();

        private void _FillAccountNumbersComboBox()
        {
            DataTable dt = clsClient.GetAllClients();
            foreach (DataRow row in dt.Rows)
            {
                cbAccountsNumber.Items.Add(row["AccountNumber"]);

            }

            cbAccountsNumber.SelectedIndex = 0;
        }


        public void _ReloadPage()
        {
            Client = clsClient.GetClientInfoByAccountNum(cbAccountsNumber.Text);

            if (Client == null)
            {
                lblBalanceAmount.Text = "0$";

                MessageBox.Show("Client not found. Check the account number.");

                return;
            }

            lblBalanceAmount.Text = Client.Balance.ToString() + "$";
        }




        private void btnDeposit_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Are You Sure You Want To Deposit [" + nudDepositAmount.Value + "] To Account With Number [" + cbAccountsNumber.Text + "]?", "Confirm",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (Client.Deposite((decimal)nudDepositAmount.Value))
                {
                    MessageBox.Show("Deposit Completed Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _ReloadPage();
                }
                else
                {
                    MessageBox.Show("Deposit Operation Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }

        private void cbAccountsNumber_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            _ReloadPage();  
        }

        private void frmDepositScreen_Load_1(object sender, EventArgs e)
        {
            _FillAccountNumbersComboBox();  
        }
    }
}
