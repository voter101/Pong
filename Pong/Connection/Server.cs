using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net.Sockets;
using System.Net;

namespace TCPServer {
    class Server {
        private static Server instance;
        private Thread thread;
        private TcpListener connectionListener;
        private TcpClient client;
        private Socket connectionSocket;
        private Boolean connectionInitialized = false;
        private ushort serverPort;
        private Queue messageQue;
        private string ipClient;
        private byte[] ack;

        public string AckMessage {
            get {
                return System.Text.Encoding.ASCII.GetString(ack, 0, ack.Length);
            }
            set {
                ack = System.Text.Encoding.ASCII.GetBytes(value);
            }
        }

        private Server() { }

        public static Server Instance {
            get {
                if (instance == null) {
                    instance = new Server();
                    instance.AckMessage = "1";
                }
                return instance;
            }
        }

        /**
        * Note: We want to have only 1 client
        */
        public void Initialize(ushort port) {
            if (Initialized())
                throw new Exception("TCP Server already initialized");
            serverPort = port;
            System.Net.IPAddress ip = System.Net.IPAddress.Parse("127.0.0.1");
            try {
                connectionListener = new TcpListener(ip, serverPort);
                connectionListener.Start();
                client = connectionListener.AcceptTcpClient();
                Console.WriteLine("Server is running on " + connectionListener.LocalEndpoint);
                connectionInitialized = true;
                thread = new Thread(new ThreadStart(handleConnection));
                thread.Start();
            } catch (SocketException e) {
                Console.WriteLine("Connection uninitialized\n" + e.Message);
                Stop();
            }
        }

        public string GetClientIP() {
            if (!client.Connected)
                throw new Exception("Client connection uninitialized");
            return IPAddress.Parse(((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString()).ToString();
        }

        private void handleConnection() {
            NetworkStream stream = client.GetStream();
            byte[] message = new byte[4096];
            int bytesRead;
            ASCIIEncoding encoder = new ASCIIEncoding();
            try {
                while (true) {
                    bytesRead = 0;
                    bytesRead = stream.Read(message, 0, 4096);
                    if (bytesRead == 0)
                        throw new Exception("Disconnected");
                    System.Console.WriteLine(encoder.GetString(message, 0, bytesRead));
                    stream.Write(ack, 0, ack.Length);
                }
            } catch {
                Console.WriteLine("Conenction error");
            }
            Stop();
        }

        private byte[] prepareMessage(string data) {
            return System.Text.Encoding.ASCII.GetBytes(data);
        }

        public void Stop() {
            client.Close();
            connectionListener.Stop();
            connectionInitialized = false;
        }

        private void saveMessage(string message) {
            messageQue.Enqueue(message);
        }

        public string GetMessage() {
            if (!Initialized())
                throw new Exception("Connection not initialized");
            return (string) messageQue.Dequeue();
        }

        public Boolean Initialized() {
            return connectionInitialized;
        }
    }
}