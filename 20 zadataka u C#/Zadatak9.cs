/*Napišite program koji pronalazi sve brojeve od 1 do unijetog broja n, koji su istovremeno djeljivi sa 3 i palindromi (broj koji je isti kad se čita s obe strane).*/
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Unesite broj n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Brojevi koji su djeljivi sa 3 i palindromi:");
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0 && IsPalindrome(i))
            {
                Console.WriteLine(i);
            }
        }
    }
    static bool IsPalindrome(int number)
    {
        string original = number.ToString();
        char[] reversedArray = original.ToCharArray();
        Array.Reverse(reversedArray);
        string reversed = new string(reversedArray);
        return original == reversed;
    }
}