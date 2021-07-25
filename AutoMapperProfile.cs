using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiRnc.Dtos;
using ApiRnc.Models;
using AutoMapper;

namespace ApiRnc
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Contribuyente, DtoContribuyente>().ReverseMap();
        }
    }
}
