using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVCWithIoC;
using MVCWithIoC.Controllers;
using MVCWithIoC.Models;

namespace MVCWithIoC.Tests.Controllers
{
    [TestClass]
    public class TrackerControllerTest
    {
        [TestMethod]
        public void NothingHappensGoalZero()
        {
            HomeController controller = new HomeController(new StubTrackingService());

            ViewResult result = controller.Index() as ViewResult;

            Assert.AreEqual(0, result.ViewBag.Total);
            Assert.AreEqual(0, result.ViewBag.Goal);

        }

        [TestMethod]
        public void WhenTotalIsZero_AndAmountAdded_TotalIsIncreased()
        {
            var service = new StubTrackingService();
            service.Total = 10;

            HomeController controller = new HomeController(service);

            ViewResult result = controller.AddProtein(15) as ViewResult;

            Assert.AreEqual(25, result.ViewBag.Total);
            Assert.AreEqual(0, result.ViewBag.Goal);

        }

    }

    public class StubTrackingService : ITrackingService
    {
        public int Total { get; set; }
        public int Goal { get; set; }
        public void AddProtein(int amount)
        {
            Total += amount;
        }
    }
}
