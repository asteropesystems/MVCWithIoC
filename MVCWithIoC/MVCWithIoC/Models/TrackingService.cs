using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWithIoC.Models
{
    public class TrackingService
    {
        public int Total { get; set; }

        public int Goal { get; set; }

        public void AddProtein(int amount)
        {
            Total += amount;
        }
    }
}