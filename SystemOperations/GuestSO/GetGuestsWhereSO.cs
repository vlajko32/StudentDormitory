using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.GuestSO
{
    public class GetGuestsWhereSO : SystemOperationsBase
    {
        string cond;

        public GetGuestsWhereSO(object cond)
        {
            this.cond = (string)cond;
        }
        public override void ExecuteOperation(IEntity entity)
        {
            List<Guest> guests = broker.GetWhere(entity, cond).Cast<Guest>().ToList();
            Result = guests;
            return;
        }
    }
}
