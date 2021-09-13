using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Resident: IEntity
    {
        public int ResidentID { get; set; }

        public string ResidentName { get; set; }

        public string ResidentSurname { get; set; }

        public string IndexNumber { get; set; }

        public int CardNumber { get; set; }

        public int RoomNumber { get; set; }

        public City City { get; set; }

        public Faculty Faculty { get; set; }
        [Browsable(false)]
        public string TableName => "Residents";
        [Browsable(false)]

        public string InsertValues => "";
        [Browsable(false)]
        public string IdColumn => "";
        [Browsable(false)]
        public string SelectColumns => throw new NotImplementedException();
        [Browsable(false)]
        public string TableAlias => throw new NotImplementedException();
        [Browsable(false)]
        public string JoinTable => throw new NotImplementedException();
        [Browsable(false)]
        public string JoinCondition => throw new NotImplementedException();
        [Browsable(false)]
        public string JoinTable2 => throw new NotImplementedException();
        [Browsable(false)]
        public string JoinCondition2 => throw new NotImplementedException();
        [Browsable(false)]
        public string SelectColumnsWhere => throw new NotImplementedException();
        [Browsable(false)]
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
