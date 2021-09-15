using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.GuestSO
{
    public class DeleteGuestSO : SystemOperationsBase
    {
        int GuestID;

        public DeleteGuestSO(int GuestID)
        {
            this.GuestID = GuestID;
        }
        public override void ExecuteOperation(IEntity entity)
        {
            broker.Delete(entity, GuestID);
        }
    }
}
