namespace konsolowa
{

    public class sitoArystotelesa
    {
        static int n = 100;
        private bool[] tablicaLogiczna = new bool[n];
        
        internal void wypelnijTblice(bool[] tablica)
        {
            for (int i = 2;  i <= Math.Sqrt(n); i++)
            {
                if (tablica[i]) 
                {
                    for(int j = 2; j*i<n; j++)
                    {
                    tablica[j*i] = false;
                    }
                }
            }
        }

        public sitoArystotelesa() 
        {

            for( int i = 0; i < n; i++)
            {
                tablicaLogiczna[i] = true;
            }
            wypelnijTblice(tablicaLogiczna);
            for(int i = 2; i < n; i++)
            {
                if (tablicaLogiczna[i])
                {
                    Console.WriteLine($"{i} to liczba pierwsza");
                }
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            sitoArystotelesa s = new sitoArystotelesa();
        }
    }
}
