using System;

namespace Oliotehtava
{
    class Program
    {
        static void Main(string[] args)
        {
            Kirjasto paavo = new Kirjasto("Paavo", 92, "Lemmi Kauhanen", "kauhu");
            paavo.KirjaInfo(); // tämä metodi antaa perustietoja kirjasta
            paavo.KirjaMerkki(); // tämä metodi asettaa kirjamerkin jollekin kirjan sivulle
            paavo.SivuaViela(); // tämä metodi laskee kuinka paljon sivua on vielä luettavana. Käyttää kirjamerkkiä laskussaan.

            Kirjasto lottovoitto = new Kirjasto("Lottovoitto", 261, "Viisi Sumo", "fantasia");
            lottovoitto.KirjaInfo();
            lottovoitto.KirjaMerkki();
            lottovoitto.SivuaViela();

            Kirjasto captainAlex = new Kirjasto("Who Killed Captain Alex", 1058, "VJ Emmie", "ACTION");
            captainAlex.KirjaInfo();
            captainAlex.KirjaMerkki();
            captainAlex.SivuaViela();
        }
    }
}
