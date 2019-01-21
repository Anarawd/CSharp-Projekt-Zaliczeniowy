using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekcikZaliczeniowy
{
    class staty:Menu
    {
        public override int wynik { get { return this.wynik; } set { this.wynik = odpoczynek + szczescie; } }
        protected string imie { get; set; }
        protected string nazwisko { get; set; }
        public int odpoczynek { get; set; }
        public int szczescie { get; set; }
        public void utworz_staty() //do usuniecia
        {
            Console.WriteLine("Podaj swoje imie: ");
            imie = Console.ReadLine();
            Console.WriteLine("Podaj swoje nazwisko: ");
            nazwisko = Console.ReadLine();
            odpoczynek = 10;
            szczescie = 1;
        }
 
        public override void wyswietl_staty()
        {
            Console.WriteLine("Zauważasz w pobliżu kałużę, która odbija twoją mizerną facjatę.");
            if (imie[imie.Length - 1] == 'a') Console.WriteLine("Jesteś prawie spóźnioną studentką.");
            else Console.WriteLine("Jesteś prawie spóźnionym studentem.");
            Console.WriteLine("Ze stresu prawie zapominasz swoje imię, ale po chwili namysłu do głowy wskakują ci dwa słowa: " + imie + " " + nazwisko);
            Console.WriteLine("Tak, to chyba twoje imię i nazwisko.");
            Console.WriteLine("Masz cichą nadzieję, że profesor nie zapyta cię o numer albumu, bo tego zupełnie nie pamiętasz");
            if (odpoczynek >= 10) Console.WriteLine("Zarwanie nocki wyszło ci trochę na dobre, bo czujesz się bardzo dobrze pod względem wypoczynku");
            else if (odpoczynek >= 5) Console.WriteLine("Czujesz się dość dobrze. Mogło by być lepiej.");
            else Console.WriteLine("Jesteś na skraju wycieńczenia. Twoje oczy są zaczerwienione a ostatnie dwie komórki mózgowe odmawiają ci posłuszeństwa");
            //Console.WriteLine("Poziom szczescia: " + szczescie);
            if (szczescie < 3) Console.WriteLine("Po dłuższym gapieniu się w kałużę, zauważasz, że jakaś starsza pani patrzy na ciebie z odrazą.");
        }
        public static staty operator + (staty a, staty b) //przeciążenie operatora do levelowania
        {
            staty wynik = new staty(a.odpoczynek + b.odpoczynek, a.szczescie - b.szczescie, a.imie, a.nazwisko);
            return wynik;
        }
        public static staty operator - (staty a,staty b) //szczescie rośnie wraz ze zmęczeniem
        {
            staty wynik = new staty(a.odpoczynek - b.odpoczynek, a.szczescie + b.odpoczynek,a.imie,a.nazwisko);
            return wynik;
        }
        public staty(int odpoczynek,int szczescie,string imie,string nazwisko)
        {
            this.odpoczynek = odpoczynek;
            this.szczescie = szczescie;
            this.imie = imie;
            this.nazwisko = nazwisko;
        }
        public staty()
        {
            Console.WriteLine("Podaj swoje imie: ");
            imie = Console.ReadLine();
            Console.WriteLine("Podaj swoje nazwisko: ");
            nazwisko = Console.ReadLine();
            odpoczynek = 10;
            szczescie = 1;
        }
        ~staty()
        {
            Console.WriteLine("Dane usunięte.");
        }
    }
}
