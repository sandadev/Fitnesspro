using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fitnesspro.Repository;

namespace Fitnesspro.DataAccess.Services
{
    class ServiceViewModel
    {
        List<Service> ServicesList { get; set; }
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public int TreatmentType { get; set; }
        public int ServiceGroupId { get; set; }
    }
}
