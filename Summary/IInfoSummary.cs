using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.Summary
{
    internal interface IInfoSummary
    {
        int GetTotalVehicle();

        decimal GetTotalIncomeVehicle();

        int GetTotalVehicleByType(string type);

        decimal GetTotalIncomeByType(string type);
    }
}
