namespace konsolowa
{

    public class Euklides 
    { 
        public Euklides(int a, int b)
        {
            if (a <= 0 || b <= 0)
            {
                throw new ArgumentOutOfRangeException("Liczby musza byc dodatnie");
            }
            else
            {
                int wynik = algorytm(a, b);
                Console.WriteLine($"Najwiekszy wspolny dzielnik liczb {a}, i {b} to {wynik}");
            }
        }

        internal int algorytm(int a, int b)
        {
            while(a!=b)
            {
                if(a>b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            return a;

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                Console.WriteLine("Podaj a:");
                string input1 = Console.ReadLine();
                if (!int.TryParse(input1, out int a))
                {
                    throw new InvalidDataException("Nalezy podac liczbe calkowita");
                }
                Console.WriteLine("Podaj b:");
                string input2 = Console.ReadLine();
                if (!int.TryParse(input2, out int b))
                {
                    throw new InvalidDataException("Nalezy podac liczbe calkowita");
                }
                Euklides eu = new Euklides(a, b);
            }
        }
    }
}
