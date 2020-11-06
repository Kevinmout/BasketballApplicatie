using System;
using System.Collections.Generic;

namespace CircusTrein
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dieren dieren = new Dieren();
            List<Dieren> lijstdieren = new List<Dieren>();
            lijstdieren.Add(new Dieren() { Naam = "Zebra", Eet = "Planten", Formaat = "Middelgroot", Punten = 3});
            lijstdieren.Add(new Dieren() { Naam = "Leeuw", Eet = "Vlees", Formaat = "Middelgroot", Punten = 3 });
            lijstdieren.Add(new Dieren() { Naam = "Olifant", Eet = "Planten", Formaat = "Groot", Punten = 5 });
            lijstdieren.Add(new Dieren() { Naam = "Muis", Eet = "Planten", Formaat = "Klein", Punten = 1 });

            Treinwagon treinwagon = new Treinwagon();
            List<Dieren> InDeTrein = treinwagon.DierenAanvullen(lijstdieren);
            foreach (Dieren dieren1 in InDeTrein)
            {
                Console.WriteLine(dieren1.Naam + dieren1.Punten);
            }
















            //lijstdieren.Add(new Dieren() { Naam = "Tijger", Eet = "Vlees", Formaat = "Middelgroot" });
            //lijstdieren.Add(new Dieren() { Naam = "Giraffe", Eet = "Planten", Formaat = "Groot" });
            //lijstdieren.Add(new Dieren() { Naam = "Hert", Eet = "Planten", Formaat = "Middelgroot" });
        }
    }
}
