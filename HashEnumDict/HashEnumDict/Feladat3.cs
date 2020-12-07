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
    public partial class Feladat3 : Form
    {
        public Feladat3()
        {
            InitializeComponent();
        }

        Random r = new Random();
        HashSet<int> lottoSzamok = new HashSet<int>();

        private void button1_Click(object sender, EventArgs e)
        {
            lottoSzamok.Clear();
            label1.Text = "";
            while (lottoSzamok.Count!=5)
            {
                lottoSzamok.Add(r.Next(1,100));
            }

            foreach (var x in lottoSzamok)
            {
                label1.Text += x + ", ";
            }
        }
    }
}
