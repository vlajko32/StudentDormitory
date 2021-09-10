using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.UserSO
{
    public class LoginUserSO : SystemOperationsBase
    {
        public override void ExecuteOperation(IEntity entity)
        {
            List<User> users = broker.GetAll(entity).Cast<User>().ToList();
            User user = (User)entity;

            foreach(User u in users)
            {
                if (u.Username==user.Username && u.Password==user.Password)
                {
                    Result = u;
                    return;
                }

                Result = null;
            }
;        }
    }
}
