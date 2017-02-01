using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWithIoC.Models
{
    public interface ITrackingService
    {
        int Total { get; set; }
        int Goal { get; set; }
        void AddProtein(int amount);
    }

    public class ProteinTrackingService : ITrackingService
    {
        private IProteinRepository repository;

        public ProteinTrackingService(IProteinRepository repository)
        {
            this.repository = repository;
        }

        public int Total
        {
            get { return repository.GetData(new DateTime().Date).Total; }
            set { repository.SetTotal(new DateTime().Date, value); }
        }

        public int Goal
        {
            get { return repository.GetData(new DateTime().Date).Goal; }
            set { repository.SetGoal(new DateTime().Date, value); }
        }

        public void AddProtein(int amount)
        {
            Total += amount;
        }
    }

    public class ProteinRepository : IProteinRepository
    {
        private static ProteinData data = new ProteinData();
        public int Total { get; set; }
        public int Goal { get; set; }
        public ProteinData GetData(DateTime date)
        {
            return data;
        }

        public void SetTotal(DateTime date, int value)
        {
            Total = Total += value;
        }

        public void SetGoal(DateTime date, int value)
        {
            Goal = value;
        }
    }

    public class ProteinData
    {
        public int Total { get; set; }
        public int Goal { get; set; }
    }
}