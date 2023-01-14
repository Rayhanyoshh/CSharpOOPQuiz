using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.Model
{
    internal abstract class abstractVehicle
    {
        public abstract string NoPolice { get; set; }
        public abstract int Year { get; set; }
        public abstract decimal Price { get; set; }
        public abstract decimal TaxInYear { get; set; }
        public abstract int Seat { get; set; }
        public abstract DateOnly TransactionDate { get; set; }
        public abstract decimal Total { get; set; }
        
    }
}
