/*Napisati program u programskom jeziku C# koji demonstrira koncept nasljeđivanja korištenjem dvije klase: Zivotinja (bazna klasa) i Pas (nasljedna klasa). 
Program treba omogućiti da u baznoj klasi Zivotinja se definira Ime za pohranu imena životinje i metodu KreciSe() koja se ispisuje u formatu [Ime] se kreće. 
U nasljednoj klasi Pas se treba kreirati metoda Laj() i ispisuje se [Ime] laje: 'Av, av!'. */
namespace Nasljedjivanje
{
    class Zivotinja
    {
        public string Ime { get; set; }
        public void KreciSe()
        {
            Console.WriteLine($"{Ime} se kreće.");
        }
    }
    class Pas : Zivotinja
    {
        public void Laj()
        {
            Console.WriteLine($"{Ime} laje: 'Av, av!'");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Zivotinja zivotinja = new Zivotinja();
            zivotinja.Ime = "Neka životinja";
            zivotinja.KreciSe();
            Pas pas = new Pas();
            pas.Ime = "Rex";
            pas.KreciSe();
            pas.Laj();
            Console.ReadLine();
        }
    }
}