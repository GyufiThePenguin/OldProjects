using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HashEnumDict
{
    public partial class Feladat5 : Form
    {
        public Feladat5()
        {
            InitializeComponent();
        }

        StreamReader olvaso =new StreamReader("osztalyok.csv");

        Dictionary<string,Osztaly> t = new Dictionary<string, Osztaly>();

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            while (!olvaso.EndOfStream)
            {
                string[] sor = olvaso.ReadLine().Split(';');
                t.Add(sor[0],new Osztaly(sor[1], sor[2], sor[3]));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (t.ContainsKey(textBox1.Text))               
                listBox1.Items.Add("Osztalyfönök: " +t[textBox1.Text].Ofö + " \nTerem: " + t[textBox1.Text].Terem + " \nÖltözö: " + t[textBox1.Text].Öltözö);
            else
            {
                listBox1.Items.Add("Nincs ilyen osztaly! \nLehetösegek: ");
                foreach (var x in t)
                {
                    listBox1.Items.Add(x.Key);
                }
            }

        }

        class Osztaly
        {
            private string ofö;
            private string terem;
            private string öltözö;

            public Osztaly(string ofö, string terem, string öltözö)
            {
                this.ofö = ofö;
                this.terem = terem;
                this.öltözö = öltözö;
            }

            public string Ofö
            {
                get { return ofö; }
            }
            public string Terem
            {
                get { return terem; }
            }
            public string Öltözö
            {
                get { return öltözö; }
            }
        }
    }
}
