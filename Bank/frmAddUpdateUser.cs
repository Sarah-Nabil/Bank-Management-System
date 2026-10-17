using Bank.Global_Classes;
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
using static System.Windows.Forms.AxHost;

namespace Bank
{
    public partial class frmAddUpdateUser : Form
    {
        public enum enMode { Add = 0, Update = 1 }
        enMode _Mode = enMode.Add;
        private int _UserID = -1;
        private clsUser _User;
        private int _Permissions = 0;
        public frmAddUpdateUser()
        {
            InitializeComponent();
            _Mode = enMode.Add;
        }

        public frmAddUpdateUser(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            _Mode = enMode.Update;
        }


        private void _LoadComboBox()
        {
            DataTable dt = clsRole.GetAllRoles();

            cbRole.DisplayMember = "RoleName";
            cbRole.ValueMember = "RoleID";
            cbRole.DataSource = dt;

        }

        private void _ResetDefaultValues()
        {
            if (_Mode == enMode.Add)
            {

                lblTitle.Text = "Add New User";
                this.Text = "Add New User";
                _User = new clsUser();

            }
            else
            {
                lblTitle.Text = "Update User";
                this.Text = "Update User";

            }






        }

        private void _LoadPermissions(int permissions)
        {
            chkAll.Checked = false;
            chkClientList.Checked = false;
            chkManageUsers.Checked = false;
            chkTransactions.Checked = false;
            chkCurrencyExchange.Checked = false;
            chkLoginRegisters.Checked = false;



            if (permissions == -1)
            {
                chkAll.Checked = true;
                return;
            }

            chkClientList.Checked =
                (permissions & (int)clsUser.enPermissions.pClientList) != 0;

            chkManageUsers.Checked =
                (permissions & (int)clsUser.enPermissions.pManageUsers) != 0;

            chkTransactions.Checked =
                (permissions & (int)clsUser.enPermissions.pTransactions) != 0;

            chkCurrencyExchange.Checked =
                (permissions & (int)clsUser.enPermissions.pCurrencyExchange) != 0;

            chkLoginRegisters.Checked =
                (permissions & (int)clsUser.enPermissions.pLoginRegisters) != 0;
        }
        private void _LoadData()
        {
            _User = clsUser.Find(_UserID);



            if (_User == null)
            {
                MessageBox.Show("No User with ID = " + _UserID, "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();

                return;


            }


            txtUserName.Text = _User.UserName;
            txtPassword.Text = _User.Password;
            txtEmail.Text = _User.Email;
            txtFullName.Text = _User.FullName;
            txtPhone.Text = _User.Phone;
            chkIsActive.Checked = _User.IsActive;
          
            _LoadPermissions(_User.Permissions);




        }

     

        private int _BuildPermissions()
        {
            int permissions = 0;

            if (chkAll.Checked)
                return -1; // eAll

            if (chkClientList.Checked)
                permissions += (int)clsUser.enPermissions.pClientList;

            if (chkManageUsers.Checked)
                permissions += (int)clsUser.enPermissions.pManageUsers;

            if (chkTransactions.Checked)
                permissions += (int)clsUser.enPermissions.pTransactions;

            if (chkCurrencyExchange.Checked)
                permissions += (int)clsUser.enPermissions.pCurrencyExchange;

            if (chkLoginRegisters.Checked)
                permissions += (int)clsUser.enPermissions.pLoginRegisters;

            return permissions;
        }


        private bool _HasAnyPermissionSelected()
        {
            return chkClientList.Checked ||
                   chkManageUsers.Checked ||
                   chkTransactions.Checked ||
                   chkCurrencyExchange.Checked ||
                   chkLoginRegisters.Checked ||
                   chkAll.Checked;

        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!_HasAnyPermissionSelected())
            {
                MessageBox.Show("You must assign at least one permission!","Validation Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);

                return;
            }



            _User.UserName = txtUserName.Text;
            _User.Password = txtPassword.Text;
            _User.FullName = txtFullName.Text;
            _User.Email = txtEmail.Text;
            _User.Phone = txtPhone.Text;

            _User.RoleID = Convert.ToInt32(cbRole.SelectedValue);

            _User.Permissions = _BuildPermissions();

            _User.IsActive = chkIsActive.Checked;


          

            if (_User.Save())
            {
                MessageBox.Show("User saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to save user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {

            txtPassword.UseSystemPasswordChar = true;
            pbOpenHidden.Image = Properties.Resources.Hidden_eye; // hidden eye

            _ResetDefaultValues();
            _LoadComboBox();

            if (_Mode == enMode.Update)
            {
                _LoadData();
            }


        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (txtEmail.Text == "")
            {
                return;
            }

            if (!clsValidation.ValidateEmail(txtEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, " Invalid Email Address Format!");
            }
            else
            {
                errorProvider1.SetError(txtEmail, null);
            }
        }

     
        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtPassword.Text == "")
            {
                return;
            }

            if (!clsValidation.ValidateInteger(txtPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, " Invalid Password Format!");
            }
            else
            {
                errorProvider1.SetError(txtPassword, null);
            }
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "Username cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtUserName, null);
            }


            if (_Mode == enMode.Add)
            {
                if (clsUser.IsExist(txtUserName.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtUserName, "Username Is Used By Another User !");

                }
                else
                {

                    errorProvider1.SetError(txtUserName, null);

                }


            }
            else
            {
                if (txtUserName.Text != _User.UserName)
                {
                    if (clsUser.IsExist(txtUserName.Text))
                    {
                        e.Cancel = true;
                        errorProvider1.SetError(txtUserName, "Username Is Used By Another User !");
                        return;
                    }
                    else
                    {
                        errorProvider1.SetError(txtUserName, null);
                    }

                }

            }

        }
        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {
            Control control = sender as Control;

            if (control == null)
                return;

            if (string.IsNullOrWhiteSpace(control.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(control, "This field is required!");
            }
            else
            {
                errorProvider1.SetError(control, "");
            }
        }
        private bool _PasswordVisible = false;
        private void pbOpenHidden_Click(object sender, EventArgs e)
        {

            _PasswordVisible = !_PasswordVisible; 

            if (_PasswordVisible)
            {
                txtPassword.UseSystemPasswordChar = false;
                pbOpenHidden.Image = Properties.Resources.Open_eye;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                pbOpenHidden.Image = Properties.Resources.Hidden_eye;
            }



        }

        private bool _isUpdating = false;

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            if (_isUpdating) return;

            _isUpdating = true;

            bool state = chkAll.Checked;

            chkClientList.Checked = state;
            chkManageUsers.Checked = state;
            chkTransactions.Checked = state;
            chkCurrencyExchange.Checked = state;
            chkLoginRegisters.Checked = state;

            chkClientList.Enabled = !state;
            chkManageUsers.Enabled = !state;
            chkTransactions.Enabled = !state;
            chkCurrencyExchange.Enabled = !state;
            chkLoginRegisters.Enabled = !state;

            _isUpdating = false;
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }



}
