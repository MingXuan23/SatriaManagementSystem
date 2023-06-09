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

    public partial class Staff:SatriaUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Staff()
        {
            this.Staff_Transaction = new HashSet<Staff_Transaction>();
        }
    
        public long StaffID { get; set; }
        public Nullable<long> BlockID { get; set; }
        public decimal Salary { get; set; }
        public bool SuperAdmin { get; set; }
        public System.DateTime DateStartWork { get; set; }
    
        public virtual Block Block { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Staff_Transaction> Staff_Transaction { get; set; }
        public virtual User User { get; set; }

        SatriaManagementDatabaseEntities ent = new SatriaManagementDatabaseEntities();

        public override void getUserByID(long id)
        {
            var staff = ent.Users.FirstOrDefault(x => x.ID == id && (x.UserTypeID == 2 || x.UserTypeID == 3));
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
                var staffDetails = ent.Staffs.FirstOrDefault(x => x.StaffID == staff.ID);
                this.BlockID = staffDetails.BlockID;
                this.Salary = staffDetails.Salary;
                this.SuperAdmin = staffDetails.SuperAdmin;
                this.DateStartWork = staffDetails.DateStartWork;


            }
        }

        public override void getUserByName(string username)
        {
            var staff = ent.Users.FirstOrDefault(x => x.Username == username && (x.UserTypeID == 2 || x.UserTypeID == 3));
            if (staff == null)
                throw new NullReferenceException("This staff did not exist");
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
                staff.StaffID = user.ID;
                staff.BlockID = this.BlockID;
                staff.Salary = this.Salary;
                staff.SuperAdmin = this.SuperAdmin;
                staff.DateStartWork = this.DateStartWork;

                ent.Users.Add(user);
                ent.SaveChanges();
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

                var user = ent.Users.FirstOrDefault(x => x.ID == this.ID);
                var staff = ent.Staffs.FirstOrDefault(x => x.StaffID == this.StaffID);

                user.Username = this.Username;
                user.FullName = this.FullName;
                user.Password = this.Password;
                user.PhoneNum = this.PhoneNum;
                user.Email = this.Email;
                user.Gender = this.Gender;
                user.UserTypeID = this.UserTypeID;
                user.Status = this.Status;

                //save for children student
                if (this.BlockID.HasValue && this.SuperAdmin)
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
        }
    }
}
