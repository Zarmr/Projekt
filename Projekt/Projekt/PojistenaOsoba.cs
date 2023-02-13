using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    internal class PojistenaOsoba
    {
        public string Jmeno { get; private set; }
        public string Prijmeni { get; private set; }
        public int Vek { get; private set; }
        public int TelefonniCislo { get; private set; }

        public PojistenaOsoba(string jmeno, string prijmeni, int vek, int telefonniCislo)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vek = vek;
            TelefonniCislo = telefonniCislo;
        }

        public override string ToString()
        {
            return (Jmeno.PadRight(10) + Prijmeni.PadRight(10) + Vek.ToString().PadRight(10) + TelefonniCislo.ToString().PadRight(10));
        }
    }
}
