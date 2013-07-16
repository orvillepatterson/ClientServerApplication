using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;


namespace JDOPClients
{
    class Comm
    {
        TcpClient client = new TcpClient();
       //Connect function to handle making a connection to the server.
        public void connect(RichTextBox t, Label l)
        {
            Talker(t, "Online");

            client.Connect("127.0.0.1", 1500);
            l.Text = "Client Connected to Advance Application Server";
            
        }

        //Connunicate function to deal with sending and recieving
        public void communicate(string action,RichTextBox box)
        {
            NetworkStream stream = client.GetStream();
            byte[] sending = System.Text.Encoding.ASCII.GetBytes(action);
            stream.Write(sending, 0, sending.Length);
            stream.Flush();

            byte[] recieve = new byte[1000000];
            stream.Read(recieve, 0,  (int)client.ReceiveBufferSize);
            string data = Encoding.ASCII.GetString(recieve);
            Talker(box, "Data from Server : " + data);


        }

    

        public void Talker(RichTextBox n, string message)
        {
            n.Text = n.Text + Environment.NewLine + ">>> " + message;

        }

    }
}
