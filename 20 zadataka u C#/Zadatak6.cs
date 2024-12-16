/*Napisati C# program koji od korisnika čitava cijeli broj n ≥ 3, potom niz od n realnih brojeva za koje se zna da su svi različiti
 * (i to ne treba provjeravati) i onda ispisuje učitani niz, ali uz preskakanje najmanjeg i najvećeg elementa u nizu.*/
class Program
{
    static void Main()
    {
        Console.WriteLine("Unesite cijeli broj n (n >= 3):");
        int n;
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out n) && n >= 3)
            {
                break;
            }
            Console.WriteLine("Greška! Unesite cijeli broj n koji je veći ili jednak 3:");
        }
        double[] niz = new double[n];
        Console.WriteLine($"Unesite {n} različitih realnih brojeva:");
        for (int i = 0; i < n; i++)
        {
            while (true)
            {
                Console.Write($"Broj {i + 1}: ");
                if (double.TryParse(Console.ReadLine(), out niz[i]))
                {
                    break;
                }
                Console.WriteLine("Greška! Unesite ispravan realan broj.");
            }
        }
        double max = niz.Max();
        double min = niz.Min();
        Console.WriteLine("Niz bez najvećeg i najmanjeg elementa:");
        foreach (double broj in niz)
        {
            if (broj != max && broj != min)
            {
                Console.Write(broj + " ");
            }
        }
        Console.WriteLine();
    }
}