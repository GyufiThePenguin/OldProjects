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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Feladat2 fel2 = new Feladat2();
            fel2.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Feladat3 fel3 = new Feladat3();
            fel3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Feladat4 fel4 = new Feladat4();
            fel4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Feladat5 fel5 = new Feladat5();
            fel5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Feladat6 fel6 = new Feladat6();
            fel6.Show();
        }

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
