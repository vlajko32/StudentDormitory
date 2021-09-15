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
    public class User : IEntity
    {
        public int UserID { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        [Browsable(false)]
        public string TableName => "Users";

        [Browsable(false)]
        public string InsertValues => "";

        [Browsable(false)]
        public string IdColumn => "";

        [Browsable(false)]
        public string SelectColumns => "UserID,Username,Password" ;

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

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> entities = new List<IEntity>();
            while(reader.Read())
            {
                entities.Add(new User
                {
                    UserID = (int)reader[0],
                    Username = (string)reader[1],
                    Password = (string)reader[2]
                });

            }
            return entities;
        }

        public List<object> GetObjectsWhere(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
