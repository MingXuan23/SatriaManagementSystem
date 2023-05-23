namespace SatriaManagementSystem__Event_Project_
{
    partial class StudentViewForm
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
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.tabControlApplyRoom = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewBlock = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAction = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.labelInstruction = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.buttonDiscard = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNum = new System.Windows.Forms.TextBox();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonPay = new System.Windows.Forms.Button();
            this.labelDisplayStatus = new System.Windows.Forms.Label();
            this.labelDisplayFee = new System.Windows.Forms.Label();
            this.labelDisplayRoom = new System.Windows.Forms.Label();
            this.labelDisplayBlock = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.satriaManagementDatabaseDataSet = new SatriaManagementSystem__Event_Project_.SatriaManagementDatabaseDataSet();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsTableAdapter = new SatriaManagementSystem__Event_Project_.SatriaManagementDatabaseDataSetTableAdapters.RoomsTableAdapter();
            this.tabControlApplyRoom.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBlock)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.satriaManagementDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.AutoSize = true;
            this.buttonLogOut.Location = new System.Drawing.Point(644, 431);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(111, 50);
            this.buttonLogOut.TabIndex = 0;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // tabControlApplyRoom
            // 
            this.tabControlApplyRoom.Controls.Add(this.tabPage1);
            this.tabControlApplyRoom.Controls.Add(this.tabPage2);
            this.tabControlApplyRoom.Controls.Add(this.tabPage3);
            this.tabControlApplyRoom.Location = new System.Drawing.Point(47, 62);
            this.tabControlApplyRoom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControlApplyRoom.Name = "tabControlApplyRoom";
            this.tabControlApplyRoom.SelectedIndex = 0;
            this.tabControlApplyRoom.Size = new System.Drawing.Size(712, 361);
            this.tabControlApplyRoom.TabIndex = 1;
            this.tabControlApplyRoom.SelectedIndexChanged += new System.EventHandler(this.tabControlApplyRoom_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewBlock);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.labelInstruction);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(704, 328);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ApplyRoom";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBlock
            // 
            this.dataGridViewBlock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBlock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBlock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnName,
            this.ColumnStatus,
            this.ColumnAction});
            this.dataGridViewBlock.Location = new System.Drawing.Point(26, 108);
            this.dataGridViewBlock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewBlock.Name = "dataGridViewBlock";
            this.dataGridViewBlock.RowHeadersWidth = 51;
            this.dataGridViewBlock.RowTemplate.Height = 24;
            this.dataGridViewBlock.Size = new System.Drawing.Size(650, 189);
            this.dataGridViewBlock.TabIndex = 2;
            this.dataGridViewBlock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBlock_CellContentClick);
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "id";
            this.ColumnId.MinimumWidth = 6;
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.Visible = false;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.MinimumWidth = 6;
            this.ColumnName.Name = "ColumnName";
            // 
            // ColumnStatus
            // 
            this.ColumnStatus.HeaderText = "Status";
            this.ColumnStatus.MinimumWidth = 6;
            this.ColumnStatus.Name = "ColumnStatus";
            // 
            // ColumnAction
            // 
            this.ColumnAction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ColumnAction.HeaderText = "Action";
            this.ColumnAction.MinimumWidth = 6;
            this.ColumnAction.Name = "ColumnAction";
            this.ColumnAction.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please apply an empty room !!!";
            // 
            // labelInstruction
            // 
            this.labelInstruction.AutoSize = true;
            this.labelInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstruction.Location = new System.Drawing.Point(20, 19);
            this.labelInstruction.Name = "labelInstruction";
            this.labelInstruction.Size = new System.Drawing.Size(395, 32);
            this.labelInstruction.TabIndex = 0;
            this.labelInstruction.Text = "Your don\'t have a room now !!!";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.radioButtonFemale);
            this.tabPage2.Controls.Add(this.radioButtonMale);
            this.tabPage2.Controls.Add(this.buttonDiscard);
            this.tabPage2.Controls.Add(this.buttonEdit);
            this.tabPage2.Controls.Add(this.textBoxEmail);
            this.tabPage2.Controls.Add(this.textBoxPhoneNum);
            this.tabPage2.Controls.Add(this.textBoxFullName);
            this.tabPage2.Controls.Add(this.textBoxUserName);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(704, 328);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Student Info";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(135, 208);
            this.radioButtonFemale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(87, 24);
            this.radioButtonFemale.TabIndex = 31;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(135, 175);
            this.radioButtonMale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(68, 24);
            this.radioButtonMale.TabIndex = 30;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // buttonDiscard
            // 
            this.buttonDiscard.Location = new System.Drawing.Point(400, 272);
            this.buttonDiscard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDiscard.Name = "buttonDiscard";
            this.buttonDiscard.Size = new System.Drawing.Size(84, 29);
            this.buttonDiscard.TabIndex = 29;
            this.buttonDiscard.Text = "Discard";
            this.buttonDiscard.UseVisualStyleBackColor = true;
            this.buttonDiscard.Click += new System.EventHandler(this.buttonDiscard_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(256, 272);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(84, 29);
            this.buttonEdit.TabIndex = 28;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(471, 122);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(215, 26);
            this.textBoxEmail.TabIndex = 25;
            // 
            // textBoxPhoneNum
            // 
            this.textBoxPhoneNum.Location = new System.Drawing.Point(471, 70);
            this.textBoxPhoneNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPhoneNum.Name = "textBoxPhoneNum";
            this.textBoxPhoneNum.Size = new System.Drawing.Size(215, 26);
            this.textBoxPhoneNum.TabIndex = 24;
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Location = new System.Drawing.Point(135, 120);
            this.textBoxFullName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(193, 26);
            this.textBoxFullName.TabIndex = 22;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(135, 71);
            this.textBoxUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(193, 26);
            this.textBoxUserName.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Gender :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(334, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Email :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(334, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Phone Number :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Full Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "User Name :";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonPay);
            this.tabPage3.Controls.Add(this.labelDisplayStatus);
            this.tabPage3.Controls.Add(this.labelDisplayFee);
            this.tabPage3.Controls.Add(this.labelDisplayRoom);
            this.tabPage3.Controls.Add(this.labelDisplayBlock);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(704, 328);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Room Details";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonPay
            // 
            this.buttonPay.Location = new System.Drawing.Point(348, 253);
            this.buttonPay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(93, 43);
            this.buttonPay.TabIndex = 8;
            this.buttonPay.Text = "Pay";
            this.buttonPay.UseVisualStyleBackColor = true;
            // 
            // labelDisplayStatus
            // 
            this.labelDisplayStatus.AutoSize = true;
            this.labelDisplayStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisplayStatus.Location = new System.Drawing.Point(396, 184);
            this.labelDisplayStatus.Name = "labelDisplayStatus";
            this.labelDisplayStatus.Size = new System.Drawing.Size(45, 25);
            this.labelDisplayStatus.TabIndex = 7;
            this.labelDisplayStatus.Text = "xxx";
            // 
            // labelDisplayFee
            // 
            this.labelDisplayFee.AutoSize = true;
            this.labelDisplayFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisplayFee.Location = new System.Drawing.Point(396, 136);
            this.labelDisplayFee.Name = "labelDisplayFee";
            this.labelDisplayFee.Size = new System.Drawing.Size(45, 25);
            this.labelDisplayFee.TabIndex = 6;
            this.labelDisplayFee.Text = "xxx";
            // 
            // labelDisplayRoom
            // 
            this.labelDisplayRoom.AutoSize = true;
            this.labelDisplayRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisplayRoom.Location = new System.Drawing.Point(396, 87);
            this.labelDisplayRoom.Name = "labelDisplayRoom";
            this.labelDisplayRoom.Size = new System.Drawing.Size(45, 25);
            this.labelDisplayRoom.TabIndex = 5;
            this.labelDisplayRoom.Text = "xxx";
            // 
            // labelDisplayBlock
            // 
            this.labelDisplayBlock.AutoSize = true;
            this.labelDisplayBlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisplayBlock.Location = new System.Drawing.Point(396, 41);
            this.labelDisplayBlock.Name = "labelDisplayBlock";
            this.labelDisplayBlock.Size = new System.Drawing.Size(45, 25);
            this.labelDisplayBlock.TabIndex = 4;
            this.labelDisplayBlock.Text = "xxx";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(243, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 25);
            this.label10.TabIndex = 3;
            this.label10.Text = "Status :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(243, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Fee :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(243, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Room No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(243, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Block :";
            // 
            // satriaManagementDatabaseDataSet
            // 
            this.satriaManagementDatabaseDataSet.DataSetName = "SatriaManagementDatabaseDataSet";
            this.satriaManagementDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.satriaManagementDatabaseDataSet;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // StudentViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(821, 545);
            this.Controls.Add(this.tabControlApplyRoom);
            this.Controls.Add(this.buttonLogOut);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StudentViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentViewForm";
            this.Load += new System.EventHandler(this.StudentViewForm_Load);
            this.tabControlApplyRoom.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBlock)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.satriaManagementDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.TabControl tabControlApplyRoom;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelInstruction;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonDiscard;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPhoneNum;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.Label labelDisplayStatus;
        private System.Windows.Forms.Label labelDisplayFee;
        private System.Windows.Forms.Label labelDisplayRoom;
        private System.Windows.Forms.Label labelDisplayBlock;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewBlock;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private SatriaManagementDatabaseDataSet satriaManagementDatabaseDataSet;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private SatriaManagementDatabaseDataSetTableAdapters.RoomsTableAdapter roomsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatus;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnAction;
    }
}