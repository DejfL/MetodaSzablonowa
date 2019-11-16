using MetodaSzablonowa_KawaHerbata.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodaSzablonowa_KawaHerbata
{
    class Program
    {
        static void Main(string[] args)
        {
            //Herbata herbata = new Herbata();
            //herbata.RecepturaParzenia();

            Kawa kawa = new Kawa();
            kawa.RecepturaParzenia();
            Console.ReadKey();
        }
    }
}
