using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.ResidentSO
{
    public class UpdateResidentSO : SystemOperationsBase
    {
        int residentID;
        List<string> values;
        public UpdateResidentSO(int ResidentID, List<string> values)
        {
            residentID = ResidentID;
            this.values = values;
        }
        public override void ExecuteOperation(IEntity entity)
        {
            broker.Update(entity, values, residentID);
        }
    }
}
