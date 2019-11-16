using System;

namespace MetodaSzablonowa_KawaHerbata.Abstract
{
    public abstract class NapojZKofeina
    {
        public void RecepturaParzenia()
        {
            GotowanieWody();
            Zaparzenie();
            NalewanieDoFilizanki();
            if (CzyKlientChceDodatki())
                DomieszanieDodatkow();
        }
        public abstract void Zaparzenie();
        public abstract void DomieszanieDodatkow();
        public void GotowanieWody()
        {
            Console.WriteLine("Gotoje wode");
        }
        
        public void NalewanieDoFilizanki()
        {
            Console.WriteLine("Nalewam do filizanki");
        }

        public virtual bool CzyKlientChceDodatki()
        {
            return true;
        }
    }
}
