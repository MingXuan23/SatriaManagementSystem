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
    public partial class StudentViewForm : Form
    {
        SatriaManagementDatabaseEntities ent = new SatriaManagementDatabaseEntities();
        Student student { get; set; }
        bool haveRoom {  get; set; }
        public StudentViewForm(Student student)
        {
            InitializeComponent();
            this.student = student;
            //load data into tab page 2
            loadApplyRoomTable();
            loadStudentInfo();
            loadRoomDetails();
        }        
        private void StudentViewForm_Load(object sender, EventArgs e)
        {
            this.haveRoom = ent.Student_Room.Any(x => x.StudentID == student.ID && x.Status == "Check-in");
            if (this.haveRoom)
            {
                tabControlApplyRoom.SelectedIndex = 2;
            }
        }
        private void loadApplyRoomTable()
        {
            dataGridViewBlock.Rows.Clear();
            var block = ent.Blocks.ToList();
            foreach(var b in block)
            {
                string status = b.Status ? "Open" : "Closed";
                dataGridViewBlock.Rows.Add(b.ID,b.Name,status,"Apply Room");
                if(b.Gender!= student.Gender)
                {
                    dataGridViewBlock.Rows[dataGridViewBlock.RowCount - 2].DefaultCellStyle.BackColor = Color.IndianRed;
                }
            }
        }
        private void loadStudentInfo()
        {
            textBoxFullName.Text = student.FullName;
            textBoxEmail.Text = student.Email;
            textBoxPhoneNum.Text = student.PhoneNum;
            textBoxUserName.Text = student.Username;
            if (student.Gender == true)
            {
                radioButtonMale.Checked = true;
            }
            else
            {
                radioButtonFemale.Checked = true;
            }
        }
        private void loadRoomDetails()
        {
            var room = ent.Student_Room.FirstOrDefault(x => x.Status == "Check-in" &&  x.StudentID == student.StudentID ).Room;
            var block = room.Block.Name;
            var fee = room.RoomFees;
            var roomNo = room.RoomNo;
            var status = room.Student_Room.Any(x => x.Status == "Check-in" && x.TransactionID != null);

            labelDisplayBlock.Text = block;
            labelDisplayRoom.Text = roomNo;
            labelDisplayFee.Text = $"RM{fee}";
            labelDisplayStatus.Text = status ? "Paid" : "Unpaid" ;
            if(status)
            {
                buttonPay.Enabled = false;
            }
        }
        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserID = 0;//reset back to 0
            Properties.Settings.Default.Save();
            MessageBox.Show("Logged Out Successfully");
            this.Hide();
            new Form1().ShowDialog();
            this.Close();
        }

        private void buttonDiscard_Click(object sender, EventArgs e)
        {
            loadStudentInfo();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == string.Empty || textBoxFullName.Text == string.Empty || textBoxPhoneNum.Text == string.Empty || textBoxUserName.Text == string.Empty)
            {
                MessageBox.Show("Please don't leave any fields empty", "Empty Field");
                return;
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to modify your personal details?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    student.FullName = textBoxFullName.Text;
                    student.Email = textBoxEmail.Text;
                    student.Username = textBoxUserName.Text;
                    student.PhoneNum = textBoxPhoneNum.Text;
                    student.Gender = radioButtonMale.Checked;

                    try
                    {
                        student.editUser();
                    }
                    catch (NullReferenceException err)
                    {
                        MessageBox.Show(err.Message);
                        return;
                    }
                    MessageBox.Show("Edit Successful", "Success");
                    loadStudentInfo();
                }
                else
                {
                    return;
                }
            }
        }
       private void tabControlApplyRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.haveRoom && tabControlApplyRoom.SelectedIndex == 0)
            {
                tabControlApplyRoom.SelectedIndex = 2;
                MessageBox.Show("You already have a room");
            }
        }
        private void dataGridViewBlock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewBlock.Rows[e.RowIndex].DefaultCellStyle.BackColor == Color.IndianRed)
            {
                string gender = student.Gender ? "Female" : "Male";
                MessageBox.Show("This block is specified for " + gender);
                return;
            }

            if(dataGridViewBlock.Rows[e.RowIndex].Cells[0].Value == null)
            {
                return;
            }
            long blockid = long.Parse(dataGridViewBlock.Rows[e.RowIndex].Cells[0].Value.ToString());
            var block = ent.Blocks.FirstOrDefault(x => x.ID == blockid && x.Status);
            if (block != null && !ent.Student_Room.Any(x => x.StudentID == student.ID))
            {
                var rooms = block.Rooms.Where(x => x.Student_Room.Where(y=>y.Status != "Checkout").Count() < x.MaxCapacity).ToList();
                Student_Room studentRoom = new Student_Room();
                studentRoom.ID = ent.Student_Room.Any() ? ent.Student_Room.Max(x => x.ID + 1): 1;
                studentRoom.RoomID = long.Parse(rooms.FirstOrDefault().ID.ToString());
                studentRoom.StudentID = student.ID;
                studentRoom.Status = "Check-in";
                ent.Student_Room.Add(studentRoom);
                ent.SaveChanges();
                MessageBox.Show("Room Applied");
                haveRoom = true;
                tabControlApplyRoom.SelectedIndex = 2;
            }
        }
 
    }
}
