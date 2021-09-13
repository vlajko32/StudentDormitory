using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.FacultySO
{
    public class ReturnFacultiesSO : SystemOperationsBase
    {
        public override void ExecuteOperation(IEntity entity)
        {
            List<Faculty> faculties = broker.GetAll(entity).Cast<Faculty>().ToList();
            Console.WriteLine(faculties[0]);
            Result = faculties;
            return;
        }
    }
}
