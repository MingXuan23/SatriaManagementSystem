namespace SatriaManagementSystem__Event_Project_
{
    partial class UpdateRoomFee
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
            this.labelRoomFeeUpdation = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.textBoxUpdationRoomFee = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxOriRoomFee = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelRoomFeeUpdation
            // 
            this.labelRoomFeeUpdation.AutoSize = true;
            this.labelRoomFeeUpdation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoomFeeUpdation.Location = new System.Drawing.Point(161, 48);
            this.labelRoomFeeUpdation.Name = "labelRoomFeeUpdation";
            this.labelRoomFeeUpdation.Size = new System.Drawing.Size(159, 18);
            this.labelRoomFeeUpdation.TabIndex = 11;
            this.labelRoomFeeUpdation.Text = "Room Fee Updation";
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(270, 234);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 36);
            this.buttonConfirm.TabIndex = 10;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            // 
            // textBoxUpdationRoomFee
            // 
            this.textBoxUpdationRoomFee.Location = new System.Drawing.Point(231, 174);
            this.textBoxUpdationRoomFee.Name = "textBoxUpdationRoomFee";
            this.textBoxUpdationRoomFee.Size = new System.Drawing.Size(211, 22);
            this.textBoxUpdationRoomFee.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Updation Room Fee : ";
            // 
            // textBoxOriRoomFee
            // 
            this.textBoxOriRoomFee.Location = new System.Drawing.Point(231, 101);
            this.textBoxOriRoomFee.Name = "textBoxOriRoomFee";
            this.textBoxOriRoomFee.Size = new System.Drawing.Size(211, 22);
            this.textBoxOriRoomFee.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Original Room Fee : ";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(367, 234);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 36);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // UpdateRoomFee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 304);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelRoomFeeUpdation);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.textBoxUpdationRoomFee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxOriRoomFee);
            this.Controls.Add(this.label1);
            this.Name = "UpdateRoomFee";
            this.Text = "UpdateRoomFee";
            this.Load += new System.EventHandler(this.UpdateRoomFee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRoomFeeUpdation;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.TextBox textBoxUpdationRoomFee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxOriRoomFee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancel;
    }
}