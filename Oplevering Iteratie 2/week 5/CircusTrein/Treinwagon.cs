using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTrein
{
    class Treinwagon
    {
        List<Dieren> Wagon = new List<Dieren>();

        public Treinwagon()
        {
            Wagon = new List<Dieren>();
        }

        public List<Dieren> DierenAanvullen(List<Dieren> dieren)
        {
            int Punten = 0;
            bool middelgroot = false;
            bool klein = false;
            foreach (Dieren dier in dieren)
            {
                if (dier.Eet == "Vlees" && dier.Punten == 5 && Punten == 0)
                {
                    Wagon.Add(dier);
                    Punten = 10;
                }
                else if ((dier.Eet == "Vlees" && dier.Punten == 3 && middelgroot == false && klein == false) || (dier.Eet == "Planten" && dier.Punten == 5 && Punten <= 5))
                {
                    if (dier.Eet == "Vlees")
                    {
                        middelgroot = true;
                    }
                    Wagon.Add(dier);
                    Punten += dier.Punten;
                }
                else if ((dier.Eet == "Vlees" && dier.Punten == 1 && middelgroot == false && klein == false) || (dier.Eet == "Planten" && dier.Punten >= 3))
                {
                    if (dier.Eet == "Vlees")
                    {
                        klein = true;
                    }
                    Wagon.Add(dier);
                    Punten += dier.Punten;
                }
                if (Punten == 10)
                {
                    Console.WriteLine("");
                }
            }
            return Wagon;
        }
    }
}
