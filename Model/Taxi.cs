using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.Model
{
    internal class Taxi : abstractVehicle
    {
        private string _noPolice;
        private int _year;
        private decimal _price;
        private decimal _taxInYear;
        private int _seat;
        private DateOnly _transactionDate;
        private int _order;
        private decimal _orderPerKM;
        private decimal _total;
        private static int _count;
        static decimal _totalIncome;

        public Taxi(string noPolice, int year, decimal price, int seat, DateOnly transactionDate, int order, decimal orderPerKM)
        {
            _noPolice = noPolice;
            _year = year;
            _price = price;
            _taxInYear = _price * 10 / 100;
            _seat = seat;
            _transactionDate = transactionDate;
            _order = order;
            _orderPerKM = orderPerKM;
            _total = _order * _orderPerKM;
            _totalIncome += _total;
            _count++;
        }

        public override string NoPolice { get => _noPolice; set => _noPolice = value; }
        public override int Year { get => _year; set => _year = value; }
        public override decimal Price { get => _price; set => _price = value; }
        public override decimal TaxInYear { get => _taxInYear; set => _taxInYear = value; }
        public override int Seat { get => _seat; set => _seat = value; }
        public override DateOnly TransactionDate { get => _transactionDate; set => _transactionDate = value; }
        public override decimal Total { get => _total; set => _total = value; }
        public int Order { get => _order; set => _order = value; }
        public decimal OrderPerKM { get => _orderPerKM; set => _orderPerKM = value; }


        public static int CountTaxi()
        {
            return _count;
        }

        public static decimal TotalIncomeTaxi()
        {
            return _totalIncome;
        }


        public override string ToString()
        {
            return
$"No Police         : {NoPolice}\n" +
$"Vehicle Type      : Taxi\n" +
$"Year              : {Year}\n" +
$"Price             : Rp.{Price}\n" +
$"Tax(In Year)      : Rp.{_taxInYear}\n" +
$"Seat              : {Seat}\n" +
$"Transaction Date  : {TransactionDate}\n" +
$"Order Distance    : {Order}Km\n" +
$"Order Per KM      : Rp.{OrderPerKM}\n" +
$"Total             : Rp.{Total}\n";
        }

    }
}
