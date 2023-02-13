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
    
    int akce;
    while (!int.TryParse(Console.ReadLine(), out akce));
    Console.WriteLine();

    switch (akce)
    {
        case 1:
            seznamPojistenych.PridejPojistence();
            break;
        case 2:
            seznamPojistenych.VypisPojistence();
            break;
        case 3:
            seznamPojistenych.NajdiPojistence();
            break;
        case 4:
            pokracovat = false;
            break;
        default:
            Console.WriteLine("Neplatná akce");
            break;
    }
    Console.WriteLine("\nPokračujte libovolnou klávesou...");
    Console.ReadKey();
}