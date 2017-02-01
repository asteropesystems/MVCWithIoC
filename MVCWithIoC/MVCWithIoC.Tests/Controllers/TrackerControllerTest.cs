using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVCWithIoC;
using MVCWithIoC.Controllers;

namespace MVCWithIoC.Tests.Controllers
{
    [TestClass]
    public class TrackerControllerTest
    {
        [TestMethod]
        public void NothingHappensGoalZero()
        {
            HomeController controller = new HomeController();

            ViewResult result = controller.Index() as ViewResult;

            Assert.AreEqual(0, result.ViewBag.Total);
            Assert.AreEqual(0, result.ViewBag.Goal);

        }
    }
}
