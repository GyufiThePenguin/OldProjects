using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace UDP_fogadás
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		List<int> promList = new List<int>();
		// ThreadSave == Szálbiztos
		delegate void ListaMűvelet(string s);   //Függvénymutatók, (adott függvényróek nem mindik ugyanazt csinálják), később konkrét függvényt lehet hozzá állítani, += eseménykezelés egy fuggvény, majd utána egy másikatk, igy tovább a beállított függvények során. indirekt módon ér el egy másik szálat
		
		struct UdpAdatok
		{
			public IPEndPoint végpont;	// gép ip-je
			public UdpClient kliens;    //osztály
		}

		private void button1_Click(object sender, EventArgs e)
		{
			UdpAdatok a = new UdpAdatok();
			a.végpont = new IPEndPoint(IPAddress.Any, 0);
			a.kliens = new UdpClient(1001); // Ez a port
			a.kliens.BeginReceive(new AsyncCallback(FogadóSzál), a); // Fogadás elindítása, ,LÉtrehozott egy asszinkron szálat és elindította,
		}

		private void FogadóSzál (IAsyncResult a) //itt kapja meg a fenti a paramétert
		{
			UdpClient kliens = ((UdpAdatok)a.AsyncState).kliens;
			IPEndPoint végpont = ((UdpAdatok)a.AsyncState).végpont;
			Byte[] üzenet = kliens.EndReceive(a, ref végpont); //megkapjuk h honnan jött az üzenet IP címben
			String dekodoltüzenet = Encoding.UTF8.GetString(üzenet, 0, üzenet.Length); // Üzenet maga, honnantól, meddig. dekódolás byte[] - ből stringre
			   /* most a delegate*/
		   this.Invoke(new ListaMűvelet(Hozzáad), dekodoltüzenet);
			//Hozzáad(dekodoltüzenet);
			kliens.BeginReceive(new AsyncCallback(FogadóSzál), a.AsyncState);  // újraindítja a figyelő szálat
		}

		private void Hozzáad(string üzi)
		{
			listBox1.Items.Add(üzi);
			//promList.Add(int.Parse(üzi));
			//MessageBox.Show(promList[0].ToString());
		}
	}
}
