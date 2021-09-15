using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.GuestSO
{
    public class CreateGuestSO : SystemOperationsBase
    {
        

        public override void ExecuteOperation(IEntity entity)
        {
            try
            {
                broker.Save(entity);
                Result = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
