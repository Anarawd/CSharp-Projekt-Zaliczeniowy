using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekcikZaliczeniowy
{
    abstract class Menu
    {
        public abstract int wynik { get; set; }
        static protected int a, b;
        static protected bool karta=false;
        static public void Tutorial()
        {
            Console.Clear();
            Console.WriteLine("Oto poradnik jak poruszać się po grze.");
            Console.WriteLine("Wpisuj komendy na klawiaturze i zatwierdź enterem");
            Console.WriteLine("Na ogół są to odpowiedzi 'tak', 'nie' ale istnieje pare specjalnych komend");
            Console.WriteLine("Komenda 'help' pokaże wszystkie dostępne komendy");
            Console.WriteLine("Wcisnij dowolny przycisk aby kontynuować.");
            Console.ReadKey();
        }
        static public void Komendy() //nie pisz na czarno
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Lista komend: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("help - wyświetla pomoc");
            Console.WriteLine("show stats - pokazuje obecny status gracza");
            Console.WriteLine("powotrz calosc - pokazuje ogólnikowy opis przygody");
            Console.WriteLine("powtorz ostatnie - pokazuje ostatni wpis z przygody");
            Console.WriteLine("wynik - pokazuje obecny wynik");
            Console.WriteLine("koniec - przedterminowo kończy przygodę");
        }
        static public void Obecny_Stan() //tutaj ogólnikowy opis dla przygody
        {
            Console.WriteLine("Jesteś biednym studentem, który obudził się zbyt późno na egzamin.");
            Console.WriteLine("Twoim celem jest dotrzeć do uczelni w całości i napisać egzamin.");
        }
        static public void Obecny_Stan(int a) //przypomnienie gdzie znajduje się gracz w obecnej chwili
        {
            switch (a)
            {
                case 0: Console.WriteLine("Po przebudzeniu i zrozumieniu w jak wielkim bagnie jesteś, niczym Bolt Ussain zbierasz się");
                    Console.WriteLine("i wybiegasz ze swojego pokoju. Po szybkim oczyszczeniu się i zebraniu torby odczuwasz dziwny niepokój.");
                    Console.WriteLine("Czujesz jakbyś zupełnie o czymś zapomniał. Może to tylko przeczucie. Czy decydujesz się sprawdzić zawartość torby?"); break;

                case 1: Console.WriteLine("Po wyjściu z domu uderza w ciebie zimne styczniowe powietrze. Zakładasz słuchawki na uszy i pędzisz w kierunku metra.");
                        Console.WriteLine("Zajmuje ci to krótką chwile i na niedomiar złego prawie wywijasz kozła na lodzie. Na twoje szczęście udaje ci się");
                        Console.WriteLine("dotrzeć do warszawskiego podziemia.");
                        if (karta == true) Console.WriteLine("Skanujesz swoją kartę na bramce i z łatwością przechodzisz dalej");
                        else {Console.WriteLine("Orientujesz się, że twoja karta miejska została w domu.");
                        Console.WriteLine("Marnujesz czas na zakupienie biletu ale udaje ci się przejść dalej."); }
                        Console.WriteLine("Będąc już w środku metra, zastanawiasz się czy stać w miejscu, czy może przecisnąć się, żeby zdobyć miejsce.");
                        Console.WriteLine("Możesz przypomnieć sobię materiały na egzamin i na siedząco i na stojąco.");
                        Console.WriteLine("Czy postanawiasz zostać w miejscu i nie siadać?"); break;
                case 2: Console.WriteLine("Ewentualnie docierasz do stacji na której masz wysiąść. Grzecznie wychodzisz i kierujesz się w stronę wyjścia");
                        Console.WriteLine("Wyłaniasz się na powierzchnię, jak krasnolud wychodzący z kopalni. Zauważasz, że między tobą");
                        Console.WriteLine("a krasnoludem nie ma tak dużej różnicy. I to i to siedzi cały dzień w ciemnej jaskini.");
                        Console.WriteLine("Docierasz w końcu na przystanek tramwajowy i czekasz sobię na przyjazd trawmaju. Musisz podjąć szybką decyzję,");
                        Console.WriteLine("do którego tramwaju wsiąść? Linia 17 jest na ogół zapełniona, jednak pojawi się na przystanku szybciej");
                        Console.WriteLine("Natomiast linia 33 jest prawie zawsze pusta. Musisz jednak poczekać na nią trochę dłużej.");
                        Console.WriteLine("Na tramwaj której linii decydujesz się poczekać?"); break;
                case 3: Console.WriteLine("Jakoś ta podróż tramwajem mija. Trwa ona dość długo, bo aż 30 minut. Ale w końcu docierasz pod uczelnię.");
                        Console.WriteLine("Biegniesz najszybciej jak potrafisz i znowu prawię wywijasz kozła. Czujesz jak kończyny ci odmarzają i odpadają.");
                        Console.WriteLine("Mijasz kulę dymu stojącą przed wejściem i głośno wpadasz do środka. Jesteś już tak blisko!");
                        Console.WriteLine("W końcu dobiegasz do sali w której ma odbywać się egzamin. Powoli otwierasz drzwi."); break;

            }
        }
         static public void Przekazanie(int c,int d)
        {
            a = c;
            b = d;
        }
        static public void Potwierdz(int a)
        {
            switch(a)
            {
                case 0: Console.WriteLine("Po krótkim namyśle postanawiasz spojrzeć do torby. Ku twojej rozpaczy zauważasz, że w twojej torbie");
                    Console.WriteLine("brakuje karty miejskiej! Mało brakowało a podróż metrem mogłaby się skończyć tragedią. "); karta = true; break;

                case 1: Console.WriteLine("Postanawiasz, że nie ma co się przepychać i najlepiej jest stać podczas gdy metro jedzie.");
                        Console.WriteLine("Dzięki temu nie musisz ścierpieć tego jak starsze panie patrzą na ciebie z pogardą. Udaje ci się trochę pouczyć."); break;

                case 2: Console.WriteLine("Postanawiasz wsiąść do tramwaju linii 17. Mimo wszystko wiesz, że spieszysz się na egzamin. Po co komu komfort jazdy?");
                    Console.WriteLine("Gdy tramwaj przyjeżdża, twoje serce zaczyna ściskać ze stresu. Tramwaj przypomina konserwę z sardynkami.");
                    Console.WriteLine("Z dużą niechęcią wsiadasz do środka. Sardynki przyciskają cię do drzwi. Odkrywasz co to znaczy być zapuszkowanym."); break;

            }
        }
        static public void Zaprzecz(int a)
        {
            switch(a)
            {
                case 0: Console.WriteLine("Już i tak żyjesz na krawędzi. Po co masz marnować czas i sprawdzać torbę? Zarzucasz ją na ramię i pośpiesznie");
                        Console.WriteLine("wychodzisz z domu."); break;

                case 1: Console.WriteLine("Decydujesz się na przepychankę przez tłum ludzi w poszukiwaniu miejsca.");
                        Console.WriteLine("Udaje ci się znaleźć wolnę miejsce w rogu. Siadasz tam i zaczynasz przeglądać materiał na egzamin");
                        Console.WriteLine("Po krótkiej chwili czujesz na sobie piekący wzrok, tak jakby ktoś gapił się na ciebie z intensywnością tysiąca słońc.");
                        Console.WriteLine("Zauważasz, że starsze panie patrzą się na ciebie tak, jakby chciały swoim wzrokiem wypalić w tobie dziurę"); break;
                case 2: Console.WriteLine("Decydujesz się poczekać na trawmaj linii 33. Uważasz, że komfort jazdy jest ważniejsz od zdążenia na egzamin.");
                        Console.WriteLine("Tramwaj przyjeżdża prawię pusty. Bez problemu wybierasz sobię wygodnę miejsca i rozsiadasz się."); break;

            }
        }
        public abstract void wyswietl_staty();
    }
}
