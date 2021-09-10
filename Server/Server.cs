﻿using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    public class Server
    {
        private Socket listener;
        private List<ClientHandler> clients = new List<ClientHandler>();
        private BindingList<User> users = new BindingList<User>();
        public BindingList<User> Users
        {
            get { return users; }

        }

        public Server()
        {

        }

        public void Start()
        {
            listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            listener.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), int.Parse(ConfigurationManager.AppSettings["port"])));
        }

        public void Listen()
        {
            try
            {
                while (true)
                {
                    listener.Listen(5);
                    Socket client = listener.Accept();
                    ClientHandler clientHandler = new ClientHandler(client, this);
                    clients.Add(clientHandler);
                    Thread thread = new Thread(clientHandler.StartHandler);
                    thread.Start();
                }
            }
            catch (SocketException)
            {
                Console.WriteLine("Kraj rada, server je zaustavljen");
            }

        }

        internal void Stop()
        {
            listener.Close();
            foreach (ClientHandler client in clients)
            {
                client.Stop();
            }

            clients.Clear();

        }
    }
}

