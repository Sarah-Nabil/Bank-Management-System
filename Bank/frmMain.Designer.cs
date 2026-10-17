namespace Bank
{
    partial class frmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRoleName = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbRole = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbFullName = new System.Windows.Forms.Label();
            this.btnLoginRegister = new System.Windows.Forms.Button();
            this.btnCurrency = new System.Windows.Forms.Button();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnManageClients = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(147)))), ((int)(((byte)(212)))));
            this.panel1.Controls.Add(this.lblRoleName);
            this.panel1.Controls.Add(this.lblFullName);
            this.panel1.Controls.Add(this.lblUserName);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbRole);
            this.panel1.Controls.Add(this.lbUsername);
            this.panel1.Controls.Add(this.lbFullName);
            this.panel1.Controls.Add(this.btnLoginRegister);
            this.panel1.Controls.Add(this.btnCurrency);
            this.panel1.Controls.Add(this.btnTransactions);
            this.panel1.Controls.Add(this.btnManageUsers);
            this.panel1.Controls.Add(this.btnManageClients);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 778);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblRoleName
            // 
            this.lblRoleName.AutoSize = true;
            this.lblRoleName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleName.ForeColor = System.Drawing.Color.Maroon;
            this.lblRoleName.Location = new System.Drawing.Point(144, 87);
            this.lblRoleName.Name = "lblRoleName";
            this.lblRoleName.Size = new System.Drawing.Size(72, 24);
            this.lblRoleName.TabIndex = 13;
            this.lblRoleName.Text = "label3";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.Color.Maroon;
            this.lblFullName.Location = new System.Drawing.Point(144, 27);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(72, 24);
            this.lblFullName.TabIndex = 4;
            this.lblFullName.Text = "label1";
            this.lblFullName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.Maroon;
            this.lblUserName.Location = new System.Drawing.Point(144, 58);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(72, 24);
            this.lblUserName.TabIndex = 5;
            this.lblUserName.Text = "label2";
            this.lblUserName.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(77, 705);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(327, 750);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 32);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRole.ForeColor = System.Drawing.Color.Transparent;
            this.lbRole.Location = new System.Drawing.Point(4, 75);
            this.lbRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(75, 29);
            this.lbRole.TabIndex = 11;
            this.lbRole.Text = "Role ";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.ForeColor = System.Drawing.Color.Transparent;
            this.lbUsername.Location = new System.Drawing.Point(5, 46);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(132, 29);
            this.lbUsername.TabIndex = 10;
            this.lbUsername.Text = "Username";
            // 
            // lbFullName
            // 
            this.lbFullName.AutoSize = true;
            this.lbFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFullName.ForeColor = System.Drawing.Color.Transparent;
            this.lbFullName.Location = new System.Drawing.Point(4, 17);
            this.lbFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.Size = new System.Drawing.Size(133, 29);
            this.lbFullName.TabIndex = 9;
            this.lbFullName.Text = "Full Name";
            // 
            // btnLoginRegister
            // 
            this.btnLoginRegister.BackColor = System.Drawing.Color.White;
            this.btnLoginRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginRegister.Location = new System.Drawing.Point(44, 495);
            this.btnLoginRegister.Name = "btnLoginRegister";
            this.btnLoginRegister.Size = new System.Drawing.Size(254, 43);
            this.btnLoginRegister.TabIndex = 8;
            this.btnLoginRegister.Text = "Login Registers";
            this.btnLoginRegister.UseVisualStyleBackColor = false;
            this.btnLoginRegister.Click += new System.EventHandler(this.btnLoginRegister_Click);
            // 
            // btnCurrency
            // 
            this.btnCurrency.BackColor = System.Drawing.Color.White;
            this.btnCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurrency.Location = new System.Drawing.Point(44, 405);
            this.btnCurrency.Name = "btnCurrency";
            this.btnCurrency.Size = new System.Drawing.Size(254, 43);
            this.btnCurrency.TabIndex = 4;
            this.btnCurrency.Text = "Currency Exchange";
            this.btnCurrency.UseVisualStyleBackColor = false;
            this.btnCurrency.Click += new System.EventHandler(this.btnCurrency_Click);
            // 
            // btnTransactions
            // 
            this.btnTransactions.BackColor = System.Drawing.Color.White;
            this.btnTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactions.Location = new System.Drawing.Point(44, 322);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(254, 43);
            this.btnTransactions.TabIndex = 3;
            this.btnTransactions.Text = "Transactions";
            this.btnTransactions.UseVisualStyleBackColor = false;
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click_1);
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.BackColor = System.Drawing.Color.White;
            this.btnManageUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUsers.Location = new System.Drawing.Point(44, 237);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(254, 43);
            this.btnManageUsers.TabIndex = 2;
            this.btnManageUsers.Text = "Manage Users";
            this.btnManageUsers.UseVisualStyleBackColor = false;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // btnManageClients
            // 
            this.btnManageClients.BackColor = System.Drawing.Color.White;
            this.btnManageClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageClients.Location = new System.Drawing.Point(44, 153);
            this.btnManageClients.Name = "btnManageClients";
            this.btnManageClients.Size = new System.Drawing.Size(254, 43);
            this.btnManageClients.TabIndex = 1;
            this.btnManageClients.Text = "Manage Clients";
            this.btnManageClients.UseVisualStyleBackColor = false;
            this.btnManageClients.Click += new System.EventHandler(this.btnManageClients_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(377, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1106, 778);
            this.panel2.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 793);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbFullName;
        private System.Windows.Forms.Button btnLoginRegister;
        private System.Windows.Forms.Button btnCurrency;
        private System.Windows.Forms.Button btnTransactions;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnManageClients;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblRoleName;
    }
}