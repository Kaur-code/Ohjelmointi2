using System;
using System.Linq;

namespace Dia68
{
    class Program
    {
        static void Main(string[] args)
        {
            Alku:
            Console.WriteLine();
            Console.WriteLine("Tehtävä 1: yhteenlasku.");
            Console.WriteLine("Tehtävä 2: fahreinheit.");
            Console.WriteLine("Tehtävä 3: peruslaskut.");
            Console.WriteLine("Tehtävä 4: jakojäännös");
            Console.WriteLine("Tehtävä 5: hello!");
            Console.WriteLine("Tehtävä 10: kertotaulu");
            Console.WriteLine("Tehtävä 11: ikäsi");
            Console.WriteLine("Tehtävä 12: lukuloop");
            Console.WriteLine("Tehtävä 13: nimen vaihto");
            Console.WriteLine("Tehtävä 14: positiivinen vai negatiivinen?");
            Console.WriteLine("Tehtävä 15: Pisin sana");

            int teht = int.Parse(Console.ReadLine());
            switch (teht)
            {
                case 1:
                    Yhteenlasku();
                    break;
                case 2:
                    Fahrenheit();
                    break;
                case 3:
                    PerusLaskut();
                    break;
                case 4:
                    Jakojaannos();
                    break;
                case 5:
                    Hello();
                    break;
                case 10:
                    Kertotaulu();
                    break;
                case 11:
                    Ika();
                    break;
                case 12:
                    LukuLoop();
                    break;
                case 13:
                    NimenVaihto();
                    break;
                case 14:
                    PosVaiNeg();
                    break;
                case 15:
                    PisinSana();
                    break;
                default:
                    Console.WriteLine("Minkä tehtävän haluat minun tehdä? Anna tehtävän numero.");
                    goto Alku;
            }

            static void Yhteenlasku()
            {
                Console.WriteLine("ANNA ENSIMMÄINEN LUKU:");
                double luku1 = double.Parse(Console.ReadLine());
                Console.WriteLine("ANNA TOKA LUKU:");
                double luku2 = double.Parse(Console.ReadLine());
                Console.WriteLine(luku1 + luku2);
            }

            static void Fahrenheit()
            {
                Console.WriteLine("Muuta celsius asteet fahrenheitiksi!");
                Console.WriteLine("Anna celsius aste:");
                double aste = double.Parse(Console.ReadLine());
                double asteFah = aste * 1.8 + 32;
                Console.WriteLine("Celsius: {0}, Fahrenheit: {1}", aste, asteFah);
            }

            static void PerusLaskut()
            {
                Console.WriteLine("ANNA ENSIMMÄINEN LUKU!");
                double luku1 = double.Parse(Console.ReadLine());
                Console.WriteLine("ANNA TOKA LUKU!");
                double luku2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Yhteenlasku: {0}", luku1 + luku2);
                Console.WriteLine("Miinuslasku: {0}", luku1 - luku2);
                Console.WriteLine("Jakolasku: {0}", luku1 / luku2);
                Console.WriteLine("Kertolasku: {0}", luku1 * luku2);
            }

            static void Jakojaannos()
            {
                Console.WriteLine("ANNA ENSIMMÄINEN LUKU!");
                double luku1 = double.Parse(Console.ReadLine());
                Console.WriteLine("ANNA TOKA LUKU!");
                double luku2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Jakojäännös: {0}", luku1 % luku2);
            }

            static void Hello()
            {
                string nimi = Console.ReadLine();
                Console.WriteLine("Hei, {0}!!!!!!!!!!!!!!!", nimi);
            }

            static void Kertotaulu()
            {
                Console.WriteLine("Anna kokonaisluku (1-10), ja kerron sen kertotaulun: ");
                int num = int.Parse(Console.ReadLine());

                for(int i = 1; i < 11; i++)
                {
                    Console.WriteLine("{0} x {1} = {2}", num, i, num * i);
                }
            }

            static void Ika()
            {
                Console.WriteLine("Anna ikäsi: ");
                string ika = Console.ReadLine();
                Console.WriteLine("{0} vuotta vanha? Näytät ikäistäsi vanhemmalta.", ika);
            }

            static void LukuLoop()
            {
                Console.WriteLine("Anna lukulooppisi: ");
                int luku = int.Parse(Console.ReadLine());

                for(int i = 0; i < luku; i++)
                {
                    Console.Write(luku);
                }
            }

            static void NimenVaihto()
            {
                Console.WriteLine("Anna nimesi, jotta voin korjata sen: ");
                string nimi = Console.ReadLine();
                string pap = "";
                pap += nimi[nimi.Length - 1];
                pap += nimi.Substring(1, nimi.Length - 2);
                pap += nimi[0];
                Console.WriteLine("Uusi nimesi on: {0}",pap);
            }

            static void PosVaiNeg()
            {
                Console.WriteLine("ANNA ENSIMMÄINEN LUKU!");
                int luku1 = int.Parse(Console.ReadLine());
                Console.WriteLine("ANNA TOKA LUKU!");
                int luku2 = int.Parse(Console.ReadLine());

                if (luku1 > -1)
                {
                    if (luku2 > -1)
                    {
                        Console.WriteLine("Molemmat numerot ovat positiivisia.");
                    }
                    else
                    {
                        Console.WriteLine("Toinen on positiivinen ja toinen on negatiivinen.");
                    }
                }
                else
                {
                    if(luku2 < 0)
                    {
                        Console.WriteLine("Molemmat ovat negatiivisia numeroita.");
                    }
                    else
                    {
                        Console.WriteLine("Toinen on positiivinen ja toinen on negatiivinen.");
                    }
                }
            }

            static void PisinSana()
            {
                Console.WriteLine("Kirjoita lause, ja löydän pisimmän sanan: ");
                string sana = Console.ReadLine();
                string[] sanat = sana.Split(' ');
                int[] wow = new int[sanat.Length];

                for (int i = 0; i < sanat.Length; i++)
                {
                    int pls = sanat[i].Length;
                    wow[i] = pls;
                }
            }
            goto Alku;
        }
    }
}
