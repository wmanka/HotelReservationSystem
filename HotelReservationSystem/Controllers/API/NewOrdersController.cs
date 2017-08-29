using HotelReservationSystem.DTOs;
using HotelReservationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;

namespace HotelReservationSystem.Controllers.API
{

    public class NewOrdersController : ApiController
    {
        ApplicationDbContext _context;

        public NewOrdersController()
        {
            _context = new ApplicationDbContext();
        }

        [Authorize(Roles = RoleName.CanManageHotels)]
        public IEnumerable<Order> GetOrders()
        {
            return _context.Orders.Include(c => c.Customer).Include(c => c.Hotel).ToList();
        }

        [Authorize(Roles = RoleName.CanManageHotels)]
        public Order GetOrder(int id)
        {
            return _context.Orders.Single(c => c.Id == id);
        }

        [HttpPost]
        [Authorize(Roles = RoleName.CanManageHotels)]
        public IHttpActionResult CreateNewOrder(NewOrderDto newOrder)
        {
            var customer = _context.Customers.Single(c => c.Id == newOrder.CustomerId);

            var hotel = _context.Hotels.Single(c => c.Id == newOrder.HotelId);

            var numOfDays = Convert.ToInt32((newOrder.EndDate - newOrder.StartDate).TotalDays);

            var fullPrice = Math.Round((hotel.PricePerNight * numOfDays), 2);

            var order = new Order()
            {
                Customer = customer,
                Hotel = hotel,
                DateOrdered = DateTime.Now,
                StartDate = newOrder.StartDate,
                EndDate = newOrder.EndDate,
                NumberOfDays = numOfDays,
                FullPrice = fullPrice
            };

            _context.Orders.Add(order);

            _context.SaveChanges();

            return Ok();
        }

        [HttpPut]
        [Authorize(Roles = RoleName.CanManageHotels)]
        public void UpdateOrder(int id, Order order)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var orderInDb = _context.Orders.SingleOrDefault(c => c.Id == id);

            if (orderInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            orderInDb.Customer = order.Customer;
            orderInDb.Hotel = order.Hotel;
            orderInDb.DateOrdered = order.DateOrdered;
            orderInDb.StartDate = order.StartDate;
            orderInDb.EndDate = order.EndDate;
            orderInDb.FullPrice = order.FullPrice;
            orderInDb.NumberOfDays = order.NumberOfDays;

            _context.SaveChanges();
        }



        [HttpDelete]
        [Authorize(Roles = RoleName.CanManageHotels)]
        public void DeleteOrder(int id)
        {
            var order = _context.Orders.SingleOrDefault(c => c.Id == id);

            if (order == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Orders.Remove(order);
            _context.SaveChanges();
        }
    }
}
