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
        public decimal GetTotalIncomeByType(string type)
        {
            return type == "Suv" ? Suv.GetTotalSuvIncome() : type == "Taxi" ? Taxi.TotalIncomeTaxi() : type == "Private Jet" ? PrivateJet.TotalIncomePrivateJet() : 0;
        }

        public decimal GetTotalIncomeVehicle()
        {
            return Suv.GetTotalSuvIncome() + Taxi.TotalIncomeTaxi() + PrivateJet.TotalIncomePrivateJet();
        }

        public int GetTotalVehicle()
        {
            return Suv.CountSuv() + Taxi.CountTaxi() + PrivateJet.CountPrivateJet();
        }

        public int GetTotalVehicleByType(string type)
        {
            return type == "Suv" ? Suv.CountSuv() : type == "Taxi" ? Taxi.CountTaxi() : type == "PrivateJet" ? PrivateJet.CountPrivateJet() : 0;
        }
    }
}
