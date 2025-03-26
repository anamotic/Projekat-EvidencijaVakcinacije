using System.Diagnostics;
using System.Net;
using System.Net.Sockets;

namespace Server
{
    public class Server
    {

        Socket socket;
        public static List<ClientHandler> clientHandlers = new List<ClientHandler>();
        public Server()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public void Start()
        {
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
           
            socket.Bind(endPoint);
            socket.Listen(5);

            Thread thread = new Thread(AcceptClient);
            thread.Start();

        }

        public void AcceptClient()
        {
            try
            {
                while (true)
                {
                    Socket klijentskiSoket = socket.Accept();
                    ClientHandler handler = new ClientHandler(klijentskiSoket);
                    Thread klijentskaNit = new Thread(handler.HandleRequest);
                    klijentskaNit.Start();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
        public void Stop()
        {

        var handlersToStop = clientHandlers.ToList();

            foreach (var handler in handlersToStop)
            {
                handler.Stop(); 
            }

          socket.Close();
          clientHandlers.Clear(); 
        }
        

    }
}
