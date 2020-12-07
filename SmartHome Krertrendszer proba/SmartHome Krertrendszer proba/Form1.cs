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

namespace SmartHome_Krertrendszer_proba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FogadásIndítása(); // eggyértelmű h mit csinál
        }

        //============================================================================================== Küldés
        private void Küld(string uzenet, string IP, string Port)
        {
            IPEndPoint végpont = new IPEndPoint(IPAddress.Parse(IP), Convert.ToInt16(Port));
            UdpClient kliens = new UdpClient();
            Byte[] üzenet = Encoding.UTF8.GetBytes(uzenet);
            kliens.Send(üzenet, üzenet.Length, végpont);

            kliens.Close();
        }
        //============================================================================================== Fogadás deklarálássa
        class UdpAdatok
        {
            public IPEndPoint végpont; // A gép IP-je
            public UdpClient kliens;
        }
        //============================================================================================== Fogadás indítása 
        private void FogadásIndítása()
        {
            UdpAdatok adatok = new UdpAdatok();
            adatok.végpont = new IPEndPoint(IPAddress.Any, 0);
            adatok.kliens = new UdpClient(5443); // Port
            adatok.kliens.BeginReceive(new AsyncCallback(Fogadószál), adatok);
        }
        // Delegate
        delegate void ListaMűvelet(string s);
        //============================================================================================== Fogadószál + újraindítás 
        private void Fogadószál(IAsyncResult a)
        {
            UdpClient kliens = ((UdpAdatok)a.AsyncState).kliens;
            IPEndPoint végpont = ((UdpAdatok)a.AsyncState).végpont;
            Byte[] üzenet = kliens.EndReceive(a, ref végpont); // Küldő gép IP-je
            string küzenet = Encoding.UTF8.GetString(üzenet, 0, üzenet.Length);

            this.Invoke(new ListaMűvelet(Feldolgozó), küzenet);

            kliens.BeginReceive(new AsyncCallback(Fogadószál), a.AsyncState); // fogadás újraindítása
        }
        //============================================================================================== Feldolgozó        
        private void Feldolgozó(string parancs)
        {
            label1.Text = parancs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Küld("asd", "192.168.0.16", "5443");
        }
    }
}
