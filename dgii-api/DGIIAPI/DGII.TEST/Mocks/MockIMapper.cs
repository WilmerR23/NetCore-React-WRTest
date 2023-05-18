using AutoMapper;
using DGII.API.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGII.TEST.Mocks
{
    public class MockIMapper
    {
        public static IMapper GetMapper()
        {   // Mock automapper para crear los fake mapppings
            var mappingProfile = new DGIIProfile();
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile(mappingProfile));
            return new Mapper(configuration);
        }
    }
}
