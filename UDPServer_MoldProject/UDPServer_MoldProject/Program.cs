using System;
using System.Net.Sockets;
using System.Net;
using System.Text;

namespace UDPServer_MoldProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("UDP Server");
            StartListener();
        }

        public static void StartListener()
        {
            using (UdpClient socket = new UdpClient())
            {
                socket.Client.Bind(new IPEndPoint(IPAddress.Any, 9999));

                while (true)
                {
                    IPEndPoint from = null;
                    byte[] data = socket.Receive(ref from);
                    string recieved = Encoding.UTF8.GetString(data);
                    Console.WriteLine("Server receieved: " + recieved);
                    Console.WriteLine("Client address: " + from.Address);

                    socket.Send(data, data.Length, from);
                }
            }
        }
    }
}
