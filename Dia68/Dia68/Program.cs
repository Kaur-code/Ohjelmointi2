using System;

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
            Console.WriteLine("Tehtävä 6: kertotaulu");

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
                case 6:
                    Kertotaulu();
                    break;
                default:
                    Console.WriteLine("Minkä tehtävän haluat minun tehdä? Anna 1-6 numero.");
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
            goto Alku;
        }
    }
}
