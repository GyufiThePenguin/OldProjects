﻿using System;
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
using System.IO;

namespace Server_Client
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        public StreamReader STR;
        public StreamWriter STW;
        public string recive;
        public string TextToSend;

        public Form1()
        {
            InitializeComponent();

            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName()); // IP cím lekérése egy tömbe, mivel több fajta van
            foreach (IPAddress address in localIP)                      //      —
            {                                                           //      |
                if (address.AddressFamily == AddressFamily.InterNetwork)//      |
                {                                                       //      | Kikeresni az address tömbből at IPv4 címet
                    textBox1.Text = address.ToString();                 //      |
                }                                                       //      |
            }                                                           //      —
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TcpListener listener = new TcpListener(IPAddress.Any, int.Parse(textBox2.Text));
            listener.Start();
            client = listener.AcceptTcpClient();
            STR = new StreamReader(client.GetStream());
            STW = new StreamWriter(client.GetStream());
            string a = client.GetStream().ToString();
            STW.AutoFlush = true;

            backgroundWorker1.RunWorkerAsync();     // Elkezdi az adatok fogadását a háttérben
            backgroundWorker2.WorkerSupportsCancellation = true;


        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)  //Adat fogadás
        {
            while (client.Connected)
            {
                try
                {
                    recive = STR.ReadLine();
                    this.textBox6.Invoke(new MethodInvoker(delegate ()
                    {
                        textBox5.AppendText("Te: " + recive + "\n");
                    }));
                    recive = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e) //Adat küldés
        {
            if (client.Connected)
            {
                STW.WriteLine(TextToSend);
                this.textBox6.Invoke(new MethodInvoker(delegate ()
                {
                    textBox5.AppendText("Én: " + TextToSend + "\n");
                }));
            }
            else
            {
                MessageBox.Show("Hiba történt a küldés során!");
            }
            backgroundWorker2.CancelAsync();
        }

        private void button2_Click(object sender, EventArgs e) //Kapcsolódás a szerverhez
        {
            client = new TcpClient();
            IPEndPoint IpEnd = new IPEndPoint(IPAddress.Parse(textBox3.Text), int.Parse(textBox4.Text));
            try
            {
                client.Connect(IpEnd);
                if (client.Connected)
                {
                    textBox5.AppendText("Kapcsolódva a szerverhez" + "\n");
                    STR = new StreamReader(client.GetStream());
                    STW = new StreamWriter(client.GetStream());
                    STW.AutoFlush = true;
                    backgroundWorker1.RunWorkerAsync();
                    backgroundWorker2.WorkerSupportsCancellation = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox6.Text != "")
            {
                TextToSend = textBox6.Text;
                backgroundWorker2.RunWorkerAsync();
            }
            textBox6.Text = "";
        }
    }
}
