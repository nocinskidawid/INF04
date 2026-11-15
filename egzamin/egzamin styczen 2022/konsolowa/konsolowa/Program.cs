using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace konsolowa
{
    public class Sortowanie
    {
        public int[] tablica = new int[10];

        private int szukajMaxIndex(int j)
        {
            int max = j;

            for (int i = j ; i<tablica.Length; i++)
            {
                if (tablica[i] > tablica[max])
                {
                    max = i;
                }
            }

            return max;
        }

        public void sortuj()
        {
            int maxIndex;
            
            for (int i = 0 ; i < tablica.Length ; i++)
            {
                maxIndex = szukajMaxIndex(i);
                int temp = tablica[i];
                tablica[i] = tablica[maxIndex];
                tablica[maxIndex] = temp;
            }
        }

        public Sortowanie()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("podaj liczbe");
                int input = int.Parse(Console.ReadLine());
                tablica[i] = input;
            }

            Console.WriteLine($"nieposortowana tablica {string.Join(", ", tablica)}");
            sortuj();
            Console.WriteLine($"posortowana tablica {string.Join(", ", tablica)}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        Sortowanie sortowanie = new Sortowanie();

        }
    }
}
