using System;
using System.Net.NetworkInformation;

class Program
{

    static void Main()
    {
        bool Kontynuuj = true;

        while(Kontynuuj)
        {
            Console.WriteLine("\n --Menu--");
            Console.WriteLine("1. Kalkulator dwóch liczb");
            Console.WriteLine("2. Konwenter temperatur");
            Console.WriteLine("0. Wyjście");
            Console.Write("Wybierz zadanie: ");
            string wybor = Console.ReadLine();

            switch (wybor)
            {
                case "1":
                    Kalkulator();
                    break;
                case "2":
                    KonwenterTemperatur();
                    break;
                case "0":
                    Kontynuuj = false;
                    break;
                default:
                    Console.WriteLine("Nieprawidłowy wybór.");
                    break;

            }
        }    
    }
    
    static void Kalkulator()
    {
        Console.Write("Podaj pierwsza liczbe: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj druga liczbe: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Wybierz operację (+, -, *, /): ");
        string operacja = Console.ReadLine();

        double wynik;

        if ( operacja == "+")
        {
            wynik = a + b;
            Console.WriteLine("Wynik: " + wynik);

        }
        else if ( operacja == "-" )
        {
            wynik = a - b;
            Console.WriteLine("Wynik: " + wynik);
        }
        else if ( operacja == "*" )
        {
            wynik = a * b;
            Console.WriteLine("Wynik: " + wynik);
        }
        else if ( operacja == "/" )
        {
           if ( b != 0 )
            {
                wynik = a / b;
                Console.WriteLine("Wynik: " + wynik);
            }
           else
            {
                Console.WriteLine("Błąd: Nie można dzielić przez zero!");
            }
        }
        else
        {
            Console.WriteLine("Błąd: Nieznana operacja!");
        }
    }

    static void KonwenterTemperatur()
    {
        Console.Write("Wybierz Konwersję (C- Celsujsz -> Fahrenheit, F - Farhenheit -> Celsjusz): ");
        string kierunek = Console.ReadLine().ToUpper();

        Console.Write("Podaj Temperaturę: ");
        double temperatura = Convert.ToDouble(Console.ReadLine());

        double wynik;

        if (kierunek == "C")
        {
            wynik = temperatura * 1.8 + 32;
            Console.WriteLine($"{temperatura}°C = {wynik}°F");
        }
        else if ( kierunek == "F" )
        {
            wynik = (temperatura - 32) / 1.8;
            Console.WriteLine($"{temperatura}°F = {wynik}°C");
        }
        else
        {
             Console.WriteLine("Błąd: Nieznany tryb konwersji ( Użyj C lub F )");
        }
    }
}
