/*Napisati program koji računa sumu svih brojeva u intervalu od a do b, gdje korisnik unosi vrijednosti za a i b.*/
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Unesite početni broj a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Unesite završni broj b: ");
        int b = int.Parse(Console.ReadLine());
        int suma = 0;
        for (int i = a; i <= b; i++)
        {
            suma += i;
        }
        Console.WriteLine($"Suma brojeva od {a} do {b} je: {suma}");
    }
}