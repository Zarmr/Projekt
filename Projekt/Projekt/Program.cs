using Projekt;

SeznamPojistenych seznamPojistenych = new SeznamPojistenych();
bool pokracovat = true;

while (pokracovat)
{
    Console.Clear();
    Console.WriteLine("-----------------------------\nEvidence pojištěných\n-----------------------------\n");
    Console.WriteLine("Vyberte si akci:");
    Console.WriteLine("1 - Přidat nového pojišteného");
    Console.WriteLine("2 - Vypsat všechny pojištené");
    Console.WriteLine("3 - Vyhledat pojištěného");
    Console.WriteLine("4 - Konec");
    
    string akce = Console.ReadLine();
    Console.WriteLine();

    switch (akce)
    {
        case "1":
            seznamPojistenych.PridejPojistence();
            break;
        case "2":
            foreach (PojistenaOsoba pojistenec in seznamPojistenych.pojisteneOsoby)
                Console.WriteLine(pojistenec);
            break;
        case "3":
            foreach (PojistenaOsoba pojistenec in seznamPojistenych.NajdiPojistence())
                Console.WriteLine(pojistenec);
            break;
        case "4":
            pokracovat = false;
            break;
        default:
            Console.WriteLine("Neplatná akce");
            break;
    }
    Console.WriteLine("\nPokračujte libovolnou klávesou...");
    Console.ReadKey();
}