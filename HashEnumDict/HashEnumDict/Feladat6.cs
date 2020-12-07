using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;

namespace HashEnumDict
{
    public partial class Feladat6 : Form
    {
        public Feladat6()
        {
            InitializeComponent();
        }

        StreamReader olvaso = new StreamReader("tanarok.csv");
        List<Tanarok> tanarok = new List<Tanarok>();
        Random r = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            while (!olvaso.EndOfStream)
            {
                string[] s = olvaso.ReadLine().Split(';');
                tanarok.Add(new Tanarok{monG = s[0],nev =s[1]});
            }

            for (int i = 0; i < 10; i++)
            {
                new Thread(() =>
                {
                    int random = r.Next(0, tanarok.Count);
                    string valasz = Interaction.InputBox("A Rovidites: " + tanarok[random].monG, "Kerdes:", "",r.Next(0, (Screen.PrimaryScreen.Bounds.Width-this.Width)), r.Next(0, Screen.PrimaryScreen.Bounds.Height-this.Height));
                    if (valasz == tanarok[random].nev)
                        MessageBox.Show("Sikeresen kitalaltad " + tanarok[random].nev + " monogramjat :)");
                    else
                        MessageBox.Show("Elbasztad! " + tanarok[random].monG + " = " + tanarok[random].nev);
                }).Start();
            }
        }       
    }

    class Tanarok
    {
        public string monG;
        public string nev;
    }
}
