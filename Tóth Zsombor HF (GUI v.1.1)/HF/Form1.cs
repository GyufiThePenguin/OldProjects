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

namespace HF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // FeladatEngedelyez()  => feladat gombok engedélyezése
        // FelAtir()            => Átírja a feladatot a fejlécben
        // Kiir()               => MessageBox
        // Beker()              => InputBox

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 1024;
            this.Height = 600;
        }

        //█████████████████████████████████████████████████████████████████████████ Structs
        struct Adat
        {
            
        }

        //█████████████████████████████████████████████████████████████████████████ Előre deklarált
        StreamReader olvaso = new StreamReader(fajlnev, Encoding.Default);
        const string fajlnev = "alma.txt";
        int n;
        const int maxn = 0;

        //█████████████████████████████████████████████████████████████████████████ Válltozók
        Adat[] t = new Adat[maxn];

        //█████████████████████████████████████████████████████████████████████████ Gombok
        private void bt_beolvasas_Click(object sender, EventArgs e)
        {         
            
            FeladatEngedelyez();
        }
        private void bt_f1_Click(object sender, EventArgs e)
        {
           
        }

        private void bt_f2_Click(object sender, EventArgs e)
        {

        }

        private void bt_f3_Click(object sender, EventArgs e)
        {
            
        }

        private void bt_f4_Click(object sender, EventArgs e)
        {

        }

        private void bt_f5_Click(object sender, EventArgs e)
        {
                      
        }

        private void bt_f6_Click(object sender, EventArgs e)
        {
           
        }

        private void bt_f7_Click(object sender, EventArgs e)
        {                                                   
                        
        }                                                   

        private void bt_f8_Click(object sender, EventArgs e)
        {
            
        }

        private void bt_f9_Click(object sender, EventArgs e)
        {

        }

        private void bt_f10_Click(object sender, EventArgs e)
        {

        }

        private void bt_f11_Click(object sender, EventArgs e)
        {

        }

        private void bt_f12_Click(object sender, EventArgs e)
        {

        }

        //█████████████████████████████████████████████████████████████████████████ Függvégyek
        private void FeladatEngedelyez()
        {
            bt_f1.Enabled = true;
            System.Threading.Thread.Sleep(150);
            bt_f2.Enabled = true;
            System.Threading.Thread.Sleep(150);
            bt_f3.Enabled = true;
            System.Threading.Thread.Sleep(150);
            bt_f4.Enabled = true;
            System.Threading.Thread.Sleep(150);
            bt_f5.Enabled = true;
            System.Threading.Thread.Sleep(150);
            bt_f6.Enabled = true;
            System.Threading.Thread.Sleep(150);
            bt_f7.Enabled = true;
            System.Threading.Thread.Sleep(150);
            bt_f8.Enabled = true;
            System.Threading.Thread.Sleep(150);
            bt_f9.Enabled = true;
            System.Threading.Thread.Sleep(150);
            bt_f10.Enabled = true;
            System.Threading.Thread.Sleep(150);
            bt_f11.Enabled = true;
            System.Threading.Thread.Sleep(150);
            bt_f12.Enabled = true;

        }
        private void FelAtir(string szov)
        {
            la_szov.Text = "Feladat: " + szov;
        }
        private void Kiir(string szöveg)
        {
            MessageBox.Show(szöveg);
        }
        private string Beker (string szöveg)
        {
            return Microsoft.VisualBasic.Interaction.InputBox(szöveg);
        }
        

        //█████████████████████████████████████████████████████████████████████████ GUI elements
        private void la_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void la_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void la_jobbra_Click(object sender, EventArgs e)
        {
            if(this.Left < Screen.PrimaryScreen.Bounds.Width-this.Width)
            this.Left += 100;
        }

        private void la_fel_Click(object sender, EventArgs e)
        {
            if(this.Top >100)
                this.Top -= 100;
        }

        private void la_le_Click(object sender, EventArgs e)
        {
            if (this.Top < Screen.PrimaryScreen.Bounds.Height-200)
                this.Top += 100;
        }

        private void la_balra_Click(object sender, EventArgs e)
        {
            this.Left -= 100;
        }
    }
    //               `.`    ````                                                                      
    //             `.--.`.-----.                                                                      
    //            `----.------.`                                                                      
    //   `......``----------:------...`                                                               
    //    `..-------------------------.`                                                              
    //   ``..----------------------.``                                                                
    // `-------------------//:-------`         ..-----.`                            `.-..``..`        
    //`-------------------dMMMh:------.      .:::-...-:-.                           --.`` ```         
    //```.--------------./NMMMMN:--....     -::.      ...  --.    .-.  .-.   `..` -----.  ..`         
    //  `---.-------.-:+y::MMMMMs--.       .::.   ```````  -:-   ---` `-:.   ---  `--.`` .--`         
    //  ....---ohhs:/NNMMh/MMMMMs---`      -::`   ---:::`  .--  ---   .-:   .--`  `--`   .--          
    //     `---yMMM/oMMMMMNMMMMm:---.      .::.      -:-   `--.--.   `--.   ---   .--   `--`          
    //     `----::/+shhdy+-:/+/-----`       .----.-----.    -:--.    `---`.---`  `--.   .--           
    //     `-------/////://+-.-----.`         `.....``      .-:.      `...```.   `.``   ..`           
    //      `------.-:///:------...`                     `.---.                                       
    //        `.----.-////---....``                      ....`                                        
    //           ``...........``                                                                     

}
//█████████████████████████████████████████████████████████████████████████ Hazsnos parancsok
//██ DataGridView
//dataGridView1.Rows.Add();
//dataGridView1.Rows[i].Cells[0].Value = t[i].ar;
//██ Array.ConvertAll(olvaso.ReadLine().Split(' '), int.Parse);