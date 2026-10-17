namespace Bank
{
    partial class frmCurrencyExchang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvCurrenciesList = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbCurrency1Code = new System.Windows.Forms.ComboBox();
            this.cbCurrency2Code = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblCurrency2Rate = new System.Windows.Forms.Label();
            this.lblCurrency1Rate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrenciesList)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(981, 622);
            this.tabControl1.TabIndex = 41;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dgvCurrenciesList);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(973, 588);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Currency List";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 36);
            this.button1.TabIndex = 44;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgvCurrenciesList
            // 
            this.dgvCurrenciesList.BackgroundColor = System.Drawing.Color.White;
            this.dgvCurrenciesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrenciesList.Location = new System.Drawing.Point(26, 118);
            this.dgvCurrenciesList.Name = "dgvCurrenciesList";
            this.dgvCurrenciesList.RowHeadersWidth = 51;
            this.dgvCurrenciesList.RowTemplate.Height = 26;
            this.dgvCurrenciesList.Size = new System.Drawing.Size(941, 451);
            this.dgvCurrenciesList.TabIndex = 43;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(296, 28);
            this.textBox1.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 38);
            this.label1.TabIndex = 41;
            this.label1.Text = "Currencies List";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbCurrency1Code);
            this.tabPage2.Controls.Add(this.cbCurrency2Code);
            this.tabPage2.Controls.Add(this.btnClear);
            this.tabPage2.Controls.Add(this.nudAmount);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.lblResult);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.btnConvert);
            this.tabPage2.Controls.Add(this.lblCurrency2Rate);
            this.tabPage2.Controls.Add(this.lblCurrency1Rate);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(973, 588);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Currency Calculator";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbCurrency1Code
            // 
            this.cbCurrency1Code.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCurrency1Code.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCurrency1Code.FormattingEnabled = true;
            this.cbCurrency1Code.Location = new System.Drawing.Point(184, 114);
            this.cbCurrency1Code.Margin = new System.Windows.Forms.Padding(4);
            this.cbCurrency1Code.Name = "cbCurrency1Code";
            this.cbCurrency1Code.Size = new System.Drawing.Size(140, 29);
            this.cbCurrency1Code.TabIndex = 52;
            // 
            // cbCurrency2Code
            // 
            this.cbCurrency2Code.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCurrency2Code.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCurrency2Code.FormattingEnabled = true;
            this.cbCurrency2Code.Location = new System.Drawing.Point(533, 114);
            this.cbCurrency2Code.Margin = new System.Windows.Forms.Padding(4);
            this.cbCurrency2Code.Name = "cbCurrency2Code";
            this.cbCurrency2Code.Size = new System.Drawing.Size(140, 29);
            this.cbCurrency2Code.TabIndex = 51;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Navy;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(455, 482);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(237, 54);
            this.btnClear.TabIndex = 50;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // nudAmount
            // 
            this.nudAmount.Location = new System.Drawing.Point(184, 361);
            this.nudAmount.Margin = new System.Windows.Forms.Padding(4);
            this.nudAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(142, 28);
            this.nudAmount.TabIndex = 49;
            this.nudAmount.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 12);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(326, 38);
            this.label10.TabIndex = 48;
            this.label10.Text = "Currency Calculator";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Elephant", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Blue;
            this.lblResult.Location = new System.Drawing.Point(596, 369);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(39, 38);
            this.lblResult.TabIndex = 47;
            this.lblResult.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Elephant", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(555, 308);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 38);
            this.label9.TabIndex = 46;
            this.label9.Text = "Result";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.Location = new System.Drawing.Point(543, 173);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 22);
            this.label6.TabIndex = 45;
            this.label6.Text = "Rate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.Location = new System.Drawing.Point(190, 173);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 22);
            this.label7.TabIndex = 44;
            this.label7.Text = "Rate";
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.Color.Navy;
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnConvert.ForeColor = System.Drawing.Color.White;
            this.btnConvert.Location = new System.Drawing.Point(184, 482);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(4);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(237, 54);
            this.btnConvert.TabIndex = 42;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblCurrency2Rate
            // 
            this.lblCurrency2Rate.AutoSize = true;
            this.lblCurrency2Rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblCurrency2Rate.ForeColor = System.Drawing.Color.Green;
            this.lblCurrency2Rate.Location = new System.Drawing.Point(599, 206);
            this.lblCurrency2Rate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrency2Rate.Name = "lblCurrency2Rate";
            this.lblCurrency2Rate.Size = new System.Drawing.Size(36, 25);
            this.lblCurrency2Rate.TabIndex = 41;
            this.lblCurrency2Rate.Text = "0$";
            // 
            // lblCurrency1Rate
            // 
            this.lblCurrency1Rate.AutoSize = true;
            this.lblCurrency1Rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblCurrency1Rate.ForeColor = System.Drawing.Color.Green;
            this.lblCurrency1Rate.Location = new System.Drawing.Point(249, 206);
            this.lblCurrency1Rate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrency1Rate.Name = "lblCurrency1Rate";
            this.lblCurrency1Rate.Size = new System.Drawing.Size(36, 25);
            this.lblCurrency1Rate.TabIndex = 40;
            this.lblCurrency1Rate.Text = "0$";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label8.Location = new System.Drawing.Point(190, 308);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 22);
            this.label8.TabIndex = 39;
            this.label8.Text = "Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(528, 85);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 25);
            this.label5.TabIndex = 38;
            this.label5.Text = "To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(179, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 25);
            this.label4.TabIndex = 37;
            this.label4.Text = "From";
            // 
            // frmCurrencyExchang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 670);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCurrencyExchang";
            this.Text = "frmCurrencyExchang";
            this.Load += new System.EventHandler(this.frmCurrencyExchang_Load_1);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrenciesList)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvCurrenciesList;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cbCurrency1Code;
        private System.Windows.Forms.ComboBox cbCurrency2Code;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblCurrency2Rate;
        private System.Windows.Forms.Label lblCurrency1Rate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}