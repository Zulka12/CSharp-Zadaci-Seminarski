/*Napisati program koji pronalazi sve Armstrongove brojeve u opsegu od 1 pa do unesenog broja n. 
 * Armstrongov broj je broj jednak zbiru svojih cifara podignutih na stepen broja cifara (npr. 153= 1^3+5^3+3^3)*/
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Unesite broj n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Armstrongovi brojevi:");
        for (int i = 1; i <= n; i++)
        {
            if (IsArmstrong(i))
                Console.WriteLine(i);
        }
    }
    static bool IsArmstrong(int broj)
    {
        int suma = 0, original = broj, brojCifara = broj.ToString().Length;
        while (broj > 0)
        {
            int cifra = broj % 10;
            suma += (int)Math.Pow(cifra, brojCifara);
            broj /= 10;
        }
        return suma == original;
    }
}