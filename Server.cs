using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace Sokoban
{
    public delegate void deGet(byte data);
    public abstract class General
    {
        protected NetworkStream networkStream;
        public string host;
        public int port;
        public deGet Get;
        public int isConnected = 1;
        Thread thread;

        // Wait for connection, and the program works on
        public void Start()
        {
            thread = new Thread(Waiter);
            // Stopping the server
            thread.IsBackground = true;
            thread.Start();
        }

        // Permanent connection
        private void Waiter()
        {
            while (true)
            {
                Connect();
                while (true)
                {
                    try
                    {
                        if (isConnected == 0) { isConnected = 1; }
                        int data = networkStream.ReadByte();
                        if (data != -1) { Get((byte)data); }
                    } 
                    catch 
                    {
                        isConnected = 0;
                        Thread.Sleep(100);
                        break; 
                    }
                }
            }
        }

        abstract public void Connect();

        // Send data
        public bool Send(byte data)
        {
            try
            {
                networkStream.WriteByte(data);
                return true;
            }
            catch
            {
                Thread.Sleep(100);
                return false;
            }
        }
    }

    class Server : General
    {
        public Server(int port)
        {
            this.port = port;
        }

        override public void Connect()
        {
            try
            {
                // Creation of listener
                TcpListener listener = new TcpListener(IPAddress.Any, port);
                // Start
                listener.Start();

                // Waiting for client connection
                TcpClient client = listener.AcceptTcpClient();

                // Record for data transmission
                networkStream = client.GetStream();

                // Stop
                listener.Stop();
            } catch {}
        }
    }

    class Client : General
    {
        public Client(string host, int port)
        {
            this.host = host;
            this.port = port;
        }

        override public void Connect()
        {
            try
            {
                // Creation of client
                TcpClient client = new TcpClient(host, port);

                // Record for data transmission
                networkStream = client.GetStream();
            } catch {}
        }
    }
}
