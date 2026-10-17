
using BankBusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace Bank
{
    public partial class frmLoginRegister : Form
    {
        public frmLoginRegister()
        {
            InitializeComponent();

            this.Load += FrmLoginRegister_Load;
            btnsearch.Click += Btnsearch_Click;
            txtSearchUserName.TextChanged += TxtSearchUserName_TextChanged;
        }

        private void FrmLoginRegister_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers(string userName = "")
        {
            try
            {
                // Retrieve users through the Business Layer
                DataTable users = clsUser.GetUsers(userName);

                dataGridView1.DataSource = users;

                // Configure the grid
                dataGridView1.ReadOnly = true;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AllowUserToDeleteRows = false;
                dataGridView1.MultiSelect = false;
                dataGridView1.RowHeadersVisible = false;

                dataGridView1.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

                dataGridView1.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                // Hide the internal ID
                if (dataGridView1.Columns.Contains("UserID"))
                {
                    dataGridView1.Columns["UserID"].Visible = false;
                }

                if (dataGridView1.Columns.Contains("UserName"))
                {
                    dataGridView1.Columns["UserName"].HeaderText = "User Name";
                }

                if (dataGridView1.Columns.Contains("Password"))
                {
                    dataGridView1.Columns["Password"].HeaderText = "Password";
                }

                if (dataGridView1.Columns.Contains("DateCreated"))
                {
                    dataGridView1.Columns["DateCreated"].HeaderText =
                        "Date Created";

                    dataGridView1.Columns["DateCreated"]
                        .DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";
                }

                if (dataGridView1.Columns.Contains("Permissions"))
                {
                    dataGridView1.Columns["Permissions"].HeaderText =
                        "Permissions";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load users.\n" + ex.Message,
                    "Login Register",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void Btnsearch_Click(object sender, EventArgs e)
        {
            LoadUsers(txtSearchUserName.Text.Trim());
        }

        private void TxtSearchUserName_TextChanged(
            object sender, EventArgs e)
        {
            // Restore all users when the search box is cleared.
            if (string.IsNullOrWhiteSpace(txtSearchUserName.Text))
            {
                LoadUsers();
            }
        }
    }
}
