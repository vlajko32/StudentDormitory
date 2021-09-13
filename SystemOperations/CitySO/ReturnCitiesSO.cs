using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.CitySO
{
    public class ReturnCitiesSO : SystemOperationsBase
    {
        public override void ExecuteOperation(IEntity entity)
        {
            List<City> cities = broker.GetAll(entity).Cast<City>().ToList();
            Result = cities;
            return;
        }
    }
}
