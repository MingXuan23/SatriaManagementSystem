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
    public partial class Form1 : Form
    {
        SatriaManagementDatabaseEntities ent =new SatriaManagementDatabaseEntities();
        Student student=new Student();
        Staff staff=new Staff();
        public Form1()
        {
            if(Properties.Settings.Default.UserID != 0)//keep me signed in is in access
            {
                student.getUserByID(Properties.Settings.Default.UserID);
                this.Hide();
                new StudentViewForm(student).ShowDialog();
                this.Close();
            }
            else
            {
                InitializeComponent();
            }
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*var staff=new Staff();
            staff.getUserByID(1);
            staff.editUser();
            staff.deleteUser();
            staff.addUser();*/

          /*  var list = ent.Blocks.ToList();
            int level = 3; 
            int blocknum = 1;
            foreach (var block in list)
            {
                
                for(int i = 0; i < block.Capacity; i++)
                {
                    var room = new Room();
                    room.ID = blocknum++;
                    room.MaxCapacity = 2;
                    room.BlockID=block.ID;
                    room.LevelNum = i/5 +1;
                    room.RoomFees = 200;
                    room.RoomNo = $"{block.Name}-{i % level + 1}-{i / level + 1}";
                    ent.Rooms.Add(room);
                    ent.SaveChanges();
                }
               
;                
            }*/

        }

<<<<<<< Updated upstream
        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            this.Hide();
            new  AdminLoginForm().ShowDialog();
            this.Show();
        }

        private void linkLabelCreateAcc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new RegisterForm().ShowDialog();
            this.Show();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string inputUserName = textBoxUserName.Text;
            string inputMatricNumber = textBoxMatric.Text;
            string inputPassword = textBoxPassword.Text;

            if(inputUserName == string.Empty || inputPassword == string.Empty)
            {
                MessageBox.Show("Please don't leave username or password empty","Empty Fields");
                return;
            }
            //student try to log-in 
            if(inputMatricNumber != string.Empty)
            {
                try
                {
                    student.getUserByName(inputUserName);
                    if(inputMatricNumber != student.MatricNumber)
                    {
                        MessageBox.Show("Invalid matric number!");
                        textBoxMatric.Focus();
                        return;
                    }else if(inputPassword != student.Password)
                    {
                        MessageBox.Show("Invalid password!");
                        textBoxPassword.Focus();
                        return;
                    }
                    else//if inputs is valid
                    {
                        this.Hide();
                        new StudentViewForm(student).ShowDialog();
                        reset();
                        this.Show();
                    }
                }
                catch(NullReferenceException err)
                {
                    MessageBox.Show(err.Message);
                    return;
                }
            }
            else//staff try to log-in 
            {
                try
                {
                    staff.getUserByName(inputUserName);
                    if (inputPassword != staff.Password)
                    {
                        MessageBox.Show("Invalid password!");
                        textBoxPassword.Focus();
                        return;
                    }
                    else//if inputs is valid
                    {
                        this.Hide();
                        MessageBox.Show("Staff Log In!!!");
                        this.Show();
                    }
                }
                catch(NullReferenceException err)
                {
                    MessageBox.Show(err.Message);
                    return;
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            reset();
        }
        private void reset()
        {
            textBoxUserName.Text = string.Empty;
            textBoxMatric.Text = string.Empty;
            textBoxPassword.Text = string.Empty;
            checkBoxKeepMe.Checked = false;
            checkBoxShowPw.Checked = false;
            student = new Student();
            staff = new Staff();
        }

        private void checkBoxShowPw_CheckedChanged(object sender, EventArgs e)
        {
                textBoxPassword.UseSystemPasswordChar = !checkBoxShowPw.Checked;
        }

        private void checkBoxKeepMe_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxKeepMe.Checked && textBoxUserName.Text != string.Empty && textBoxPassword.Text != string.Empty)
            {
                if(textBoxMatric.Text!= string.Empty)//for student
                {
                    try
                    {
                        student.getUserByName(textBoxUserName.Text);
                        Properties.Settings.Default.UserID = (int)student.StudentID != 0 ? (int)student.StudentID : 0;
                        Properties.Settings.Default.Save();
                    }
                    catch (NullReferenceException err)
                    {
                        MessageBox.Show(err.Message);
                        return;
                    }
                }
                else//for staff
                {
                    try
                    {
                         staff.getUserByName(textBoxUserName.Text);
                        Properties.Settings.Default.UserID = (int)staff.StaffID != 0 ? (int)staff.StaffID : 0;
                        Properties.Settings.Default.Save();
                    }
                    catch (NullReferenceException err)
                    {
                        MessageBox.Show(err.Message);
                        return;
                    }
                }
                
            }
            else
            {
                checkBoxKeepMe.Checked = false;
            }
=======
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().ShowDialog();
            this.Show();
            pictureBox1.Image = null;
>>>>>>> Stashed changes
        }
    }
}
