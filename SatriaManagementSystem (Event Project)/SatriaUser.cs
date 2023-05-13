using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatriaManagementSystem__Event_Project_
{
    public abstract class SatriaUser : User
    {
        public abstract void getUserByID(long id);
        public abstract void getUserByName(string username);
        public abstract void addUser();

        public abstract void editUser();
        public abstract void deleteUser();

    }

    //for staff
    /*public override void getUserByID(long id)
        {
            var staff = ent.Users.FirstOrDefault(x => x.ID == id && (x.UserTypeID == 2||x.UserTypeID==3));
            if (staff == null)
                throw new NullReferenceException("This staff did not exist");
            else
            {
                //save for parent user
                this.ID = staff.ID;
                this.StaffID = staff.ID;
                this.Username = staff.Username;
                this.FullName = staff.FullName;
                this.Password = staff.Password;
                this.PhoneNum = staff.PhoneNum;
                this.Email = staff.Email;
                this.Gender = staff.Gender;
                this.UserTypeID = staff.UserTypeID;
                this.Status = staff.Status;

                //save for children student
                var staffDetails=ent.Staffs.FirstOrDefault(x=>x.StaffID==staff.ID);
                this.BlockID = staffDetails.BlockID;
                this.Salary=staffDetails.Salary;
                this.SuperAdmin=staffDetails.SuperAdmin;
                this.DateStartWork = staffDetails.DateStartWork;


            }
        }

        public override void getUserByName(string username)
        {
            var staff = ent.Users.FirstOrDefault(x => x.Username == username && (x.UserTypeID == 2 || x.UserTypeID == 3));
            if (staff == null)
                throw new NullReferenceException("This student did not exist");
            else
            {
                //save for parent user
                this.ID = staff.ID;
                this.StaffID = staff.ID;
                this.Username = staff.Username;
                this.Password = staff.Password;
                this.FullName = staff.FullName;
                this.PhoneNum = staff.PhoneNum;
                this.Email = staff.Email;
                this.Gender = staff.Gender;
                this.UserTypeID = staff.UserTypeID;
                this.Status = staff.Status;

                //save for children student
                var staffDetails = ent.Staffs.FirstOrDefault(x => x.StaffID == staff.ID);
                this.BlockID = staffDetails.BlockID;
                this.Salary = staffDetails.Salary;
                this.SuperAdmin = staffDetails.SuperAdmin;
                this.DateStartWork = staffDetails.DateStartWork;


            }
        }

        public override void addUser()
        {
            if (ent.Users.Any(x => x.ID == this.ID) || ent.Staffs.Any(x => x.StaffID == this.StaffID))
            {

                throw new NullReferenceException("This staff adready exist");
            }
            else
            {
                var user = ent.Users.Create();
                var staff = ent.Staffs.Create();

                //save for parent user
                user.ID = ent.Users.Any()?ent.Users.Max(x => x.ID) + 1:1;
                user.Username = this.Username;
                user.FullName = this.FullName;
                user.Password = this.Password;
                user.PhoneNum = this.PhoneNum;
                user.Email = this.Email;
                user.Gender = this.Gender;
                user.UserTypeID = this.UserTypeID;
                user.Status = this.Status;

                //save for children student
                staff.StaffID = user.ID;
                staff.BlockID = this.BlockID;
                staff.Salary = this.Salary;
                staff.SuperAdmin = this.SuperAdmin;
                staff.DateStartWork = this.DateStartWork;

                ent.Users.Add(user);
                ent.Staffs.Add(staff);
                ent.SaveChanges();
            }
        }
        public override void deleteUser()
        {
            if (ent.Users.Any(x => x.ID == this.ID) || ent.Staffs.Any(x => x.StaffID == this.StaffID))
            {
                var user = ent.Users.FirstOrDefault(x => x.ID == this.ID);
                var staff = ent.Staffs.FirstOrDefault(x => x.StaffID == this.StaffID);

                ent.Staffs.Remove(staff);
                ent.Users.Remove(user);
                ent.SaveChanges();
            }
            else
            {
                throw new NullReferenceException("This student did not exist");
            }
        }

        public override void editUser()
        {
            if (ent.Users.Any(x => x.ID == this.ID) || ent.Staffs.Any(x => x.StaffID == this.StaffID))
            {

                var user =ent.Users.FirstOrDefault(x=>x.ID == this.ID);
                var staff =ent.Staffs.FirstOrDefault(x=>x.StaffID==this.StaffID);
              
                user.Username = this.Username;
                user.FullName = this.FullName;
                user.Password = this.Password;
                user.PhoneNum = this.PhoneNum;
                user.Email = this.Email;
                user.Gender = this.Gender;
                user.UserTypeID = this.UserTypeID;
                user.Status = this.Status;

                //save for children student
               if(this.BlockID.HasValue && this.SuperAdmin)
                {
                    staff.BlockID = this.BlockID;
                }
                
                staff.Salary = this.Salary;
                staff.SuperAdmin = this.SuperAdmin;
                staff.DateStartWork = this.DateStartWork;

    ent.SaveChanges();
                

            }
            else
{
    throw new NullReferenceException("This student did not exist");
}
        }*/

    //for student
    /* public override void addUser()
        {
            if (ent.Users.Any(x => x.ID == this.ID) || ent.Students.Any(x => x.StudentID == this.StudentID))
            {

                throw new NullReferenceException("This student adready exist");
            }
            else
            {
                var user = ent.Users.Create();
                var student = ent.Students.Create();

                //save for parent user
                user.ID = ent.Users.Any() ? ent.Users.Max(x => x.ID) + 1 : 1;
                user.Username = this.Username;
                user.FullName = this.FullName;
                user.Password = this.Password;
                user.PhoneNum = this.PhoneNum;
                user.Email = this.Email;
                user.Gender = this.Gender;
                user.UserTypeID = this.UserTypeID;
                user.Status = this.Status;

                //save for children student
                student.MatircNumber = this.MatircNumber;

                ent.Users.Add(user);
                ent.Students.Add(student);
                ent.SaveChanges();
            }
        }

        public override void deleteUser()
        {
            if (ent.Users.Any(x => x.ID == this.ID) || ent.Students.Any(x => x.StudentID == this.StudentID))
            {
                var user = ent.Users.FirstOrDefault(x => x.ID == this.ID);
                var student = ent.Students.FirstOrDefault(x => x.StudentID == this.StudentID);

                ent.Students.Remove(student);
                ent.Users.Remove(user);
                ent.SaveChanges();
            }
            else
            {
                throw new NullReferenceException("This student did not exist");
            }
        }

        public override void editUser()
        {
            if (ent.Users.Any(x => x.ID == this.ID) || ent.Students.Any(x => x.StudentID == this.StudentID))
            {

                var user = ent.Users.FirstOrDefault(x => x.ID == this.ID);
                var student = ent.Students.FirstOrDefault(x => x.StudentID == this.StudentID);

                user.Username = this.Username;
                user.FullName = this.FullName;
                user.Password = this.Password;
                user.PhoneNum = this.PhoneNum;
                user.Email = this.Email;
                user.Gender = this.Gender;
                user.UserTypeID = this.UserTypeID;
                user.Status = this.Status;



                student.MatircNumber = this.MatircNumber;

                ent.SaveChanges();


            }
            else
            {
                throw new NullReferenceException("This student did not exist");
            }
        }

        public override void getUserByID(long id)
        {
            var student = ent.Users.FirstOrDefault(x => x.ID == id &&x.UserTypeID ==  1);
            if (student == null)
                throw new NullReferenceException("This student did not exist");
            else
            {
                //save for parent user
                this.ID = student.ID;
                this.StudentID = student.ID;
                this.Username = student.Username;
                this.FullName=student.FullName;
                this.Password = student.Password;
                this.PhoneNum = student.PhoneNum;
                this.Email = student.Email;
                this.Gender = student.Gender;
                this.UserTypeID = student.UserTypeID;
                this.Status = student.Status;

                //save for children student
                this.MatircNumber = student.Student.MatircNumber;


            }
        }

        public override void getUserByName(string username)
        {
            var student = ent.Users.FirstOrDefault(x => x.Username == username && x.UserTypeID == 1);
            if (student == null)
                throw new NullReferenceException("This student did not exist");
            else
            {
                //save for parent user
                this.ID = student.ID;
                this.StudentID = student.ID;
                this.Username = student.Username;
                this.FullName = student.FullName;
                this.Password = student.Password;
                this.PhoneNum = student.PhoneNum;
                this.Email = student.Email;
                this.Gender = student.Gender;
                this.UserTypeID = student.UserTypeID;
                this.Status = student.Status;

                //save for children student
                this.MatircNumber = student.Student.MatircNumber;


            }
        }*/


}
