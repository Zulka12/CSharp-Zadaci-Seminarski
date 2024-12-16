/*Implementirati program koji generiše prvih n brojeva Fibonacci niza, ali da se preskaču svu brojevi koji su djeljivi sa 5 i generisanje da se završi ukoliko broj prelazi 10 000.*/
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Unesite broj elemenata n: ");
        int n = int.Parse(Console.ReadLine());
        int a = 0, b = 1, count = 0;
        Console.WriteLine("Fibonacci niz (bez brojeva djeljivih sa 5):");
        while (count < n)
        {
            int next = a + b;
            a = b;
            b = next;
            if (next > 10000) break;
            if (next % 5 == 0) continue;
            Console.WriteLine(next);
            count++;
        }
    }
}