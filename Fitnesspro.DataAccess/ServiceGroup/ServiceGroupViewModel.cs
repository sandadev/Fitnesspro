using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitnesspro.DataAccess.ServiceGroup
{
   public class ServiceGroupViewModel
    {
        public int ServiceGroupId { get; set; }
        public string GroupName { get; set; }
        public Nullable<int> AppointmentColor { get; set; }
        public string Description { get; set; }
        public Nullable<int> EntityId { get; set; }
    }
}
