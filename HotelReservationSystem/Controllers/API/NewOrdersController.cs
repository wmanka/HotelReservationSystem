using HotelReservationSystem.DTOs;
using HotelReservationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HotelReservationSystem.Controllers.API
{

    public class NewOrdersController : ApiController
    {
        ApplicationDbContext _context;

        public NewOrdersController()
        {
            _context = new ApplicationDbContext();
        }

        public IEnumerable<Order> GetOrders()
        {
            return _context.Orders.ToList();
        }

        [HttpPost]
        public IHttpActionResult CreateNewOrder(NewOrderDto newOrder)
        {
            var customer = _context.Customers.Single(c => c.Id == newOrder.CustomerId);

            var hotel = _context.Hotels.Single(c => c.Id == newOrder.HotelId);

            var order = new Order()
            {
                Customer = customer,
                Hotel = hotel,
                DateOrdered = DateTime.Now,
                StartDate = newOrder.StartDate,
                EndDate = newOrder.EndDate,
                NumberOfDays = newOrder.NumberOfDays
            };

            _context.Orders.Add(order);

            _context.SaveChanges();

            return Ok();
        }
    }
}
