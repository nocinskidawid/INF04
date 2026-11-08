using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using static Program;
using static System.Net.Mime.MediaTypeNames;

internal class Program
{

    public class Kosc
    {
        static Random rnd = new Random();
        public static int LiczbaInstancji;
        private string[] nazwyPlikow = { "kosc0.png", "kosc1.png", "kosc2.png", "kosc3.png", "kosc4.png", "kosc5.png", "kosc6.png" };
        private int wartosc;
        private string? idPlikuGraficznego;
        private bool czyDostepna;

        public int Wartosc { get; private set; }
        public string IdPlikuGraficznego { get; private set; }

        public Kosc(int LiczbaOczek)
        {
            if (LiczbaOczek != 1 && LiczbaOczek != 2 && LiczbaOczek != 3 && LiczbaOczek != 4 && LiczbaOczek != 5 && LiczbaOczek != 6)
            {
                LiczbaOczek = 0;
            }

            Wartosc = LiczbaOczek;
            IdPlikuGraficznego = nazwyPlikow[LiczbaOczek];
            czyDostepna = true;
            LiczbaInstancji++;
        }

        public Kosc()
        {
            int LiczbaOczek = rnd.Next(1, 7);
            Wartosc = LiczbaOczek;
            IdPlikuGraficznego = nazwyPlikow[LiczbaOczek];
            czyDostepna = true;
            LiczbaInstancji++;
        }

        public void rzut()
        {
            if (czyDostepna)
            {
                int LiczbaOczek = rnd.Next(1, 7);
                Wartosc = LiczbaOczek;
                IdPlikuGraficznego = nazwyPlikow[LiczbaOczek];
            }
        }

        public void zablokuj()
        {
            czyDostepna = false;
        }

        public string zwrocTekst()
        {
            return Wartosc switch
            {
                1 => "jeden",
                2 => "dwa",
                3 => "trzy",
                4 => "cztery",
                5 => "piec",
                6 => "szesc",
                _ => "bledna wartosc"
            };
        }
        private static void Main(string[] args)
        {
            //while (true) { //for debuging only
            Console.WriteLine("podaj wartosc pierwszej kosci");
            string? input = Console.ReadLine();

            Kosc pierwszaKosc;

            if (int.TryParse(input, out int liczba))
            {
                pierwszaKosc = new Kosc(liczba);
            }
            else
            {
                pierwszaKosc = new Kosc(0);
            }
            Console.WriteLine($"Liczba instancji klasy kosc - {Kosc.LiczbaInstancji}");
            Console.WriteLine($"Liczba oczek na pierwszej kosci - {pierwszaKosc.Wartosc}, slownie - {pierwszaKosc.zwrocTekst()}");
            Console.WriteLine($"Nazwa pliku odpowiadajaca wartosci - {pierwszaKosc.IdPlikuGraficznego}");

            Kosc drugaKosc = new Kosc();
            Console.WriteLine($"Liczba instancji klasy kosc - {Kosc.LiczbaInstancji}");
            Console.WriteLine($"Liczba oczek na drugiej kosci - {drugaKosc.Wartosc}, slownie - {drugaKosc.zwrocTekst()}");
            Console.WriteLine($"Nazwa pliku odpowiadajaca wartosci - {drugaKosc.IdPlikuGraficznego}");
            //}

        }
    }
}