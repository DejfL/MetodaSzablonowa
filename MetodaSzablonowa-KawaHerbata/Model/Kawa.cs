using MetodaSzablonowa_KawaHerbata.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodaSzablonowa_KawaHerbata.Model
{
    public class Kawa : NapojZKofeina
    {
        public override void DomieszanieDodatkow()
        {
            Console.WriteLine("Dodaje cukru");
        }

        public override void Zaparzenie()
        {
            Console.WriteLine("Parze se kawe");
        }

        public override bool CzyKlientChceDodatki()
        {
            return PobierzOdpowiedz();
        }

        private bool PobierzOdpowiedz()
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz dodatki", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult.Yes == dialogResult)
                return true;
            else
                return false;
        }
    }
}
