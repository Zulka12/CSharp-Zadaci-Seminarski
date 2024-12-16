/*Napisati c# program koji računa rastojanje dvije tačke u ravni ako tačka A ima koordinate (x1, x2), 
a tačka B ima koordinate (y1, y2), onda je rastojanje tačaka A i B dato sa 
d(A,B)=√(〖(x_1-y_1)〗^2+〖(x_2-y_2)〗^2 )
*/
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Unesite koordinate tačke A:");
        Console.Write("x1: ");
        double x1 = double.Parse(Console.ReadLine());
        Console.Write("x2: ");
        double x2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Unesite koordinate tačke B:");
        Console.Write("y1: ");
        double y1 = double.Parse(Console.ReadLine());
        Console.Write("y2: ");
        double y2 = double.Parse(Console.ReadLine());
        double rastojanje = Math.Sqrt(Math.Pow(x1 - y1, 2) + Math.Pow(x2 - y2, 2));
        Console.WriteLine($"Rastojanje između tačaka A i B je: {rastojanje:F2}");
        Console.ReadLine();
    }
}