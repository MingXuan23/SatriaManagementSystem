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
    
    public partial class User
    {
        public long ID { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public string PhoneNum { get; set; }
        public string Email { get; set; }
        public bool Gender { get; set; }
        public long UserTypeID { get; set; }
        public bool Status { get; set; }
    
        public virtual Staff Staff { get; set; }
        public virtual Student Student { get; set; }
        public virtual UserType UserType { get; set; }
    }
}
