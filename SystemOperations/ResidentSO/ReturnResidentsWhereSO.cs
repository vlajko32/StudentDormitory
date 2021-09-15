using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.ResidentSO
{
    public class ReturnResidentsWhereSO : SystemOperationsBase
    {
        object cond;

        public ReturnResidentsWhereSO(object cond)
        {
            this.cond = cond;
        }

        public override void ExecuteOperation(IEntity entity)
        {
            string cond2;
            if(cond is int)
            {
                cond2 = cond.ToString();
            }
            else
            {
                cond2 = (string)cond;
            }
            List<Resident> residents = broker.GetWhere(entity, cond2).Cast<Resident>().ToList();
            Result = residents;
            return;
        }
    }
}
