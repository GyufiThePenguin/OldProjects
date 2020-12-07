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
    public partial class Feladat4 : Form
    {
        public Feladat4()
        {
            InitializeComponent();
        }

        enum Osztalyzatok
        {
            elégtelen = 0,
            elégséges,
            közepes,
            jó,
            jeles
        };


        Random r = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add((Osztalyzatok) r.Next(0, 5));
            }
        }
    }
}
