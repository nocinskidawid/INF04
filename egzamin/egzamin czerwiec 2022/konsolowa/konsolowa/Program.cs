using System.Security.Cryptography.X509Certificates;

internal class Program
{

    public static Random random = new Random();
    public static int[] liczby = { };

    public static void WypelnienieTablicy()
    {
        for (int i = 0; i < 67; i++)
        {
            liczby = liczby.Append(random.Next(1, 101)).ToArray();
        }
    }
    /* 
     nazwa funkcji:   Szukanie
     argumenty:       int x-przechowuje liczbe wpisana przez uzytkownika
     typ zwracany:    int, miejsce liczby w tablicy
     informacje:      deklaracja zmiennej indeks ktora jest zwracana przez funkcje, ustawienie wartownika na ostatniej pozycji tablicy, 
                      przeiterowanie tablicy w celu znalezienia podanej przez uzytkownika liczby, jezeli znajdzie sie szukana liczba funkcja
                      sie przerywa, zwraca indeks znalezionej liczby badz wartownika
    autor:            00000000000
     */
    public static int Szukanie(int x)
    {
        int indeks = 0;
        liczby = liczby.Append(x).ToArray();
        for(int i = 0; true ; i++)
        {
            if (liczby[i]==x) 
            {
                indeks = i;
                break;
            }
        }
        return indeks;
    }

    private static void Main(string[] args)
    {
        WypelnienieTablicy();

        Console.WriteLine("Podaj liczbe uzytkowniku:");
        int x = int.Parse(Console.ReadLine());

        
        int indeks = Szukanie(x);

        for (int i = 0; i < liczby.Length; i++)
        {
            Console.Write($"{i}:{liczby[i]}, ");
        }

        Console.WriteLine();

        if (indeks == liczby.Length-1)
        {
            Console.WriteLine("Jest to wartownik, nie ma szukanej liczby w tablicy");
        } 
        else 
        { 
            Console.WriteLine($"Pierwsza liczba {x} jest na indeksie {indeks}");
        }

    }
}