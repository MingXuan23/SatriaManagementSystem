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
       SatriaManagementDatabaseEntities ent=new SatriaManagementDatabaseEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var findStaff =ent.StaffUsers.FirstOrDefault(x=>x.SuperAdmin==true);
            var staff = new Staff(findStaff.StaffID);
        }
    }
}
