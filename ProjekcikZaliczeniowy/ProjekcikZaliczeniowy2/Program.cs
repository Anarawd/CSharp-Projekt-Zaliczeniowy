using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekcikZaliczeniowy
{
    class Program
    {
        static void Main(string[] args)
        {
            string wejscie;
            int stan = 0;
            int zmienna = 0;
            Console.WriteLine("Rozpoczynamy wspaniala przygode z grą zaliczeniowa!");
            Console.WriteLine();
            Console.WriteLine("Witaj we wspanialym swiecie Mordoru!");
            Console.WriteLine("Jesteś biednym studentem ktory ma dzisiaj egzamin.");
            Console.WriteLine("Przez wlasne lenistwo postanowiłeś poprzednią noc zarwać na naukę");
            Console.WriteLine("Z tego powodu zaspałeś i jeśli się nie pospieszysz, spóźnisz się na zajęcia!");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(6, 6);
            Console.WriteLine("Naciśnij dowolny klawisz aby zacząć tworzenie profilu: ");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            staty gracz = new staty();
            Zakonczenie koncowka = new Zakonczenie();
            staty odpoczynek_plus = new staty(1, 1, "odpoczynek", "plus");
            staty szczescie_plus = new staty(1, 1, "szczescie", "plus");
            //gracz.utworz_staty();
            Menu.Tutorial();
            Console.Clear();
            Menu.Obecny_Stan(stan);
            while (true)
            {
                if (zmienna==1) { stan++; zmienna--; Menu.Obecny_Stan(stan); }
                if (stan == 3)
                {
                    Menu.Przekazanie(gracz.odpoczynek, gracz.szczescie);
                    
                    Zakonczenie.koniec();
                    koncowka.wyswietl_staty();
                    Console.WriteLine("Oto twój końcowy wynik: " + koncowka.wynik);
                    Console.ReadKey();
                    break;
                }
                Console.WriteLine();
                Console.WriteLine("----");
                Console.WriteLine("Komenda: ");
                wejscie = Console.ReadLine();
                switch(wejscie)
                {
                    case "show stats": gracz.wyswietl_staty(); break;
                    case "help": Menu.Komendy(); break;
                    case "level szczescie": gracz = gracz - szczescie_plus; break;
                    case "level odpoczynek": gracz = gracz + odpoczynek_plus; break;
                    case "powtorz calosc": Menu.Obecny_Stan(); break;
                    case "powtorz ostatnie": Menu.Obecny_Stan(stan); break;
                    case "tak": zmienna = 1; gracz = gracz - szczescie_plus; Console.Clear(); Menu.Potwierdz(stan); break; //odpowiedzi na tak zwiekszaja szczescie ale zmniejszaja odpoczynek
                    case "nie": zmienna = 1; gracz = gracz + odpoczynek_plus; Console.Clear(); Menu.Zaprzecz(stan); break; //tutaj na odwrót
                    case "koniec": zmienna = 2; break;
                    case "33": if (stan == 2) { zmienna = 1; gracz = gracz + odpoczynek_plus; Console.Clear(); Menu.Zaprzecz(stan); }
                        else Console.WriteLine("Nieznane polecenie"); break;
                    case "17": if (stan == 2) { zmienna = 1; gracz = gracz - szczescie_plus; Console.Clear(); Menu.Potwierdz(stan); }
                        else Console.WriteLine("Nieznane polecenie"); break;
                    case "wynik": Console.WriteLine("twój obecny wynik to:" + gracz.wynik); break;
                    default: Console.WriteLine("Nieznane polecenie"); break;
                }
                if (zmienna == 2) break;

            }
            gracz = null;
            odpoczynek_plus = null;
            szczescie_plus = null;
            koncowka = null;
        }
    }
}
