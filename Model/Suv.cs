﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.Model { 
    internal class Suv : abstractVehicle
    {
        private string _noPolice;
        private string _typeVehicle = "SUV";
        private int _year;
        private decimal _price;
        private decimal _taxInYear;
        private int _seat;
        private DateOnly _transactionDate;
        private decimal _rent;
        private decimal _driver;
        private decimal _total;
        private static int _count;
        static decimal _totalIncome;


        public Suv(string noPolice, string TypeVehicle ,int year, decimal price,int seat, DateOnly transactionDate, decimal rent, decimal driver)
        {
            _noPolice = noPolice;
            _typeVehicle = TypeVehicle;
            _year = year;
            _price = price;
            _taxInYear = _price * 10 / 100;
            _seat = seat;
            _transactionDate = transactionDate;
            _rent = rent;
            _driver = driver;
            _total = _rent + _driver;
            _totalIncome += _total;
            _count++;
        }

        public override string NoPolice { get => _noPolice; set => _noPolice = value; }
        public override int Year { get => _year; set => _year = value; }
        public override decimal Price { get => _price; set => _price = value ; }
        public override decimal TaxInYear { get => _taxInYear; set => _taxInYear = value; }
        public override int Seat { get =>_seat; set => _seat = value; }
        public override DateOnly TransactionDate { get => _transactionDate; set => _transactionDate = value; }
        public override decimal Total { get => _total; set => _total = value; }
        public decimal Rent { get => _rent; set => _rent = value; }
        public decimal Driver { get => _driver; set => _driver = value; } 


        public static int CountSuv()
        {
            return _count;
        }

        public static decimal GetTotalSuvIncome()
        {
            return _totalIncome;
        }

        public override string ToString()
        {
            return $"No Police         : {NoPolice}\n" +
                   $"Vehicle Type      : SUV\n" +
                   $"Year              : {Year}\n" +
                   $"Price             : Rp.{Price}\n" +
                   $"Tax(In Year)      : Rp.{_taxInYear}\n" +
                   $"Seat              : {Seat}\n" +
                   $"Transaction Date  : {TransactionDate}\n" +
                   $"Rent              : Rp.{Rent}\n" +
                   $"Driver            : Rp.{Driver}\n" +
                   $"Total             : Rp.{Total}\n";
        }

    }
}
