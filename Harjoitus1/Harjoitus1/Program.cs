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
            Console.WriteLine("Viides tehtävä");
            Console.WriteLine("KOKONAISLUKU, DOUBLE-LUKU, TAI MERKKIJONO?");
            Console.WriteLine("(kokonaisluku), (double), (merkkijono)");

            string tyyppi = Console.ReadLine();

            if (tyyppi == "kokonaisluku")
            {
                Console.WriteLine("ANNA KOKONAISLUKU!");
                int dang1 = int.Parse(Console.ReadLine());
                Console.WriteLine("ANNOIT KOKONAISLUVUN: {0}", dang1);
            }
            else if(tyyppi == "double")
            {
                Console.WriteLine("ANNA DOUBLE-LUKU!");
                double dang2 = double.Parse(Console.ReadLine());
                Console.WriteLine("ANNOIT DOUBLE-LUVUN: {0}", dang2);
            }
            else if (tyyppi == "merkkijono")
            {
                Console.WriteLine("ANNA MERKKIJONO!");
                string dang3 = Console.ReadLine();
                Console.WriteLine("ANNOIT MERKKIJONON: {0}", dang3);
            }

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
            int yuper = int.Parse(yup);
            string[] vast = new string[3];
            bool eiKym = false;
            bool eiYk = false;
            bool toista = false;
            bool vainSata = false;
            if (yup == "0")
            {
                Console.WriteLine("Nolla");
            }
            else if (yup == "10")
            {
                Console.WriteLine("kymmenen");
            }
            else if (yuper < 1000 && yuper > -1 && yup.Length == 3)
            {
                switch (yup[0])
                {
                    case '0':
                        break;
                    case '1':
                        NumPlus("yksi", vast);
                        vainSata = true;
                        break;
                    case '2':
                        NumPlus("kaksi", vast);
                        break;
                    case '3':
                        NumPlus("kolme", vast);
                        break;
                    case '4':
                        NumPlus("neljä", vast);
                        break;
                    case '5':
                        NumPlus("viisi", vast);
                        break;
                    case '6':
                        NumPlus("kuusi", vast);
                        break;
                    case '7':
                        NumPlus("seitsemän", vast);
                        break;
                    case '8':
                        NumPlus("kahdeksan", vast);
                        break;
                    case '9':
                        NumPlus("yhdeksän", vast);
                        break;
                }
                switch (yup[1])
                {
                    case '0':
                        eiKym = true;
                        break;
                    case '1':
                        NumPlus2("yksi", vast);
                        toista = true;
                        break;
                    case '2':
                        NumPlus2("kaksi", vast);
                        break;
                    case '3':
                        NumPlus2("kolme", vast);
                        break;
                    case '4':
                        NumPlus2("neljä", vast);
                        break;
                    case '5':
                        NumPlus2("viisi", vast);
                        break;
                    case '6':
                        NumPlus2("kuusi", vast);
                        break;
                    case '7':
                        NumPlus2("seitsemän", vast);
                        break;
                    case '8':
                        NumPlus2("kahdeksan", vast);
                        break;
                    case '9':
                        NumPlus2("yhdeksän", vast);
                        break;
                }
                switch (yup[2])
                {
                    case '0':
                        eiYk = true;
                        break;
                    case '1':
                        NumPlus3("yksi", vast);
                        break;
                    case '2':
                        NumPlus3("kaksi", vast);
                        break;
                    case '3':
                        NumPlus3("kolme", vast);
                        break;
                    case '4':
                        NumPlus3("neljä", vast);
                        break;
                    case '5':
                        NumPlus3("viisi", vast);
                        break;
                    case '6':
                        NumPlus3("kuusi", vast);
                        break;
                    case '7':
                        NumPlus3("seitsemän", vast);
                        break;
                    case '8':
                        NumPlus3("kahdeksan", vast);
                        break;
                    case '9':
                        NumPlus3("yhdeksän", vast);
                        break;
                }
                if (vainSata == true)
                {
                    if (eiKym == true)
                    {
                        if (eiYk == true)
                        {
                            Console.WriteLine("sata");
                        }
                        else
                        {
                            Console.WriteLine("sata {0}", vast[2]);
                        }
                    }
                    else
                    {
                        if (toista == true)
                        {
                            if (eiYk == true)
                            {
                                Console.WriteLine("sata kymmenen");
                            }
                            else
                            {
                                Console.WriteLine("sata {0}toista", vast[2]);
                            }
                        }
                        else
                        {
                            if (eiYk)
                            {
                                Console.WriteLine("sata {0}kymmentä", vast[1]);
                            }
                            else
                            {
                                Console.WriteLine("sata {0}kymmentä {1}", vast[1], vast[2]);
                            }
                        }
                    }
                }
                else
                {
                    if (eiKym == true)
                    {
                        if (eiYk == true)
                        {
                            Console.WriteLine("{0}sataa", vast[0]);
                        }
                        else
                        {
                            Console.WriteLine("{0}sataa {1}", vast[0], vast[2]);
                        }
                    }
                    else
                    {
                        if (toista == true)
                        {
                            if (eiYk == true)
                            {
                                Console.WriteLine("{0}sataa kymmenen", vast[0]);
                            }
                            else
                            {
                                Console.WriteLine("{0}sataa {1}toista", vast[0], vast[2]);
                            }
                        }
                        else
                        {
                            if (eiYk)
                            {
                                Console.WriteLine("{0}sataa {1}kymmentä", vast[0], vast[1]);
                            }
                            else
                            {
                                Console.WriteLine("{0}sataa {1}kymmentä {2}", vast[0], vast[1], vast[2]);
                            }
                        }
                    }
                }
            }
            else if (yuper < 1000 && yuper > -1 && yup.Length == 2)
            {
                switch (yup[0])
                {
                    case '1':
                        NumPlus("yksi", vast);
                        toista = true;
                        break;
                    case '2':
                        NumPlus("kaksi", vast);
                        break;
                    case '3':
                        NumPlus("kolme", vast);
                        break;
                    case '4':
                        NumPlus("neljä", vast);
                        break;
                    case '5':
                        NumPlus("viisi", vast);
                        break;
                    case '6':
                        NumPlus("kuusi", vast);
                        break;
                    case '7':
                        NumPlus("seitsemän", vast);
                        break;
                    case '8':
                        NumPlus("kahdeksan", vast);
                        break;
                    case '9':
                        NumPlus("yhdeksän", vast);
                        break;
                }
                switch (yup[1])
                {
                    case '0':
                        eiYk = true;
                        break;
                    case '1':
                        NumPlus2("yksi", vast);
                        break;
                    case '2':
                        NumPlus2("kaksi", vast);
                        break;
                    case '3':
                        NumPlus2("kolme", vast);
                        break;
                    case '4':
                        NumPlus2("neljä", vast);
                        break;
                    case '5':
                        NumPlus2("viisi", vast);
                        break;
                    case '6':
                        NumPlus2("kuusi", vast);
                        break;
                    case '7':
                        NumPlus2("seitsemän", vast);
                        break;
                    case '8':
                        NumPlus2("kahdeksan", vast);
                        break;
                    case '9':
                        NumPlus2("yhdeksän", vast);
                        break;
                }
                if (toista == true)
                {
                    Console.WriteLine("{0}toista", vast[1]);
                }
                else
                {
                    if (eiYk == true)
                    {
                        Console.WriteLine("{0}kymmentä", vast[0]);
                    }
                    else
                    {
                        Console.WriteLine("{0}kymmentä {1}", vast[0], vast[1]);
                    }
                }
            }
            else if (yuper < 1000 && yuper > -1 && yup.Length == 1)
            {
                switch (yup[0])
                {
                    case '1':
                        Console.WriteLine("yksi");
                        break;
                    case '2':
                        Console.WriteLine("kaksi");
                        break;
                    case '3':
                        Console.WriteLine("kolme");
                        break;
                    case '4':
                        Console.WriteLine("neljä");
                        break;
                    case '5':
                        Console.WriteLine("viisi");
                        break;
                    case '6':
                        Console.WriteLine("kuusi");
                        break;
                    case '7':
                        Console.WriteLine("seitsemän");
                        break;
                    case '8':
                        Console.WriteLine("kahdeksan");
                        break;
                    case '9':
                        Console.WriteLine("yhdeksän");
                        break;
                }
            }
            else
            {
                Console.WriteLine("ANNA NUMERO (0-999)");
            }
        }
        public static void NumPlus(string number, string[] arr)
        {
            arr[0] = number;
        }
        public static void NumPlus2(string number, string[] arr)
        {
            arr[1] = number;
        }
        public static void NumPlus3(string number, string[] arr)
        {
            arr[2] = number;
        }
    }
}