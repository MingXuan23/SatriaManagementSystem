//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SatriaManagementSystem__Event_Project_
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public partial class Student :SatriaUser
    {
        SatriaManagementDatabaseEntities ent=new SatriaManagementDatabaseEntities();
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            this.Student_Room = new HashSet<Student_Room>();
        }
    
        public long StudentID { get; set; }
        public string MatircNumber { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student_Room> Student_Room { get; set; }
        public virtual User User { get; set; }

        public override void addUser()
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
        }
    }
}
