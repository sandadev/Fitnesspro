using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Fitnesspro.DataAccess.Services;


namespace Fitnesspro.Repository.Response
{
    class MappingProfile:Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<ServiceGroup, ServiceGroupViewModel>();
            Mapper.CreateMap<ServiceGroupViewModel, ServiceGroup>();
        }
    }
}
