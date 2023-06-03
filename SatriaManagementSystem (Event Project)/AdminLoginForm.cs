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
    public partial class AdminLoginForm : Form,InterfaceLogin
    {
        Staff staff = new Staff();
        SatriaManagementDatabaseEntities ent = new SatriaManagementDatabaseEntities();  
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void loadColor()
        {
            Color color = Properties.Settings.Default.LogInColor;
            this.BackColor = color;
        }
        private void AdminLoginForm_Load(object sender, EventArgs e)
        {
            loadColor();
        }

        private void checkBoxShowPw_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = !checkBoxShowPw.Checked;
        }

        public void login()
        {
            string inputUserName = textBoxUserName.Text;
            string inputPassword = textBoxPassword.Text;
            if (inputUserName == string.Empty || inputPassword == string.Empty)
            {
               prompt("Please don't leave username or password empty", "Empty Fields");
                return;
            }
            try
            {
                var entStaff = ent.Users.FirstOrDefault(x => x.Username == inputUserName && x.Password == inputPassword && x.UserTypeID != 1);

                if (entStaff != null)
                {
                    staff.getUserByName(entStaff.Username);
                    this.Hide();
                    Properties.Settings.Default.UserID = this.staff.StaffID;
                    Properties.Settings.Default.UserType = this.staff.UserTypeID;
                    Properties.Settings.Default.Save();
                    new Staff_Form(staff).ShowDialog();
                    this.Close();
                }
                else
                {
                    prompt("The credentials do not match","Invalid Fields");
                    return;
                }
            }
            catch (NullReferenceException err)
            {
                prompt(err.Message,"Error");
            }
        }

        public void prompt(string msg, string title)
        {
            MessageBox.Show(msg, title);
        }

  

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }

        private void textBoxUserName_KeyDown(object sender, KeyEventArgs e)
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

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            login();
        }
    }
}
