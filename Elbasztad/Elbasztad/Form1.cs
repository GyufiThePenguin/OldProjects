using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Microsoft.VisualBasic;

namespace Elbasztad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            Application.Exit();
        }
        Random r = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Top = (r.Next(0, Screen.PrimaryScreen.Bounds.Height-100));
            this.Left = (r.Next(0, Screen.PrimaryScreen.Bounds.Width-100));
        }
        Form2 f2 = new Form2();
        int s = 5;
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "You have " + s + " seconds to close!";
            label1.Refresh();
            s--;
            if(s==0)
            {
                Thread.Sleep(1000);
                timer2.Enabled = true;
                timer1.Enabled = false;
            }

        }
        private int j = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                string valasz = Interaction.InputBox("A Rovidites: ", "Kerdes:", "", r.Next(0, (Screen.PrimaryScreen.Bounds.Width)), r.Next(0, Screen.PrimaryScreen.Bounds.Height));
            }).Start();           
        }
    }
}
