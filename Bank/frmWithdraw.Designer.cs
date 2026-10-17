namespace Bank
{
    partial class frmWithdraw
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
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.lblBalanceAmount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudWithdrawAmount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAccountsNumber = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudWithdrawAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.Color.Navy;
            this.btnWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btnWithdraw.ForeColor = System.Drawing.Color.Transparent;
            this.btnWithdraw.Location = new System.Drawing.Point(93, 318);
            this.btnWithdraw.Margin = new System.Windows.Forms.Padding(4);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(231, 53);
            this.btnWithdraw.TabIndex = 23;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click_1);
            // 
            // lblBalanceAmount
            // 
            this.lblBalanceAmount.AutoSize = true;
            this.lblBalanceAmount.Font = new System.Drawing.Font("Impact", 13.25F);
            this.lblBalanceAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblBalanceAmount.Location = new System.Drawing.Point(361, 175);
            this.lblBalanceAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBalanceAmount.Name = "lblBalanceAmount";
            this.lblBalanceAmount.Size = new System.Drawing.Size(37, 28);
            this.lblBalanceAmount.TabIndex = 22;
            this.lblBalanceAmount.Text = "0$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(346, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 22);
            this.label4.TabIndex = 21;
            this.label4.Text = "Balance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(32, 224);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Enter Amount To Withdraw";
            // 
            // nudWithdrawAmount
            // 
            this.nudWithdrawAmount.Location = new System.Drawing.Point(37, 267);
            this.nudWithdrawAmount.Margin = new System.Windows.Forms.Padding(4);
            this.nudWithdrawAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudWithdrawAmount.Name = "nudWithdrawAmount";
            this.nudWithdrawAmount.Size = new System.Drawing.Size(140, 24);
            this.nudWithdrawAmount.TabIndex = 19;
            this.nudWithdrawAmount.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(20, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Choose Account Number";
            // 
            // cbAccountsNumber
            // 
            this.cbAccountsNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbAccountsNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbAccountsNumber.FormattingEnabled = true;
            this.cbAccountsNumber.Location = new System.Drawing.Point(27, 132);
            this.cbAccountsNumber.Margin = new System.Windows.Forms.Padding(4);
            this.cbAccountsNumber.Name = "cbAccountsNumber";
            this.cbAccountsNumber.Size = new System.Drawing.Size(191, 24);
            this.cbAccountsNumber.TabIndex = 17;
            this.cbAccountsNumber.SelectedIndexChanged += new System.EventHandler(this.cbAccountsNumber_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(123, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 36);
            this.label1.TabIndex = 16;
            this.label1.Text = "Withdraw Screen";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(325, 219);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(99, 30);
            this.btnRefresh.TabIndex = 24;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // frmWithdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 418);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.lblBalanceAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudWithdrawAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbAccountsNumber);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmWithdraw";
            this.Text = "frmWithdraw";
            this.Load += new System.EventHandler(this.frmWithdraw_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.nudWithdrawAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Label lblBalanceAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudWithdrawAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbAccountsNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefresh;
    }
}