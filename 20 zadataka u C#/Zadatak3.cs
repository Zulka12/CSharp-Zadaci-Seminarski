/*Napisati program u C# jeziku koji koristi statička polja i statičke metode za implementaciju jednostavnog kalkulatora. 
Program treba da ima klasu Kalkulator sa statičkim poljima i metodama koje izvode matematičke operacije sabiranje i množenje.*/
class Kalkulator
{
    public static int Broj1 = 10;
    public static int Broj2 = 20;
    public static int Saberi()
    {
        return Broj1 + Broj2;
    }
    public static int Pomnozi()
    {
        return Broj1 * Broj2;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Broj1: {Kalkulator.Broj1}");
        Console.WriteLine($"Broj2: {Kalkulator.Broj2}");
        Console.WriteLine($"Zbir: {Kalkulator.Saberi()}");
        Console.WriteLine($"Proizvod: {Kalkulator.Pomnozi()}");
        Console.ReadLine();
    }
}