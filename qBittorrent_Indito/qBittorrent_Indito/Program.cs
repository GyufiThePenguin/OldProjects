using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  System.IO;
using System.Threading;

namespace qBittorrent_Indito
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("qBittorrent ellenörzése...");
            Thread.Sleep(1000 * 3);
            if (File.Exists(@"E:\ellenorzo.txt"))
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("Helyi lemez E: észlelve \n qBittorent indítása...");
                Directory.SetCurrentDirectory(@"C:\Program Files\qBittorrent");
                Process.Start("qbittorrent.exe");
                Console.WriteLine("A qBittorrent indítása sikeres.");
                Thread.Sleep(1000 * 2);
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.Clear();
                Console.WriteLine("A qBittorrent indítása nem sikerült.");
                Console.ReadKey();
            }
        }
    }
}
