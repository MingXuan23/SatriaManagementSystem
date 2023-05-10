using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatriaManagementSystem__Event_Project_
{
    internal class Staff :User
    {
        public virtual StaffUser StaffUser { get; set; }
        public Nullable<long> BlockID { get; set; }
        public decimal Salary { get; set; }
        public System.DateTime DateStartWork { get; set; }

        public virtual Block Block { get; set; }


        SatriaManagementDatabaseEntities ent =new SatriaManagementDatabaseEntities();
        public Staff()
        {
            this.StaffUser = new StaffUser();
        }

        public Staff(long staffid)
        {
            var user = ent.Users.FirstOrDefault(x=>x.ID==staffid &&(x.UserTypeID==2||x.UserTypeID==3));
            if(user == null)
            {
                throw new Exception("This staff did not exist");
            }
            else
            {
                this.Gender= user.Gender ;
                this.Status = true;
                this.FullName = user.FullName;
                this.Username = user.Username;
                this.Password = user.Password;
                this.UserTypeID = 2;
                this.PhoneNum = user.PhoneNum;
                this.Email = user.Email;
                this.ID = user.ID;
                this.StaffUser = ent.StaffUsers.FirstOrDefault(x => x.StaffID == staffid);
            }
            
        }

        public void AddStaff()
        {
            var user=ent.Users.Create();
            user.ID = ent.Users.Max(x=>x.ID)+1;
            user.Gender = this.Gender;
            user.Status = true;
            user.FullName = this.FullName;
            user.Username = this.Username;
            user.Password = this.Password;
            user.UserTypeID = 2;
            user.PhoneNum = this.PhoneNum;
            user.Email = this.Email;
            ent.Users.Add(user);
            this.StaffUser.ID=ent.StaffUsers.Max(x=>x.ID);
            this.StaffUser.StaffID = user.ID;
            this.StaffUser.SuperAdmin = false;
            ent.StaffUsers.Add(StaffUser);
            ent.SaveChanges();
        }

        public void EditStaff()
        {
            var user = ent.Users.FirstOrDefault(x => x.ID == this.ID && (x.UserTypeID == 2 || x.UserTypeID == 3));
            user.Gender = this.Gender;
            user.Status = this.Status;
            user.FullName = this.FullName;
            user.Password = this.Password;
            user.PhoneNum = this.PhoneNum;
            user.Email = this.Email;
            ent.SaveChanges();
        }
    }
}
