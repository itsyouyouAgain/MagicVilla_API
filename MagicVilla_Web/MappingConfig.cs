﻿using System;
using AutoMapper;
using MagicVilla_Web.Models.Dto;

namespace MagicVilla_Web
{
	public class MappingConfig : Profile
	{
		public MappingConfig()
		{
			CreateMap<VillaDTO, VillaCreateDTO>().ReverseMap();
            //id or name is same, automapping all of that, return villa
            CreateMap<VillaDTO, VillaUpdateDTO>().ReverseMap();

            CreateMap<VillaNumberDTO, VillaNumberCreateDTO>().ReverseMap();
            CreateMap<VillaNumberDTO, VillaNumberUpdateDTO>().ReverseMap();
        }
	}
}

