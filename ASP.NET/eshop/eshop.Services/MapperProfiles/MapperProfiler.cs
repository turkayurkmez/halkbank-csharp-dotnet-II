using AutoMapper;
using eshop.Entities;
using eshop.Services.DataTransferObjects.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.Services.MapperProfiles
{
    public class MapperProfiler : Profile
    {
        public MapperProfiler()
        {
            CreateMap<Product, ProductSummaryResponse>();
        }
    }
}
