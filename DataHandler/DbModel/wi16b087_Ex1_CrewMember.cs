//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataHandler.DbModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class wi16b087_Ex1_CrewMember
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public wi16b087_Ex1_CrewMember()
        {
            this.wi16b087_Ex1_Task = new HashSet<wi16b087_Ex1_Task>();
        }
    
        public System.Guid Id { get; set; }
        public string Name { get; set; }
        public string LicenseNumber { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<wi16b087_Ex1_Task> wi16b087_Ex1_Task { get; set; }
    }
}
