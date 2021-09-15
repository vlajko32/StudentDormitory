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

        internal object GetGuests()
        {
            Request request = new Request { Operation = Operation.GetGuests };
            sender.Send(request);
            Response response = receiver.Receive();
            return (List<Guest>)response.Result; 
        }

        internal object GetGuestsWhere(string cond)
        {
            Request request = new Request { Operation = Operation.GetGuestsWhere, Data = cond };
            sender.Send(request);
            Response response = receiver.Receive();
            return (List<Guest>)response.Result;
        }

        internal void Connect()
        {
            socket.Connect("127.0.0.1", 8080);
            sender = new Sender(socket);
            receiver = new Receiver(socket);
        }

        internal void DeleteGuests(int value)
        {
            Request request = new Request { Operation = Operation.DeleteGuest, Data = value };
            sender.Send(request);
            Response response = receiver.Receive();
            return;
        }

        internal object GetFaculties()
        {
            Request request = new Request { Operation = Operation.GetAllFaculties };
            sender.Send(request);
            Response response = receiver.Receive();
            return (List<Faculty>)response.Result;
        }

        internal void SaveGuest(Guest guest)
        {
            Request request = new Request { Operation = Operation.CreateGuest, Data = guest };
            sender.Send(request);
            Response response = receiver.Receive();
            return;
        }

        internal object GetResidents()
        {
            try
            {
                Request request = new Request { Operation = Operation.GetResidents };
                sender.Send(request);
                Response response = receiver.Receive();
                return (List<Resident>)response.Result;
            }
        }

        internal void DeleteResident(int DeletedID)
        {
            Request request = new Request { Operation = Operation.DeleteResident, Data = DeletedID };
            sender.Send(request);
            Response response = receiver.Receive();
            return;
        }

        internal void UpdateResident(int residentID, List<string> values)
        {
            Request request = new Request { Operation = Operation.UpdateResident, Data = new List<object> { residentID, values } };
            sender.Send(request);
            Response response = receiver.Receive();
            return;
        }

        internal object GetResidentsWhere(object cond)
        {
            Request request = new Request { Operation = Operation.GetResidentsWhere, Data =  cond};
            sender.Send(request);
            Response response = receiver.Receive();
            return (List<Resident>)response.Result;
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

        internal void SaveResident(Resident resident)
        {
            try
            {
                Request request = new Request { Operation = Operation.CreateResident, Data = resident };
                sender.Send(request);
                Response response = receiver.Receive();
                return;
            }
            catch(Exception ex)
            {
                
            }
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
