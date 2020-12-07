using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consuela
{
    public partial class foform : Form
    {
        public foform()
        {
            InitializeComponent();
        }
        // Deklarálás__________________________________________________
        bool aktiv;
        Image villam;
        


        // FORM LOAD___________________________________________________
        private void foform_Load(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start(@"C:\Users\tothz\Desktop\Fájlok\Dagadek\Dagadek\bin\Debug\Dagadek.exe");

            villam = Image.FromFile("media/villam.png");
            pb_1.Image = villam;







        }

        private void foform_Activated(object sender, EventArgs e)
        {
            this.Hide();
            aktiv = false;
        }

        // BALLON IKON_____________________________________________________________________
        private void notifyIcon1_MouseDown(object sender, MouseEventArgs e)
        {
            if (aktiv)
            {
                this.Hide();
                aktiv = false;
                this.Refresh();
            }

            else if (!aktiv)
            {
                this.Show();
                aktiv = true;
                this.Refresh();
            }
        }
    }
}
