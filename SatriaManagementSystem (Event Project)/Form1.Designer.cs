namespace SatriaManagementSystem__Event_Project_
{
    partial class Form1
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
            this.labelUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelNewMember = new System.Windows.Forms.Label();
            this.linkLabelCreateAcc = new System.Windows.Forms.LinkLabel();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxMatric = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxShowPw = new System.Windows.Forms.CheckBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(114, 36);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(101, 20);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "User Name : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Matric Number :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Passwords : ";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(218, 415);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(90, 51);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(410, 415);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(92, 51);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelNewMember
            // 
            this.labelNewMember.AutoSize = true;
            this.labelNewMember.Location = new System.Drawing.Point(202, 492);
            this.labelNewMember.Name = "labelNewMember";
            this.labelNewMember.Size = new System.Drawing.Size(180, 20);
            this.labelNewMember.TabIndex = 6;
            this.labelNewMember.Text = "Don\'t have account yet?";
            // 
            // linkLabelCreateAcc
            // 
            this.linkLabelCreateAcc.AutoSize = true;
            this.linkLabelCreateAcc.Location = new System.Drawing.Point(418, 492);
            this.linkLabelCreateAcc.Name = "linkLabelCreateAcc";
            this.linkLabelCreateAcc.Size = new System.Drawing.Size(91, 20);
            this.linkLabelCreateAcc.TabIndex = 7;
            this.linkLabelCreateAcc.TabStop = true;
            this.linkLabelCreateAcc.Text = "Create One";
            this.linkLabelCreateAcc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCreateAcc_LinkClicked);
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(248, 36);
            this.textBoxUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(198, 26);
            this.textBoxUserName.TabIndex = 8;
            // 
            // textBoxMatric
            // 
            this.textBoxMatric.Location = new System.Drawing.Point(248, 85);
            this.textBoxMatric.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxMatric.Name = "textBoxMatric";
            this.textBoxMatric.Size = new System.Drawing.Size(198, 26);
            this.textBoxMatric.TabIndex = 9;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(248, 148);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(198, 26);
            this.textBoxPassword.TabIndex = 10;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxShowPw);
            this.groupBox1.Controls.Add(this.labelUsername);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxPassword);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxMatric);
            this.groupBox1.Controls.Add(this.textBoxUserName);
            this.groupBox1.Location = new System.Drawing.Point(19, 195);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(696, 212);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // checkBoxShowPw
            // 
            this.checkBoxShowPw.AutoSize = true;
            this.checkBoxShowPw.Location = new System.Drawing.Point(491, 146);
            this.checkBoxShowPw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxShowPw.Name = "checkBoxShowPw";
            this.checkBoxShowPw.Size = new System.Drawing.Size(147, 24);
            this.checkBoxShowPw.TabIndex = 12;
            this.checkBoxShowPw.Text = "Show password";
            this.checkBoxShowPw.UseVisualStyleBackColor = true;
            this.checkBoxShowPw.CheckedChanged += new System.EventHandler(this.checkBoxShowPw_CheckedChanged);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::SatriaManagementSystem__Event_Project_.Properties.Resources.logo_utem;
            this.pictureBoxLogo.Location = new System.Drawing.Point(250, 30);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(251, 158);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBoxLogo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 528);
            this.Controls.Add(this.linkLabelCreateAcc);
            this.Controls.Add(this.labelNewMember);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelNewMember;
        private System.Windows.Forms.LinkLabel linkLabelCreateAcc;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxMatric;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxShowPw;
    }
}

