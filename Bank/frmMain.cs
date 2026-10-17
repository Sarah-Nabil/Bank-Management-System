
using Bank.NewFolder1;
using BankBusinessLayer;
using System;
using System.Windows.Forms;

namespace Bank
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            // Ensure the Load event is connected exactly once.
            this.Load -= frmMain_Load;
            this.Load += frmMain_Load;
        }

        // =========================
        // Open Forms Inside Panel
        // =========================

        private void OpenFormInPanel(Form frm)
        {
            panel2.Controls.Clear();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            panel2.Controls.Add(frm);
            panel2.Tag = frm;

            frm.Show();
        }

        // =========================
        // Apply Module Permissions
        // =========================


        private void ApplyModulePermissions()
        {
            var currentUser = clsGlobal.CurrentUser;

            if (currentUser == null)
            {
                btnManageClients.Enabled = false;
                btnManageUsers.Enabled = false;
                btnTransactions.Enabled = false;
                btnCurrency.Enabled = false;
                btnLoginRegister.Enabled = false;
                return;
            }

            string roleName = currentUser.RoleInfo?.RoleName ?? "";

            bool isAdmin =
                string.Equals(
                    roleName,
                    "Admin",
                    StringComparison.OrdinalIgnoreCase)
                ||
                string.Equals(
                    roleName,
                    "Administrator",
                    StringComparison.OrdinalIgnoreCase);

            // Only Admin automatically gets every module.
            // Other users must have explicit, valid permissions.
            int permissions = currentUser.Permissions;

            btnManageClients.Enabled =
                isAdmin ||
                (permissions > 0 &&
                 (permissions & (int)clsUser.enPermissions.pClientList) != 0);

            btnManageUsers.Enabled =
                isAdmin ||
                (permissions > 0 &&
                 (permissions & (int)clsUser.enPermissions.pManageUsers) != 0);

            btnTransactions.Enabled =
                isAdmin ||
                (permissions > 0 &&
                 (permissions & (int)clsUser.enPermissions.pTransactions) != 0);

            btnCurrency.Enabled =
                isAdmin ||
                (permissions > 0 &&
                 (permissions & (int)clsUser.enPermissions.pCurrencyExchange) != 0);

            btnLoginRegister.Enabled =
                isAdmin ||
                (permissions > 0 &&
                 (permissions & (int)clsUser.enPermissions.pLoginRegisters) != 0);
        }


        // =========================
        // Buttons
        // =========================

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmManageUsers());
        }

        private void btnManageClients_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmManageClients());
        }

        private void btnTransactions_Click_1(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmTransactions());
        }

        private void btnCurrency_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmCurrencyExchang());
        }

        private void btnLoginRegister_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmLoginRegister());
        }

        // =========================
        // Current User Information
        // =========================

        private void LoadCurrentUserInfo()
        {
            clsUser currentUser = clsGlobal.CurrentUser;

            if (currentUser == null)
                return;

            lblFullName.Text = currentUser.FullName;
            lblUserName.Text = currentUser.UserName;

            if (currentUser.RoleInfo != null)
            {
                lblRoleName.Text = currentUser.RoleInfo.RoleName;
            }
            else
            {
                lblRoleName.Text = "Unknown";
            }
        }

        // =========================
        // Form Load
        // =========================

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadCurrentUserInfo();
            ApplyModulePermissions();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmLogin frm = new frmLogin();
            frm.ShowDialog();

            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        //private void frmMain_Load(object sender, EventArgs e)
        //{
        //    LoadCurrentUserInfo();
        //    ApplyModulePermissions();

        //    var user = clsGlobal.CurrentUser;

        //    if (user == null)
        //    {
        //        MessageBox.Show("CurrentUser is NULL!");
        //        return;
        //    }

        //    MessageBox.Show(
        //        "Username: " + user.UserName +
        //        "\nRoleID: " + user.RoleID +
        //        "\nPermissions: " + user.Permissions +
        //        "\n\nManage Clients: " + btnManageClients.Enabled +
        //        "\nManage Users: " + btnManageUsers.Enabled +
        //        "\nTransactions: " + btnTransactions.Enabled +
        //        "\nCurrency Exchange: " + btnCurrency.Enabled +
        //        "\nLogin/Register: " + btnLoginRegister.Enabled,
        //        "Permissions Diagnostic");
        //    }
        }



    }

