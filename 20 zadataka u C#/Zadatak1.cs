/*Napišite konzolnu aplikaciju u programskom jeziku C#, koja simulira upravljanje podacima o studentima na fakultetu. 
Aplikacija treba da omogući korisniku sljedeće funkcionalnosti:
Dodavanje studenata:
•	Korisnik unosi ime, prezime i broj indeksa studenta.
•	Nakon unosa, novi student se dodaje u listu studenata.
Prikaz svih studenata:
•	Prikazuje listu svih unijetih studenata sa njihovim podacima (ime, prezime i broj indeksa).
•	Ako lista studenata nije popunjena, aplikacija treba da obavijesti korisnika da nema unijetih studenata.
Izlaz iz aplikacije:
•	Korisnik može da prekine rad aplikacije.*/
namespace FakultetAplikacija
{
    class Student
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrojIndeksa { get; set; }
        public override string ToString()
        {
            return $"Ime: {Ime}, Prezime: {Prezime}, Broj indeksa: {BrojIndeksa}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studenti = new List<Student>();
            string izbor;
            Console.WriteLine("Dobrodošli u aplikaciju za upravljanje studentima!");
            do
            {
                Console.WriteLine("\nIzaberite opciju:");
                Console.WriteLine("1. Dodaj studenta");
                Console.WriteLine("2. Prikaži sve studente");
                Console.WriteLine("3. Izlaz");
                Console.Write("Vaš izbor: ");
                izbor = Console.ReadLine();
                switch (izbor)
                {
                    case "1":
                        DodajStudenta(studenti);
                        break;
                    case "2":
                        PrikaziStudente(studenti);
                        break;
                    case "3":
                        Console.WriteLine("Hvala što koristite aplikaciju! Doviđenja!");
                        break;
                    default:
                        Console.WriteLine("Nepoznata opcija. Pokušajte ponovo.");
                        break;
                }
            } while (izbor != "3");
        }
        static void DodajStudenta(List<Student> studenti)
        {
            Console.WriteLine("\nDodavanje novog studenta:");
            Console.Write("Unesite ime: ");
            string ime = Console.ReadLine();
            Console.Write("Unesite prezime: ");
            string prezime = Console.ReadLine();
            Console.Write("Unesite broj indeksa: ");
            string brojIndeksa = Console.ReadLine();
            Student noviStudent = new Student
            {
                Ime = ime,
                Prezime = prezime,
                BrojIndeksa = brojIndeksa
            };
            studenti.Add(noviStudent);
            Console.WriteLine("Student uspješno dodat!");
        }
        static void PrikaziStudente(List<Student> studenti)
        {
            Console.WriteLine("\nLista studenata:");
            if (studenti.Count == 0)
            {
                Console.WriteLine("Nema unijetih studenata.");
            }
            else
            {
                foreach (var student in studenti)
                {
                    Console.WriteLine(student);
                }
            }
        }
    }
}