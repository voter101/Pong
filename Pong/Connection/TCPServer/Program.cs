using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Server server = Server.Instance;
            server.Initialize(1337);
            Console.ReadKey();
        }
    }
}
