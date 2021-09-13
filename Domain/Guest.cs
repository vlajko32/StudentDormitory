using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Guest: IEntity
    {
        public int GuestID { get; set; }

        public string GuestName { get; set; }

        public string GuestSurname { get; set; }

        public string GIndexNumber { get; set; }

        public int GCardNumber { get; set; }

        public City City { get; set; }

        public string TableName => throw new NotImplementedException();

        public string InsertValues => throw new NotImplementedException();

        public string IdColumn => throw new NotImplementedException();

        public string SelectColumns => throw new NotImplementedException();

        public string TableAlias => throw new NotImplementedException();

        public string JoinTable => throw new NotImplementedException();

        public string JoinCondition => throw new NotImplementedException();

        public string JoinTable2 => throw new NotImplementedException();

        public string JoinCondition2 => throw new NotImplementedException();

        public string SelectColumnsWhere => throw new NotImplementedException();

        public string Where => throw new NotImplementedException();

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public List<object> GetObjectsWhere(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
