using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JuraganMobil.Model;
using JuraganMobil.Repo;
using JuraganMobil.Summary;

namespace JuraganMobil.Base
{
    internal interface IRepositoryManager
    {
        public ISuvRepository Suv { get; }

        public IPrivateJetRepository PrivateJet { get; }

        public ITaxiRepository Taxi { get; }

        public IInfoSummary Summary { get; }
    }
}
