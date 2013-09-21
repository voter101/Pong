using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPClient
{
    class Program
    {
        static void Main(string[] args)
        {
            String ip = "127.0.0.1";
            Client tcpClient = Client.Instance;
            tcpClient.Initialize(ip, 1337);
            Console.WriteLine("Kuniec");
            Console.ReadKey();
        }
    }
}
