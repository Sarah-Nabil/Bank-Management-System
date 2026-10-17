namespace Bank
{
    partial class frmTotalBalances
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvtotalamount = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumOfClients = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtotalamount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTotalAmount.Location = new System.Drawing.Point(426, 25);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(45, 35);
            this.lblTotalAmount.TabIndex = 26;
            this.lblTotalAmount.Text = "0$";
            this.lblTotalAmount.Click += new System.EventHandler(this.lblTotalAmount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 35);
            this.label1.TabIndex = 25;
            this.label1.Text = "Total Balances Of Clients Is :";
            // 
            // dgvtotalamount
            // 
            this.dgvtotalamount.AllowUserToAddRows = false;
            this.dgvtotalamount.AllowUserToDeleteRows = false;
            this.dgvtotalamount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvtotalamount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvtotalamount.BackgroundColor = System.Drawing.Color.White;
            this.dgvtotalamount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtotalamount.Location = new System.Drawing.Point(12, 121);
            this.dgvtotalamount.Name = "dgvtotalamount";
            this.dgvtotalamount.ReadOnly = true;
            this.dgvtotalamount.RowHeadersWidth = 51;
            this.dgvtotalamount.RowTemplate.Height = 30;
            this.dgvtotalamount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvtotalamount.Size = new System.Drawing.Size(897, 230);
            this.dgvtotalamount.TabIndex = 27;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(22, 82);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(331, 24);
            this.txtSearch.TabIndex = 28;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(364, 83);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 25);
            this.btnSearch.TabIndex = 29;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Client Number :";
            // 
            // lblNumOfClients
            // 
            this.lblNumOfClients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNumOfClients.AutoSize = true;
            this.lblNumOfClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblNumOfClients.ForeColor = System.Drawing.Color.Blue;
            this.lblNumOfClients.Location = new System.Drawing.Point(180, 368);
            this.lblNumOfClients.Name = "lblNumOfClients";
            this.lblNumOfClients.Size = new System.Drawing.Size(25, 25);
            this.lblNumOfClients.TabIndex = 31;
            this.lblNumOfClients.Text = "0";
            // 
            // frmTotalBalances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 405);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNumOfClients);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvtotalamount);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTotalBalances";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTotalBalances";
            ((System.ComponentModel.ISupportInitialize)(this.dgvtotalamount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvtotalamount;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumOfClients;
    }
}