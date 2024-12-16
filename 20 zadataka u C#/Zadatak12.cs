/*Napišite program koji unosi kvadratnu matricu n x n, a zatim ispisuje njen transponovani oblik.*/
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Unesite dimenziju matrice n: ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrica = new int[n, n];
        Console.WriteLine("Unesite elemente matrice:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrica[i, j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("Transponovana matrica:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrica[j, i] + " ");
            }
            Console.WriteLine();
        }
    }
}