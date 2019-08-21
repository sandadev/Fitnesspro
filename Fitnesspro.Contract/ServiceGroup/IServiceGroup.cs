using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fitnesspro.DataAccess.Services;
using Fitnesspro;
using Fitnesspro.DataAccess.Response;



namespace Fitnesspro.Contract.ServiceGroup
{
   public interface IServiceGroup
    {

        List<ServiceGroupViewModel> ServiceGroupList();
        ValidationResponse CreateServiceGroup(ServiceGroupViewModel servicegroup);


    }
}
