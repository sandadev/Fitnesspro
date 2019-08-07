//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fitnesspro.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class Staff
    {
        public Staff()
        {
            this.StaffWorkingHours = new HashSet<StaffWorkingHour>();
        }
    
        public int StaffId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<long> MobileNumber { get; set; }
        public string Email { get; set; }
        public Nullable<int> UserPermission { get; set; }
        public Nullable<bool> EnableAppointmentBooking { get; set; }
        public Nullable<int> AppointmentColor { get; set; }
        public string StaffTitle { get; set; }
        public string Notes { get; set; }
        public Nullable<System.DateTime> EmploymentStartDate { get; set; }
        public Nullable<System.DateTime> EmploymentEndDate { get; set; }
        public Nullable<int> EntityId { get; set; }
    
        public virtual EntityType EntityType { get; set; }
        public virtual ICollection<StaffWorkingHour> StaffWorkingHours { get; set; }
    }
}