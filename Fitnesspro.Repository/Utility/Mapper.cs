using AutoMapper;
using Fitnesspro.DataAccess.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitnesspro.Repository.Utility
{
  internal static class Mapper
    {
        internal static List<ServiceGroupViewModel> MappingServiceGroup(List<ServiceGroup> lstServiceGroup)
        {
            ServiceGroupViewModel serviceVM = new ServiceGroupViewModel();
            List<ServiceGroupViewModel> lstServiceVM = null;
            if (lstServiceGroup.Count > 0)
            {
                foreach (var group in lstServiceGroup)
                {
                    serviceVM.ServiceGroupId = group.ServiceGroupId;
                    serviceVM.GroupName = group.GroupName;
                    serviceVM.AppointmentColor =(int)group.AppointmentColor;
                    serviceVM.Description = group.Description;
                    serviceVM.EntityId = (int)group.EntityId;
                    lstServiceVM.Add(serviceVM);
                }
            }
            return lstServiceVM;
           
        }
    }
}
