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
    public class Guest: IEntity
    {
        public int GuestID { get; set; }

        public string GuestName { get; set; }

        public string GuestSurname { get; set; }

        public string GIndexNumber { get; set; }

        public int GCardNumber { get; set; }

        public City City { get; set; }
        [Browsable(false)]
        public string TableName => "Guest";
        [Browsable(false)]
        public string InsertValues => $"'{GuestName}', '{GuestSurname}', '{GIndexNumber}', {GCardNumber}, {City.CityID}";
        [Browsable(false)]
        public string IdColumn => "GuestID";
        [Browsable(false)]
        public string SelectColumns => "g.GuestID GuestID, g.GuestName GuestName, g.GuestSurname GuestSurname,"+
            " g.IndexNumber GIndexNumber, g.CardNumber GCardNumber, c.CityID CityID, c.Name CityName, c.PostNumber PostNumber";
        [Browsable(false)]
        public string TableAlias => "g";
        [Browsable(false)]
        public string JoinTable => "join Cities c";
        [Browsable(false)]
        public string JoinCondition => "on (g.CityID=c.CityID)";
        [Browsable(false)]
        public string JoinTable2 =>"";
        [Browsable(false)]
        public string JoinCondition2 => "";
        [Browsable(false)]
        public string SelectColumnsWhere => "";
        [Browsable(false)]
        public string Where => "";
        [Browsable(false)]
        public string UpdateValues => "";
        [Browsable(false)]
        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> entities = new List<IEntity>();
            while (reader.Read())
            {
                entities.Add(new Guest
                {
                    GuestID = (int)reader["GuestID"],
                    GuestName=(string)reader["GuestName"],
                    GuestSurname=(string)reader["GuestSurname"],
                    GCardNumber=(int)reader["GCardNumber"],
                    GIndexNumber=(string)reader["GIndexNumber"],
                    City = new City
                    {
                        CityID=(int)reader["CityID"],
                        Name = (string)reader["CityName"],
                        PostNumber = (int)reader["PostNumber"]
                    }
                });

            }
            return entities;
        }
        [Browsable(false)]
        public List<object> GetObjectsWhere(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
