﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitnesspro.DataAccess.Services
{
    public class ServiceGroupViewModel
    {
        public int ServiceGroupId { get; set; }
        public string GroupName { get; set; }
        public int AppointmentColor { get; set; }
        public string Description { get; set; }
        public int EntityId { get; set; }
    }

}
