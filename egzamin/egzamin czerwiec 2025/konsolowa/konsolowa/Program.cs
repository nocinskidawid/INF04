namespace konsolowa
{

    public class Losowanie
    {
        public Losowanie(int input)
        {
            int[][] losy = losuj(input);
            wyswietlWyniki(losy, input);
        }

        internal int[][] losuj(int input)
        {
            Random r = new Random();
            int[][] losy = new int[input][];
            for (int i = 0; i < input; i++)
            {
                losy[i] = new int[6];
                int[] wylosowane = { 0, 0, 0, 0, 0, 0 };
                for (int j = 0; j < 6; j++)
                {
                    int wylosowana = 0;
                    int k = 0;
                    while (wylosowane[5]==0)
                    {
                        wylosowana = r.Next(1, 49);
                        if (!wylosowane.Contains(wylosowana))
                        {
                            losy[i][k] = wylosowana;
                            wylosowane[k] = wylosowana;
                            k++;
                        }
                    }

                }
            }
            return losy;
        }

        public void wyswietlWyniki(int[][] losy, int input)
        {
            //wyswietlanie zestawow liczb
            Console.WriteLine("Zestawy wylosowanych liczb:");
            int n = 1;
            foreach (int[] l in losy)
            {
                Console.WriteLine($"Losowanie {n}: {string.Join(",", l)}");
                n++;
            }
            //wyswietlanie liczby wystapien
            for (int i = 1;i < 49; i++)
            {
                int wystapienia = 0;
                for(int j = 0; j <input; j++)
                {
                    for(int k = 0; k < 6; k++)
                    {
                        if (losy[j][k] == i)
                        {
                            wystapienia++;
                        }
                    }
                }
                Console.WriteLine($"Wystapienia liczby {i}: {wystapienia}");
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ile wygenerowac losowan?");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int parsed))
            {
                Losowanie l = new Losowanie(parsed);
            }
            else
            {
                throw new InvalidDataException("Podaj liczbe");
            }
        }
    }
}
