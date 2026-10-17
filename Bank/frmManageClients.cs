
using BankBusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace Bank
{
    public partial class frmManageClients : Form
    {
        private DataTable _dtAllClients;

        public frmManageClients()
        {
            InitializeComponent();
        }

        private void _RefreshClientList()
        {
            _dtAllClients = clsClient.GetAllClients();

            dgvManageClients.DataSource = _dtAllClients;

            lblRecords.Text =
                "Clients Count: " + _dtAllClients.Rows.Count;

            if (dgvManageClients.Columns.Contains("ClientID"))
                dgvManageClients.Columns["ClientID"].HeaderText = "Client ID";

            if (dgvManageClients.Columns.Contains("AccountNumber"))
                dgvManageClients.Columns["AccountNumber"].HeaderText = "Account Number";

            if (dgvManageClients.Columns.Contains("FullName"))
                dgvManageClients.Columns["FullName"].HeaderText = "Full Name";

            if (dgvManageClients.Columns.Contains("NationalID"))
                dgvManageClients.Columns["NationalID"].HeaderText = "National ID";

            if (dgvManageClients.Columns.Contains("PinCode"))
                dgvManageClients.Columns["PinCode"].Visible = false;

            if (dgvManageClients.Columns.Contains("CreatedBy"))
                dgvManageClients.Columns["CreatedBy"].HeaderText = "Created By";

            dgvManageClients.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvManageClients.ReadOnly = true;
            dgvManageClients.AllowUserToAddRows = false;
            dgvManageClients.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvManageClients.MultiSelect = false;
        }

        private void frmManageClients_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Client ID");
            comboBox1.Items.Add("Account Number");
            comboBox1.Items.Add("Full Name");
            comboBox1.Items.Add("National ID");
            comboBox1.Items.Add("Phone");
            comboBox1.Items.Add("Email");

            comboBox1.SelectedIndex = 0;

            _RefreshClientList();
        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {
            _RefreshClientList();
            textBox1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_dtAllClients == null)
                return;

            string columnName = "ClientID";

            switch (comboBox1.Text)
            {
                case "Account Number":
                    columnName = "AccountNumber";
                    break;

                case "Full Name":
                    columnName = "FullName";
                    break;

                case "National ID":
                    columnName = "NationalID";
                    break;

                case "Phone":
                    columnName = "Phone";
                    break;

                case "Email":
                    columnName = "Email";
                    break;
            }

            DataView view = _dtAllClients.DefaultView;

            string searchText = textBox1.Text.Trim()
                .Replace("'", "''")
                .Replace("[", "[[]")
                .Replace("%", "[%]")
                .Replace("*", "[*]");

            if (searchText == "")
            {
                view.RowFilter = "";
            }
            else if (columnName == "ClientID")
            {
                if (int.TryParse(searchText, out int id))
                    view.RowFilter = $"ClientID = {id}";
                else
                    view.RowFilter = "1 = 0";
            }
            else
            {
                view.RowFilter =
                    $"Convert([{columnName}], 'System.String') LIKE '%{searchText}%'";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            using (frmAddUpdateClient frm = new frmAddUpdateClient())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    _RefreshClientList();
                }
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvManageClients.CurrentRow == null ||
                dgvManageClients.CurrentRow.IsNewRow)
            {
                MessageBox.Show(
                    "Please select a client first.",
                    "Update Client",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int clientID = Convert.ToInt32(
                dgvManageClients.CurrentRow.Cells["ClientID"].Value);

            using (frmAddUpdateClient frm = new frmAddUpdateClient(clientID))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    _RefreshClientList();
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvManageClients.CurrentRow == null ||
                dgvManageClients.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Please select a client first.");
                return;
            }

            int clientID = Convert.ToInt32(
                dgvManageClients.CurrentRow.Cells["ClientID"].Value);

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this client?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            if (clsClient.Delete(clientID))
            {
                MessageBox.Show("Client deleted successfully.");
                _RefreshClientList();
            }
            else
            {
                MessageBox.Show(
                    "Failed to delete client. The client may be referenced by another record.");
            }
        }

        private void lblNumOfClients_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
    }
}
