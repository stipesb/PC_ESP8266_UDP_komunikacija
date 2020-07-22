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
using System.Net.Sockets;     // biblioteke za sockete slanje/primanje udp paketa



namespace UDP_PCESP_komunikacija
{
    public partial class Form1 : Form

    {


        UdpClient klijent;                         // defaultni konstruktori
        IPEndPoint odrediste;

        int TIPKA1 = 0, TIPKA2 = 0, TIPKA3 = 0;  // ovisno je li tipka uprita vraca true ili false



        public Form1()
        {
            InitializeComponent();

            IPracunala.Text = getIPAddress();   // cita ip adresu racunala, te je ispisuje u textbox

          
            

        }

        private void IPracunala_TextChanged(object sender, EventArgs e)
        {

        }

        private void IPodredista_TextChanged(object sender, EventArgs e)
        {

        }

        private void PORT_TextChanged(object sender, EventArgs e)
        {

        }

        private void Zapocni_Click(object sender, EventArgs e)
        {

            


           odrediste = new IPEndPoint(IPAddress.Parse(IPodredista.Text), int.Parse(PORT.Text));    // ip i port odredišta

            klijent = new UdpClient();                      // konstruktor za Klijent-a

            klijent.Connect(odrediste);                       // slanje paketa na odredište u kojem su prosljeđeni parametri ip adrese i port


            timer1.Start();

        }




      

        private void slider_Scroll(object sender, EventArgs e)
        {

        }

        private void tipka1_Click(object sender, EventArgs e)
        {

            if(TIPKA1 == 0)
               TIPKA1 = 1;
            else
               TIPKA1 = 0;


        }

        private void tipka2_Click(object sender, EventArgs e)
        {
            if (TIPKA2 == 0)
                TIPKA2 = 1;
            else
                TIPKA2 = 0;

        }

        private void tipka3_Click(object sender, EventArgs e)
        {
            if (TIPKA3 == 0)
                TIPKA3 = 1;
            else
                TIPKA3 = 0;

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {


           // string a =  slider.Value.ToString(); // uzima vrijednost slidera te prebacuje int u string
            string b =  TIPKA1.ToString();
            string c =  TIPKA2.ToString();
            string d =  TIPKA3.ToString();

            string poruka = b + c + d;

            Byte[] sendBytes = Encoding.ASCII.GetBytes(poruka);  // pakira podatke "poruke", u oblik pogodan za slanje internetom 

            klijent.Send(sendBytes, sendBytes.Length);   // slanje podataka koji se nalaze u string varijabli "poruka"

 
        }

        private string getIPAddress()
        {

            //Get all local IP addresses
            IPHostEntry ipe = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress[] ip = ipe.AddressList;
            for (int i = 0; i < ip.Length; i++)
            {
                if (ip[i].AddressFamily.ToString().Equals("InterNetwork"))
                {

                    return ip[i].ToString();
                }
            }
            return null;
        }


     

    }
}
