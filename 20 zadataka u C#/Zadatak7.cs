/*Napisati C# program koji od korisnika učitava brojeve iz skupa {-10, ..., -1, 0, 1, ..., 10} i broji koliko se puta svaki od njih pojavio. 
 * Kraj unosa označen je brojem 99 koji se ne računa. */
class Program
{
    static void Main()
    {
        Console.WriteLine("Unosite brojeve iz skupa (-10, ..., 10). Za kraj unosa unesite broj 99.");
        Dictionary<int, int> brojac = new Dictionary<int, int>();
        for (int i = -10; i <= 10; i++)
        {
            brojac[i] = 0;
        }
        while (true)
        {
            Console.Write("Unesite broj: ");
            string unos = Console.ReadLine();
            if (int.TryParse(unos, out int broj))
            {
                if (broj == 99)
                {
                    Console.WriteLine("Kraj unosa.");
                    break;
                }
                if (brojac.ContainsKey(broj))
                {
                    brojac[broj]++;
                }
                else
                {
                    Console.WriteLine("Broj nije iz skupa (-10, ..., 10). Pokušajte ponovo.");
                }
            }
            else
            {
                Console.WriteLine("Neispravan unos. Pokušajte ponovo.");
            }
        }
        Console.WriteLine("\nBrojanje pojavljivanja:");
        foreach (var par in brojac)
        {
            Console.WriteLine($"Broj {par.Key}: {par.Value} puta");
        }
    }
}