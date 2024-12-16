/*Napisati program koji omogućava unos ocjena za više studenata i računa prosječnu ocjenu svakog studenta. */
class Student
{
    public string Ime { get; set; }
    public List<int> Ocjene { get; set; }
    public double ProsjecnaOcjena()
    {
        int suma = 0;
        foreach (var ocjena in Ocjene)
        {
            suma += ocjena;
        }
        return (double)suma / Ocjene.Count;
    }
}
class Program
{
    static void Main(string[] args)
    {
        List<Student> studenti = new List<Student>();
        Console.Write("Koliko studenata želite da unesete? ");
        int brojStudenata = int.Parse(Console.ReadLine());
        for (int i = 0; i < brojStudenata; i++)
        {
            Console.Write("Ime studenta: ");
            string ime = Console.ReadLine();
            Console.Write("Unesite broj ocjena: ");
            int brojOcjena = int.Parse(Console.ReadLine());
            List<int> ocjene = new List<int>();
            for (int j = 0; j < brojOcjena; j++)
            {
                Console.Write($"Ocjena {j + 1}: ");
                ocjene.Add(int.Parse(Console.ReadLine()));
            }
            studenti.Add(new Student { Ime = ime, Ocjene = ocjene });
        }
        Console.WriteLine("\nProsječne ocjene:");
        foreach (var student in studenti)
        {
            Console.WriteLine($"{student.Ime}: {student.ProsjecnaOcjena():F2}");
        }
    }
}