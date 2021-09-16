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
    public class City: IEntity
    {
        public int CityID { get; set; }

        public string Name { get; set; }

        public int PostNumber { get; set; }

        [Browsable(false)]
        public string TableName => "Cities";
        [Browsable(false)]
        public string InsertValues => "";
        [Browsable(false)]
        public string IdColumn => "";
        [Browsable(false)]
        public string SelectColumns => "CityID, Name, PostNumber";
        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> entities = new List<IEntity>();
            while (reader.Read())
            {
                entities.Add(new City
                {
                    CityID = (int)reader[0],
                    Name = (string)reader[1],
                    PostNumber = (int)reader[2]
                });

            }
            return entities;
        }
        [Browsable(false)]
        public string TableAlias => "";
        [Browsable(false)]
        public string JoinTable => "";
        [Browsable(false)]
        public string JoinCondition => "";
        [Browsable(false)]
        public string JoinTable2 => "";
        [Browsable(false)]
        public string JoinCondition2 => "";
        [Browsable(false)]
        public string SelectColumnsWhere => "";

        public string Where => "";

        public string UpdateValues => throw new NotImplementedException();

       

        public List<object> GetObjectsWhere(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
