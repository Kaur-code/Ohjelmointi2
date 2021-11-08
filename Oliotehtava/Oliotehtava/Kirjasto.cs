using System;
using System.Collections.Generic;
using System.Text;

namespace Oliotehtava
{
    class Kirjasto
    {
        string kirja;
        int sivut;
        string kirjailia;
        string genre2;
        int kirjamerkkini;
        public Kirjasto(string kirjaNimi, int sivuMaara, string author, string genre)
        {
            kirja = kirjaNimi;
            sivut = sivuMaara;
            kirjailia = author;
            genre2 = genre;
        }

        public void KirjaMerkki()
        {
            Console.WriteLine("Laitat kirjamerkkisi sivuun: ");
            Alku:
            kirjamerkkini = int.Parse(Console.ReadLine());

            if(kirjamerkkini > sivut || kirjamerkkini < 1)
            {
                Console.WriteLine("Kirjassasi ei ole riittävästi sivuja kirjanmerkin sijaintiin.");
                Console.WriteLine("Yritä uudelleen.");
                goto Alku;
            }
            else
            {
                Console.WriteLine("Kirjamerkki asetettu sivulle {0}", kirjamerkkini);
            }
        }

        public void SivuaViela()
        {
            Console.WriteLine("Sinulla on {0} sivua jäljellä luettavana kirjasta '{1}'.", sivut - kirjamerkkini, kirja);
        }

        public void KirjaInfo()
        {
            Console.WriteLine("Kirjan nimi on '{0}'. Sen kirjailia: '{1}'. Kirjan genre on {2}. Kirjan sivumäärä: {3}", kirja, kirjailia, genre2, sivut);
        }
    }
}
