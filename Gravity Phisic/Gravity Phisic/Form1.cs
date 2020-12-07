using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gravity_Phisic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            box.Height = 50;
            box.Width = 50;    
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            var relativePoint = this.PointToClient(Cursor.Position);
            box.Top = relativePoint.Y;
            box.Left = relativePoint.X;
           
            Gravity(box);       
        }

        public void Gravity(Label la)
        {
            int speed = 0;
            bool onPlatform = false;
            while (!onPlatform)
            {
                if (speed < 50)
                    speed++;
                la.Top += speed;

                if (la.Top + la.Height >= this.Height - la.Height)
                {
                    if (speed > 5)
                    {
                        speed *= -1;
                    }

                    if (speed < 5)
                    {
                        onPlatform = true;
                    }
                }
                System.Threading.Thread.Sleep(30);
            }
        }
    }
}
