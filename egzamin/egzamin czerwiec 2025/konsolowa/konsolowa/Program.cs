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
                for (int j = 0; j < 6; j++)
                {
                    losy[i][j] = r.Next(1,49); //todo brak powtarzania
                }
            }
            return losy; 
        }

        public void wyswietlWyniki(int[][] losy, int input)
        {
            Console.WriteLine("Zestawy wylosowanych liczb:");
            int j = 1;
            foreach (int[] l in losy)
            {
                Console.WriteLine($"Losowanie {j}: {string.Join(",", l)}");
                j++;
            } // todo zliczanie wystapien
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ile wygenerowac losowan?");
            string input = Console.ReadLine();
            if(int.TryParse(input, out int parsed))
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
