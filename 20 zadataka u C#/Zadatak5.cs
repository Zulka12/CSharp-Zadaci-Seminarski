/*Na jednom turniru karatisti se takmiče u tri kategorije: juniori (takmičari os 7 do 12 godina), 
 * kadeti (takmičari od 13 do 20 godina) i seniori (takmičari od 21 godinu na dalje). 
 * Napisati C# program koji od korisnika učitava cijele brojeve (koji predstavlja starost prijavljenih takmičara) 
 * sve dok korisnik ne unese riječ KRAJ, za svakog takmičara ispisuje kategoriju kojoj pripada. 
 * Ukoliko takmičar ima manje od 7 godina program treba da ispiše da takmičar nema pravno da se takmiči.*/
class Program
{
    static void Main()
    {
        Console.WriteLine("Unesite starost takmičara (ili 'KRAJ' za završetak):");
        while (true)
        {
            string unos = Console.ReadLine();

            if (unos.ToUpper() == "KRAJ")
            {
                Console.WriteLine("Kraj unosa.");
                break;
            }
            if (int.TryParse(unos, out int starost))
            {
                if (starost < 7)
                {
                    Console.WriteLine("Takmičar nema pravo da se takmiči.");
                }
                else if (starost >= 7 && starost <= 12)
                {
                    Console.WriteLine("Takmičar pripada kategoriji: Juniori.");
                }
                else if (starost >= 13 && starost <= 20)
                {
                    Console.WriteLine("Takmičar pripada kategoriji: Kadeti.");
                }
                else if (starost >= 21)
                {
                    Console.WriteLine("Takmičar pripada kategoriji: Seniori.");
                }
            }
            else
            {
                Console.WriteLine("Pogrešan unos. Unesite broj godina ili 'KRAJ'.");
            }
        }
    }
}