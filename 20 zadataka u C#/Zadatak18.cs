/*Napisati program koji zamjenjuje sve samoglasnike u unijetoj riječi sa znakom *.*/
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Unesite riječ: ");
        string rijec = Console.ReadLine();
        string rezultat = "";
        foreach (char c in rijec)
        {
            if ("aeiouAEIOU".Contains(c))
                rezultat += '*';
            else
                rezultat += c;
        }
        Console.WriteLine($"Rezultat: {rezultat}");
    }
}