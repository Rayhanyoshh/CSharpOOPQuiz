using System;
using JuraganMobil.Repo;
using JuraganMobil.Base;
using JuraganMobil.Model;

namespace JuraganMobil// Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var repoManager = new RepositoryManager();

            //---------- FIND SUV ALL -----------------
            //var findSuv = repoManager.Suv.FindAllSuv();
            //foreach (var suv in findSuv) ;
            //    Console.WriteLine(suv);

            //------------ FIND SUV BY NOPOL ---------------------------
            //var findSuvID = repoManager.Suv.FindByNopoll("D 1001 UM");
            //Console.WriteLine(findSuvID);

            //-------------- DELETE SUV BY NOPOL -------------------------
            //var deleteSuv = repoManager.Suv.DeleteSuvByNopol("D 1004 UM");
            //Console.WriteLine($" Deleted SUV with NoPol : {deleteSuv}");

            //------------------ CREATE NEW SUV ---------------------------
            //var createSuv = repoManager.Suv.Create(new Suv("BM 1104 RY","SUV",2020,50_000_000,5000_000,4,new DateOnly(2023,01,12),3_000_000,300_000));
            //foreach (var newSuv in createSuv)
            //    Console.WriteLine(newSuv);

            //------------- FIND ALL PRIVATE JET -----------
            //    var findJet = repoManager.PrivateJet.FindAllJet();
            //foreach (var jet in findJet) ;
            //    Console.WriteLine(jet);

            //    var findAllTaxi = repoManager.Taxi.FindAllTaxi();
            //foreach (var taxi in findAllTaxi);
            //    Console.WriteLine(taxi);


            //----- GET TOTAL VEH
            var findSuv = repoManager.Suv.FindAllSuv();
            foreach (var suv in findSuv) ;
            var findJet = repoManager.PrivateJet.FindAllJet();
            foreach (var jet in findJet) ;
            var findAllTaxi = repoManager.Taxi.FindAllTaxi();
            foreach (var taxi in findAllTaxi) ;
            var CountTotalVehicle = repoManager.Summary.GetTotalIncomeVehicle();
            Console.WriteLine(CountTotalVehicle);

        }
    }
}