using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelReservationSystem.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        //[OutputCache(Duration = 50, Location = System.Web.UI.OutputCacheLocation.Server, VaryByParam = "*")]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}