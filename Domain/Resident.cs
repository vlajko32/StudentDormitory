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
        public string TableName => "Resident";
        [Browsable(false)]

        public string InsertValues => $"'{ResidentName}', '{ResidentSurname}', '{IndexNumber}', {CardNumber}, {RoomNumber}, {City.CityID}, {Faculty.FacultyID}";
        [Browsable(false)]
        public string IdColumn => "ResidentID";
        [Browsable(false)]
        public string SelectColumns => "r.ResidentID ResidentID, r.ResidentName ResidentName," + 
               " r.ResidentSurname ResidentSurname, r.IndexNumber IndexNumber, r.CardNumber CardNumber, r.RoomNumber RoomNumber," +
                " c.CityID CityID, c.Name Name, c.PostNumber PostNumber," + "f.FacultyID FacultyID, f.FacultyName FacultyName, f.University University";
        [Browsable(false)]
        public string TableAlias => "r";
        [Browsable(false)]
        public string JoinTable => "join Cities c";
        [Browsable(false)]
        public string JoinCondition => "on (r.CityID = c.CityID)";
        [Browsable(false)]
        public string JoinTable2 => "join Faculties f";
        [Browsable(false)]
        public string JoinCondition2 => "on (r.FacultyID = f.FacultyID)";
        [Browsable(false)]
        public string SelectColumnsWhere => throw new NotImplementedException();
        [Browsable(false)]
        public string Where => throw new NotImplementedException();
        [Browsable(false)]
        public string UpdateValues => "RoomNumber FacultyID IndexNumber";

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> entities = new List<IEntity>();
            while (reader.Read())
            {
                entities.Add(new Resident
                {
                    ResidentID = (int)reader["ResidentID"],
                    ResidentName = (string)reader["ResidentName"],
                    ResidentSurname = (string)reader["ResidentSurname"],
                    IndexNumber = (string)reader["IndexNumber"],
                    CardNumber = (int)reader["CardNumber"],
                    RoomNumber = (int)reader["RoomNumber"],
                    City = new City
                    { 
                        CityID = (int)reader["CityID"],
                        Name = (string)reader["Name"],
                        PostNumber = (int)reader["PostNumber"]
                    },
                    Faculty = new Faculty
                    {
                        FacultyID = (int)reader["FacultyID"],
                        FacultyName = (string)reader["FacultyName"],
                        UniversityName = (string)reader["University"]
                    }
                });

            }
            return entities;
        }

        public List<object> GetObjectsWhere(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return ResidentName + " " + ResidentSurname;
        }
    }
}
