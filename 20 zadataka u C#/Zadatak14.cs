/*Napisati program koji omogućava korisniku da unese dva broja i izabere jednu od osnovnih matematičkih operacija (+, -, *, /), zatim izračunava i prikazuje rezultat.*/
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Unesite prvi broj: ");
        double broj1 = double.Parse(Console.ReadLine());
        Console.Write("Unesite drugi broj: ");
        double broj2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Izaberite operaciju (+, -, *, /): ");
        char operacija = char.Parse(Console.ReadLine());
        double rezultat = 0;
        switch (operacija)
        {
            case '+':
                rezultat = broj1 + broj2;
                break;
            case '-':
                rezultat = broj1 - broj2;
                break;
            case '*':
                rezultat = broj1 * broj2;
                break;
            case '/':
                if (broj2 != 0)
                    rezultat = broj1 / broj2;
                else
                    Console.WriteLine("Djeljenje sa nulom nije dozvoljeno.");
                break;
            default:
                Console.WriteLine("Nepoznata operacija.");
                return;
        }
        Console.WriteLine($"Rezultat: {rezultat}");
    }
}