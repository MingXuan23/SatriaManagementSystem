using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatriaManagementSystem__Event_Project_
{
    //hello world
    public partial class Staff_Form : Form
    {
        Staff staff =new Staff();
        SatriaManagementDatabaseEntities ent = new SatriaManagementDatabaseEntities(); 
        public Staff_Form()
        {
            InitializeComponent();
        }
        public void loadColor()
        {
            Color color = Properties.Settings.Default.LogInColor;
            this.BackColor = color;
            foreach (Control control in tabControl1.Controls)
            {
                control.BackColor = color;
            }
        }
        public Staff_Form(long id)
        {
            InitializeComponent();
            try
            {
                staff.getUserByID(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Staff_Form(Staff staff)
        {
            InitializeComponent();
            this.staff = staff;
        }

        public void initializeInformation()
        {
            foreach(Control control in tabPageMyInformation.Controls)
            {
                if(control is TextBox)
                {
                    control.DataBindings.Clear();
                }
            }
            textBoxUsername.DataBindings.Add("Text", staff, "Username");
            textBoxPassword.DataBindings.Add("Text", staff, "Password");
            textBoxFullName.DataBindings.Add("Text", staff, "FullName");
            textBoxEmail.DataBindings.Add("Text", staff, "Email");
            textBoxPhoneNo.DataBindings.Add("Text", staff, "PhoneNum");
            if (staff.Gender)
            {
                radioButtonMale.Checked = true;
            }
            else
            {
                radioButtonFemale.Checked = true;
            }

        }
        private void StaffForm_Load(object sender, EventArgs e)
        {
            initializeInformation();
            textBoxSearchStudent.ForeColor = Color.Gray;
            fetchBlock();
            loadColor();
            
        }

        private void linkLabelSuperAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (staff.UserTypeID != 3)
            {
                MessageBox.Show("You are not super admin");
                return;
            }
            this.Hide();
            new SuperAdminForm().ShowDialog();
            this.Show();
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar=!checkBoxShowPassword.Checked;
        }

        public void fetchStudent()
        {
            string keyword = textBoxSearchStudent.Text;
            if (keyword == "Search student name, matric number and block name")
                keyword = "";
            var list = ent.Users.Where(x => (x.FullName.Contains(keyword) || x.Student.MatricNumber.Contains(keyword)) && x.UserTypeID == 1).ToList();
            var studentslist = new List<Student>();
            var searchRoom = ent.Student_Room.Where(x => x.Status == "Check-in" && x.Room.RoomNo.Contains(keyword)).Select(x => x.Student.User);

            list = list.Union(searchRoom).ToList();
            foreach (var user in list)
            {
                try
                {
                    Student a = new Student();
                    a.getUserByID(user.ID);
                    studentslist.Add(a);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

            }

            dataGridView1.Rows.Clear();
            foreach (var student in studentslist)
            {
                var rows = new object[7];
                rows[0] = student.ID;
                rows[1] = student.FullName;
                rows[2] = student.MatricNumber;

                var room = ent.Student_Room.FirstOrDefault(x => x.Status == "Check-in" && x.StudentID == student.StudentID);
                if (room != null)
                {
                    rows[3] = room.Room.Block.Name;
                    rows[4] = room.Room.RoomNo;
                    rows[5] = room.TransactionID == null ? "Unpaid" : "Paid";
                    rows[6] = true;
                }
                else
                {
                    rows[3] = "-";
                    rows[4] = "No room";
                    rows[5] = "No room";
                    rows[6] = false;
                }

                dataGridView1.Rows.Add(rows);


            }

            progressBar1.Maximum = ent.Students.Count();
            progressBar1.Value=studentslist.Count;
            labelFilter.Text = $"FIlter Students:{progressBar1.Value}/{progressBar1.Maximum}";

        }
        private void textBoxSearchStudent_TextChanged(object sender, EventArgs e)
        {
            fetchStudent();
           
        }

        public void fetchBlock()
        {
            var block = ent.Blocks.ToList();
            if (!staff.SuperAdmin)
            {
                block = block.Where(x => x.ID == staff.BlockID).ToList();
            }
            dataGridView2.Rows.Clear();
            foreach (var b in block)
            {
                var rows = new object[9];
                rows[0] = b.ID;
                rows[1 ] = b.Name;
                rows[2] = b.Gender ? "Male" : "Female";
                rows[3] = "RM "+b.Asset.ToString("0.00");
                var count = b.Rooms.Select(x => new { studentCount = x.Student_Room.Where(y => y.Status == "Check-in").Count() });
                var maximum = b.Capacity * b.Rooms.FirstOrDefault().MaxCapacity;
                rows[4] = count.Select(x => x.studentCount).FirstOrDefault().ToString() +"/"+ maximum.ToString();
                rows[5] = b.Status ? "Open" : "Close";
                rows[6] = b.Status ? "Stop Apply" : "Open Apply";
                rows[7] = "Update";
                rows[8] = "Confirm";
                dataGridView2.Rows.Add(rows);
                if(b.Status == false)
                {
                    dataGridView2.Rows[dataGridView2.RowCount-2].DefaultCellStyle.BackColor = Color.IndianRed;
                }
            }
        }



        private void buttonEdit_Click(object sender, EventArgs e)
        {
            foreach(Control control in tabPageMyInformation.Controls)
            {
                if((control is TextBox||control is MaskedTextBox) &&control.Text =="")
                {
                    MessageBox.Show("Please filled all fields");
                    return;
                }
            }
            decimal result;
            if (!decimal.TryParse(textBoxPhoneNo.Text, out result))
            {
                MessageBox.Show("Please filled valid phoen number");
                return;
            }
           if (ent.Users.Any(x => x.Username == textBoxUsername.Text && x.ID!=staff.ID))
            {
                MessageBox.Show("This username have been taken", "Invalid Field");
                return;
            }
            staff.Gender = radioButtonMale.Checked;
            staff.editUser();
            MessageBox.Show("Your information was updated successfully");
        }

        private void buttonDiscard_Click(object sender, EventArgs e)
        {
            long id =staff.ID;
            staff = new Staff();
            staff.getUserByID(id);
            initializeInformation();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView2.Rows[e.RowIndex].Cells[0].Value == null)
            {
                return;
            }
            else if (e.ColumnIndex == 6)
            {
                Console.WriteLine("close application");
                long blockid= long.Parse(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
                var block =ent.Blocks.FirstOrDefault(x=>x.ID==blockid);
                block.Status=!block.Status;
                ent.SaveChanges();
                fetchBlock();
            }
            else if(e.ColumnIndex == 7)
            {
                Console.WriteLine("update");
                long blockid = long.Parse(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
                new UpdateAmount(1,blockid).ShowDialog();
                fetchBlock();
            }
            else if(e.ColumnIndex==8)
            {
                long blockid = long.Parse(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());

                var studentRoom = ent.Student_Room.Where(x => x.Status == "Check-in" && x.Room.BlockID == blockid).ToList();
                var unpaidCount = studentRoom.Where(x => x.TransactionID == null).ToList();
                var result=MessageBox.Show($"There are {unpaidCount.Count} student did not paid the room fee, do you confirm to continue to check out all student?","Confirmation",MessageBoxButtons.YesNo);

                if(result == DialogResult.Yes)
                {
                    foreach(var sr in studentRoom)
                    {
                        sr.Status = "Check-out";
                    }
                    ent.SaveChanges();
                    fetchBlock();
                }
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserID = 0;//reset back to 0
            Properties.Settings.Default.UserType = 0;
            Properties.Settings.Default.Save();
            //MessageBox.Show("Logged Out Successfully");
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result=MessageBox.Show("Do you confirm to exit application?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Application.Exit();
                }
                catch (Exception ex)
                {
                    //do nothing
                }
            }
           
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxSearchStudent_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxSearchStudent.ForeColor == Color.Gray)
            {
                textBoxSearchStudent.Text = "";
                textBoxSearchStudent.ForeColor = Color.Black;
            }
        }

        private void textBoxSearchStudent_Leave(object sender, EventArgs e)
        {
            if (textBoxSearchStudent.ForeColor == Color.Black && textBoxSearchStudent.Text=="")
            {
                textBoxSearchStudent.Text = "Search student name, matric number and block name";
                textBoxSearchStudent.ForeColor = Color.Gray;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==6)
            {
                var id=dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                if (id == null)
                    return;


                bool status = bool.Parse(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());
                var checkboxCell = (DataGridViewCheckBoxCell)dataGridView1.Rows[e.RowIndex].Cells[6];
                if (status)
                {
                    try
                    {
                        string message = "Do you confirm to check out this student?";
                        var studentId = long.Parse(id.ToString());
                        var studentRoom = ent.Student_Room.FirstOrDefault(x => x.StudentID == studentId && x.Status == "Check-in");
                        if (studentRoom.TransactionID == null)
                            message += "\nWarning:This student did not settle his/her payment yet";
                        var result = MessageBox.Show(message, "Confirmation", MessageBoxButtons.OKCancel);
                        if (result == DialogResult.OK)
                        {

                            studentRoom.Status = "Check-out";
                            ent.SaveChanges();
                        }
                    }catch (Exception ex)
                    {
                        fetchStudent();
                        return;
                    }
                    
                }
                fetchStudent();
            }
        }

        private void Staff_Form_VisibleChanged(object sender, EventArgs e)
        {
            loadColor();
        }

        private void tabPageMyInformation_Click(object sender, EventArgs e)
        {

        }
    }
}
