using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fitnesspro.Contract.ServiceGroup;
using Fitnesspro.DataAccess.ServiceGroup;



namespace Fitnesspro.Core.BusinessLogiv.ServiceGroup
{
   public class ServiceGroupOperations :IServiceGroup
    {
        private IServiceGroup _servicegroup;
        public ServiceGroupOperations(IServiceGroup servicegroup)
        {
            _servicegroup = servicegroup;
        }

         /// <summary>
        /// Return all the Service group
        /// </summary>
        /// <returns> all Service group</returns>
        /// 
        //public List<ServiceGroupViewModel> ServiceGroupList()
        //{
        //    return List<ServiceGroupViewModel>();
        //}
    }
}
