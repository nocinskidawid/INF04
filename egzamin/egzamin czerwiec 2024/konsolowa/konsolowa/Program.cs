namespace konsolowa
{

    public class Kostki
    {
        private int[] kosci = new int[10];
        public int[] Kosci { get { return kosci; } private set { kosci = value; } }
        internal int inputParsed;

        internal void PobierzDane()
        {
            Console.WriteLine("Ile kostek chcesz rzucic?(3-10)");
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int parsed))
            {
                if (parsed < 3 || parsed > 10)
                {
                    throw new InvalidDataException("Liczba kosci musi byc z przedzialu 3-10");
                }
                else
                {
                    Losowanie(parsed);
                    inputParsed = parsed;
                }
            }
            else { throw new InvalidDataException("Podano bledne dane"); };
        }

        internal void Losowanie(int LiczbaKosci)
        {
            Random r = new Random();
            for (int i = 0; i < LiczbaKosci; i++)
            {
                Kosci[i] = r.Next(1, 6);
            }
        }

        internal int LiczPunkty()
        {
            int SumaPunktow;
            int suma1 = 0;
            int suma2 = 0;
            int suma3 = 0;
            int suma4 = 0;
            int suma5 = 0;
            int suma6 = 0;

            for (int i = 0; i < Kosci.Length; i++)
            {
                switch (Kosci[i])
                {
                    case 0: break;
                    case 1: suma1 += 1; break;
                    case 2: suma2 += 2; break;
                    case 3: suma3 += 3; break;
                    case 4: suma4 += 4; break;
                    case 5: suma5 += 5; break;
                    case 6: suma6 += 6; break;
                }
            }

            if (suma1 == 1) { suma1 = 0; }
            if (suma2 == 2) { suma2 = 0; }
            if (suma3 == 3) { suma3 = 0; }
            if (suma4 == 4) { suma4 = 0; }
            if (suma5 == 5) { suma5 = 0; }
            if (suma6 == 6) { suma6 = 0; }

            SumaPunktow = suma1 + suma2 + suma3 + suma4 + suma5 + suma6;
            return SumaPunktow;
        }

        internal void WyswietlDane(int suma)
        {
            for (int i = 0; i < inputParsed; i++)
            {
                Console.WriteLine($"Kostka {i+1}: {Kosci[i]}");
            }
            Console.WriteLine(suma);
        }
        public Kostki()
        {
            PobierzDane();
            int suma = LiczPunkty();
            WyswietlDane(suma);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Kostki k = new Kostki();
            //Console.WriteLine($"debug {string.Join(",", k.Kosci)}");
        }
    }
}
