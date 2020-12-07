using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakk
{
    class Program
    {
        static int k;
        static void Main(string[] args)
        {
            bool[,] tábla = new bool[8,8];
            TáblaTörlés(tábla);

            //Lerak(tábla,6,2);
            k = 0;
            Start(tábla);
            Console.WriteLine(k);

            Kiír(tábla);
        }

        static void Start(bool[,] t, int mélység = 0, string knok = "")
        {
            //Kiír(t);
            if (mélység == 8)
            {
                Console.WriteLine(mélység + " - " +knok);
               // Kiír(t);
                k++;
                return;
            }
                      
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    bool[,] klon = (bool[,])t.Clone();
                    if (klon[i,j])
                    {
                        Lerak(klon, i, j);
                        Start(klon, mélység + 1, knok + " " + j +","+i);
                    }
                }
            }
        }

        static void Kiír(bool[,] tábla)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (tábla[i, j] == false)
                        Console.Write(" ▓ ");
                    else
                        Console.Write(" x ");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void TáblaTörlés(bool[,] tábla)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    tábla[i, j] = true;
                }
            }
        }

        static void Lerak(bool[,] tömb,int x, int y)
        {
            tömb[x, y] = false;
            //1. átló határ meghatározása      
            int y1;
            if (y - x < 0)
                y1 = 0;
            else
               y1 = y - x;

            int x1;
            if (x - y < 0)
                x1 = 0;
            else
                x1 = x - y;
            tömb[x1, y1] = false;//Átlóhatár
            //Átló1 meghúzása
            while (x1<8 && y1 < 8)
            {
                tömb[x1, y1] = false;
                x1++;
                y1++;
            }

            //2. átló határ meghatározása (nyilván, ez egy egyszerűbb módszer mint az 1. átló határnál, de elbasztam vele 1 órát és működik, úgyhogy bennemarad!)
            int y2 = y;
            int x2 = x;
            while (y2 > 0 && x2 !=7)
            {
                y2--;
                x2++;
            }
            tömb[y2, x2] = false;//átlóhatár
            //Átló2 meghúzása
            while (x2 >-1 && y2 < 8)
            {
                tömb[y2, x2] = false;
                y2++;
                x2--;
            }

            //y tengely egyenes húzás
            for (int Y = 0; Y < 8; Y++)
            {
                tömb[Y, y] = false;
            }

            //x tengely egyenes húzás
            for (int X = 0; X < 8; X++)
            {
                tömb[x, X] = false;
            }
        }
    }
}
