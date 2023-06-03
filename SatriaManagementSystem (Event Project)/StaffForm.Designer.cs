namespace SatriaManagementSystem__Event_Project_
{
    partial class Staff_Form
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageMyInformation = new System.Windows.Forms.TabPage();
            this.linkLabelSuperAdmin = new System.Windows.Forms.LinkLabel();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.buttonDiscard = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textBoxPhoneNo = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPhoneNo = new System.Windows.Forms.Label();
            this.labelFullName = new System.Windows.Forms.Label();
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelMyInformation = new System.Windows.Forms.Label();
            this.tabPageSearchStudent = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatricNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Block = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayingStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.textBoxSearchStudent = new System.Windows.Forms.TextBox();
            this.tabPageRoomApplication = new System.Windows.Forms.TabPage();
            this.labelBlock = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.BlockID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlockName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlockGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlockAsset = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlockCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlockStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlockStopApp = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BlockUpdateRoomFee = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BlockViewStudent = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPageMyInformation.SuspendLayout();
            this.tabPageSearchStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPageRoomApplication.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageMyInformation);
            this.tabControl1.Controls.Add(this.tabPageSearchStudent);
            this.tabControl1.Controls.Add(this.tabPageRoomApplication);
            this.tabControl1.Location = new System.Drawing.Point(12, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(862, 426);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageMyInformation
            // 
            this.tabPageMyInformation.Controls.Add(this.linkLabelSuperAdmin);
            this.tabPageMyInformation.Controls.Add(this.radioButtonFemale);
            this.tabPageMyInformation.Controls.Add(this.radioButtonMale);
            this.tabPageMyInformation.Controls.Add(this.buttonDiscard);
            this.tabPageMyInformation.Controls.Add(this.buttonEdit);
            this.tabPageMyInformation.Controls.Add(this.textBoxPhoneNo);
            this.tabPageMyInformation.Controls.Add(this.textBoxEmail);
            this.tabPageMyInformation.Controls.Add(this.textBoxFullName);
            this.tabPageMyInformation.Controls.Add(this.labelGender);
            this.tabPageMyInformation.Controls.Add(this.labelEmail);
            this.tabPageMyInformation.Controls.Add(this.labelPhoneNo);
            this.tabPageMyInformation.Controls.Add(this.labelFullName);
            this.tabPageMyInformation.Controls.Add(this.checkBoxShowPassword);
            this.tabPageMyInformation.Controls.Add(this.textBoxUsername);
            this.tabPageMyInformation.Controls.Add(this.textBoxPassword);
            this.tabPageMyInformation.Controls.Add(this.labelPassword);
            this.tabPageMyInformation.Controls.Add(this.labelUsername);
            this.tabPageMyInformation.Controls.Add(this.labelMyInformation);
            this.tabPageMyInformation.Location = new System.Drawing.Point(4, 25);
            this.tabPageMyInformation.Name = "tabPageMyInformation";
            this.tabPageMyInformation.Size = new System.Drawing.Size(854, 397);
            this.tabPageMyInformation.TabIndex = 2;
            this.tabPageMyInformation.Text = "My Information";
            this.tabPageMyInformation.UseVisualStyleBackColor = true;
            // 
            // linkLabelSuperAdmin
            // 
            this.linkLabelSuperAdmin.AutoSize = true;
            this.linkLabelSuperAdmin.Location = new System.Drawing.Point(267, 330);
            this.linkLabelSuperAdmin.Name = "linkLabelSuperAdmin";
            this.linkLabelSuperAdmin.Size = new System.Drawing.Size(213, 16);
            this.linkLabelSuperAdmin.TabIndex = 64;
            this.linkLabelSuperAdmin.TabStop = true;
            this.linkLabelSuperAdmin.Text = "Are you a Super Admin? Click here";
            this.linkLabelSuperAdmin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSuperAdmin_LinkClicked);
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(540, 221);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(74, 20);
            this.radioButtonFemale.TabIndex = 62;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(540, 195);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(58, 20);
            this.radioButtonMale.TabIndex = 61;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // buttonDiscard
            // 
            this.buttonDiscard.Location = new System.Drawing.Point(396, 277);
            this.buttonDiscard.Name = "buttonDiscard";
            this.buttonDiscard.Size = new System.Drawing.Size(90, 37);
            this.buttonDiscard.TabIndex = 60;
            this.buttonDiscard.Text = "Discard";
            this.buttonDiscard.UseVisualStyleBackColor = true;
            this.buttonDiscard.Click += new System.EventHandler(this.buttonDiscard_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(266, 277);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(90, 37);
            this.buttonEdit.TabIndex = 58;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textBoxPhoneNo
            // 
            this.textBoxPhoneNo.Location = new System.Drawing.Point(540, 110);
            this.textBoxPhoneNo.Name = "textBoxPhoneNo";
            this.textBoxPhoneNo.Size = new System.Drawing.Size(153, 22);
            this.textBoxPhoneNo.TabIndex = 57;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(540, 150);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(153, 22);
            this.textBoxEmail.TabIndex = 56;
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Location = new System.Drawing.Point(170, 190);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(153, 22);
            this.textBoxFullName.TabIndex = 54;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(419, 194);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(58, 16);
            this.labelGender.TabIndex = 53;
            this.labelGender.Text = "Gender :";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(419, 153);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(47, 16);
            this.labelEmail.TabIndex = 52;
            this.labelEmail.Text = "Email :";
            // 
            // labelPhoneNo
            // 
            this.labelPhoneNo.AutoSize = true;
            this.labelPhoneNo.Location = new System.Drawing.Point(419, 110);
            this.labelPhoneNo.Name = "labelPhoneNo";
            this.labelPhoneNo.Size = new System.Drawing.Size(103, 16);
            this.labelPhoneNo.TabIndex = 51;
            this.labelPhoneNo.Text = "Phone Number :";
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Location = new System.Drawing.Point(74, 195);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(74, 16);
            this.labelFullName.TabIndex = 50;
            this.labelFullName.Text = "Full Name :";
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.AutoSize = true;
            this.checkBoxShowPassword.Location = new System.Drawing.Point(329, 149);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(62, 20);
            this.checkBoxShowPassword.TabIndex = 49;
            this.checkBoxShowPassword.Text = "Show";
            this.checkBoxShowPassword.UseVisualStyleBackColor = true;
            this.checkBoxShowPassword.CheckedChanged += new System.EventHandler(this.checkBoxShowPassword_CheckedChanged);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(170, 107);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(153, 22);
            this.textBoxUsername.TabIndex = 48;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(170, 147);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.ReadOnly = true;
            this.textBoxPassword.Size = new System.Drawing.Size(153, 22);
            this.textBoxPassword.TabIndex = 47;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(74, 150);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(76, 16);
            this.labelPassword.TabIndex = 43;
            this.labelPassword.Text = "Password : ";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(74, 110);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(85, 16);
            this.labelUsername.TabIndex = 42;
            this.labelUsername.Text = "User Name : ";
            // 
            // labelMyInformation
            // 
            this.labelMyInformation.AutoSize = true;
            this.labelMyInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMyInformation.Location = new System.Drawing.Point(314, 60);
            this.labelMyInformation.Name = "labelMyInformation";
            this.labelMyInformation.Size = new System.Drawing.Size(120, 18);
            this.labelMyInformation.TabIndex = 40;
            this.labelMyInformation.Text = "My Information";
            // 
            // tabPageSearchStudent
            // 
            this.tabPageSearchStudent.Controls.Add(this.pictureBox1);
            this.tabPageSearchStudent.Controls.Add(this.dataGridView1);
            this.tabPageSearchStudent.Controls.Add(this.textBoxSearchStudent);
            this.tabPageSearchStudent.Location = new System.Drawing.Point(4, 25);
            this.tabPageSearchStudent.Name = "tabPageSearchStudent";
            this.tabPageSearchStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchStudent.Size = new System.Drawing.Size(854, 397);
            this.tabPageSearchStudent.TabIndex = 0;
            this.tabPageSearchStudent.Text = "Search Student";
            this.tabPageSearchStudent.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SatriaManagementSystem__Event_Project_.Properties.Resources.Search;
            this.pictureBox1.Location = new System.Drawing.Point(32, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.sName,
            this.MatricNo,
            this.Block,
            this.RoomNo,
            this.PayingStatus,
            this.Status});
            this.dataGridView1.Location = new System.Drawing.Point(32, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(816, 293);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // sName
            // 
            this.sName.HeaderText = "Name";
            this.sName.MinimumWidth = 6;
            this.sName.Name = "sName";
            // 
            // MatricNo
            // 
            this.MatricNo.HeaderText = "Matric No";
            this.MatricNo.MinimumWidth = 6;
            this.MatricNo.Name = "MatricNo";
            // 
            // Block
            // 
            this.Block.HeaderText = "Block";
            this.Block.MinimumWidth = 6;
            this.Block.Name = "Block";
            // 
            // RoomNo
            // 
            this.RoomNo.HeaderText = "Room No";
            this.RoomNo.MinimumWidth = 6;
            this.RoomNo.Name = "RoomNo";
            // 
            // PayingStatus
            // 
            this.PayingStatus.HeaderText = "Paying Status";
            this.PayingStatus.MinimumWidth = 6;
            this.PayingStatus.Name = "PayingStatus";
            // 
            // Status
            // 
            this.Status.HeaderText = "Student Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            // 
            // textBoxSearchStudent
            // 
            this.textBoxSearchStudent.Location = new System.Drawing.Point(90, 33);
            this.textBoxSearchStudent.Name = "textBoxSearchStudent";
            this.textBoxSearchStudent.Size = new System.Drawing.Size(358, 22);
            this.textBoxSearchStudent.TabIndex = 1;
            this.textBoxSearchStudent.Text = "Search student name, matric number and block name";
            this.textBoxSearchStudent.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxSearchStudent_MouseClick);
            this.textBoxSearchStudent.TextChanged += new System.EventHandler(this.textBoxSearchStudent_TextChanged);
            this.textBoxSearchStudent.Leave += new System.EventHandler(this.textBoxSearchStudent_Leave);
            // 
            // tabPageRoomApplication
            // 
            this.tabPageRoomApplication.Controls.Add(this.labelBlock);
            this.tabPageRoomApplication.Controls.Add(this.dataGridView2);
            this.tabPageRoomApplication.Location = new System.Drawing.Point(4, 25);
            this.tabPageRoomApplication.Name = "tabPageRoomApplication";
            this.tabPageRoomApplication.Size = new System.Drawing.Size(854, 397);
            this.tabPageRoomApplication.TabIndex = 1;
            this.tabPageRoomApplication.Text = "Room Application";
            this.tabPageRoomApplication.UseVisualStyleBackColor = true;
            // 
            // labelBlock
            // 
            this.labelBlock.AutoSize = true;
            this.labelBlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBlock.Location = new System.Drawing.Point(18, 28);
            this.labelBlock.Name = "labelBlock";
            this.labelBlock.Size = new System.Drawing.Size(99, 16);
            this.labelBlock.TabIndex = 8;
            this.labelBlock.Text = "Block Detail :";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BlockID,
            this.BlockName,
            this.BlockGender,
            this.BlockAsset,
            this.BlockCapacity,
            this.BlockStatus,
            this.BlockStopApp,
            this.BlockUpdateRoomFee,
            this.BlockViewStudent});
            this.dataGridView2.Location = new System.Drawing.Point(19, 56);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(832, 327);
            this.dataGridView2.TabIndex = 7;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // BlockID
            // 
            this.BlockID.HeaderText = "ID";
            this.BlockID.MinimumWidth = 6;
            this.BlockID.Name = "BlockID";
            this.BlockID.Visible = false;
            // 
            // BlockName
            // 
            this.BlockName.HeaderText = "Name";
            this.BlockName.MinimumWidth = 6;
            this.BlockName.Name = "BlockName";
            // 
            // BlockGender
            // 
            this.BlockGender.HeaderText = "Gender";
            this.BlockGender.MinimumWidth = 6;
            this.BlockGender.Name = "BlockGender";
            // 
            // BlockAsset
            // 
            this.BlockAsset.HeaderText = "Asset";
            this.BlockAsset.MinimumWidth = 6;
            this.BlockAsset.Name = "BlockAsset";
            // 
            // BlockCapacity
            // 
            this.BlockCapacity.HeaderText = "Number Students";
            this.BlockCapacity.MinimumWidth = 6;
            this.BlockCapacity.Name = "BlockCapacity";
            // 
            // BlockStatus
            // 
            this.BlockStatus.HeaderText = "Status";
            this.BlockStatus.MinimumWidth = 6;
            this.BlockStatus.Name = "BlockStatus";
            // 
            // BlockStopApp
            // 
            this.BlockStopApp.HeaderText = "Stop Room Application";
            this.BlockStopApp.MinimumWidth = 6;
            this.BlockStopApp.Name = "BlockStopApp";
            this.BlockStopApp.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // BlockUpdateRoomFee
            // 
            this.BlockUpdateRoomFee.HeaderText = "Update Room Fee";
            this.BlockUpdateRoomFee.MinimumWidth = 6;
            this.BlockUpdateRoomFee.Name = "BlockUpdateRoomFee";
            // 
            // BlockViewStudent
            // 
            this.BlockViewStudent.HeaderText = "Check Out Student";
            this.BlockViewStudent.MinimumWidth = 6;
            this.BlockViewStudent.Name = "BlockViewStudent";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(886, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.returnToolStripMenuItem.Text = "Return";
            this.returnToolStripMenuItem.Click += new System.EventHandler(this.returnToolStripMenuItem_Click);
            // 
            // Staff_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 483);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Staff_Form";
            this.Text = "StaffForm";
            this.Load += new System.EventHandler(this.StaffForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageMyInformation.ResumeLayout(false);
            this.tabPageMyInformation.PerformLayout();
            this.tabPageSearchStudent.ResumeLayout(false);
            this.tabPageSearchStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPageRoomApplication.ResumeLayout(false);
            this.tabPageRoomApplication.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageSearchStudent;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxSearchStudent;
        private System.Windows.Forms.TabPage tabPageRoomApplication;
        private System.Windows.Forms.TabPage tabPageMyInformation;
        private System.Windows.Forms.TextBox textBoxPhoneNo;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPhoneNo;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.CheckBox checkBoxShowPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelMyInformation;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label labelBlock;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonDiscard;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.LinkLabel linkLabelSuperAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatricNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Block;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayingStatus;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlockID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlockName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlockGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlockAsset;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlockCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlockStatus;
        private System.Windows.Forms.DataGridViewButtonColumn BlockStopApp;
        private System.Windows.Forms.DataGridViewButtonColumn BlockUpdateRoomFee;
        private System.Windows.Forms.DataGridViewButtonColumn BlockViewStudent;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
    }
}