namespace Bank
{
    partial class frmTransactions
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
            this.tabTransactions = new System.Windows.Forms.TabControl();
            this.tbDeposite = new System.Windows.Forms.TabPage();
            this.tbWithdraw = new System.Windows.Forms.TabPage();
            this.tbTotalBalance = new System.Windows.Forms.TabPage();
            this.tbTransfer = new System.Windows.Forms.TabPage();
            this.tbTransferLog = new System.Windows.Forms.TabPage();
            this.tabTransactions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabTransactions
            // 
            this.tabTransactions.Controls.Add(this.tbDeposite);
            this.tabTransactions.Controls.Add(this.tbWithdraw);
            this.tabTransactions.Controls.Add(this.tbTotalBalance);
            this.tabTransactions.Controls.Add(this.tbTransfer);
            this.tabTransactions.Controls.Add(this.tbTransferLog);
            this.tabTransactions.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabTransactions.Location = new System.Drawing.Point(1, 0);
            this.tabTransactions.Name = "tabTransactions";
            this.tabTransactions.SelectedIndex = 0;
            this.tabTransactions.Size = new System.Drawing.Size(1216, 711);
            this.tabTransactions.TabIndex = 0;
            // 
            // tbDeposite
            // 
            this.tbDeposite.Location = new System.Drawing.Point(4, 30);
            this.tbDeposite.Name = "tbDeposite";
            this.tbDeposite.Padding = new System.Windows.Forms.Padding(3);
            this.tbDeposite.Size = new System.Drawing.Size(1208, 677);
            this.tbDeposite.TabIndex = 0;
            this.tbDeposite.Text = "Deposit";
            this.tbDeposite.UseVisualStyleBackColor = true;
            // 
            // tbWithdraw
            // 
            this.tbWithdraw.Location = new System.Drawing.Point(4, 30);
            this.tbWithdraw.Name = "tbWithdraw";
            this.tbWithdraw.Padding = new System.Windows.Forms.Padding(3);
            this.tbWithdraw.Size = new System.Drawing.Size(1208, 677);
            this.tbWithdraw.TabIndex = 1;
            this.tbWithdraw.Text = "Withdraw";
            this.tbWithdraw.UseVisualStyleBackColor = true;
            // 
            // tbTotalBalance
            // 
            this.tbTotalBalance.AutoScroll = true;
            this.tbTotalBalance.Location = new System.Drawing.Point(4, 30);
            this.tbTotalBalance.Name = "tbTotalBalance";
            this.tbTotalBalance.Padding = new System.Windows.Forms.Padding(3);
            this.tbTotalBalance.Size = new System.Drawing.Size(1208, 677);
            this.tbTotalBalance.TabIndex = 2;
            this.tbTotalBalance.Text = "Total Balances";
            this.tbTotalBalance.UseVisualStyleBackColor = true;
            this.tbTotalBalance.Click += new System.EventHandler(this.tbTotalBalance_Click);
            // 
            // tbTransfer
            // 
            this.tbTransfer.Location = new System.Drawing.Point(4, 30);
            this.tbTransfer.Name = "tbTransfer";
            this.tbTransfer.Padding = new System.Windows.Forms.Padding(3);
            this.tbTransfer.Size = new System.Drawing.Size(1208, 677);
            this.tbTransfer.TabIndex = 3;
            this.tbTransfer.Text = "Transfer";
            this.tbTransfer.UseVisualStyleBackColor = true;
            // 
            // tbTransferLog
            // 
            this.tbTransferLog.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTransferLog.Location = new System.Drawing.Point(4, 30);
            this.tbTransferLog.Name = "tbTransferLog";
            this.tbTransferLog.Padding = new System.Windows.Forms.Padding(3);
            this.tbTransferLog.Size = new System.Drawing.Size(1208, 677);
            this.tbTransferLog.TabIndex = 4;
            this.tbTransferLog.Text = "Transfer Log";
            this.tbTransferLog.UseVisualStyleBackColor = true;
            // 
            // frmTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 709);
            this.Controls.Add(this.tabTransactions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTransactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTransactions";
            this.Load += new System.EventHandler(this.frmTransactions_Load);
            this.tabTransactions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabTransactions;
        private System.Windows.Forms.TabPage tbDeposite;
        private System.Windows.Forms.TabPage tbWithdraw;
        private System.Windows.Forms.TabPage tbTotalBalance;
        private System.Windows.Forms.TabPage tbTransfer;
        private System.Windows.Forms.TabPage tbTransferLog;
    }
}