﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Pizzaria.Application.AutoMapper
{
    public class AutoMapperConfig 
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x => { x.AddProfile(new DomainToViewModelAutoMappingProfile()); });
        }
    }
}
