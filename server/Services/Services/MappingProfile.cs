using AutoMapper;
using Common.DTO_s;
using Repository.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {

            CreateMap<Child, ChildDTO>().ReverseMap();
            CreateMap<User, UserDTO>().ReverseMap();
          


        }
    }
}
