using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.VisitSO
{
    public class ReturnVisitsSO : SystemOperationsBase
    {
        public override void ExecuteOperation(IEntity entity)
        {
            try
            {
                List<Visit> visits = broker.GetAll(entity).Cast<Visit>().ToList();
                Result = visits;
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
