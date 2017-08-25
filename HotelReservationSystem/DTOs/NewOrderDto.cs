using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelReservationSystem.DTOs
{
    public class NewOrderDto
    {
        [Required]
        public int CustomerId { get; set; }

        [Required]
        public int HotelId { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        public int NumberOfDays { get; set; }
    }
}