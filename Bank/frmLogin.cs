
using Bank.NewFolder1;
using Bank_Utilities;
using BankBusinessLayer;
using System;
using System.Windows.Forms;

namespace Bank
{
    public partial class frmLogin : Form
    {
        private int _failedLoginCounter = 0;
        private int _remainingSeconds = 30;

        public frmLogin()
        {
            InitializeComponent();

            txtPassword.UseSystemPasswordChar = true;

            btnSignIn.Click += btnSignIn_Click;
            pictureBox1.Click += pbHideorview_Click;
        }


        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();

            lblTime.Visible = false;
            timer1.Interval = 1000;
            timer1.Enabled = false;

            string username = "";
            string password = "";

            bool found = clsRememberMe.GetStoredCredential(
                ref username, ref password);

            if (found)
            {
                txtUserName.Text = username;
                txtPassword.Text = password;
                chkRememberMe.Checked = true;
            }
            else
            {
                txtUserName.Clear();
                txtPassword.Clear();
                chkRememberMe.Checked = false;
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (!btnSignIn.Enabled)
                return;

            string userName = txtUserName.Text.Trim();
            string password = txtPassword.Text;

            lblMessage.Visible = false;
            lblMessage.Text = "";

            clsUser user =
                clsUser.FindByUserNameAndPassword(userName, password);

            if (user == null)
            {
                _failedLoginCounter++;
                txtPassword.Clear();

                if (_failedLoginCounter >= 3)
                {
                    LockLogin();
                }
                else
                {
                    lblMessage.Text =
                        $"Invalid username or password. " +
                        $"{3 - _failedLoginCounter} attempts remaining.";

                    lblMessage.Visible = true;
                    txtPassword.Focus();
                }

                return;
            }

            _failedLoginCounter = 0;

            if (!user.IsActive)
            {
                lblMessage.Text = "This account is inactive.";
                lblMessage.Visible = true;
                return;
            }

            // Remember Me
            if (chkRememberMe.Checked)
            {
                bool saved =
                    clsRememberMe.RememberUsernameAndPassword(
                        userName, password);

                if (!saved)
                {
                    MessageBox.Show(
                        "Failed to save login credentials.",
                        "Remember Me",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            else
            {
                clsRememberMe.DeleteCredentials();
            }

            clsGlobal.CurrentUser = user;

            this.Hide();

            using (frmMain mainForm = new frmMain())
            {
                mainForm.ShowDialog();
            }

            this.Close();
        }

  

        private void LockLogin()
        {
            btnSignIn.Enabled = false;
            txtPassword.Enabled = false;
            txtUserName.Enabled = false;

            _remainingSeconds = 10;

            lblTime.Text = "00:10";
            lblTime.Visible = true;

            timer1.Start();

            MessageBox.Show(
                "Too many failed login attempts.\nPlease wait 10 seconds.",
                "Login Locked",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }



        private void pbHideorview_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar =
                !txtPassword.UseSystemPasswordChar;

            pictureBox1.Image = txtPassword.UseSystemPasswordChar
                ? Properties.Resources.Hidden_eye
                : Properties.Resources.Open_eye;
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtPassword, "");
        }

        private void lblForgetPassword_LinkClicked(
            object sender,
            LinkLabelLinkClickedEventArgs e)
        {
            using (frmForgotPassword forgotPasswordForm =
                   new frmForgotPassword())
            {
                forgotPasswordForm.ShowDialog();
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            _remainingSeconds--;

            if (_remainingSeconds <= 0)
            {
                timer1.Stop();

                btnSignIn.Enabled = true;
                txtPassword.Enabled = true;
                txtUserName.Enabled = true;

                lblTime.Visible = false;

                _failedLoginCounter = 0;
                _remainingSeconds = 30;

                txtUserName.Focus();

                return;
            }

            int minutes = _remainingSeconds / 60;
            int seconds = _remainingSeconds % 60;

            lblTime.Text = $"{minutes:00}:{seconds:00}";
        }

        private void chkRememberMe_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtUserName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                txtUserName.Focus();
                errorProvider1.SetError(txtUserName, "This field is required.");

                return;
            }
            else
            {
                errorProvider1.SetError(txtUserName, "");
            }



        }

        private void txtPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.Focus();
                errorProvider1.SetError(txtPassword, "This field is required.");

                return;
            }
            else
            {
                errorProvider1.SetError(txtPassword, "");
            }
        }
    }
}
