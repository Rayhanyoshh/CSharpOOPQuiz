using JuraganMobil.Summary;
using JuraganMobil.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.Base
{
    internal class RepositoryManager : IRepositoryManager
    {
        private ISuvRepository _suvRepository;

        public ISuvRepository Suv
        {
            get
            {
                if (_suvRepository is null)
                    _suvRepository = new SuvRepository();

                return _suvRepository;
            }
        }

        public IPrivateJetRepository _privateJetRepository;

        public IPrivateJetRepository PrivateJet
        {
            get
            {
                if(_privateJetRepository is null)
                    _privateJetRepository = new PrivateJetRepository();
                return (_privateJetRepository);
            }
        }

        public ITaxiRepository _taxiRepository;

        public ITaxiRepository Taxi
        {
            get
            {
                if (_taxiRepository is null)
                    _taxiRepository = new TaxiRepository();
                return (_taxiRepository);
            }
        }

        public IInfoSummary _iinfoSummary;

        public IInfoSummary Summary
        {
            get
            {
                if (_iinfoSummary is null)
                    _iinfoSummary = new InfoSummary();
                return (_iinfoSummary);
            }
        }

    }
}
