using System;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Net.Http;

namespace UDPMoldProjectListener
{
    class Program
    {
        private static string APIURL = "http://localhost:23864/api/MoldProjectAPI";
        static void Main(string[] args)
        {
            Console.WriteLine("UDP Listener");

            
            using (UdpClient socket = new UdpClient())
            {
                
                socket.Client.Bind(new IPEndPoint(IPAddress.Any, 10100));
                                
                using (HttpClient client = new HttpClient())
                {                   
                    while (true)
                    {                        
                        IPEndPoint from = null;
                       
                        byte[] data = socket.Receive(ref from);
                        
                        string recieved = Encoding.UTF8.GetString(data);
                        Console.WriteLine("Server receieved: " + recieved + " From " + from.Address);
                                                
                        HttpContent content = new StringContent(recieved, Encoding.UTF8, "application/json");
                        
                        client.PostAsync(APIURL, content);
                    }
                }
            }
        }

        
    }
}
