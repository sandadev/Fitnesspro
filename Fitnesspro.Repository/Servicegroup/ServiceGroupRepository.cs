using Fitnesspro.DataAccess.Response;
using Fitnesspro.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Fitnesspro.Repository.Servicegroup
{
    public class ServiceGroupRepository:IServiceGroupRepository
    {
        public ValidationResponse CreateServiceGroup(ServiceGroup servicegroup)
        {
            throw new NotImplementedException();
        }

        public List<ServiceGroup> ServiceGroupList()
        {
            List<ServiceGroup> groupList = null;
            using (var context = new FitnessProEntities())
            {
                groupList = context.ServiceGroups.ToList();
                return groupList;
            };
        }

    }
}
