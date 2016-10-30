/* This software has been created by Ankit Sharma, Tushar Kawadkar under the guidance of Dileep Kumar Singh in visual studio 2012.
 * Under no circumstances should you copy this code without permission from the authors.*/



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

namespace CryptChat
{
    public partial class Form1 : Form
    {
        public bool disable=false;
        Socket sck;
        EndPoint epLocal, epRemote;
        byte[] buffer;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            TextLocalIP.Text = GetLocalIP();
            textRemoteIP.Text = GetLocalIP();
        }
        public string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";


        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
           
            epLocal = new IPEndPoint(IPAddress.Parse(TextLocalIP.Text), Convert.ToInt32(textLocalPort.Text));
           sck.Bind(epLocal);
           epRemote = new IPEndPoint(IPAddress.Parse(textRemoteIP.Text), Convert.ToInt32(textRemotePort.Text));
          sck.Connect(epRemote);
           buffer = new byte[1500];
            sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            groupBox3.Enabled = true;
            buttonConnect.Enabled = false;
        }
        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                byte[] receivedData = new byte[1500];
                receivedData = (byte[])aResult.AsyncState;
                ASCIIEncoding aEncoding = new ASCIIEncoding();
                string receivedMessage = aEncoding.GetString(receivedData);
                
                previewBox.Text = receivedMessage;
                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }


        }

    
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void encryptBTN_Click_1(object sender, EventArgs e)
        {
            string text = MainMessage.Text;
            
            char key = '|';

            StringBuilder temp = new StringBuilder(text);


            for (int i = 0; i < text.Length; i++)
            {
                temp[i] = Convert.ToChar(text[i] ^ key);

            }
            text = temp.ToString();
            previewBox.Text = text;
        }

        private void clearBTN_Click(object sender, EventArgs e)
        {
            previewBox.Text = "";
            MainMessage.Text = "";

        }

        private void MainMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void decryptBTN_Click_1(object sender, EventArgs e)
        {
            string text = previewBox.Text;
           
            char key = '|';

            StringBuilder temp = new StringBuilder(text);


            for (int i = 0; i < text.Length; i++)
            {
                temp[i] = Convert.ToChar(text[i] ^ key);

            }
            text = temp.ToString();
           MainMessage.Text = text;

        }

        private void aboutBTN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This software is the combined effort of:\n\n Ankit Sharma\n Tushar Kawadkar\n\n Special thanks to: \n\nDileep Kumar Singh ", "About Us", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sendBTN_Click_1(object sender, EventArgs e)
        {
            UTF8Encoding aEncoding = new UTF8Encoding();
            byte[] sendingMessage = new byte[1500];
            sendingMessage = aEncoding.GetBytes(previewBox.Text);
            sck.Send(sendingMessage);
            

        }

        private void groupBox3_Enter_1(object sender, EventArgs e)
        {

        }
    }
}
