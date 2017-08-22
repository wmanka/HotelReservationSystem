using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelReservationSystem.Models
{
    public class Hotel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Country Country { get; set; }

        public int CountryId { get; set; }

        public string City { get; set; }

        public int Stars { get; set; }

        public double PricePerNight { get; set; }

        public bool IsAllInclusive { get; set; }
    }
}