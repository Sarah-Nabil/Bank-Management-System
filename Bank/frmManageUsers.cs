using Bank.NewFolder1;
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

namespace Bank
{
    public partial class frmManageUsers : Form

    {


        private DataTable _dtAllUsers;
    
        public frmManageUsers()
        {
            InitializeComponent();
        }


        //private void ApplyActionsPermissions()
        //{

        //    if (clsGlobal.CurrentUser == null)
        //        return;

        //    btnAdd.Enabled =
        //        clsGlobal.CurrentUser.HasActionPermission(
        //            clsUser.enActionsPermissions.Add);

        //    updateToolStripMenuItem.Enabled =
        //        clsGlobal.CurrentUser.HasActionPermission(
        //            clsUser.enActionsPermissions.Update);

        //    deleteToolStripMenuItem.Enabled =
        //        clsGlobal.CurrentUser.HasActionPermission(
        //            clsUser.enActionsPermissions.Delete);
        //}

        private void ApplyActionsPermissions()
        {
            clsUser currentUser = clsGlobal.CurrentUser;

            if (currentUser == null)
            {
                btnAdd.Enabled = false;
                updateToolStripMenuItem.Enabled = false;
                deleteToolStripMenuItem.Enabled = false;
                return;
            }

            // Admin has access to every module.
            bool isAdmin = currentUser.RoleID == 1;

            // Other users must have permission to manage users.
            bool canManageUsers =
                isAdmin ||
                currentUser.HasPermission(
                    clsUser.enPermissions.pManageUsers);

            // Actions are determined by the user's role.
            btnAdd.Enabled =
                canManageUsers &&
                currentUser.HasActionPermission(
                    clsUser.enActionsPermissions.Add);

            updateToolStripMenuItem.Enabled =
                canManageUsers &&
                currentUser.HasActionPermission(
                    clsUser.enActionsPermissions.Update);

            deleteToolStripMenuItem.Enabled =
                canManageUsers &&
                currentUser.HasActionPermission(
                    clsUser.enActionsPermissions.Delete);
        }
        private void _RefreshUserList()
        {
            _dtAllUsers = clsUser.GetAllUsers();
            dgvManageUsers.DataSource = _dtAllUsers;
            dgvManageUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lblRecords.Text = dgvManageUsers.Rows.Count.ToString();



        }
        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            _RefreshUserList();
            ApplyActionsPermissions();

            cbFilter.SelectedIndex = 0;


            if (dgvManageUsers.Rows.Count > 0)
            {

                dgvManageUsers.Columns[0].HeaderText = "User ID";
                //dgvManageUsers    .Columns[0].Width = 110;

                dgvManageUsers.Columns[1].HeaderText = "User Name";
                //  dgvAllUsers.Columns[1].Width = 120;

                dgvManageUsers.Columns[2].HeaderText = "Full Name";
                //  dgvAllUsers.Columns[2].Width = 350;

                dgvManageUsers.Columns[3].HeaderText = "Email";
                //  dgvAllUsers.Columns[3].Width = 120;
                dgvManageUsers.Columns[4].HeaderText = "Phone";
                
                dgvManageUsers.Columns[5].HeaderText = "Role Name";

                dgvManageUsers.Columns[6].HeaderText = "Permissions";
                // dgvAllUsers.Columns[4].Width = 120;

                dgvManageUsers.Columns[7].HeaderText = "Is Active";
                //  dgvAllUsers.Columns[5].Width = 120;

            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser();
            frm.ShowDialog();   
            frmManageUsers_Load(null, null); 
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbFilter.Text == "Is Active")
            {
                txtFilterValue.Visible = false;
                cbIsActive.Visible = true;
                cbIsActive.Focus();
                cbIsActive.SelectedIndex = 0;
            }
            else
            {
                cbIsActive.Visible = false;
                txtFilterValue.Visible = (cbFilter.Text != "None");
                txtFilterValue.Focus();
                txtFilterValue.Text = "";

            }
        }
        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "IsActive";
            string FilterValue = cbIsActive.Text;
            switch (FilterValue)
            {
                case "All":
                    break;

                case "Yes":
                    FilterValue = "1";
                    break;
                case "No":
                    FilterValue = "0";
                    break;

            }


            if (FilterValue == "All")
            {
                _dtAllUsers.DefaultView.RowFilter = "";

            }
            else
            {
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);
            }

            lblRecords.Text = dgvManageUsers.Rows.Count.ToString();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch (cbFilter.Text)
            {
                case "User ID":
                    FilterColumn = "UserID";
                    break;

                case "UserName":
                    FilterColumn = "UserName";
                    break;

                case "Full Name":
                    FilterColumn = "FullName";
                    break;

                case "Role Name":
                    FilterColumn = "RoleName";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }


            if (txtFilterValue.Text == "" || FilterColumn == "None")
            {
                _dtAllUsers.DefaultView.RowFilter = "";
                lblRecords.Text = dgvManageUsers.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "UserID" )
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());



            lblRecords.Text = dgvManageUsers.Rows.Count.ToString();

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvManageUsers.CurrentRow.Cells[0].Value;
            frmAddUpdateUser frm = new frmAddUpdateUser(UserID);
            frm.ShowDialog();
            frmManageUsers_Load(null, null);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvManageUsers.CurrentRow.Cells[0].Value;

            if (MessageBox.Show("Are You Sure You Want To Delete This User [ " + UserID.ToString() + "]", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (clsUser.Delete(UserID))
                {
                    MessageBox.Show("User has been deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frmManageUsers_Load(null, null);

                }
                else
                {
                    MessageBox.Show("User is not delted due to data connected to it.", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
            }
        }

     
    }
}
