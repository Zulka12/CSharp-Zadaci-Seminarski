/*Napisati program koji unosi kvadratnu matricu n x n, a zatim ispisuje samo glavnu i sporednu dijagonalu matrice.*/
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
        Console.WriteLine("Glavna i sporedna dijagonala matrice:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(matrica[i, i] + " ");
            if (i != n - i - 1)
                Console.Write(matrica[i, n - i - 1] + " ");
            Console.WriteLine();
        }
    }
}