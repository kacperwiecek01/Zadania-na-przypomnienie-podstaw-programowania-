using System;
using System.Net.NetworkInformation;

class Program
{

    static void Main()
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
}
