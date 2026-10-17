namespace Bank
{
    partial class frmForgotPassword
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNewpassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblmood = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.txtUsername);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.txtNewpassword);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtConfirmPassword);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(45, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(540, 362);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 28);
            this.label2.TabIndex = 16;
            this.label2.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "UserName:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(220, 58);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(203, 23);
            this.txtEmail.TabIndex = 14;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(220, 120);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(203, 23);
            this.txtUsername.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(180, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 37);
            this.button1.TabIndex = 12;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNewpassword
            // 
            this.txtNewpassword.Location = new System.Drawing.Point(220, 169);
            this.txtNewpassword.Name = "txtNewpassword";
            this.txtNewpassword.Size = new System.Drawing.Size(203, 23);
            this.txtNewpassword.TabIndex = 11;
            this.txtNewpassword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "New Password:";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(220, 221);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(203, 23);
            this.txtConfirmPassword.TabIndex = 10;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Confirm Password:";
            // 
            // lblmood
            // 
            this.lblmood.AutoSize = true;
            this.lblmood.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmood.Location = new System.Drawing.Point(156, 9);
            this.lblmood.Name = "lblmood";
            this.lblmood.Size = new System.Drawing.Size(322, 40);
            this.lblmood.TabIndex = 13;
            this.lblmood.Text = "Change Password ";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(324, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 37);
            this.button2.TabIndex = 14;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 463);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblmood);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmForgotPassword";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNewpassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblmood;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button button2;
    }
}