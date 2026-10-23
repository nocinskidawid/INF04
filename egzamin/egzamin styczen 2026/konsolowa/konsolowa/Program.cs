internal class Program
{
    static Random random = new Random();
    public static string haslo = "";

/*
nazwa:               StworzHaslo
opis funkcji:        Funkcja generuje losowe haslo 12 znakowe w ktorym znajduja sie 3 losowe male litery, 3 losowe duze litery, 2 losowe cyfry,
                     2 losowe polskie znaki, 2 losowe znaki specjalne z podanego zestawu, nastepnie zwraca wygenerowane haslo
paramatry:           brak
zwracany typ i opis: losowo wygenerowane haslo jako zmienna tekstowa
autor:               1111111111 
*/
    public static string StworzHaslo()
    {
        haslo = "";

        char[] znakiM = { 'a', 'b', 'c', 'd', 'e' };
        char[] znakiW = { 'A', 'B', 'C','D','E',};
        char[] znakiNosowe = { 'Ą','Ć','ą','ć','ę'};
        char[] liczby = { '0', '1','2','3'};
        char[] znakiSpecjalne = { '!', '@', '#','$'};

        int maleIlosc = 3;
        int wielkieIlosc = 3;
        int nosoweIlosc = 2;
        int liczbyIlosc = 2;
        int specjalneIlosc = 2;
        
        for (int i = 0; i < 11;) 
        { 
          int losowyZestawZnakow = random.Next(1, 6);
            //Console.WriteLine(i);
            if (losowyZestawZnakow == 1 && maleIlosc > 0)
            {
                int losowyZnak = random.Next(0, znakiM.Length);
                haslo += znakiM[losowyZnak];
                maleIlosc--;
                i++;
                //Console.WriteLine("Debug male");
                //Console.WriteLine($"Debug wynik {wynik}");
                //Console.WriteLine($"Debug i {i}");
            }
            else if (losowyZestawZnakow == 2 && wielkieIlosc > 0)
            {
                int losowyZnak = random.Next(0, znakiW.Length);
                haslo += znakiW[losowyZnak];
                wielkieIlosc--;
                i++;
                //Console.WriteLine("Debug duze");
            }
            else if (losowyZestawZnakow == 3 && nosoweIlosc > 0)
            {
                int losowyZnak = random.Next(0, znakiNosowe.Length);
                haslo += znakiNosowe[losowyZnak];
                nosoweIlosc--;
                i++;
                //Console.WriteLine("Debug nosowe");
            }
            else if (losowyZestawZnakow == 4 && specjalneIlosc > 0)
            {
                int losowyZnak = random.Next(0, znakiSpecjalne.Length);
                haslo += znakiSpecjalne[losowyZnak];
                specjalneIlosc--;
                i++;
                //Console.WriteLine("Debug specjalne");
            }
            else if (losowyZestawZnakow == 5 && liczbyIlosc > 0)
            {
                int losowyZnak = random.Next(0, liczby.Length);
                haslo += liczby[losowyZnak];
                liczbyIlosc--;
                i++;
                //Console.WriteLine("Debug liczby");
            }
        }
        //Console.WriteLine($"Debug ostateczny {wynik}");
        return haslo;
    }
    private static void Main(string[] args)
    {
        for (int i = 0; i < 5; i++)
        {
            StworzHaslo();
            Console.WriteLine($"Haslo {i+1} - {haslo}");
        }
    }
}