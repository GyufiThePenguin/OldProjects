using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lézerlövészet
{
	class Program
	{
		static void Main(string[] args)
		{
			List<JatekosLovese> l = new List<JatekosLovese>();
			StreamReader olvaso = new StreamReader("lovesek.txt");
			string[] sor = olvaso.ReadLine().Split(';');
			JatekosLovese.celtablaKordináta[0] = Convert.ToDouble(sor[0]);
			JatekosLovese.celtablaKordináta[1] = Convert.ToDouble(sor[1]);
			int szamlalo = 1;
			while (!olvaso.EndOfStream)
			{
				l.Add(new JatekosLovese(olvaso.ReadLine(), szamlalo));
				szamlalo++;
			}

			Console.WriteLine(l.Count());
			Console.WriteLine("______");
			double min = l.Min(x => x.Távolság);
			foreach (var item in l.Where(x=>x.Távolság == min))
			{
				Console.WriteLine(item.sorszam + item.név);
			}

			Console.WriteLine(l.Count(x=> x.Pontszam == 0));

			Console.WriteLine(l.GroupBy(x=>x.név).Count());

			foreach (var item in l.GroupBy(x=>x.név))
			{
				Console.WriteLine(item.Key + " " + item.Count());
			}

			foreach (var item in l.GroupBy(x => x.név))
			{
				Console.WriteLine(item.Key + " " + item.Average(x=>x.Pontszam));
			}

			double max = l.GroupBy(x => x.név).Max(x => x.Average(y => y.Pontszam));
			foreach (var item in l.GroupBy(x=>x.név).Where(x=>x.Average(y=>y.Pontszam) == max))
			{
				Console.WriteLine(item.Key);
			}
			Console.WriteLine(l.GroupBy(x => x.név).First(x => x.Average(y => y.Pontszam) == max).Key);

			Console.WriteLine("Ki lőtte a legjobb lövést(ami a legközelebb van a középponthoz)");
			double legjobb = l.Min(x => x.Távolság);
			foreach (var item in l.Where(x=>x.Távolság == legjobb))
			{
				Console.WriteLine(item.név);
			}




		}
	}

	class JatekosLovese
	{
		public string név;
		public double[] kordináta = new double[2];
		public static double[] celtablaKordináta = new double[2];

		public int sorszam;
		public JatekosLovese(string sor, int sorszam)
		{
			string[] sorr = sor.Split(';');
			név = sorr[0];
			kordináta[0] = Convert.ToDouble(sorr[1]);
			kordináta[1] = Convert.ToDouble(sorr[2]);
			this.sorszam = sorszam;
		}

		public double Távolság
		{
			get
			{
				return Math.Sqrt(Math.Pow(celtablaKordináta[0] - kordináta[0], 2) + Math.Pow(celtablaKordináta[1] - kordináta[1], 2));
			}
		}

		public double Pontszam
		{
			get
			{
				return Math.Max(0, Math.Round(10 - Távolság, 2));
			}
		}



	}
}
