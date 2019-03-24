using AutoMapper;
using GI.DTO;
using GI.Service.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GI.Service
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserDTO, User>();
            CreateMap<User, UserDTO>();

        }
    }
}
