using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JuraganMobil.Model;

namespace JuraganMobil.Repo
{
    internal interface ITaxiRepository
    {
        List<Taxi> FindAllTaxi();
        Suv FindByNopol(string noPol);
        List<Taxi> Create(Taxi newSuv);
        int DeleteTaxiByNopol(string noPol);
    }
}
