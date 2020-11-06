using System;
using System.Collections.Generic;
using System.Text;

namespace ContainerOpdracht_Logic
{
    public class Vrachtschip
    {
        public int Gewicht { get;}
        public int MaxGewicht { get;}
        public int GewichtLinks { get;}
        public int GewichtRechts { get;}

        public Vrachtschip(int gewicht, int maxGewicht, int gewichtLinks, int gewichtRechts)
        {
            Gewicht = gewicht;
            MaxGewicht = maxGewicht;
            GewichtLinks = gewichtLinks;
            GewichtRechts = gewichtRechts;
        }



        public void Sorteer(List<Container> containers)
        {
            ContainerPositie containerStapel = new ContainerPositie();
            foreach (Container container in containers)
            {
                if (container.Waardevol == false)
                {

                }
            }
        }
    }
}
