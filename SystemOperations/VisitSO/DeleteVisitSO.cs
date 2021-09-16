using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.VisitSO
{
    public class DeleteVisitSO : SystemOperationsBase
    {
        int VisitID;
        public DeleteVisitSO(int id)
        {
            this.VisitID = id;
        }
        public override void ExecuteOperation(IEntity entity)
        {
            broker.Delete(entity, VisitID);
        }
    }
}
