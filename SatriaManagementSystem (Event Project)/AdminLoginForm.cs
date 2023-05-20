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
    public partial class AdminLoginForm : Form
    {
        Staff staff = new Staff();
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textBoxUserName.Text = string.Empty;
            textBoxPassword.Text = string.Empty;
            staff = new Staff();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string inputUserName = textBoxUserName.Text;
            string inputPassword = textBoxPassword.Text;
            if (inputUserName == string.Empty || inputPassword == string.Empty)
            {
                MessageBox.Show("Please don't leave username or password empty", "Empty Fields");
                return;
            }
            try
            {
                staff.getUserByName(inputUserName);
                if(inputPassword != staff.Password)
                {
                    MessageBox.Show("Invalid password!");
                    textBoxPassword.Focus();
                    return;
                }
                else
                {
                    this.Hide();
                    MessageBox.Show("Admin Log In!!!");
                    this.Show();
                }
            }
            catch(NullReferenceException err)
            {
                MessageBox.Show(err.Message);
            }
            
        }
    }
}
