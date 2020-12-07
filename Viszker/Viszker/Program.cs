using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viszker
{
	class Program
	{
		static int[] X; 

		static void ViszKer()
		{
			X = new int[8];
			for ( int k=0; k<X.Length; ++k)
			{
				X[k] = -1;
			}

			int i = 0;
			while(i>=0 && i<X.Length)
			{
				if(VanJóEset(i))  //előre lép
				{
					++i;
				}
				else
				{
					X[i] = -1;
					--i;
				}
			}

			if(i==X.Length)
			{
				foreach (var item in X)
				{
					Console.Write(item+" ");
				}
			}
			else
				Console.WriteLine("Nincs mo");
		}



		static bool VanJóEset(int i)
		{
			++X[i];
			while (X[i] < 8 && !JóEset(i))
				++X[i];

			return X[i] < 8; 
		}

		static bool JóEset(int i)
		{
			int j = 0;
			while (j < i && !Ütközik(i, j))
				++j;

			return j == i;
		}

		static bool Ütközik(int i, int j)
		{
			return X[i] == X[j] || Math.Abs(i - j) == Math.Abs(X[i] - X[j]);
		}

		static void ViszKerMinden()
		{
			X = new int[8];
			for (int k = 0; k < X.Length; ++k)
			{
				X[k] = -1;
			}

			int i = 0;
			while (i >= 0)
			{
				if (VanJóEset(i))  //előre lép
				{
					++i;

					if(i==X.Length) //jobbra kiléptünk, van mo
					{
						foreach (var item in X)
						{
							Console.Write(item + " ");							
						}
						Console.WriteLine();
						--i;  //visszalépünk, hogy folytassa a probálgatást
					}
				}
				else
				{
					X[i] = -1;
					--i;
				}
			}

		}



		static void ViszKerMax()
		{
			X = new int[8];
			for (int k = 0; k < X.Length; ++k)
			{
				X[k] = -1;
			}

			int max = 0;
			int[] maxX = new int[X.Length];

			int i = 0;
			while (i >= 0)
			{
				if (VanJóEset(i))  //előre lép
				{
					++i;

					if (i == X.Length) //jobbra kiléptünk, van mo
					{
						int összeg = X.Sum();
						if (összeg > max)
						{
							max = összeg;
							maxX = (int[])X.Clone();
							
						}
						
						--i;  //visszalépünk, hogy folytassa a probálgatást
					}
				}
				else
				{
					X[i] = -1;
					--i;
				}
			}

			if(max>0)
			{
				foreach (var item in maxX)
				{
					Console.Write(item + " ");
				}
			}

		}


		static void Main(string[] args)
		{
			//ViszKer();
			//ViszKerMinden();
			ViszKerMax();
		}
	}
}
