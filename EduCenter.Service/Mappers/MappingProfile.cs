using AutoMapper;
using EduCenter.Domain.Entities.Students;
using EduCenter.Service.DTOs.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCenter.Service.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<StudentForCreationDto,Student>().ReverseMap();
        }
    }
}
