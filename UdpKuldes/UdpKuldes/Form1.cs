using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace UdpKuldes
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			IPEndPoint végpont = new IPEndPoint(IPAddress.Parse(textBox1.Text), Convert.ToInt16(textBox2.Text));
			UdpClient kliens = new UdpClient();
			Byte[] üzenet = Encoding.UTF8.GetBytes(textBox3.Text);
			kliens.Send(üzenet, üzenet.Length, végpont);

			kliens.Close();
		}
	}
}
