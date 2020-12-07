using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rekurzio
{
    class Program
    {
        static void Main(string[] args)
        {
            int osszeg = 0;
            Console.WriteLine("Adjon meg egy számot, a program kiírja a szám faktoriálisát.");
            int faktSzam = Convert.ToInt32(Console.ReadLine());
            osszeg = Faktorialis(faktSzam);
            Console.WriteLine(osszeg);

            Console.ReadKey();
        }
        public static int Faktorialis(int hamham)
        {
            if (hamham == 1)
            {
                return 1;
            }
            else
            {
                return hamham * Faktorialis(hamham - 1);
            }
            
        }
    }
}
