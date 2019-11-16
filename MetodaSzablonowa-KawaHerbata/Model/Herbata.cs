using MetodaSzablonowa_KawaHerbata.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodaSzablonowa_KawaHerbata.Model
{
    public class Herbata : NapojZKofeina
    {
        public override void DomieszanieDodatkow()
        {
            Console.WriteLine("Dodaje cukru i cytryny");
        }

        public override void Zaparzenie()
        {
            Console.WriteLine("Parze se herbate");
        }


    }
}
