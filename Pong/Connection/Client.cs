using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net.Sockets;
using System.IO;

namespace Pong.Connection {
    public class Client {

        private static Client instance;
        private TcpClient client;
        private String serverIP;
        private int serverPort;
        private Boolean connectionInitialized = false;
        private Thread thread;
        private Queue messageQue;

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
                connectionInitialized = true;
                thread = new Thread(new ThreadStart(handleConnection));
                thread.Start();
            } catch (SocketException e) {
                Console.WriteLine("Connection uninitialized\n" + e.Message);
                Close();
            }
        }

        private void handleConnection() {
            messageQue = new Queue();
            NetworkStream stream = client.GetStream();
            try {
                while (true) {
                    string message = (string)messageQue.Dequeue();
                    if (message == null)
                        continue;
                    byte[] data = prepareMessage(message);
                    stream.Write(data, 0, data.Length);
                    Console.WriteLine("Message Sent: {0}", message);
                    byte[] responeData = new byte[256];
                    int bytes = stream.Read(responeData, 0, responeData.Length);
                    String respone = System.Text.Encoding.ASCII.GetString(responeData, 0, bytes);
                    if (respone != "1")
                        Console.WriteLine("Unexpected server respone.");
                }
            } catch (SocketException e) {
                Console.WriteLine("TCPClient error: " + e.Message);
            } finally {
                Close();
            }
        }

        private byte[] prepareMessage(string data) {
            return System.Text.Encoding.ASCII.GetBytes(data);
        }

        public void SendMessage(string message) {
            if (!Initialized())
                throw new Exception("Connection not initialized");
            messageQue.Enqueue(message);
        }

        public void Close() {
            if (client != null)
                client.Close();
            connectionInitialized = false;
        }

        public Boolean Initialized() {
            return connectionInitialized;
        }

    }
}