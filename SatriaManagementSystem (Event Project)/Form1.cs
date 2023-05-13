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
    }
}
