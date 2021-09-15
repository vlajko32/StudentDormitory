using BrokerDB;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOperations;
using SystemOperations.CitySO;
using SystemOperations.FacultySO;
using SystemOperations.GuestSO;
using SystemOperations.ResidentSO;
using SystemOperations.UserSO;

namespace DBController
{
    public class Controller
    {
        private SystemOperationsBase so;
        Broker broker = new Broker();
        private static object _lock = new object();

        public User LoggedInUser { get; set; }

        #region
        private static Controller controller;

        public static Controller Instance
        {
            get
            {
                if (controller == null)
                {
                    lock (_lock)
                    {
                        if (controller == null)
                        {
                            controller = new Controller();
                        }
                    }
                }
                return controller;
            }
        }

        private Controller()
        {


        }
        #endregion

        public User Login(string username, string password)
        {
            so = new LoginUserSO();

            User user = new User { Username = username, Password = password };

            so.ExecuteTemplate(entity: user);

            User loggedIn = (User)so.Result;

            if(loggedIn !=null)
            {
                LoggedInUser = loggedIn;
                return loggedIn;
            }
            return null;
        }

        public object GetAllCities()
        {
            so = new ReturnCitiesSO();
            City city = new City();
            so.ExecuteTemplate(entity: city);

            List<City> cities = (List<City>)so.Result;

            return cities;


        }

        public object GetAllFaculties()
        {
            so = new ReturnFacultiesSO();
            Faculty faculty = new Faculty();
            so.ExecuteTemplate(entity: faculty);

            List<Faculty> faculties = (List<Faculty>)so.Result;
            
            return faculties;

        }

        public void CreateResident(Resident r)
        {
            so = new CreateResidentSO();
            so.ExecuteTemplate(entity: r);


        }

        public object GetResidents()
        {
            so = new ReturnResidentsSO();
            so.ExecuteTemplate(entity: new Resident());
            List<Resident> residents = (List<Resident>)so.Result;
            return residents;
        }

        public object GetResidentWhere(object cond)
        {
            so = new ReturnResidentsWhereSO(cond);
            so.ExecuteTemplate(entity: new Resident());
            List<Resident> residents = (List<Resident>)so.Result;
            return residents;
        }

        public void DeleteResident(int residentID)
        {
            so = new DeleteResidentSO(residentID);
            so.ExecuteTemplate(entity: new Resident());

        }

        public void UpdateResident(int residentID, List<string> values)
        {
            so = new UpdateResidentSO(residentID, values);
            so.ExecuteTemplate(entity: new Resident());
        }

        public void CreateGuest(Guest g)
        {
            so = new CreateGuestSO();
            so.ExecuteTemplate(entity: g);
        }

        public object GetGuests()
        {
            so = new ReturnGuestsSO();
            so.ExecuteTemplate(entity: new Guest());
            List<Guest> guests = (List<Guest>)so.Result;
            return guests;
        }

        public object GetGuestsWhere(object cond)
        {
            so = new GetGuestsWhereSO(cond);
            so.ExecuteTemplate(entity: new Guest());
            List<Guest> guests = (List<Guest>)so.Result;
            return guests;
        }

        public void DeleteGuest(int guestID)
        {
            so = new DeleteGuestSO(guestID);
            so.ExecuteTemplate(entity: new Guest());

        }
    }
}
