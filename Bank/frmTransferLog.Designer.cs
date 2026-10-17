namespace Bank
{
    partial class frmTransferLog
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTransferLog = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblNumOfTransferLog = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransferLog)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 35);
            this.label1.TabIndex = 23;
            this.label1.Text = "Transfer Log";
            // 
            // dgvTransferLog
            // 
            this.dgvTransferLog.BackgroundColor = System.Drawing.Color.White;
            this.dgvTransferLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransferLog.Location = new System.Drawing.Point(12, 114);
            this.dgvTransferLog.Name = "dgvTransferLog";
            this.dgvTransferLog.RowHeadersWidth = 51;
            this.dgvTransferLog.RowTemplate.Height = 26;
            this.dgvTransferLog.Size = new System.Drawing.Size(1035, 383);
            this.dgvTransferLog.TabIndex = 24;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 53);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(357, 24);
            this.txtSearch.TabIndex = 25;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(407, 53);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 28);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblNumOfTransferLog
            // 
            this.lblNumOfTransferLog.AutoSize = true;
            this.lblNumOfTransferLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblNumOfTransferLog.Location = new System.Drawing.Point(28, 509);
            this.lblNumOfTransferLog.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumOfTransferLog.Name = "lblNumOfTransferLog";
            this.lblNumOfTransferLog.Size = new System.Drawing.Size(24, 25);
            this.lblNumOfTransferLog.TabIndex = 21;
            this.lblNumOfTransferLog.Text = "0";
            this.lblNumOfTransferLog.Click += new System.EventHandler(this.lblNumOfTransferLog_Click);
            // 
            // frmTransferLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 596);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvTransferLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNumOfTransferLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTransferLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTransferLog";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransferLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTransferLog;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblNumOfTransferLog;
    }
}