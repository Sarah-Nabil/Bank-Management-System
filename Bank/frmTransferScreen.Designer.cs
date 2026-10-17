namespace Bank
{
    partial class frmTransferScreen
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.lblClient2Balance = new System.Windows.Forms.Label();
            this.lblClient1Balance = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudAmountToTransfer = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAccountsNumber2 = new System.Windows.Forms.ComboBox();
            this.cbAccountsNumber1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountToTransfer)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.Location = new System.Drawing.Point(324, 210);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 22);
            this.label6.TabIndex = 37;
            this.label6.Text = "Balance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(9, 204);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 22);
            this.label5.TabIndex = 36;
            this.label5.Text = "Balance";
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.Blue;
            this.btnTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnTransfer.ForeColor = System.Drawing.Color.White;
            this.btnTransfer.Location = new System.Drawing.Point(77, 358);
            this.btnTransfer.Margin = new System.Windows.Forms.Padding(4);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(234, 38);
            this.btnTransfer.TabIndex = 34;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click_1);
            // 
            // lblClient2Balance
            // 
            this.lblClient2Balance.AutoSize = true;
            this.lblClient2Balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblClient2Balance.ForeColor = System.Drawing.Color.Green;
            this.lblClient2Balance.Location = new System.Drawing.Point(354, 243);
            this.lblClient2Balance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClient2Balance.Name = "lblClient2Balance";
            this.lblClient2Balance.Size = new System.Drawing.Size(36, 25);
            this.lblClient2Balance.TabIndex = 33;
            this.lblClient2Balance.Text = "0$";
            // 
            // lblClient1Balance
            // 
            this.lblClient1Balance.AutoSize = true;
            this.lblClient1Balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblClient1Balance.ForeColor = System.Drawing.Color.Green;
            this.lblClient1Balance.Location = new System.Drawing.Point(13, 243);
            this.lblClient1Balance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClient1Balance.Name = "lblClient1Balance";
            this.lblClient1Balance.Size = new System.Drawing.Size(36, 25);
            this.lblClient1Balance.TabIndex = 32;
            this.lblClient1Balance.Text = "0$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(157, 256);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 22);
            this.label4.TabIndex = 31;
            this.label4.Text = "Amount";
            // 
            // nudAmountToTransfer
            // 
            this.nudAmountToTransfer.Location = new System.Drawing.Point(126, 303);
            this.nudAmountToTransfer.Margin = new System.Windows.Forms.Padding(4);
            this.nudAmountToTransfer.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudAmountToTransfer.Name = "nudAmountToTransfer";
            this.nudAmountToTransfer.Size = new System.Drawing.Size(140, 24);
            this.nudAmountToTransfer.TabIndex = 30;
            this.nudAmountToTransfer.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudAmountToTransfer.ValueChanged += new System.EventHandler(this.nudAmountToTransfer_ValueChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(245, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 22);
            this.label3.TabIndex = 29;
            this.label3.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(13, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 22);
            this.label2.TabIndex = 28;
            this.label2.Text = "From";
            // 
            // cbAccountsNumber2
            // 
            this.cbAccountsNumber2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbAccountsNumber2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbAccountsNumber2.FormattingEnabled = true;
            this.cbAccountsNumber2.Location = new System.Drawing.Point(247, 160);
            this.cbAccountsNumber2.Margin = new System.Windows.Forms.Padding(4);
            this.cbAccountsNumber2.Name = "cbAccountsNumber2";
            this.cbAccountsNumber2.Size = new System.Drawing.Size(140, 24);
            this.cbAccountsNumber2.TabIndex = 27;
            this.cbAccountsNumber2.SelectedIndexChanged += new System.EventHandler(this.cbAccountsNumber2_SelectedIndexChanged_1);
            // 
            // cbAccountsNumber1
            // 
            this.cbAccountsNumber1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbAccountsNumber1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbAccountsNumber1.FormattingEnabled = true;
            this.cbAccountsNumber1.Location = new System.Drawing.Point(8, 160);
            this.cbAccountsNumber1.Margin = new System.Windows.Forms.Padding(4);
            this.cbAccountsNumber1.Name = "cbAccountsNumber1";
            this.cbAccountsNumber1.Size = new System.Drawing.Size(140, 24);
            this.cbAccountsNumber1.TabIndex = 26;
            this.cbAccountsNumber1.SelectedIndexChanged += new System.EventHandler(this.cbAccountsNumber1_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(97, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 35);
            this.label1.TabIndex = 25;
            this.label1.Text = "Transfer Screen";
            // 
            // frmTransferScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 418);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.lblClient2Balance);
            this.Controls.Add(this.lblClient1Balance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudAmountToTransfer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbAccountsNumber2);
            this.Controls.Add(this.cbAccountsNumber1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTransferScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTransferScreen";
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountToTransfer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Label lblClient2Balance;
        private System.Windows.Forms.Label lblClient1Balance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudAmountToTransfer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbAccountsNumber2;
        private System.Windows.Forms.ComboBox cbAccountsNumber1;
        private System.Windows.Forms.Label label1;
    }
}