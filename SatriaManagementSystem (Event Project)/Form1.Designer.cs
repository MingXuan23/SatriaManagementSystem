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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelNewMember = new System.Windows.Forms.Label();
            this.linkLabelCreateAcc = new System.Windows.Forms.LinkLabel();
            this.textBoxMatric = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxShowPw = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Matric Number :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Passwords : ";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Image = global::SatriaManagementSystem__Event_Project_.Properties.Resources.icons8_log_in_30;
            this.buttonLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogin.Location = new System.Drawing.Point(194, 332);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(108, 41);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            this.buttonLogin.MouseLeave += new System.EventHandler(this.buttonLogin_MouseLeave);
            this.buttonLogin.MouseHover += new System.EventHandler(this.buttonLogin_MouseHover);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Image = global::SatriaManagementSystem__Event_Project_.Properties.Resources.icons8_wrong_30;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(364, 332);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(106, 41);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            this.buttonCancel.MouseLeave += new System.EventHandler(this.buttonCancel_MouseLeave);
            this.buttonCancel.MouseHover += new System.EventHandler(this.buttonCancel_MouseHover);
            // 
            // labelNewMember
            // 
            this.labelNewMember.AutoSize = true;
            this.labelNewMember.Location = new System.Drawing.Point(180, 394);
            this.labelNewMember.Name = "labelNewMember";
            this.labelNewMember.Size = new System.Drawing.Size(149, 16);
            this.labelNewMember.TabIndex = 6;
            this.labelNewMember.Text = "Don\'t have account yet?";
            // 
            // linkLabelCreateAcc
            // 
            this.linkLabelCreateAcc.AutoSize = true;
            this.linkLabelCreateAcc.Location = new System.Drawing.Point(372, 394);
            this.linkLabelCreateAcc.Name = "linkLabelCreateAcc";
            this.linkLabelCreateAcc.Size = new System.Drawing.Size(75, 16);
            this.linkLabelCreateAcc.TabIndex = 7;
            this.linkLabelCreateAcc.TabStop = true;
            this.linkLabelCreateAcc.Text = "Create One";
            this.linkLabelCreateAcc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCreateAcc_LinkClicked);
            // 
            // textBoxMatric
            // 
            this.textBoxMatric.Location = new System.Drawing.Point(220, 43);
            this.textBoxMatric.Name = "textBoxMatric";
            this.textBoxMatric.Size = new System.Drawing.Size(176, 22);
            this.textBoxMatric.TabIndex = 9;
            this.textBoxMatric.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxMatric_KeyDown);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(220, 93);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(176, 22);
            this.textBoxPassword.TabIndex = 10;
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPassword_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxShowPw);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxPassword);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxMatric);
            this.groupBox1.Location = new System.Drawing.Point(17, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(619, 170);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // checkBoxShowPw
            // 
            this.checkBoxShowPw.AutoSize = true;
            this.checkBoxShowPw.Location = new System.Drawing.Point(436, 92);
            this.checkBoxShowPw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxShowPw.Name = "checkBoxShowPw";
            this.checkBoxShowPw.Size = new System.Drawing.Size(124, 20);
            this.checkBoxShowPw.TabIndex = 12;
            this.checkBoxShowPw.Text = "Show password";
            this.checkBoxShowPw.UseVisualStyleBackColor = true;
            this.checkBoxShowPw.CheckedChanged += new System.EventHandler(this.checkBoxShowPw_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SatriaManagementSystem__Event_Project_.Properties.Resources.logoUtem;
            this.pictureBox1.Location = new System.Drawing.Point(237, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 422);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabelCreateAcc);
            this.Controls.Add(this.labelNewMember);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelNewMember;
        private System.Windows.Forms.LinkLabel linkLabelCreateAcc;
        private System.Windows.Forms.TextBox textBoxMatric;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxShowPw;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

