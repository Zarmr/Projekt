using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    internal class SeznamPojistenych
    {
        public List<PojistenaOsoba> pojisteneOsoby { get; private set; }
        private KontrolaVstupu kontrolaVstupu;

        public SeznamPojistenych()
        {
            pojisteneOsoby = new List<PojistenaOsoba>();
            kontrolaVstupu = new KontrolaVstupu();
        }

        public void PridejPojistence()
        {
            Console.WriteLine("Zadejte jméno pojištěného:");
            string jmeno = kontrolaVstupu.KontrolaTextu();
            Console.WriteLine("Zadejte příjmení:");
            string prijmeni = kontrolaVstupu.KontrolaTextu();
            Console.WriteLine("Zadejte telefonní číslo:");
            int telefonniCislo = kontrolaVstupu.KontrolaCisel();
            Console.WriteLine("Zadejte věk:");
            int vek = kontrolaVstupu.KontrolaCisel();
            pojisteneOsoby.Add(new PojistenaOsoba(jmeno, prijmeni, vek, telefonniCislo));
        }

        public List<PojistenaOsoba> NajdiPojistence()
        {
            Console.WriteLine("Zadejte jméno pojištěného:");
            string jmeno = kontrolaVstupu.KontrolaTextu();
            Console.WriteLine("Zadejte příjmení:");
            string prijmeni = kontrolaVstupu.KontrolaTextu();
            Console.WriteLine();

            var dotaz = from pojistenec in pojisteneOsoby
                where (jmeno.ToLower() == pojistenec.Jmeno.ToLower())
                && (prijmeni.ToLower() == pojistenec.Prijmeni.ToLower())
                select pojistenec;

            List<PojistenaOsoba> nalezenePojisteneOsoby = dotaz.ToList<PojistenaOsoba>();
            return nalezenePojisteneOsoby;
        } 
    }
}
