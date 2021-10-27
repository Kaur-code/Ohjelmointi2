using System;
using System.Linq;

namespace Harjoitus1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eka tehtävä");
            Console.WriteLine("Anna ensimmäinen luku: ");
            int luku1 = int.Parse(Console.ReadLine());

            Console.Write("Anna toinein luku: ");
            int luku2 = int.Parse(Console.ReadLine());
            if (luku1 > luku2)
            {
                Console.WriteLine("Ensimmäinen luku on isompi");
            }
            else if (luku2 > luku1)
            {
                Console.WriteLine("Toka luku on isompi");
            }
            else
            {
                Console.WriteLine("Luvut ovat samansuuruiset");
            }
            Console.WriteLine();
            Console.WriteLine("Toka tehtävä.");
            Console.Write("Anna ensimmäinen luku: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Anna toka luku: ");
            int y = int.Parse(Console.ReadLine());

            Console.Write("Anna kolmas luku: ");
            int z = int.Parse(Console.ReadLine());

            int[] nums = { x, y, z };

            Console.WriteLine(nums.Max() + " on isoin numero.");

            Console.WriteLine();
            Console.WriteLine("Kolmas tehtävä");

            Console.WriteLine("Anna luku 0-9");
            int luku = int.Parse(Console.ReadLine());

            switch (luku)
            {
                case 0:
                    Console.WriteLine("nolla");
                    break;
                case 1:
                    Console.WriteLine("yksi");
                    break;
                case 2:
                    Console.WriteLine("kaksi");
                    break;
                case 3:
                    Console.WriteLine("kolme");
                    break;
                case 4:
                    Console.WriteLine("neljä");
                    break;
                case 5:
                    Console.WriteLine("viisi");
                    break;
                case 6:
                    Console.WriteLine("kuusi");
                    break;
                case 7:
                    Console.WriteLine("seitsemän");
                    break;
                case 8:
                    Console.WriteLine("kahdeksan");
                    break;
                case 9:
                    Console.WriteLine("yhdeksän");
                    break;
            }
            Console.WriteLine();
            Console.WriteLine("Neljäs tehtävä");
            Console.WriteLine("ANNA VIISI NUMEROA!");

            Console.WriteLine("EKA");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("TOKA");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("KOLMAS");
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("NEJÄS");
            int num4 = int.Parse(Console.ReadLine());

            Console.WriteLine("VIIDES");
            int num5 = int.Parse(Console.ReadLine());

            int[] nums2 = { num1, num2, num3, num4, num5 };

            Console.WriteLine(nums2.Max() + " on isoin numero.");

            Console.WriteLine();
            Console.WriteLine("Kuudes tehtävä");
            Console.WriteLine("Anna luku: ");
            int gaga = int.Parse(Console.ReadLine());

            switch (gaga)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("SAIT 10 PISTETTÄ!");
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("SAIT 100 PISTETTÄ!");
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("SAIT 1000 PISTETTÄ");
                    break;
                default:
                    Console.WriteLine("ANNA NUMERO SUUREMPI KUIN 0 JA PIENEMPI KUIN 10!");
                    break;
            }
            Console.WriteLine();
            Console.WriteLine("Seitsemäs Tehtävä");

            Console.WriteLine("Anna luku (0-999): ");
            string yup = Console.ReadLine();
            char yupas = Convert.ToChar(yup[2]);
            int yuper = int.Parse(yup);
            string[] vast = { };
            if (yup == "0")
            {
                Console.WriteLine("Nolla");
            }
            else if (yup == "10")
            {
                Console.WriteLine(vast[0]);
            }
            else if (yuper < 1000 && yuper > -1)
            {
                switch (yupas)
                {
                    case "0":
                        break;
                    case "1":
                        Array.Resize(ref vast, vast.Length + 1);
                        vast[0] = "yksi";
                        break;
                    case "2":
                        Array.Resize(ref vast, vast.Length + 1);
                        vast[0] = "kaksi";
                        break;
                    case "3":
                        Array.Resize(ref vast, vast.Length + 1);
                        vast[0] = "kolme";
                        break;
                    case "4":
                        Array.Resize(ref vast, vast.Length + 1);
                        vast[0] = "neljä";
                        break;
                    case "5":
                        Array.Resize(ref vast, vast.Length + 1);
                        vast[0] = "viisi";
                        break;
                    case "6":
                        Array.Resize(ref vast, vast.Length + 1);
                        vast[0] = "kuusi";
                        break;
                    case "7":
                        Array.Resize(ref vast, vast.Length + 1);
                        vast[0] = "seitsemän";
                        break;
                    case "8":
                        Array.Resize(ref vast, vast.Length + 1);
                        vast[0] = "kahdeksan";
                        break;
                    case "9":
                        Array.Resize(ref vast, vast.Length + 1);
                        vast[0] = "yhdeksän";
                        break;

                }
            }
        }
    }
}