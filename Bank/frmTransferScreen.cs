
using BankBusinessLayer;
using Bank.NewFolder1;
using System;
using System.Data;
using System.Windows.Forms;

namespace Bank
{
    public partial class frmTransferScreen : Form
    {
        private clsClient Client1 = null;
        private clsClient Client2 = null;

        public frmTransferScreen()
        {
            InitializeComponent();
            this.Load += frmTransferScreen_Load;
        }

        private void frmTransferScreen_Load(object sender, EventArgs e)
        {
            _FillAccountNumbersComboBox();

            lblClient1Balance.Text = "0.00$";
            lblClient2Balance.Text = "0.00$";

            nudAmountToTransfer.Minimum = 0;
            nudAmountToTransfer.DecimalPlaces = 2;
        }

        private void _FillAccountNumbersComboBox()
        {
            cbAccountsNumber1.Items.Clear();
            cbAccountsNumber2.Items.Clear();

            DataTable dt = clsClient.GetAllClients();

            foreach (DataRow row in dt.Rows)
            {
                string accountNumber = row["AccountNumber"].ToString();

                // حساب التحويل منه: لازم يكون فيه رصيد
                if (Convert.ToDecimal(row["Balance"]) > 0)
                {
                    cbAccountsNumber1.Items.Add(accountNumber);
                }

                // حساب التحويل إليه: ممكن يستقبل حتى لو رصيده صفر
                cbAccountsNumber2.Items.Add(accountNumber);
            }
        }

        private void btnTransfer_Click_1(object sender, EventArgs e)
        {
            // 1. التأكد من اختيار الحسابين
            if (Client1 == null || Client2 == null)
            {
                MessageBox.Show(
                    "Please select both accounts.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            // 2. التأكد من صحة المبلغ
            decimal amount = nudAmountToTransfer.Value;

            if (amount <= 0)
            {
                MessageBox.Show(
                    "Please enter an amount greater than zero.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            // 3. التأكد من اختلاف الحسابين
            if (Client1.AccountNumber == Client2.AccountNumber)
            {
                MessageBox.Show(
                    "Please select two different accounts.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            // 4. التأكد من كفاية الرصيد
            if (amount > Client1.Balance)
            {
                MessageBox.Show(
                    "Insufficient balance.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            // 5. تأكيد التحويل
            DialogResult answer = MessageBox.Show(
                "Are you sure you want to transfer " +
                amount.ToString("0.00") +
                "$ from account [" + Client1.AccountNumber +
                "] to account [" + Client2.AccountNumber + "]?",

                "Confirm Transfer",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (answer != DialogResult.Yes)
                return;

            // 6. الحصول على اسم المستخدم الحالي
            string username = clsGlobal.CurrentUser?.UserName;

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show(
                    "Unable to identify the current user.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            // 7. تنفيذ التحويل وتسجيل اسم المستخدم
            bool success = clsClient.TransferBalance(
                Client1.AccountNumber,
                Client2.AccountNumber,
                amount,
                username);

            // 8. عرض نتيجة التحويل
            if (success)
            {
                MessageBox.Show(
                    "Transfer Completed Successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // تحديث بيانات الحسابين من قاعدة البيانات
                Client1 = clsClient.GetClientInfoByAccountNum(
                    Client1.AccountNumber);

                Client2 = clsClient.GetClientInfoByAccountNum(
                    Client2.AccountNumber);

                // تحديث الأرصدة المعروضة
                lblClient1Balance.Text =
                    Client1 == null
                    ? "0.00$"
                    : Client1.Balance.ToString("0.00") + "$";

                lblClient2Balance.Text =
                    Client2 == null
                    ? "0.00$"
                    : Client2.Balance.ToString("0.00") + "$";

                // تصفير مبلغ التحويل
                nudAmountToTransfer.Value = 0;
            }
            else
            {
                MessageBox.Show(
                    "Transfer Failed. Please check the accounts and try again.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void nudAmountToTransfer_ValueChanged_1(
            object sender, EventArgs e)
        {
            if (Client1 != null &&
                nudAmountToTransfer.Value > Client1.Balance)
            {
                nudAmountToTransfer.Value = Client1.Balance;
            }
        }

        private void cbAccountsNumber1_SelectedIndexChanged_1(
            object sender, EventArgs e)
        {
            Client1 = clsClient.GetClientInfoByAccountNum(
                cbAccountsNumber1.Text);

            lblClient1Balance.Text = Client1 == null
                ? "0.00$"
                : Client1.Balance.ToString("0.00") + "$";

            nudAmountToTransfer.Value = 0;

            // ضبط الحد الأقصى للمبلغ حسب رصيد الحساب المرسل
            if (Client1 != null)
            {
                nudAmountToTransfer.Maximum =
                    Math.Max(1000000m, Client1.Balance);
            }
        }

        private void cbAccountsNumber2_SelectedIndexChanged_1(
            object sender, EventArgs e)
        {
            Client2 = clsClient.GetClientInfoByAccountNum(
                cbAccountsNumber2.Text);

            lblClient2Balance.Text = Client2 == null
                ? "0.00$"
                : Client2.Balance.ToString("0.00") + "$";

            if (Client1 != null && Client2 != null &&
                Client1.AccountNumber == Client2.AccountNumber)
            {
                MessageBox.Show(
                    "Please choose two different accounts.",
                    "Invalid Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cbAccountsNumber2.SelectedIndex = -1;
                Client2 = null;

                lblClient2Balance.Text = "0.00$";
            }
        }
    }
}
