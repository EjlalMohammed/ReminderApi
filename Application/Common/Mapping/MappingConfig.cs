﻿using Domain.Entity;

namespace Application.Common
{
    public class MappingConfig
    {
        public static IMapper Configure()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, UserDTO>().ReverseMap();


            }).CreateMapper(); 

        }
    }
}
