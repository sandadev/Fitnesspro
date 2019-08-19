using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fitnesspro.Repository;
using Fitnesspro.DataAccess.Response;


namespace Fitnesspro.Repository.Interface
{
   public interface IServiceGroupRepository
    {
        List<servicegropv> ServiceGroupList();
        ValidationResponse CreateServiceGroup(ServiceGroup servicegroup);
    }
}
