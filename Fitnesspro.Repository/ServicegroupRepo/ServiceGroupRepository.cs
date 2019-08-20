using AutoMapper;
using Fitnesspro.DataAccess.Response;
using Fitnesspro.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Fitnesspro.DataAccess.Services;


namespace Fitnesspro.Repository.Servicegroup
{
    public class ServiceGroupRepository:IServiceGroupRepository
    {
        public ServiceGroupRepository()
        {
           
            Mapper.CreateMap<ServiceGroupViewModel, ServiceGroup>();
        }
     //MapperConfiguration config = new MapperConfiguration(cfg =>
     //   {
     //       cfg.CreateMap<ServiceGroup, ServiceGroupViewModel>();
     //   });
     //   MapperConfiguration revMapConfig = new MapperConfiguration(cfg =>
     //   {
     //       cfg.CreateMap<ServiceGroupViewModel, ServiceGroup>();
     //   });
        public ValidationResponse CreateServiceGroup(ServiceGroup servicegroup)
        {
            throw new NotImplementedException();
        }

        public List<ServiceGroupViewModel> ServiceGroupList()
        {
            List<ServiceGroup> groupList = null;
            using (var context = new FitnessProEntities())
            {
                groupList = context.ServiceGroups.ToList();
            //.Select(Mapper.Map(ServiceGroup,ServiceGroupViewModel));

                List<ServiceGroupViewModel> mUsers = Mapper.CreateMap<List<ServiceGroup>, List<ServiceGroupViewModel>>(groupList);
                return mUsers;
            };
        }

    }
}
