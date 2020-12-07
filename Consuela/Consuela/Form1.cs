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
    public partial class fr_load : Form
    {
//DEKLARÁLÁS____________________________________________________________________
        int a;
        byte ido;
        Image image;

        public fr_load()
        {   
            InitializeComponent();
// ELEMEK_____________________________________________________________________
            Random r = new Random();
            ido = 0;
            a = r.Next(1,7);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
// ELHEJEZÉS______________________________________________________________________
            this.Left = Screen.PrimaryScreen.Bounds.Width/2 - this.Width/2;
            this.Top = Screen.PrimaryScreen.Bounds.Height/2 - this.Height/2;
            this.Width = 20 * Screen.PrimaryScreen.Bounds.Width / 100;
            this.Height = 20 * Screen.PrimaryScreen.Bounds.Height / 100;
            la_consuela.Top = 0;
            la_consuela.Left = 0;
            la_consuela.Width = this.Width;
            la_consuela.Height = 20 * this.Height / 100;
            pb_load.Left = 0;
            pb_load.Top = la_consuela.Height;
            pb_load.Width = la_consuela.Width;
            pb_load.Height = this.Height - la_consuela.Height;

// PB_ TULAJDONSÁGOK_________________________________________________________________________
            image = Image.FromFile("media/load1.gif");
            pb_load.Image = image;          
        }

// TIMER ÜT__________________________________________________________________________________
        private void timer1_Tick(object sender, EventArgs e)
        {
            ido++;

// BETÖLTÉS BEFEJEZVE________________________________________________________________________
            if (ido == a)
            {
                image = Image.FromFile("media/villam.png");
                pb_load.Image = image;
                pb_load.SizeMode = PictureBoxSizeMode.StretchImage;
                pb_load.Refresh();
                timer1.Enabled = false;

                this.Height = 10 * Screen.PrimaryScreen.Bounds.Height / 100;

                pb_load.Top = 5;
                pb_load.Left = 5;
                pb_load.Width = this.Height - 10;
                pb_load.Height = this.Height - 10;
                la_consuela.Top = 0;
                la_consuela.Left = pb_load.Width + 10;
                la_consuela.Width = this.Width - (pb_load.Width + 10);
                la_consuela.Height = this.Height;
                la_consuela.Text = "Szia! :)";
                this.Refresh();
                System.Threading.Thread.Sleep(4000);

                for (int i = 100; i > 50; i--)
                {
                    System.Threading.Thread.Sleep(40);
                    this.Opacity -= .1;
                }

                Application.Exit(); // Nem kell

                this.Visible = false;
                foform kezelo = new foform();
                kezelo.ShowDialog();
                this.Hide();




            }
        }
    }
}
