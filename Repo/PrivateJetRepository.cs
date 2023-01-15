using JuraganMobil.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.Repo
{
    internal class PrivateJetRepository : IPrivateJetRepository
    {
        private List<PrivateJet> _listJet;

        public PrivateJetRepository()
        {
            _listJet = new List<PrivateJet>
            {
                new PrivateJet("ID8089",2015,150_000_000_000,12,new DateOnly(2023,02,11),35_000_000,15_000_000),
                new PrivateJet("ID8099",2018,175_000_000_000,15,new DateOnly(2023,02,12),55_000_000,25_000_000)
            };      
        }

        public List<PrivateJet> Create(PrivateJet newJet)
        {
            throw new NotImplementedException();
        }

        public int DeleteJetByNoReg(string noReg)
        {
            throw new NotImplementedException();
        }

        public List<PrivateJet> FindAllJet()
        {
            return _listJet;
        }

        public Suv FindByNoRegister(string noReg)
        {
            throw new NotImplementedException();
        }
    }
}
