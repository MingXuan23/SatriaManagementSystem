using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatriaManagementSystem__Event_Project_
{
    internal class Student :User
    {
        public virtual StudentUser StudentUser { get; set; }
        public string MatircNumber { get; set; }

        SatriaManagementDatabaseEntities ent =new SatriaManagementDatabaseEntities();

        public Student()
        {
            this.StudentUser = new StudentUser();
        }

        public Student(long studentId)
        {
            var user = ent.Users.FirstOrDefault(x => x.ID == studentId && x.UserTypeID == 1);
            if (user == null)
            {
                throw new Exception("This staff did not exist");
            }
            else
            {
                this.Gender = user.Gender;
                this.Status = true;
                this.FullName = user.FullName;
                this.Username = user.Username;
                this.Password = user.Password;
                this.UserTypeID = 2;
                this.PhoneNum = user.PhoneNum;
                this.Email = user.Email;
                this.ID=user.ID;
                this.StudentUser = ent.StudentUsers.FirstOrDefault(x => x.StudentID == this.ID);
            }
        }
    }
}
