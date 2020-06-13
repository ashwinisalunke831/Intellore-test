using AutoMapper;
using intellore_system_test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace intellore_system_test.Repository
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Post, PostDto>();
        }
    }
}