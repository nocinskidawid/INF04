namespace ConsoleApp1
{
    internal class Program
    {

        public static class Rzeczy {

            public static string pesel = "55030101193";

            /*
             nazwa funkcji:         Jakaplec
             opis funkcji:          funkcja sprawdza jaka jest plec na podstawie peselu
             parametry:             string pesel-nr pesel w postaci łancucha znakow
             zwracany typ i opis:   char K-po peslu okresla plec na kobiete, char M-po peslu okresla plen na mezczyzne
             autor:                 2 pedalow i cwel
             
             */
            public static char Jakaplec(string pesel) {
                
                int cyfra = int.Parse(pesel.Substring(9, 1));
                if (cyfra % 2 == 0)
                {
                    return 'K';
                }
                else { 
                    return 'M';
                }               
            }
            
            public static bool sumaKontrolna(string pesel) {

                int s = 0;
                int r;
            
                for(int i = 0; i < pesel.Length-1; i++)
                {
                    int cyfraI = int.Parse(pesel.Substring(i, 1));

                    if(i+1 == 1 || i + 1 == 5 || i + 1 == 9)
                    {
                        s += 1 * cyfraI;
                    }
                    if (i + 1 == 2 || i + 1 == 6 || i + 1 == 10)
                    {
                        s += 3 * cyfraI;
                    }
                    if (i + 1 == 3 || i + 1 == 7)
                    {
                        s += 7 * cyfraI;
                    }
                    if (i + 1 == 4 || i + 1 == 8)
                    {
                        s += 9 * cyfraI;
                    }
                    //Console.WriteLine($"{cyfraI}, suma{s}");
                }
                int m = s % 10;
                if (m == 0)
                {
                    r = 0;
                }
                else
                {
                    r = 10 - m;
                }

                //Console.WriteLine($"Debug suma-{s}, m-{m}, r-{r}");

                if (r == int.Parse(pesel.Substring(10, 1))){
                    return true;
                }
                else
                {
                    return false;
                }


            }

        
        }




        static void Main(string[] args)
        {
            Console.WriteLine("Podaj Pesel:");
            Rzeczy.pesel = Console.ReadLine();
            Console.WriteLine(Rzeczy.Jakaplec(Rzeczy.pesel));

            if (Rzeczy.sumaKontrolna(Rzeczy.pesel)){
                Console.WriteLine("Pesel poprawny");
            }
            else
            {
                Console.WriteLine("Niepoprawny pesel");
            }
        }
    }
}
