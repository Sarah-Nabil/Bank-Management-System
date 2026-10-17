namespace Bank
{
    partial class frmLogin
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.lblForgetPassword = new System.Windows.Forms.LinkLabel();
            this.chkRememberMe = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.lblMessage);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnSignIn);
            this.panel1.Controls.Add(this.lblForgetPassword);
            this.panel1.Controls.Add(this.chkRememberMe);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(62, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 321);
            this.panel1.TabIndex = 155;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Black;
            this.lblTime.Location = new System.Drawing.Point(287, 187);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(97, 34);
            this.lblTime.TabIndex = 163;
            this.lblTime.Text = "00:30";
            this.lblTime.Visible = false;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(168, 201);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(63, 17);
            this.lblMessage.TabIndex = 164;
            this.lblMessage.Text = "Message ";
            this.lblMessage.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bank.Properties.Resources.Hidden_eye;
            this.pictureBox1.Location = new System.Drawing.Point(451, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 162;
            this.pictureBox1.TabStop = false;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.Location = new System.Drawing.Point(254, 246);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(151, 42);
            this.btnSignIn.TabIndex = 161;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            // 
            // lblForgetPassword
            // 
            this.lblForgetPassword.AutoSize = true;
            this.lblForgetPassword.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgetPassword.Location = new System.Drawing.Point(434, 156);
            this.lblForgetPassword.Name = "lblForgetPassword";
            this.lblForgetPassword.Size = new System.Drawing.Size(133, 18);
            this.lblForgetPassword.TabIndex = 158;
            this.lblForgetPassword.TabStop = true;
            this.lblForgetPassword.Text = "  Forgot password?";
            this.lblForgetPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblForgetPassword_LinkClicked);
            // 
            // chkRememberMe
            // 
            this.chkRememberMe.AutoSize = true;
            this.chkRememberMe.Location = new System.Drawing.Point(134, 144);
            this.chkRememberMe.Name = "chkRememberMe";
            this.chkRememberMe.Size = new System.Drawing.Size(122, 21);
            this.chkRememberMe.TabIndex = 157;
            this.chkRememberMe.Text = "Remember Me.";
            this.chkRememberMe.UseVisualStyleBackColor = true;
            this.chkRememberMe.CheckedChanged += new System.EventHandler(this.chkRememberMe_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(202, 92);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(290, 24);
            this.txtPassword.TabIndex = 156;
            this.txtPassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(202, 26);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(290, 24);
            this.txtUserName.TabIndex = 155;
            this.txtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserName_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(92)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(25, 79);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 36);
            this.label7.TabIndex = 154;
            this.label7.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(92)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(22, 26);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 36);
            this.label8.TabIndex = 153;
            this.label8.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(129)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(76, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(586, 46);
            this.label1.TabIndex = 141;
            this.label1.Text = "Welcome back to Smart Bank!";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(213)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(792, 453);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.LinkLabel lblForgetPassword;
        private System.Windows.Forms.CheckBox chkRememberMe;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblMessage;
    }
}

