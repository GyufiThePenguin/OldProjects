using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nitroglicerin
{
	class Program
	{
		//N liter nitroglicerint el tudunk-e szállítani H hordokban, a hordóknak tele kell lenni, különben robban

		static int N = 10;
		static int[] H = { 3, 3, 3, 2, 2 };

		static int[] X;  //2 érték, 0: üres, 1: tele a hordó

		static void ViszKer()
		{
			X = new int[H.Length];
			for (int k = 0; k < X.Length; ++k)
			{
				X[k] = -1;
			}

			bool Van = false;

			int i = 0;
			while (i >= 0)
			{
				if (VanJóEset(i))  //előre lép
				{
					int s = Összeg(i);
					if(Összeg(i)==N)
					{
						Van = true;
						break;
					}

					++i;

					if (i == X.Length)
						--i;
				}
				else
				{
					X[i] = -1;
					--i;
				}
			}

			if (Van)
			{
				foreach (var item in X)
				{
					Console.Write(item + " ");
				}
			}
			else
				Console.WriteLine("Nincs mo");
		}



		static bool VanJóEset(int i)
		{
			++X[i];
			while (X[i] < 2 && !JóEset(i))
				++X[i];

			return X[i] < 2;
		}

		static int Összeg(int i)//Összeadja az idik hordóig a megtöltött hordók térfogatát
		{
			int s = 0;
			for (int j = 0; j <= i; ++j)
				if (X[j] == 1)
					s += H[j];
			return s;
		}

		static bool JóEset(int i)
		{			
			return Összeg(i)<=N;
		}

		



		static void Main(string[] args)
		{
			ViszKer();
		}
	}
}
