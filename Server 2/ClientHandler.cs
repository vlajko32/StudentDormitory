using Common;
using DBController;
using Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ClientHandler
    {
        private Socket client;
        private Server server;
        public ClientHandler(Socket client, Server server)
        {
            this.client = client;
            this.server = server;
        }

        public void StartHandler()
        {
            try
            {
                NetworkStream stream = new NetworkStream(client);
                BinaryFormatter formatter = new BinaryFormatter();
                while (true)
                {
                    Request request = (Request)formatter.Deserialize(stream);
                    Response response = ProcessRequest(request);
                    formatter.Serialize(stream, response);
                }
            }
            catch (IOException ex)
            {

                Console.WriteLine("Klijent je prekinuo vezu");
              
            }

        }

        private Response ProcessRequest(Request request)
        {
            Response response = new Response();
            switch (request.Operation)
            {
                case Operation.Login:
                    User u = (User)request.Data;
                    response.Result = Controller.Instance.Login(u.Username, u.Password);
                    if((User)response.Result !=null)
                    {
                        server.Users.Add((User)response.Result);
                    }

                    break;
            }
            return response;
        }

        internal void Stop()
        {
            client.Close();
        }

    }
}
