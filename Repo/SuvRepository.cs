
using JuraganMobil.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.Repo
{
    internal class SuvRepository : ISuvRepository
    {
        private List<Suv> _listSuv;

        public SuvRepository()
        {
            _listSuv = new List<Suv>
            {
                new Suv("D 1001 UM", "SUV", 2010, 350_000_000,4, new DateOnly(2023, 01, 10),500_000,150_000),
                new Suv("D 1002 UM","SUV",2010, 350_000_000,4, new DateOnly(2023, 01, 10),500_000,150_000),
                new Suv("D 1003 UM","SUV",2015, 350_000_000,5, new DateOnly(2023, 01, 12),500_000,150_000),
                new Suv("D 1002 UM","SUV",2010, 350_000_000,5, new DateOnly(2023, 01, 13),500_000,150_000)
            };

        }

        public List<Suv> Create(Suv newSuv)
        {
            _listSuv.Add(newSuv);

            return FindAllSuv();
        }

            public int DeleteSuvByNopol(string noPol)
        {
            var suvNopol = _listSuv.Find(s => s.NoPolice.Equals(noPol));
            if (suvNopol != null)
            {
                _listSuv.Remove(suvNopol);
                return 1;
            }
            return 0;
        }

        public List<Suv> FindAllSuv()
        {
            return _listSuv;
        }

        public Suv FindByNopoll(string noPol)
        {
            var suvNopol = _listSuv.Find(s => s.NoPolice.Equals(noPol));
            if (suvNopol != null)
            {
                return suvNopol;
            }

            return null;
        }
    }
}
