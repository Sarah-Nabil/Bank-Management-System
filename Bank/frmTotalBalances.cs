using BankBusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace Bank
{
    public partial class frmTotalBalances : Form
    {
        public frmTotalBalances()
        {
            InitializeComponent();
            this.Load += frmTotalBalances_Load;
        }

        private void _FillListWithClients()
        {
            DataTable dt = clsClient.GetAllClients();

            dgvtotalamount.AutoGenerateColumns = true;
            dgvtotalamount.DataSource = null;
            dgvtotalamount.DataSource = dt;

            // عرض عدد العملاء
            lblNumOfClients.Text = dt.Rows.Count.ToString();

            // حساب إجمالي الأرصدة
            decimal totalAmount = 0;

            foreach (DataRow row in dt.Rows)
            {
                if (row["Balance"] != DBNull.Value)
                {
                    totalAmount += Convert.ToDecimal(row["Balance"]);
                }
            }

            lblTotalAmount.Text = totalAmount.ToString("0.00") + "$";
        }

        private void frmTotalBalances_Load(object sender, EventArgs e)
        {
            _FillListWithClients();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string accountNumber = txtSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(accountNumber))
            {
                _FillListWithClients();
                return;
            }

            DataTable dt = clsClient.FindClientByAccNO(accountNumber);

            dgvtotalamount.DataSource = dt;
            lblNumOfClients.Text = dt.Rows.Count.ToString();

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show(
                    "Account not found.",
                    "Search",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void lblTotalAmount_Click(object sender, EventArgs e)
        {

        }
    }
}