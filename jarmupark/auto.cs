using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jarmupark
{
    class Auto
    {
        private string szin, tipus;
        private double uzemAnyag, fogyaszt, km, megtehetoKm;

        public Auto(string szin, string tipus, double fogyaszt)
        {
            this.szin = szin;
            this.tipus = tipus;
            this.fogyaszt = fogyaszt;
            this.uzemAnyag = 0;
            this.km = 0;
            this.megtehetoKm = 0;

        }

        private void Megteheto()
        {
            megtehetoKm = uzemAnyag / fogyaszt * 100;
        }
        public void Tankol(double mennyit)
        {
            uzemAnyag += mennyit;
            Megteheto();
        }

        public void Megy(double km)
        {
            this.km += km;
            uzemAnyag -= (km * fogyaszt / 100);
            Megteheto();
        }

        public void Allapot()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"{tipus} - {szin}");
            Console.WriteLine($"Km óra: {km} km");
            Console.WriteLine($"Üzemanyag: {uzemAnyag} l");
            Console.WriteLine($"Megtehető km: {megtehetoKm} km");
            Console.WriteLine("-----------------------------------");
        }
    }
}
