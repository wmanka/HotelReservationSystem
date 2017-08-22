using HotelReservationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelReservationSystem.ViewModels
{
    public class HotelViewModel
    {
        public Hotel Hotel { get; set; }
        public IEnumerable<Country> Countries { get; set; }
    }
}