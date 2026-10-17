
using System;
using System.Data;
using System.Windows.Forms;

namespace Bank
{
    public partial class frmCurrencyExchang : Form
    {
        private bool _isLoadingCurrencies = false;

        public frmCurrencyExchang()
        {
            InitializeComponent();

            // Currency List events
            button1.Click -= button1_Click;
            button1.Click += button1_Click;

            textBox1.TextChanged -= textBox1_TextChanged;
            textBox1.TextChanged += textBox1_TextChanged;

            // Currency Calculator events
            cbCurrency1Code.SelectedIndexChanged -=
                cbCurrency1Code_SelectedIndexChanged;
            cbCurrency1Code.SelectedIndexChanged +=
                cbCurrency1Code_SelectedIndexChanged;

            cbCurrency2Code.SelectedIndexChanged -=
                cbCurrency2Code_SelectedIndexChanged;
            cbCurrency2Code.SelectedIndexChanged +=
                cbCurrency2Code_SelectedIndexChanged;

            btnConvert.Click -= btnConvert_Click;
            btnConvert.Click += btnConvert_Click;

            btnClear.Click -= btnClear_Click;
            btnClear.Click += btnClear_Click;
        }

        // =========================
        // Load Both Tabs
        // =========================

        private void frmCurrencyExchang_Load_1(object sender, EventArgs e)
        {
            LoadCurrencies();
            LoadCurrencyComboBoxes();
        }

        // =========================
        // Currency List
        // =========================

        private void LoadCurrencies(string countryName = "")
        {
            try
            {
                DataTable currencies =
                    CurrencyBusiness.GetCurrencies(countryName);

                dgvCurrenciesList.DataSource = currencies;

                dgvCurrenciesList.ReadOnly = true;
                dgvCurrenciesList.AllowUserToAddRows = false;
                dgvCurrenciesList.AllowUserToDeleteRows = false;
                dgvCurrenciesList.MultiSelect = false;
                dgvCurrenciesList.RowHeadersVisible = false;

                dgvCurrenciesList.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

                dgvCurrenciesList.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                if (dgvCurrenciesList.Columns.Contains("CurrencyID"))
                {
                    dgvCurrenciesList.Columns["CurrencyID"].Visible = false;
                }

                if (dgvCurrenciesList.Columns.Contains("CountryName"))
                {
                    dgvCurrenciesList.Columns["CountryName"].HeaderText =
                        "Country";
                }

                if (dgvCurrenciesList.Columns.Contains("CurrencyCode"))
                {
                    dgvCurrenciesList.Columns["CurrencyCode"].HeaderText =
                        "Code";
                }

                if (dgvCurrenciesList.Columns.Contains("CurrencyName"))
                {
                    dgvCurrenciesList.Columns["CurrencyName"].HeaderText =
                        "Currency";
                }

                if (dgvCurrenciesList.Columns.Contains("Rate"))
                {
                    dgvCurrenciesList.Columns["Rate"].HeaderText = "Rate $";

                    // Remove unnecessary trailing zeros.
                    dgvCurrenciesList.Columns["Rate"]
                        .DefaultCellStyle.Format = "0.####";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load currencies.\n" + ex.Message,
                    "Currency Exchange",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadCurrencies(textBox1.Text.Trim());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadCurrencies(textBox1.Text.Trim());
        }

        // =========================
        // Currency Calculator
        // =========================

        private void LoadCurrencyComboBoxes()
        {
            try
            {
                DataTable currencies =
                    CurrencyBusiness.GetCurrencies();

                if (currencies.Rows.Count == 0)
                {
                    MessageBox.Show("No currencies were found.");
                    return;
                }

                _isLoadingCurrencies = true;

                // First currency ComboBox
                cbCurrency1Code.DataSource = null;
                cbCurrency1Code.DisplayMember = "CountryName";
                cbCurrency1Code.ValueMember = "CurrencyCode";
                cbCurrency1Code.DataSource = currencies.Copy();

                // Second currency ComboBox
                cbCurrency2Code.DataSource = null;
                cbCurrency2Code.DisplayMember = "CountryName";
                cbCurrency2Code.ValueMember = "CurrencyCode";
                cbCurrency2Code.DataSource = currencies.Copy();

                cbCurrency1Code.SelectedIndex = 0;

                cbCurrency2Code.SelectedIndex =
                    currencies.Rows.Count > 1 ? 1 : 0;

                _isLoadingCurrencies = false;

                UpdateCurrencyRates();
            }
            catch (Exception ex)
            {
                _isLoadingCurrencies = false;

                MessageBox.Show(
                    "Failed to load currencies for the calculator.\n"
                    + ex.Message,
                    "Currency Exchange",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Get the selected currency's rate
        private decimal GetSelectedRate(ComboBox comboBox)
        {
            DataRowView selectedRow =
                comboBox.SelectedItem as DataRowView;

            if (selectedRow == null)
            {
                throw new InvalidOperationException(
                    "Please select a currency.");
            }

            decimal rate =
                Convert.ToDecimal(selectedRow["Rate"]);

            if (rate <= 0)
            {
                throw new InvalidOperationException(
                    "The currency rate must be greater than zero.");
            }

            return rate;
        }

        // Show the selected currencies' rates


        private void UpdateCurrencyRates()
        {
            try
            {
                if (cbCurrency1Code.SelectedItem == null ||
                    cbCurrency2Code.SelectedItem == null)
                {
                    return;
                }

                decimal rate1 = GetSelectedRate(cbCurrency1Code);
                decimal rate2 = GetSelectedRate(cbCurrency2Code);

                DataRowView currency1 =
                    (DataRowView)cbCurrency1Code.SelectedItem;

                DataRowView currency2 =
                    (DataRowView)cbCurrency2Code.SelectedItem;

                string code1 = currency1["CurrencyCode"].ToString();
                string code2 = currency2["CurrencyCode"].ToString();

                lblCurrency1Rate.Text =
                    $"1 $ = {rate1.ToString("0.########")} {code1}";

                lblCurrency2Rate.Text =
                    $"1 $ = {rate2.ToString("0.########")} {code2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Currency Exchange",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }



        private void cbCurrency1Code_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            if (!_isLoadingCurrencies)
            {
                UpdateCurrencyRates();
            }
        }

        private void cbCurrency2Code_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            if (!_isLoadingCurrencies)
            {
                UpdateCurrencyRates();
            }
        }

        // =========================
        // Convert Currency
        // =========================

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                decimal amount = nudAmount.Value;

                decimal rate1 = GetSelectedRate(cbCurrency1Code);
                decimal rate2 = GetSelectedRate(cbCurrency2Code);

                // Rates represent currency units per 1 USD.
                decimal result = amount / rate1 * rate2;

                DataRowView targetCurrency =
                    cbCurrency2Code.SelectedItem as DataRowView;

                if (targetCurrency == null)
                {
                    MessageBox.Show("Please select the target currency.");
                    return;
                }

                string targetCode =
                    targetCurrency["CurrencyCode"].ToString();

                // Display without unnecessary zeros or thousands separators.
                lblResult.Text =
                    $"{result.ToString("0.####")} {targetCode}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Conversion failed.\n" + ex.Message,
                    "Currency Exchange",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================
        // Clear Calculator
        // =========================

        private void btnClear_Click(object sender, EventArgs e)
        {
            nudAmount.Value = nudAmount.Minimum;
            lblResult.Text = "0";
        }
    }
}
