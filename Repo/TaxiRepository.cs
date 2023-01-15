using JuraganMobil.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.Repo
{
    internal class TaxiRepository : ITaxiRepository
    {
        private List<Taxi> _listTaxi;

        public TaxiRepository()
        {
            _listTaxi = new List<Taxi>
            {
                new Taxi("D 11 K",2002, 175_000_000,4, new DateOnly(2023, 01, 12),45,4500),
                new Taxi("D 12 K",2015, 225_000_000,4, new DateOnly(2023, 01, 13),75,4500),
                new Taxi("D 13 K",2020, 275_000_000,4, new DateOnly(2023, 01, 13),90,4500)
            };
        }

        public List<Taxi> Create(Taxi newSuv)
        {
            throw new NotImplementedException();
        }

        public int DeleteTaxiByNopol(string noPol)
        {
            throw new NotImplementedException();
        }

        public List<Taxi> FindAllTaxi()
        {
            return _listTaxi;
        }

        public Suv FindByNopol(string noPol)
        {
            throw new NotImplementedException();
        }
    }
}
