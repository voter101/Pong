using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net.Sockets;
using System.IO;

namespace TCPClient {
    class Client {

        private static Client instance;
        private Thread thread;
        private TcpClient client;
        private String serverIP;
        private int serverPort;
        private Boolean connectionInitialized = false;

        private Client() { }

        public static Client Instance {
            get {
                if (instance == null)
                    instance = new Client();
                return instance;
            }
        }

        public void Initialize(String ip, int port) {
            if (Initialized())
                throw new Exception("TCP connection already initialized");
            serverIP = ip;
            serverPort = port;
            try {
                client = new TcpClient(ip, port);
                thread = new Thread(new ThreadStart(handleConnection));
                thread.Start();
            } catch (Exception e) {
                Console.WriteLine("Connection lost" + e.Message);
            }
        }

        private void handleConnection() {
            NetworkStream stream = client.GetStream();
            string message = "Chuj";
            while (true) {
                byte[] data = prepareMessage(message);
                stream.Write(data, 0, data.Length);
                Console.WriteLine("Message Sent: {0}", message);
                byte[] responeData = new byte[256];
                int bytes = stream.Read(responeData, 0, responeData.Length);
                String respone = System.Text.Encoding.ASCII.GetString(responeData, 0, bytes);
                if (respone != "1")
                    Console.WriteLine("Unexpected server respone");
            }
            stream.Close();
            client.Close();
            connectionInitialized = false;
        }

        private byte[] prepareMessage(string data) {
            return System.Text.Encoding.ASCII.GetBytes(data);
        }

        public Boolean Initialized() {
            return connectionInitialized;
        }

    }
}
