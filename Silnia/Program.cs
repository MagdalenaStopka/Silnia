using System;

namespace Silnia
{
    class Program
    {

        static void Main(string[] args)
        {
            int silnia = 0;
            
            Program p = new Program();
            Console.WriteLine("To jest program obliczający silnię w sposób iteracyjny oraz rekurentyjny \n");
            Console.WriteLine("Podaj z jakiej liczby program ma obliczyć silnię: ");
            silnia = int.Parse(Console.ReadLine());

            // p.SposobIteracyjny(silnia);
            Console.WriteLine("\nSilnia obliczona w sposób iteracyjny: " + sposobIteracyjny(silnia).ToString());

            Console.WriteLine("\nSilnia obliczona w sposób rekurencyjny: " + sposobRekurencyjny(silnia).ToString());
            Console.ReadKey();
        }

        public static long sposobIteracyjny(int silnia)
        {
            int i = 1;
            long wynikIteracyjny = 1;
            while (i <= silnia)
            {
                wynikIteracyjny = wynikIteracyjny * i;
                i++;
            }
           // Console.WriteLine("\nSilnia obliczona w sposób iteracyjny: " + wynikIteracyjny);
            return wynikIteracyjny;
        }

        public static long   sposobRekurencyjny(int silnia)
        {
            long wynikRekurencyjny = 1;
            if (silnia <= 0)
            {
                wynikRekurencyjny = 1;
            }
            else
            {
                wynikRekurencyjny = silnia * sposobRekurencyjny(silnia - 1);
            }
            return wynikRekurencyjny;
        }
    }
}

