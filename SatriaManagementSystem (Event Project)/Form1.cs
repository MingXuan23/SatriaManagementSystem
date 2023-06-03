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
    public partial class Form1 : Form,InterfaceLogin
    {
        SatriaManagementDatabaseEntities ent =new SatriaManagementDatabaseEntities();
        Student student=new Student();
        Staff staff=new Staff();
        public Form1()
        {
            InitializeComponent();

                
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadColor();
            if (Properties.Settings.Default.UserID != 0)//keep me signed in is in access
            {
                try
                {
                    if(Properties.Settings.Default.UserType == 1)
                    {
                        this.Hide();
                        new StudentViewForm(Properties.Settings.Default.UserID).ShowDialog();
                    }
                    else
                    {
                        this.Hide();
                        new Staff_Form(Properties.Settings.Default.UserID).ShowDialog();
                    }
                        
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                if (Application.OpenForms.Count != 0)
                {
                    this.Show();
                    loadColor();
                    reset();
                }
                
                
            }
        }

        public void loadColor()
        {
            Color color = Properties.Settings.Default.LogInColor;
            this.BackColor = color;
        }


        private void linkLabelCreateAcc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new RegisterForm().ShowDialog();
            reset();
            this.Show();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            login();

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            //reset();
            Application.Exit();
        }
        private void reset()
        {

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



        //interface
        public void login()
        {
            string inputMatricNumber = textBoxMatric.Text;
            string inputPassword = textBoxPassword.Text;



            if (inputMatricNumber == string.Empty || inputPassword == string.Empty)
            {
                prompt("Please don't leave username or password empty", "Empty Fields");
                return;
            }
            //student try to log-in 
            try
            {
                var student = ent.Users.FirstOrDefault(x => x.Student.MatricNumber == inputMatricNumber && x.Password == inputPassword);
                if (student == null)
                {
                    prompt("The credentials do not match ","Invalid Field");
                    textBoxMatric.Focus();
                    return;
                }
                this.student.getUserByID(student.ID);


                this.Hide();
                Properties.Settings.Default.UserID = this.student.StudentID;
                Properties.Settings.Default.UserType = this.student.UserTypeID;
                Properties.Settings.Default.Save();
                new StudentViewForm(this.student).ShowDialog();
                reset();
                this.Show();

            }
            catch (NullReferenceException err)
            {
                prompt(err.Message,"Error");
                return;
            }
        }

        public void prompt(string msg,string title)
        {
           MessageBox.Show(msg,title);
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            new AdminLoginForm().ShowDialog();
            try
            {
                reset();
                loadColor();
                this.Show();
            }
            catch (Exception err)
            {
                //do nothing
            }
        }

        private void textBoxMatric_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }

        private void buttonLogin_MouseHover(object sender, EventArgs e)
        {
            buttonLogin.BackColor = Color.LightSkyBlue;

        }

        private void buttonLogin_MouseLeave(object sender, EventArgs e)
        {
            buttonLogin.BackColor = Color.WhiteSmoke;
        }

        private void buttonCancel_MouseHover(object sender, EventArgs e)
        {
            buttonCancel.BackColor = Color.PaleVioletRed;
        }

        private void buttonCancel_MouseLeave(object sender, EventArgs e)
        {
            buttonCancel.BackColor = Color.WhiteSmoke;
        }
    }
}
