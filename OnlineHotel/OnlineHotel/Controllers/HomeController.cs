using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineHotel.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListRooms()
        {
            return View();
        }
        public ActionResult Booking()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
	}
}