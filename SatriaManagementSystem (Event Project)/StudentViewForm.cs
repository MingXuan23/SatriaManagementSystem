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
        Student student;
        public StudentViewForm(Student student)
        {
            InitializeComponent();
            this.student = student;
            //load data into tab page 2
            loadData();
        }
        private void loadData()
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
        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserID = 0;//reset back to 0
            MessageBox.Show("Logged Out Successfully");
            this.Hide();
            new Form1().ShowDialog();
            this.Close();
        }

        private void buttonDiscard_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if(textBoxEmail.Text == string.Empty||textBoxFullName.Text == string.Empty|| textBoxPhoneNum.Text == string.Empty || textBoxUserName.Text == string.Empty)
            {
                MessageBox.Show("Please don't leave any fields empty", "Empty Field");
                return;
            }
            else
            {
                student.FullName = textBoxFullName.Text;
                student.Email = textBoxEmail.Text;
                student.Username = textBoxUserName.Text;
                student.PhoneNum = textBoxPhoneNum.Text;
                student.Gender = radioButtonMale.Checked;
            }
            try
            {
                student.editUser();
            }
            catch(NullReferenceException err)
            {
                MessageBox.Show(err.Message);
                return;
            }
            MessageBox.Show("Edit Successful", "Success");
        }
    }
}
