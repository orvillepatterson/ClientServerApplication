//Orville Patterson-26090047    
//Joel Dean-26090055


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;


namespace OPJDServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(">> Advance Application Development Server Started");

            //creating new TCP listerner to listen for incoming connection
            TcpListener listener;
            //new TCP client
            TcpClient client = new TcpClient();

            IPAddress ip = IPAddress.Parse("127.0.0.1");

            int clientCount = 0;
            listener = new TcpListener(ip, 1500);

            listener.Start();
            Console.WriteLine("APP DEV SERVER IS WAITING FOR CONNECTIONS");
            while (true)
            {
                clientCount++;
                //accepting socket if request is made for a connection
                client = listener.AcceptTcpClient();
                //Indicating that the client has connected and has been started.
                Console.WriteLine(">>>>" + "Client No:" + Convert.ToString(clientCount) + " Started!");
                //creating a new instance of the client handler to handle messaging
                clientHandler handled = new clientHandler();    
                //starting the client communication and passing the client and its name to the client handler.
                handled.startClient(client, Convert.ToString(clientCount));


            }



        }



    }



    public class clientHandler
    {
        TcpClient clientelle;
        string clientID;

        public void startClient(TcpClient clientConnection, string number)
        {
            this.clientelle = clientConnection;
            this.clientID = number;
            //starting new thread that will handle messaging therefore allowing multple clients to be messaging while the server listens for new clients on the main thread.
            Thread clientThread = new Thread(Messaging);
            clientThread.Start();
        }

        //Function to handle messaging
        private void Messaging()
        {
            int count = 0;
            byte[] recievedBytes = new byte[100000];
            string recievedData = null;
            Byte[] bytestosend = null;
            string serverResponse = "Test";
            string resCount = null;

            while (true)
            {
                try
                {
                    count++;
                    //Acquring stream sent by the client
                    NetworkStream networkStream = clientelle.GetStream();
                    //reading network stream and reading from the start of the array to the point where the message ends and not reading empty bytes.
                    networkStream.Read(recievedBytes, 0, (int)clientelle.ReceiveBufferSize);
                    
                    //acquring string from byte array recieved
                    recievedData = System.Text.Encoding.ASCII.GetString(recievedBytes);
                   //reading message
                   recievedData = recievedData.Substring(0, recievedData.IndexOf("\0"));

                    Console.WriteLine(">>>>>> " + "From Client- #" + clientID +"  MSG:"+ recievedData);
                    resCount = Convert.ToString(count);

                    //action logic to determine approprate action
                    if (recievedData == "ADD")
                    {
                        serverResponse = "Server says to clinet(" + clientID + ") " + " You want to Add";
                    }
                    else if (recievedData == "DIVIDE")
                    {
                        serverResponse = "Server says to clinet(" + clientID + ") " + "You want to Divide";
                    }
                    else if (recievedData == "MINUS")
                    {
                        serverResponse = "Server says to clinet(" + clientID + ") " + "You want to Minus";
                    }
                    else
                    {
                        serverResponse = "Server says to clinet(" + clientID + ") " + "I dont understand your request try again";
                    }

                    //Responding to client
                    //encoding the reply message into a bytue array
                    bytestosend = Encoding.ASCII.GetBytes(serverResponse);
                    //writing to the network stream to send to message.
                    networkStream.Write(bytestosend, 0, bytestosend.Length);
                    networkStream.Flush();
                   

                }
                catch (Exception e)
                {
                    Console.WriteLine(">> " + e.ToString());
                }
            }
        }

    }
}
