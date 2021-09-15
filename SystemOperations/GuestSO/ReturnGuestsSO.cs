using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.GuestSO
{
    public class ReturnGuestsSO : SystemOperationsBase
    {
        public override void ExecuteOperation(IEntity entity)
        {
            try
            {
                List<Guest> guests = broker.GetAll(entity).Cast<Guest>().ToList();
                Result = guests;
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
