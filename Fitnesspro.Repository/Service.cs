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
    
    public partial class Service
    {
        public Service()
        {
            this.OnlineBookingServices = new HashSet<OnlineBookingService>();
            this.ServicePriceOptions = new HashSet<ServicePriceOption>();
            this.ServiceSettings = new HashSet<ServiceSetting>();
        }
    
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public Nullable<int> TreatmentType { get; set; }
        public Nullable<int> ServiceGroupId { get; set; }
    
        public virtual ICollection<OnlineBookingService> OnlineBookingServices { get; set; }
        public virtual ServiceGroup ServiceGroup { get; set; }
        public virtual ICollection<ServicePriceOption> ServicePriceOptions { get; set; }
        public virtual ICollection<ServiceSetting> ServiceSettings { get; set; }
    }
}