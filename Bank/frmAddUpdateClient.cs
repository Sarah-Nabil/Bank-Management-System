
using Bank.NewFolder1;
using BankBusinessLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bank
{
    public partial class frmAddUpdateClient : Form
    {
        private HashSet<Control> touchedFields = new HashSet<Control>();

        private clsClient _Client;

        public frmAddUpdateClient()
        {
            InitializeComponent();

            _Client = new clsClient();

            InitializeValidation();

            this.Text = "Add New Client";
        }

        public frmAddUpdateClient(int clientID)
        {
            InitializeComponent();

            InitializeValidation();

            _Client = clsClient.Find(clientID);

            if (_Client == null)
            {
                MessageBox.Show(
                    "Client not found.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                this.DialogResult = DialogResult.Cancel;
                this.Load += (s, e) => this.Close();

                return;
            }

            LoadClientData();

            this.Text = "Update Client";
        }

        private void InitializeValidation()
        {
            btnSave.Enabled = false;
            errorProvider1.Clear();

            txtAccNO.TextChanged += Inputs_TextChanged;
            txtName.TextChanged += Inputs_TextChanged;
            txtNationalID.TextChanged += Inputs_TextChanged;
            txtPINCode.TextChanged += Inputs_TextChanged;
            txtPhone.TextChanged += Inputs_TextChanged;
            txtEmail.TextChanged += Inputs_TextChanged;
            txtBalance.TextChanged += Inputs_TextChanged;

            txtAccNO.Validating += Inputs_Validating;
            txtName.Validating += Inputs_Validating;
            txtNationalID.Validating += Inputs_Validating;
            txtPINCode.Validating += Inputs_Validating;
            txtPhone.Validating += Inputs_Validating;
            txtEmail.Validating += Inputs_Validating;
            txtBalance.Validating += Inputs_Validating;

            // Hide PIN Code initially.
            txtPINCode.UseSystemPasswordChar = true;

            // Connect the eye icon click event.
            pictureBox1.Click -= pictureBox1_Click;
            pictureBox1.Click += pictureBox1_Click;
        }

        private void LoadClientData()
        {
            txtAccNO.Text = _Client.AccountNumber;
            txtName.Text = _Client.FullName;
            txtNationalID.Text = _Client.NationalID;
            txtPINCode.Text = _Client.PinCode;
            txtPhone.Text = _Client.Phone;
            txtEmail.Text = _Client.Email;
            txtBalance.Text = _Client.Balance.ToString();

            touchedFields.Clear();
            errorProvider1.Clear();

            ValidateInputs();
        }

        private bool ValidateInputs(bool showAllErrors = false)
        {
            bool isValid = true;

            isValid &= ValidateField(
                txtAccNO,
                "Account Number is required.",
                showAllErrors);

            isValid &= ValidateField(
                txtName,
                "Full Name is required.",
                showAllErrors);

            isValid &= ValidateField(
                txtNationalID,
                "National ID is required.",
                showAllErrors);

            isValid &= ValidateField(
                txtPINCode,
                "PIN Code is required.",
                showAllErrors);

            isValid &= ValidateField(
                txtPhone,
                "Phone is required.",
                showAllErrors);

            isValid &= ValidateField(
                txtEmail,
                "Email is required.",
                showAllErrors);

            if (string.IsNullOrWhiteSpace(txtBalance.Text))
            {
                errorProvider1.SetError(
                    txtBalance,
                    "Balance is required.");

                isValid = false;
            }
            else if (!decimal.TryParse(
                         txtBalance.Text,
                         out decimal balance)
                     || balance < 0)
            {
                errorProvider1.SetError(
                    txtBalance,
                    "Enter a valid, non-negative balance.");

                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtBalance, "");
            }

            btnSave.Enabled = isValid;

            return isValid;
        }

        private bool ValidateField(
            TextBox textBox,
            string message,
            bool showAllErrors)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                // Show the error when the field is left empty,
                // or when Save is clicked.
                if (showAllErrors || touchedFields.Contains(textBox))
                {
                    errorProvider1.SetError(textBox, message);
                }

                return false;
            }

            errorProvider1.SetError(textBox, "");

            return true;
        }

        private void Inputs_TextChanged(object sender, EventArgs e)
        {
            if (sender is Control control)
            {
                touchedFields.Add(control);
            }

            ValidateInputs();
        }


        private void Inputs_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!(sender is TextBox textBox))
                return;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider1.SetError(
                    textBox,
                    "This field is required.");

                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBox, "");
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(showAllErrors: true))
            {
                return;
            }

            _Client.AccountNumber = txtAccNO.Text.Trim();
            _Client.FullName = txtName.Text.Trim();
            _Client.NationalID = txtNationalID.Text.Trim();
            _Client.PinCode = txtPINCode.Text.Trim();
            _Client.Phone = txtPhone.Text.Trim();
            _Client.Email = txtEmail.Text.Trim();

            if (!decimal.TryParse(
                    txtBalance.Text,
                    out decimal balance)
                || balance < 0)
            {
                MessageBox.Show(
                    "Please enter a valid balance.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            _Client.Balance = balance;

            bool wasUpdate =
                _Client.Mode == clsClient.enMode.Update;

            if (!wasUpdate)
            {
                _Client.CreatedBy = clsGlobal.CurrentUser.UserID;
            }

            if (_Client.Save())
            {
                MessageBox.Show(
                    wasUpdate
                        ? "Client updated successfully!"
                        : "Client added successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(
                    "Failed to save client. Check the data and try again.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            txtPINCode.UseSystemPasswordChar =
                !txtPINCode.UseSystemPasswordChar;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
