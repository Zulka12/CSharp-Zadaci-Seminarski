/*Napišite program koji ispisuje sve brojeve od unijetog broja i za svaki broj određuje da li je prost ili nije. 
 * Treba se implementirati metoda za provjeru prostih brojeva.*/
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Unesite broj: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            if (IsPrime(i))
                Console.WriteLine($"{i} je prost broj.");
            else
                Console.WriteLine($"{i} nije prost broj.");
        }
    }
    static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }
}