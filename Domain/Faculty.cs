using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Faculty : IEntity
    {
        public int FacultyID { get; set; }

        public string FacultyName { get; set; }

        public string UniversityName { get; set; }
        public string TableName => "Faculties";

        public string InsertValues => "";

        public string IdColumn => "";

        public string SelectColumns => "FacultyID, FacultyName, University";
        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> entities = new List<IEntity>();
            while (reader.Read())
            {
                entities.Add(new Faculty
                {
                    FacultyID = (int)reader[0],
                    FacultyName = (string)reader[1],
                    UniversityName = (string)reader[2]
                });

            }
            return entities;
        }

        public string TableAlias => "";

        public string JoinTable => "";

        public string JoinCondition => "";

        public string JoinTable2 => "";

        public string JoinCondition2 => "";

        public string SelectColumnsWhere => "";

        public string Where => "";

        public string UpdateValues => throw new NotImplementedException();

       

        public List<object> GetObjectsWhere(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return FacultyName;
        }
    }
}
