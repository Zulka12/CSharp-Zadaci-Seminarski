/*Napisati program koji omogućava dodavanje i prikaz termina u stomatološkoj ordinaciji. 
 * Sistem provjerava da li je termin već zauzet.*/
class Program
{
    static void Main(string[] args)
    {
        List<string> termini = new List<string>();
        while (true)
        {
            Console.WriteLine("\n1. Dodaj termin");
            Console.WriteLine("2. Prikaži termine");
            Console.WriteLine("3. Izlaz");
            Console.Write("Izaberite opciju: ");
            int opcija = int.Parse(Console.ReadLine());
            if (opcija == 1)
            {
                Console.Write("Unesite vrijeme termina (HH:mm): ");
                string vrijeme = Console.ReadLine();
                if (termini.Contains(vrijeme))
                {
                    Console.WriteLine("Termin u ovom vremenu je već zauzet!");
                }
                else
                {
                    termini.Add(vrijeme);
                    Console.WriteLine("Termin uspješno dodat!");
                }
            }
            else if (opcija == 2)
            {
                Console.WriteLine(termini.Count > 0 ? "Zakazani termini: " + string.Join(", ", termini) : "Nema zakazanih termina.");
            }
            else if (opcija == 3)
            {
                Console.WriteLine("Hvala Vam što ste koristili aplikaciju!");
                break;
            }
            else
            {
                Console.WriteLine("Nepoznata opcija!");
            }
        }
    }
}