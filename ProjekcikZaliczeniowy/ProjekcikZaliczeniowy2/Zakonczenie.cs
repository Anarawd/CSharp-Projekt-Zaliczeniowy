using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekcikZaliczeniowy
{
    class Zakonczenie:Menu
    {
        public override void wyswietl_staty() //a to odpoczynek, b szczescie
        {
            Console.WriteLine("Oto podsumowanie twojej przygody: ");
            Console.WriteLine("Twoje szczęście wynosi: " + b);
            Console.WriteLine("Twój stopień odpoczynku wynosi: " + a);
        }
        public static void koniec()
        {
            Console.WriteLine("Drzwi do sali uchylają się.");
            if ((a==7)&&(b==4)) //najmniejszy odpoczynek, najwieksze szczescie
            {
                Console.WriteLine("Po bardzo męczącej podróży, w końcu docierasz do sali.");
                Console.WriteLine("Na twoję szczęścię, egzamin jeszcze się nie zaczął. Powolnym krokiem zmierasz na tył sali.");
                Console.WriteLine("Zajmujesz sobię wygodnę miejscę i wyjmujesz długopis. Egzamin w krótce się zacznie.");
                Console.WriteLine("Odczuwasz dość duże zmęczenie z powodu swojego pośpiechu ale przynajmniej masz satysfakcję ze swojej prędkości");
                Console.WriteLine("Czujesz, że egzamin poszedł ci dość dobrze. Do domu wracasz z bananem na twarzy.");
            }
            else if ((a==13)&&(b==-2))
            {
                Console.WriteLine("Po bardzo długiej podróży, w końcu docierasz do sali.");
                Console.WriteLine("Egzamin zaczął się już jakiś czas temu. Profesor Wynikowy patrzy na ciebię z pogardą i wyprasza cię z sali.");
                Console.WriteLine("Może trzeba było się bardziej pośpieszyć.");
            }
            else
            {
                Console.WriteLine("Po ciężkiej podróży, w końcu docierasz do sali.");
                Console.WriteLine("Akurat Profesor Wynik rozdaje testy. Pocichu zajmujesz pierwsze lepsze miejsce i zabierasz się za pisanie.");
                Console.WriteLine("Poszło ci OK. Nie dobrze, nie źle. Po prostu OK. Mogło być lepiej ale lepszy rydz niż nic.");
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Potwierdź dowolnym klawiszem.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
            Console.Clear();
        }
        public override int wynik
        {
            get
            {
                return a + b * 2;
            }
            set
            {
                this.wynik = a + b * 2;
            }
        }

        public Zakonczenie()
        {
            
        }
        ~Zakonczenie()
        {
            Console.WriteLine("Dane usunięte.");
        }

    }
}
