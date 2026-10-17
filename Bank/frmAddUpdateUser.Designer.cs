namespace Bank
{
    partial class frmAddUpdateUser
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkCurrencyExchange = new System.Windows.Forms.CheckBox();
            this.chkLoginRegisters = new System.Windows.Forms.CheckBox();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.chkTransactions = new System.Windows.Forms.CheckBox();
            this.chkClientList = new System.Windows.Forms.CheckBox();
            this.chkManageUsers = new System.Windows.Forms.CheckBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.pbOpenHidden = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOpenHidden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "FullName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "Role";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkCurrencyExchange);
            this.groupBox1.Controls.Add(this.chkLoginRegisters);
            this.groupBox1.Controls.Add(this.chkAll);
            this.groupBox1.Controls.Add(this.chkTransactions);
            this.groupBox1.Controls.Add(this.chkClientList);
            this.groupBox1.Controls.Add(this.chkManageUsers);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 428);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 147);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permissions";
            // 
            // chkCurrencyExchange
            // 
            this.chkCurrencyExchange.AutoSize = true;
            this.chkCurrencyExchange.Location = new System.Drawing.Point(223, 94);
            this.chkCurrencyExchange.Margin = new System.Windows.Forms.Padding(4);
            this.chkCurrencyExchange.Name = "chkCurrencyExchange";
            this.chkCurrencyExchange.Size = new System.Drawing.Size(216, 28);
            this.chkCurrencyExchange.TabIndex = 12;
            this.chkCurrencyExchange.Tag = "2";
            this.chkCurrencyExchange.Text = "Currency Exchang";
            this.chkCurrencyExchange.UseVisualStyleBackColor = true;
            // 
            // chkLoginRegisters
            // 
            this.chkLoginRegisters.AutoSize = true;
            this.chkLoginRegisters.Location = new System.Drawing.Point(19, 94);
            this.chkLoginRegisters.Margin = new System.Windows.Forms.Padding(4);
            this.chkLoginRegisters.Name = "chkLoginRegisters";
            this.chkLoginRegisters.Size = new System.Drawing.Size(188, 28);
            this.chkLoginRegisters.TabIndex = 10;
            this.chkLoginRegisters.Tag = "8";
            this.chkLoginRegisters.Text = "Login Registers";
            this.chkLoginRegisters.UseVisualStyleBackColor = true;
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Location = new System.Drawing.Point(482, 94);
            this.chkAll.Margin = new System.Windows.Forms.Padding(4);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(58, 28);
            this.chkAll.TabIndex = 11;
            this.chkAll.Tag = "-1";
            this.chkAll.Text = "All";
            this.chkAll.UseVisualStyleBackColor = true;
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // chkTransactions
            // 
            this.chkTransactions.AutoSize = true;
            this.chkTransactions.Location = new System.Drawing.Point(223, 45);
            this.chkTransactions.Margin = new System.Windows.Forms.Padding(4);
            this.chkTransactions.Name = "chkTransactions";
            this.chkTransactions.Size = new System.Drawing.Size(160, 28);
            this.chkTransactions.TabIndex = 2;
            this.chkTransactions.Tag = "2";
            this.chkTransactions.Text = "Transactions";
            this.chkTransactions.UseVisualStyleBackColor = true;
            // 
            // chkClientList
            // 
            this.chkClientList.AutoSize = true;
            this.chkClientList.Location = new System.Drawing.Point(439, 45);
            this.chkClientList.Margin = new System.Windows.Forms.Padding(4);
            this.chkClientList.Name = "chkClientList";
            this.chkClientList.Size = new System.Drawing.Size(131, 28);
            this.chkClientList.TabIndex = 1;
            this.chkClientList.Tag = "1";
            this.chkClientList.Text = "Client List";
            this.chkClientList.UseVisualStyleBackColor = true;
            // 
            // chkManageUsers
            // 
            this.chkManageUsers.AutoSize = true;
            this.chkManageUsers.Location = new System.Drawing.Point(19, 45);
            this.chkManageUsers.Margin = new System.Windows.Forms.Padding(4);
            this.chkManageUsers.Name = "chkManageUsers";
            this.chkManageUsers.Size = new System.Drawing.Size(174, 28);
            this.chkManageUsers.TabIndex = 3;
            this.chkManageUsers.Tag = "4";
            this.chkManageUsers.Text = "Manage Users";
            this.chkManageUsers.UseVisualStyleBackColor = true;
            // 
            // txtUserName
            // 
            this.txtUserName.AccessibleDescription = "gvg";
            this.txtUserName.Location = new System.Drawing.Point(172, 87);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(214, 24);
            this.txtUserName.TabIndex = 12;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            this.txtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserName_Validating);
            // 
            // txtPassword
            // 
            this.txtPassword.AccessibleDescription = "gvg";
            this.txtPassword.Location = new System.Drawing.Point(172, 133);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(214, 24);
            this.txtPassword.TabIndex = 13;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // txtFullName
            // 
            this.txtFullName.AccessibleDescription = "gvg";
            this.txtFullName.Location = new System.Drawing.Point(172, 193);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(214, 24);
            this.txtFullName.TabIndex = 14;
            this.txtFullName.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(172, 344);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(214, 24);
            this.cbRole.TabIndex = 15;
            this.cbRole.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // txtEmail
            // 
            this.txtEmail.AccessibleDescription = "gvg";
            this.txtEmail.Location = new System.Drawing.Point(172, 248);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(214, 24);
            this.txtEmail.TabIndex = 16;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // txtPhone
            // 
            this.txtPhone.AccessibleDescription = "gvg";
            this.txtPhone.Location = new System.Drawing.Point(172, 292);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(214, 24);
            this.txtPhone.TabIndex = 17;
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(311, 611);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(139, 42);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsActive.Location = new System.Drawing.Point(34, 611);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(132, 33);
            this.chkIsActive.TabIndex = 20;
            this.chkIsActive.Text = "Is Active";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // pbOpenHidden
            // 
            this.pbOpenHidden.Image = global::Bank.Properties.Resources.Hidden_eye;
            this.pbOpenHidden.Location = new System.Drawing.Point(408, 133);
            this.pbOpenHidden.Name = "pbOpenHidden";
            this.pbOpenHidden.Size = new System.Drawing.Size(42, 29);
            this.pbOpenHidden.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOpenHidden.TabIndex = 21;
            this.pbOpenHidden.TabStop = false;
            this.pbOpenHidden.Click += new System.EventHandler(this.pbOpenHidden_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(188, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(206, 32);
            this.lblTitle.TabIndex = 22;
            this.lblTitle.Text = "Add New User";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(468, 612);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 42);
            this.button1.TabIndex = 23;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAddUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(622, 666);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbOpenHidden);
            this.Controls.Add(this.chkIsActive);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddUpdateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/UpdateUser";
            this.Load += new System.EventHandler(this.frmAddUpdateUser_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOpenHidden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkLoginRegisters;
        private System.Windows.Forms.CheckBox chkAll;
        private System.Windows.Forms.CheckBox chkTransactions;
        private System.Windows.Forms.CheckBox chkClientList;
        private System.Windows.Forms.CheckBox chkManageUsers;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.CheckBox chkCurrencyExchange;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.PictureBox pbOpenHidden;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button1;
    }
}