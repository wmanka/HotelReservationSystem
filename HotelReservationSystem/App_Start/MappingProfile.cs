using AutoMapper;
using HotelReservationSystem.DTOs;
using HotelReservationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelReservationSystem.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Hotel, HotelDto>();
            Mapper.CreateMap<HotelDto, Hotel>();

            Mapper.CreateMap<Country, CountryDto>();
        }
    }
}