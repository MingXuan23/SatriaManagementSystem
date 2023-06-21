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
    public partial class RegisterForm : Form
    {
        SatriaManagementDatabaseEntities ent = new SatriaManagementDatabaseEntities();
        Student student = new Student();

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string inputUserName = textBoxUserName.Text;
            string inputFullName = textBoxFullName.Text;
            string inputPassword = textBoxPw.Text;
            string inputConfirmPassword = textBoxComPw.Text;    
            string inputMatricNo = textBoxMatricNum.Text;
            string inputPhoneNo = textBoxPhoneNum.Text;
            string inputEmail = textBoxEmail.Text;
            bool inputIsMale = radioButtonMale.Checked;
            bool inputIsFemale = radioButtonFemale.Checked;

            if(inputUserName == string.Empty || inputFullName == string.Empty|| inputPassword == string.Empty|| inputConfirmPassword ==string.Empty||inputMatricNo == string.Empty || inputPhoneNo == string.Empty|| inputEmail ==string.Empty || (!inputIsFemale && !inputIsMale))
            {
                MessageBox.Show("Please don't leave any field empty", "Empty Fields");
                return;
            }else if(inputPassword != inputConfirmPassword || inputPassword.Length < 6)
            {
                MessageBox.Show("Please make sure both passwords match and the password's length is at least 6 characters","Invalid Password");
                textBoxPw.Text = string.Empty;
                textBoxPw.Focus();
                textBoxComPw.Text = string.Empty;
                return;
            }
            else if (!decimal.TryParse(textBoxPhoneNum.Text, out decimal value))
            {
                MessageBox.Show("Please key in valid phone num", "Invalid Field");
                return;
            }
            else if (ent.Users.Any(x => x.Username == inputUserName))
            {
                MessageBox.Show("This username have been taken", "Invalid Field");
                return;
            }
            else if (ent.Students.Any(x => x.MatricNumber == inputMatricNo))
            {
                MessageBox.Show("Duplicated matric number detected ", "Invalid Field");
                return;
            }
            else//if inputs are valid
            {
                try
                {
                    student.Username = inputUserName;
                    student.FullName = inputFullName;
                    student.Password = inputPassword;
                    student.MatricNumber = inputMatricNo;
                    student.PhoneNum = inputPhoneNo;
                    student.Email = inputEmail;
                    student.Gender = inputIsMale ? true : false;
                    student.UserTypeID = 1;
                    student.Status = true;
                    student.addUser();
                }
                catch (NullReferenceException err)
                {
                    MessageBox.Show(err.Message);
                    return;
                }

                MessageBox.Show("Student Registration Successful!");
                this.Close();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void loadColor()
        {
            Color color = Properties.Settings.Default.LogInColor;
            this.BackColor = color;
        }
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            loadColor();
        }

        private void textBoxMatricNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
