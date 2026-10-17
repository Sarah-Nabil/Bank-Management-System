
using BankBusinessLayer;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Bank
{
    public partial class frmTransferLog : Form
    {
        private DataTable _transferLogTable;

        public frmTransferLog()
        {
            InitializeComponent();
            this.Load += frmTransferLog_Load;
            txtSearch.TextChanged += txtSearch_TextChanged;
        }

        private void frmTransferLog_Load(object sender, EventArgs e)
        {
            _LoadTransferLog();
        }

        public void _LoadTransferLog()
        {
            DataTable dt = clsClient.GetAllTransferLog();

            _transferLogTable = dt;
            dgvTransferLog.DataSource = dt;

            lblNumOfTransferLog.Text =
                "Number of Transfers: " + dt.Rows.Count;

            dgvTransferLog.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvTransferLog.ReadOnly = true;
            dgvTransferLog.AllowUserToAddRows = false;
            dgvTransferLog.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvTransferLog.MultiSelect = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(search))
            {
                dgvTransferLog.DataSource = _transferLogTable;
            }
            else
            {
                var rows = _transferLogTable.AsEnumerable()
                    .Where(row =>
                        row["FromAccount"].ToString()
                            .IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0
                        ||
                        row["ToAccount"].ToString()
                            .IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0
                    );

                DataTable filteredTable = _transferLogTable.Clone();

                foreach (DataRow row in rows)
                {
                    filteredTable.ImportRow(row);
                }

                dgvTransferLog.DataSource = filteredTable;
            }

            lblNumOfTransferLog.Text =
                "Number of Transfers: " + dgvTransferLog.Rows.Count;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                dgvTransferLog.DataSource = _transferLogTable;

                lblNumOfTransferLog.Text =
                    "Number of Transfers: " + _transferLogTable.Rows.Count;
            }
        }
        public void RefreshTransferLog()
        {
            _LoadTransferLog();

            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                dgvTransferLog.DataSource = _transferLogTable;

                lblNumOfTransferLog.Text =
                    "Number of Transfers: " + _transferLogTable.Rows.Count;
            }
            else
            {
                btnSearch_Click(btnSearch, EventArgs.Empty);
            }
        }
        private void lblNumOfTransferLog_Click(object sender, EventArgs e)
        {
        }
    }
}
