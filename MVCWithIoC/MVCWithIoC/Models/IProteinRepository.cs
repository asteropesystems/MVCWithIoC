using System;

namespace MVCWithIoC.Models
{
    public interface IProteinRepository
    {
        ProteinData GetData(DateTime date);
        void SetGoal(DateTime date, int value);
        void SetTotal(DateTime date, int value);
    }
}