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
    
    public partial class Room
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Room()
        {
            this.Student_Room = new HashSet<Student_Room>();
        }
    
        public long ID { get; set; }
        public long BlockID { get; set; }
        public string RoomNo { get; set; }
        public long LevelNum { get; set; }
        public decimal RoomFees { get; set; }
        public long MaxCapacity { get; set; }
    
        public virtual Block Block { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student_Room> Student_Room { get; set; }
    }
}
