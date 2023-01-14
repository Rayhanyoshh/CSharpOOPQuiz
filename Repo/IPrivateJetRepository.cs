using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JuraganMobil.Model;

namespace JuraganMobil.Repo
{
    internal interface IPrivateJetRepository
    {
        List<PrivateJet> FindAllJet();
        Suv FindByNoRegister(string noReg);
        List<PrivateJet> Create(PrivateJet newJet);
        int DeleteJetByNoReg(string noReg);
    }
}
