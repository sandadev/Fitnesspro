using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fitnesspro.Repository;
using Fitnesspro.DataAccess.Response;
using Fitnesspro.DataAccess.Services;

namespace Fitnesspro.Repository.Interface
{
   public interface IServiceGroupRepository
    {
        List<ServiceGroupViewModel> ServiceGroupList();
        ValidationResponse CreateServiceGroup(ServiceGroup servicegroup);
    }
}
