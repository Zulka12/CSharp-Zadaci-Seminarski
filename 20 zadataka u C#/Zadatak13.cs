/*Napisati program koji uklanja duplikate iz unijetog niza brojeva i ispisuje jedinstvene vrijednosti. */
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Unesite broj elemenata niza: ");
        int n = int.Parse(Console.ReadLine());
        int[] niz = new int[n];
        HashSet<int> jedinstveniBrojevi = new HashSet<int>();
        Console.WriteLine("Unesite elemente niza:");
        for (int i = 0; i < n; i++)
        {
            niz[i] = int.Parse(Console.ReadLine());
            jedinstveniBrojevi.Add(niz[i]);
        }
        Console.WriteLine("Jedinstveni brojevi:");
        foreach (int broj in jedinstveniBrojevi)
        {
            Console.WriteLine(broj);
        }
    }
}