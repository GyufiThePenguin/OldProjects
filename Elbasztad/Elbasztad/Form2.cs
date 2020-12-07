using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elbasztad
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int s = 0;
        private void enable_Tick(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(s);
            label1.Refresh();
            s++;
        }
        Random r = new Random();
        private void Form2_Load(object sender, EventArgs e)
        {
            this.Top = (r.Next(0, Screen.PrimaryScreen.Bounds.Height));
            this.Left = (r.Next(0, Screen.PrimaryScreen.Bounds.Width));
        }
    }
}
