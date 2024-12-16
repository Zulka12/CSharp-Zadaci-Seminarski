/*Napisati program koji provjerava da li su dvije riječi anagrami (sadrže iste karaktere u različitom redoslijedu).*/
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Unesite prvu riječ: ");
        string prvaRijec = Console.ReadLine();
        Console.Write("Unesite drugu riječ: ");
        string drugaRijec = Console.ReadLine();
        char[] prva = prvaRijec.ToLower().ToCharArray();
        char[] druga = drugaRijec.ToLower().ToCharArray();
        Array.Sort(prva);
        Array.Sort(druga);
        if (new string(prva) == new string(druga))
            Console.WriteLine("Riječi su anagrami.");
        else
            Console.WriteLine("Riječi nisu anagrami.");
    }
}