namespace konsolowa
{
    internal class Program
    {

        public class OperacjeNaTablicach
        {
            Random rnd = new Random();

            private int[] tablica;
            private int liczbaElementowTablicy;
            
            public OperacjeNaTablicach(int rozmiarTablicy)
            {
                liczbaElementowTablicy = rozmiarTablicy;
                tablica = new int[rozmiarTablicy];

                for(int i = 0; i < rozmiarTablicy; i++)
                {
                    tablica[i] = rnd.Next(1,1001);
                }
            }

            public void wyswietl()
            {
                Console.WriteLine("Zawartosc tablicy:");
                for (int i = 0; i < tablica.Length; i++)
                {
                    Console.WriteLine($"{i}: {tablica[i]}");
                }
            }

            public int wyszukaj(int szukana)
            {
                for (int i = 0; i < tablica.Length; i++)
                {
                    if (tablica[i] == szukana)
                    {
                        return i;
                    }
                }
                return -1;
            }

            public void nieparzyste()
            {
                int liczbaNieparzystych = 0;
                Console.WriteLine("Liczby nieparzyste");
                for (int i = 0; i < tablica.Length; i++)
                {
                    if (tablica[i]%2!=0)
                    {
                        Console.WriteLine(tablica[i]);
                        liczbaNieparzystych++;
                    }
                }
                Console.WriteLine($"Razem nieparzystych: {liczbaNieparzystych}");
            }

            public int srednia()
            {
                int suma = 0;
                for (int i = 0; i < tablica.Length; i++)
                {
                    suma += tablica[i];
                }
                return suma / liczbaElementowTablicy;
            }
        }
        static void Main(string[] args)
        {
            OperacjeNaTablicach tablice = new OperacjeNaTablicach(21);
            tablice.wyswietl();
            Console.WriteLine("Podaj szukana liczbe (1-1000)");
            string? input = Console.ReadLine();
            if(int.TryParse(input, out int inputParsed))
            {
                int indeks = tablice.wyszukaj(inputParsed);
                if (indeks != -1)
                {
                    Console.WriteLine($"znaleziono wartosc {inputParsed} pod indeksem {indeks}");
                }
            }
            else
            {
                Console.WriteLine("Podaj poprawny indeks");
            }
            tablice.nieparzyste();
            Console.WriteLine($"Srednia wszystkich elementow: {tablice.srednia()}");


            
        }
    }
}
