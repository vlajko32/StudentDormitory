using Common;
using Domain;
using Forms.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
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

        public void SendRequest(Request request)
        {
            try
            {
                sender.Send(request);
            }
            catch (IOException ex)
            {
                throw new ServerException(ex.Message);
            }
            catch (SocketException ex)
            {

                throw new ServerException(ex.Message);
            }
        }

        internal object GetVisits()
        {
            Request request = new Request { Operation = Operation.GetVisits };
            SendRequest(request);
            Response response = receiver.Receive();
            return (List<Visit>)response.Result;
        }

        private Communication()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        }

        internal object GetGuests()
        {
            Request request = new Request { Operation = Operation.GetGuests };
            SendRequest(request);
            Response response = receiver.Receive();
            return (List<Guest>)response.Result; 
        }

        internal object GetGuestsWhere(string cond)
        {
            Request request = new Request { Operation = Operation.GetGuestsWhere, Data = cond };
            SendRequest(request);
            Response response = receiver.Receive();
            return (List<Guest>)response.Result;
        }

        internal void Connect()
        {
            socket.Connect("127.0.0.1", 8080);
            sender = new Sender(socket);
            receiver = new Receiver(socket);
        }

        internal bool CreateVisit(Visit v)
        {
            Request request = new Request { Operation = Operation.CreateVisit, Data = v };
            SendRequest(request);
            Response response = receiver.Receive();
            return response.IsSuccessful;
        }

        internal bool DeleteGuests(int value)
        {
            Request request = new Request { Operation = Operation.DeleteGuest, Data = value };
            SendRequest(request);
            Response response = receiver.Receive();
            return response.IsSuccessful;
        }

        internal object GetFaculties()
        {
            Request request = new Request { Operation = Operation.GetAllFaculties };
            SendRequest(request);
            Response response = receiver.Receive();
            return (List<Faculty>)response.Result;
        }

        internal void SaveGuest(Guest guest)
        {
            Request request = new Request { Operation = Operation.CreateGuest, Data = guest };
            SendRequest(request);
            Response response = receiver.Receive();
            return;
        }

        internal object GetResidents()
        {
            try
            {
                Request request = new Request { Operation = Operation.GetResidents };
                SendRequest(request);
                Response response = receiver.Receive();
                return (List<Resident>)response.Result;
            }catch(Exception)
            {
                throw;
            }
        }

        internal bool DeleteResident(int DeletedID)
        {
            Request request = new Request { Operation = Operation.DeleteResident, Data = DeletedID };
            SendRequest(request);
            Response response = receiver.Receive();
            return response.IsSuccessful;
        }

        internal void UpdateResident(int residentID, List<string> values)
        {
            Request request = new Request { Operation = Operation.UpdateResident, Data = new List<object> { residentID, values } };
            SendRequest(request);
            Response response = receiver.Receive();
            return;
        }

        internal object GetResidentsWhere(object cond)
        {
            Request request = new Request { Operation = Operation.GetResidentsWhere, Data =  cond};
            SendRequest(request);
            Response response = receiver.Receive();
            return (List<Resident>)response.Result;
        }

        internal object GetCities()
        {
            Request request = new Request { Operation = Operation.GetAllCities };
            SendRequest(request);
            Response response = receiver.Receive();
            return (List<City>)response.Result;
        }

        internal User Login(TextBox txtUsername, TextBox txtPassword)
        {
            Request request = new Request { Operation = Operation.Login, 
                Data = new User { Username = txtUsername.Text, Password = txtPassword.Text } };
            SendRequest(request);
            Response response = receiver.Receive();
            return (User)response.Result;

        }

        internal bool SaveResident(Resident resident)
        {
            try
            {
                Request request = new Request { Operation = Operation.CreateResident, Data = resident };
                SendRequest(request);
                Response response = receiver.Receive();
                return response.IsSuccessful;
            }
            catch(Exception ex)
            {
                throw;
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

        internal void Disconnect()
        {
            socket.Close();
            socket = null;
        }
    }
}
