using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    internal class SeznamPojistenych
    {
        private List<PojistenaOsoba> pojisteneOsoby;

        public SeznamPojistenych()
        {
            pojisteneOsoby = new List<PojistenaOsoba>();
        }

        public void PridejPojistence()
        {
            Console.WriteLine("Zadejte jméno pojištěného:");
            string jmeno = KontrolaTextu();
            Console.WriteLine("Zadejte příjmení:");
            string prijmeni = KontrolaTextu();
            Console.WriteLine("Zadejte telefonní číslo:");
            int telefonniCislo = KontrolaCisel();
            Console.WriteLine("Zadejte věk:");
            int vek = KontrolaCisel();
            pojisteneOsoby.Add(new PojistenaOsoba(jmeno, prijmeni, vek, telefonniCislo));
        }

        public void VypisPojistence()
        {
            foreach (PojistenaOsoba pojistenec in pojisteneOsoby)
                Console.WriteLine(pojistenec);
        }

        public void NajdiPojistence()
        {
            Console.WriteLine("Zadejte jméno pojištěného:");
            string jmeno = KontrolaTextu();
            Console.WriteLine("Zadejte příjmení:");
            string prijmeni = KontrolaTextu();
            Console.WriteLine();

            var dotaz = from pojistenec in pojisteneOsoby
                where (jmeno.ToLower() == pojistenec.Jmeno.ToLower())
                && (prijmeni.ToLower() == pojistenec.Prijmeni.ToLower())
                select pojistenec;

            foreach (var pojistenec in dotaz)
                Console.WriteLine(pojistenec);
        }

        public string KontrolaTextu()
        {
            string text = Console.ReadLine().Trim();
            while (text == "")
            {
                Console.WriteLine("Neplatný vstup. Zadejte znovu:");
                text = Console.ReadLine().Trim();
            }
            return text;
        }

        public int KontrolaCisel()
        {
            int cislo;
            bool jeCislo = int.TryParse(Console.ReadLine(), out cislo);
            while (!jeCislo)
            {
                Console.WriteLine("Neplatný vstup. Zadejte znovu:");
                jeCislo = int.TryParse(Console.ReadLine(), out cislo);
            }
            return cislo;
        }
    }
}
