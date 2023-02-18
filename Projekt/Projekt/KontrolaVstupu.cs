using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    internal class KontrolaVstupu
    {
        public string KontrolaTextu()
        {
            string text;
            while (string.IsNullOrWhiteSpace(text = Console.ReadLine()))
                Console.WriteLine("Neplatný vstup. Zadejte znovu:");
            return text.Trim();
        }

        public int KontrolaCisel()
        {
            int cislo;
            while (!int.TryParse(Console.ReadLine(), out cislo))
                Console.WriteLine("Neplatný vstup. Zadejte znovu:");
            return cislo;
        }
    }
}
