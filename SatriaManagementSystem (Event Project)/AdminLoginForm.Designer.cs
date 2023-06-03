namespace SatriaManagementSystem__Event_Project_
{
    partial class AdminLoginForm
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
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.checkBoxShowPw = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Login";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(41, 110);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(82, 16);
            this.labelUsername.TabIndex = 11;
            this.labelUsername.Text = "UserName : ";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(174, 150);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(155, 22);
            this.textBoxPassword.TabIndex = 14;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(173, 110);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(156, 22);
            this.textBoxUserName.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Passwords : ";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(225, 205);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(82, 41);
            this.buttonCancel.TabIndex = 16;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(53, 207);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(76, 37);
            this.buttonLogin.TabIndex = 15;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // checkBoxShowPw
            // 
            this.checkBoxShowPw.AutoSize = true;
            this.checkBoxShowPw.Location = new System.Drawing.Point(350, 152);
            this.checkBoxShowPw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxShowPw.Name = "checkBoxShowPw";
            this.checkBoxShowPw.Size = new System.Drawing.Size(124, 20);
            this.checkBoxShowPw.TabIndex = 17;
            this.checkBoxShowPw.Text = "Show password";
            this.checkBoxShowPw.UseVisualStyleBackColor = true;
            this.checkBoxShowPw.CheckedChanged += new System.EventHandler(this.checkBoxShowPw_CheckedChanged);
            // 
            // AdminLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 292);
            this.Controls.Add(this.checkBoxShowPw);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "AdminLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminLoginForm";
            this.Load += new System.EventHandler(this.AdminLoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.CheckBox checkBoxShowPw;
    }
}