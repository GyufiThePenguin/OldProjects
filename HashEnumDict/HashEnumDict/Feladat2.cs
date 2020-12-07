using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HashEnumDict
{
    public partial class Feladat2 : Form
    {
        public Feladat2()
        {
            InitializeComponent();
        }

        private int dobasSzam;
        Random r = new Random();
        private Dictionary<int, int> szam = new Dictionary<int, int>()
        {
            {1, 0},
            {2, 0},
            {3, 0},
            {4, 0},
            {5, 0},
            {6, 0}
        };

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (textBox1.Text != "" && int.Parse(textBox1.Text) > 0)
                dobasSzam = Convert.ToInt32(textBox1.Text);
            else
                MessageBox.Show("Rossz szamot adtal meg!");
            for (int i = 0; i < dobasSzam; i++)
            {
                szam[r.Next(1, 7)]++;
            }
            listBox1.Items.Add(dobasSzam + "-szor dobva.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var x in szam)
            {
                if (x.Value>0)
                {
                    for (int i = 0; i < x.Value; i++)
                    {
                        listBox1.Items.Add(x.Value);
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var x in szam)
            {
                if (x.Value!=0)
                {
                    listBox1.Items.Add(x.Key + " szam ennyoiszer lett kidobva: " + x.Value);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var x in szam)
            {
                if (x.Value != 0)
                {
                    listBox1.Items.Add(x.Key + " szam ennyoiszer lett kidobva: " + x.Value);
                }
            }
        }
    }
}
