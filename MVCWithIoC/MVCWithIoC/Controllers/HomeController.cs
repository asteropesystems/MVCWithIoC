using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCWithIoC.Models;

namespace MVCWithIoC.Controllers
{
    public class HomeController : Controller
    {
        private ITrackingService trackingService;

        public HomeController(ITrackingService trackingService)
        {
            this.trackingService = trackingService;
        }


        public ActionResult Index()
        {
            ViewBag.Total = trackingService.Total;
            ViewBag.Goal = trackingService.Goal;

            return View();
        }

        [HttpGet]
        public ActionResult AddProtein(int amount)
        {
            trackingService.AddProtein(amount);

            ViewBag.Total = trackingService.Total;
            ViewBag.Goal = trackingService.Goal;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}