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
        //Staff staff=new Staff();
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
            

        }

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
            try
            {
                student.getUserByName(inputUserName);
                if (inputMatricNumber != student.MatricNumber)
                {
                    MessageBox.Show("Invalid matric number!");
                    textBoxMatric.Focus();
                    return;
                }
                else if (inputPassword != student.Password)
                {
                    MessageBox.Show("Invalid password!");
                    textBoxPassword.Focus();
                    return;
                }
                else//if inputs is valid
                {
                    this.Hide();
                    Properties.Settings.Default.UserID = student.StudentID;
                    Properties.Settings.Default.Save();
                    new StudentViewForm(student).ShowDialog();
                    reset();
                    this.Show();
                }
            }
            catch (NullReferenceException err)
            {
                MessageBox.Show(err.Message);
                return;
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
            checkBoxShowPw.Checked = false;
            student = new Student();

        }

        private void checkBoxShowPw_CheckedChanged(object sender, EventArgs e)
        {
                textBoxPassword.UseSystemPasswordChar = !checkBoxShowPw.Checked;
        }

        private void checkBoxKeepMe_CheckedChanged(object sender, EventArgs e)
        {
            /*if (checkBoxKeepMe.Checked && textBoxUserName.Text != string.Empty && textBoxPassword.Text != string.Empty)
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
            }*/
        }
    }
}
