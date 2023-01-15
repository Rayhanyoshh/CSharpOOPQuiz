using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JuraganMobil.Model;

namespace JuraganMobil.Summary
{
    internal class InfoSummary : IInfoSummary
    {
        public decimal GetTotalIncomeVehicle()
        {
            return Suv.GetTotalSuvIncome();
        }

        public int GetTotalVehicle()
        {
            return Suv.CountSuv() + Taxi.CountTaxi() + PrivateJet.CountPrivateJet();
        }
    }
}
