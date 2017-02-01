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
        private IProteinTrackingService _proteinTrackingService;

        public HomeController(IProteinTrackingService _proteinTrackingService)
        {
            this._proteinTrackingService = _proteinTrackingService;
        }


        public ActionResult Index()
        {
            ViewBag.Total = _proteinTrackingService.Total;
            ViewBag.Goal = _proteinTrackingService.Goal;

            return View();
        }

        [HttpGet]
        public ActionResult AddProtein(int amount)
        {
            _proteinTrackingService.AddProtein(amount);

            ViewBag.Total = _proteinTrackingService.Total;
            ViewBag.Goal = _proteinTrackingService.Goal;

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