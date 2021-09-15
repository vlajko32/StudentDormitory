using BrokerDB;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.ResidentSO
{
    public class ReturnResidentsSO: SystemOperationsBase
    {
        public override void ExecuteOperation(IEntity entity)
        {
            try
            {
                List<Resident> residents = broker.GetAll(entity).Cast<Resident>().ToList();
                Result = residents;
                return;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
