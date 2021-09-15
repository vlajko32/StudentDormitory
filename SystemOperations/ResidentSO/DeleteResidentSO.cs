using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.ResidentSO
{
    public class DeleteResidentSO : SystemOperationsBase
    {
        int ResidentID;
        public DeleteResidentSO(int id)
        {
            this.ResidentID = id;
        }
        public override void ExecuteOperation(IEntity entity)
        {
            broker.Delete(entity, ResidentID);
        }
    }
}
