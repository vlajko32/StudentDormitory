using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms.Communication
{
    public class Communication
    {
        private static Communication instance;
        private Socket socket;
        private Sender sender;
        private Receiver receiver;

        private Communication()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        }

        internal void Connect()
        {
            socket.Connect("127.0.0.1", 8080);
            sender = new Sender(socket);
            receiver = new Receiver(socket);
        }

        internal object GetFaculties()
        {
            Request request = new Request { Operation = Operation.GetAllFaculties };
            sender.Send(request);
            Response response = receiver.Receive();
            return (List<Faculty>)response.Result;
        }

        internal object GetCities()
        {
            Request request = new Request { Operation = Operation.GetAllCities };
            sender.Send(request);
            Response response = receiver.Receive();
            return (List<City>)response.Result;
        }

        internal User Login(TextBox txtUsername, TextBox txtPassword)
        {
            Request request = new Request { Operation = Operation.Login, 
                Data = new User { Username = txtUsername.Text, Password = txtPassword.Text } };
            sender.Send(request);
            Response response = receiver.Receive();
            return (User)response.Result;

        }




        public static Communication Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Communication();
                }
                return instance;
            }
        }
    }
}
