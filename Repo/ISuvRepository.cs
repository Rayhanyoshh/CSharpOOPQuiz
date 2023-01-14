using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JuraganMobil.Model;

namespace JuraganMobil.Repo
{
    internal interface ISuvRepository
    {
        List<Suv> FindAllSuv();
        Suv FindByNopoll(string noPol);
        List<Suv> Create(Suv newSuv);
        int DeleteSuvByNopol(string noPol);
    }
}
