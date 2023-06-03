using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatriaManagementSystem__Event_Project_
{
    public partial class UpdateAmount : Form
    {
        int data { get; set; }
        long dataID { get; set; }

        SatriaManagementDatabaseEntities ent =new SatriaManagementDatabaseEntities();
        public UpdateAmount(int data,long dataID)
        {
            InitializeComponent();
            this.data = data;
            this.dataID = dataID;
        }

        private void UpdateAmount_Load(object sender, EventArgs e)
        {
            switch (data)
            {
                case 1:

                    var block = ent.Blocks.FirstOrDefault(x => x.ID == dataID);
                    labelTitle.Text="Update Room fee for "+block.Name;
                    CurrentLabel.Text="RM "+block.Rooms.FirstOrDefault().RoomFees.ToString("0.00");
                    numericUpdate.Value = block.Rooms.FirstOrDefault().RoomFees;
                    break;


                case 2:
                    var staff = ent.Staffs.FirstOrDefault(x => x.StaffID == dataID);
                    labelTitle.Text = "Update Salary for " + staff.User.FullName;
                    CurrentLabel.Text = "RM " + staff.Salary.ToString("0.00");
                    numericUpdate.Value = staff.Salary;
                    break;

            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            switch (data)
            {
                case 1:

                    var block = ent.Blocks.FirstOrDefault(x => x.ID == dataID);
                    block.Rooms.ToList().ForEach(x => x.RoomFees = (decimal)numericUpdate.Value);
                    ent.SaveChanges();
                    break;


                case 2:
                    var staff = ent.Staffs.FirstOrDefault(x => x.StaffID == dataID);
                    staff.getUserByID(staff.StaffID);
                    staff.Salary = (decimal)numericUpdate.Value;

                    staff.editUser();
                    break;

            }
            this.Close();
        }
    }
}
