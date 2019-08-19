using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fitnesspro.Contract.ServiceGroup;
using Fitnesspro.DataAccess.Services;
using Fitnesspro.DataAccess.Response;
using Fitnesspro.Repository.Servicegroup;
using Fitnesspro.Repository;
using Fitnesspro.Repository.Interface;

namespace Fitnesspro.Core.ServiceGBusinessLogivroup
{
   public class ServiceGroupOperations :IServiceGroup
    {
        private IServiceGroupRepository _servicegrouprepo;
        public ServiceGroupOperations(IServiceGroupRepository servicegroup)
        {
            _servicegrouprepo = servicegroup;
        }

        //public ValidationResponse CreateServiceGroup(ServiceGroupViewModel servicegroup)
        //{
        //    throw new NotImplementedException();
        //}

        /// <summary>
        /// Return all the Service group
        /// </summary>
        /// <returns> all Service group</returns>
        /// 

      public List<ServiceGroupViewModel> ServiceGroupList()
        {
            //return _servicegrouprepo.ServiceGroupList();
            throw new NotImplementedException();
        }

      
    }
}
