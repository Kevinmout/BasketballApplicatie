using System;
using System.Collections.Generic;

namespace BesteTijdVoorWetenschappers
{
    class Program
    {
        static void Main(string[] args)
        {
            Sorteren sorteren = new Sorteren();
            sorteren.Wetenschapper.Add(new Wetenschappers { Naam = "Albert Einstein", geboortejaar = 1879, sterftejaar = 1955 });
            sorteren.Wetenschapper.Add(new Wetenschappers { Naam = "Alessandro Volta", geboortejaar = 1745, sterftejaar = 1827 });
            sorteren.Wetenschapper.Add(new Wetenschappers { Naam = "Alexander Fleming", geboortejaar = 1881, sterftejaar = 1955 });
            sorteren.Wetenschapper.Add(new Wetenschappers { Naam = "Alexander Graham Bell", geboortejaar = 1847, sterftejaar = 1922 });
            sorteren.Wetenschapper.Add(new Wetenschappers { Naam = "Alfred Nobel", geboortejaar = 1833, sterftejaar = 1896 });
            sorteren.Wetenschapper.Add(new Wetenschappers { Naam = "Amedeo Avogadro", geboortejaar = 1776, sterftejaar = 1856 });

            sorteren.Wetenschapper.Add(new Wetenschappers { Naam = "André - Marie Ampère", geboortejaar = 1775, sterftejaar = 1836 });
            sorteren.Wetenschapper.Add(new Wetenschappers { Naam = "Antoine Henri Becquerel", geboortejaar = 1852, sterftejaar = 1908 });
            sorteren.Wetenschapper.Add(new Wetenschappers { Naam = "Antoine Lavoisier", geboortejaar = 1743, sterftejaar = 1794 });

            sorteren.Wetenschapper.Add(new Wetenschappers { Naam = "Blaise Pascal", geboortejaar = 1623, sterftejaar = 1662 });
            sorteren.Wetenschapper.Add(new Wetenschappers { Naam = "Carl Friedrich Gauss", geboortejaar = 1777, sterftejaar = 1855 });
            sorteren.Wetenschapper.Add(new Wetenschappers { Naam = "Carl Sagan", geboortejaar = 1934, sterftejaar = 1996 });
            sorteren.Wetenschapper.Add(new Wetenschappers { Naam = "Charles Darwin", geboortejaar = 1809, sterftejaar = 1882 });
            sorteren.Wetenschapper.Add(new Wetenschappers { Naam = "Charles - Augustin de Coulomb", geboortejaar = 1736, sterftejaar = 1806 });
            sorteren.Wetenschapper.Add(new Wetenschappers { Naam = "Edwin Hubble", geboortejaar = 1889, sterftejaar = 1953 });
            sorteren.Wetenschapper.Add(new Wetenschappers { Naam = "Enrico Fermi", geboortejaar = 1901, sterftejaar = 1954 });
            sorteren.Wetenschapper.Add(new Wetenschappers { Naam = "Evangelista Torricelli", geboortejaar = 1608, sterftejaar = 1647 });
            sorteren.Wetenschapper.Add(new Wetenschappers { Naam = "Francis Crick", geboortejaar = 1916, sterftejaar = 2004 });
            sorteren.Wetenschapper.Add(new Wetenschappers { Naam = "Galileo Galilei", geboortejaar = 1564, sterftejaar = 1642 });
            sorteren.Wetenschapper.Add(new Wetenschappers { Naam = "Gottfried Wilhelm Leibniz", geboortejaar = 1646, sterftejaar = 1716 });
            sorteren.Wetenschapper.Add(new Wetenschappers { Naam = "Gregor Mendel", geboortejaar = 1822, sterftejaar = 1884 });
            sorteren.Wetenschapper.Add(new Wetenschappers { Naam = "Guglielmo Marconi", geboortejaar = 1874, sterftejaar = 1937 });
            sorteren.AliveOrDead();
            Console.WriteLine(sorteren.doodOfLevend.ToString());
            /*
            foreach(Wetenschappers item in sorteren.Wetenschapper)
            {
                Console.WriteLine(item.geboortejaar);
            }


            sorteren.Wetenschapper.Add(new Wetenschappers { Naam = "", geboortejaar = , sterftejaar =  });
            sorteren.Wetenschapper.Add(new Wetenschappers { Naam = "", geboortejaar = , sterftejaar =  });
            sorteren.Wetenschapper.Add(new Wetenschappers { Naam = "", geboortejaar = , sterftejaar =  });
            sorteren.Wetenschapper.Add(new Wetenschappers { Naam = "", geboortejaar = , sterftejaar =  });
            sorteren.Wetenschapper.Add(new Wetenschappers { Naam = "", geboortejaar = , sterftejaar =  });
            sorteren.Wetenschapper.Add(new Wetenschappers { Naam = "", geboortejaar = , sterftejaar =  });
            sorteren.Wetenschapper.Add(new Wetenschappers { Naam = "", geboortejaar = , sterftejaar =  });
            sorteren.Wetenschapper.Add(new Wetenschappers { Naam = "", geboortejaar = , sterftejaar =  });
            sorteren.Wetenschapper.Add(new Wetenschappers { Naam = "", geboortejaar = , sterftejaar =  });
            sorteren.Wetenschapper.Add(new Wetenschappers { Naam = "", geboortejaar = , sterftejaar =  });
            sorteren.Wetenschapper.Add(new Wetenschappers { Naam = "", geboortejaar = , sterftejaar =  });

            sorteren.Wetenschapper.Add(new Wetenschappers { Naam = "", geboortejaar = , sterftejaar =  });
            sorteren.Wetenschapper.Add(new Wetenschappers { Naam = "", geboortejaar = , sterftejaar =  });
            sorteren.Wetenschapper.Add(new Wetenschappers { Naam = "", geboortejaar = , sterftejaar =  });

            


            
            
            
            
            
            
            
            
            
            Heinrich Hertz; 1857; 1894
            Isaac Newton; 1642; 1727
            James Clerk Maxwell; 1831; 1879
            James Prescott Joule; 1818; 1889
            Johannes Kepler; 1571; 1630
            John Dalton; 1766; 1844
            John von Neumann; 1903; 1957
            Leonardo da Vinci; 1452; 1519
            Leonhard Euler; 1707; 1783
            Louis Pasteur; 1822; 1895
            Ludwig Boltzmann; 1844; 1906
            Marie Curie; 1867; 1934
            Max Planck; 1858; 1947
            Michael Faraday; 1791; 1867
            Nicolaas Copernicus; 1473; 1543
            Niels Bohr; 1885; 1962
            Nikola Tesla; 1856; 1943
            Paul Dirac; 1902; 1984
            Pierre Curie; 1859; 1906
            René Descartes; 1596; 1650
            Robert Boyle; 1627; 1691
            Subramanyan Chandrasekhar; 1910; 1995
            Wilhelm Röntgen; 1845; 1923
            William Thomson; 1824; 1907
            */
        }
    }
}
