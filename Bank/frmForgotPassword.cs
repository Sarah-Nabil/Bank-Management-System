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
    public partial class frmForgotPassword : Form
    {
        public frmForgotPassword()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string newPassword = txtNewpassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (string.IsNullOrWhiteSpace(userName) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(newPassword) ||
                string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show(
                    "Please fill in all fields.",
                    "Required Fields",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show(
                    "Password and confirmation do not match.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtConfirmPassword.Focus();
                return;
            }

            bool isReset = clsUser.ResetPassword(
                userName,
                email,
                newPassword);

            if (isReset)
            {
                MessageBox.Show(
                    "Password reset successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtUsername.Clear();
                txtEmail.Clear();
                txtNewpassword.Clear();
                txtConfirmPassword.Clear();

                this.Close();
            }
            else
            {
                MessageBox.Show(
                    "Username or email is incorrect, or the account is inactive.",
                    "Reset Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
