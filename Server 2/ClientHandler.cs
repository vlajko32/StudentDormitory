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
                case Operation.GetAllCities:
                    List<City> cities;
                    response.Result = Controller.Instance.GetAllCities();

                    break;
                case Operation.GetAllFaculties:
                    List<Faculty> faculties;
                    response.Result = Controller.Instance.GetAllFaculties();
                    break;

                case Operation.CreateResident:
                    try
                    {
                        Resident r = (Resident)request.Data;
                        Controller.Instance.CreateResident(r);
                        response.IsSuccessful = true;
                    }catch(Exception)
                    {
                        response.IsSuccessful = false;
                        
                    }
                    break;

                case Operation.GetResidents:
                    response.Result = Controller.Instance.GetResidents();
                    break;

                case Operation.GetResidentsWhere:
                    try
                    {
                        object cond = request.Data;
                        response.Result = Controller.Instance.GetResidentWhere(cond);
                        response.IsSuccessful = true;
                    }catch(Exception)
                    {
                        
                    }
                    break;

                case Operation.DeleteResident:
                    try
                    {
                        int ResidentID = (int)request.Data;
                        Controller.Instance.DeleteResident(ResidentID);
                        response.IsSuccessful = true;
                    }catch(Exception)
                    {
                        response.IsSuccessful = false;
                    }
                    break;

                case Operation.UpdateResident:
                    try
                    {
                        List<object> data = (List<object>)request.Data;
                        int ResidentID = (int)data[0];
                        List<string> values = (List<string>)data[1];
                        Controller.Instance.UpdateResident(ResidentID, values);
                        response.IsSuccessful = true;
                    }
                    catch(Exception)
                    {
                        response.IsSuccessful = false;
         
                    }
                    break;

                case Operation.CreateGuest:
                    try
                    {
                        Guest g = (Guest)request.Data;
                        Controller.Instance.CreateGuest(g);
                        response.IsSuccessful = true;
                    }
                    catch (Exception)
                    {
                        response.IsSuccessful = false;
                        
                    }                  
                    break;
                case Operation.GetGuests:
                    response.Result = Controller.Instance.GetGuests();
                    break;

                case Operation.GetGuestsWhere:
                    try
                    {
                        object cond = request.Data;
                        response.Result = Controller.Instance.GetGuestsWhere(cond);
                    }
                    catch (Exception)
                    {

                    }
                    break;

                case Operation.DeleteGuest:
                    try
                    {
                        int GuestID = (int)request.Data;
                        Controller.Instance.DeleteGuest(GuestID);
                        response.IsSuccessful = true;
                    }
                    catch (Exception)
                    {
                        response.IsSuccessful = false;
                    }
                    break;
                case Operation.CreateVisit:
                    try
                    {
                        Visit v = (Visit)request.Data;
                        Controller.Instance.CreateVisit(v);
                        response.IsSuccessful = true;
                    }
                    catch (Exception)
                    {
                        response.IsSuccessful = false;
                        throw;
                    }
                    break;
                case Operation.GetVisits:
                    response.Result = Controller.Instance.GetVisits();
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
