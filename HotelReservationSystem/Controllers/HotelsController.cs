using HotelReservationSystem.Models;
using HotelReservationSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelReservationSystem.Controllers
{
    public class HotelsController : Controller
    {
        private ApplicationDbContext _context;
        public HotelsController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [AllowAnonymous]
        public ActionResult Index()
        {
            if (User.IsInRole(RoleName.CanManageHotels))
                return View("List");

            return View("ReadOnlyList");
        }

        [Authorize(Roles = RoleName.CanManageHotels)]
        public ActionResult New()
        {
            var countries = _context.Countries.ToList();

            var viewModel = new HotelViewModel()
            {
                Hotel = new Hotel(),
                Countries = countries
            };

            return View("Form", viewModel);
        }

        [Authorize(Roles = RoleName.CanManageHotels)]
        public ActionResult Edit(int id)
        {
            var hotel = _context.Hotels.SingleOrDefault(h => h.Id == id);

            if (hotel == null)
                return HttpNotFound();

            var viewModel = new HotelViewModel()
            {
                Hotel = hotel,
                Countries = _context.Countries.ToList()
            };

            return View("Form", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.CanManageHotels)]
        public ActionResult Save(Hotel hotel)
        {
            if(!ModelState.IsValid)
            {
                var viewModel = new HotelViewModel()
                {
                    Hotel = hotel,
                    Countries = _context.Countries.ToList()
                };

                return View("Form", viewModel);
            }

            if (hotel.Id == 0)
                _context.Hotels.Add(hotel);
            else
            {
                var hotelInDb = _context.Hotels.Single(c => c.Id == hotel.Id);
                hotelInDb.Name = hotel.Name;
                hotelInDb.City = hotel.City;
                hotelInDb.CountryId = hotel.CountryId;
                hotelInDb.IsAllInclusive = hotel.IsAllInclusive;
                hotelInDb.PricePerNight = hotel.PricePerNight;
                hotelInDb.Stars = hotel.Stars;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Hotels");
        }
    }
}