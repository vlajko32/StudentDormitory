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
    public class Visit: IEntity
    {
        
        public int VisitID { get; set; }

        public Resident Resident { get; set; }

        public Guest Guest { get; set; }

        public DateTime Date { get; set; }

        // public Boolean ProcessingStatus { get; set; }
        [Browsable(false)]
        public string TableName => "Visits";
        [Browsable(false)]
        public string InsertValues => $"{Resident.ResidentID}, {Guest.GuestID}, '{Date}'";
        [Browsable(false)]
        public string IdColumn => "";
        [Browsable(false)]
        public string SelectColumns => "v.VisitID vID, r.ResidentID rID, r.ResidentName rName,r.ResidentSurname rSurname, r.RoomNumber rRoom, g.GuestID gID, g.GuestName gName,g.GuestSurname gSurname, v.VisitDate date";
        [Browsable(false)]
        public string TableAlias => "v";
        [Browsable(false)]
        public string JoinTable => "join Resident r";
        [Browsable(false)]
        public string JoinCondition => "on (v.ResidentID=r.ResidentID)";
        [Browsable(false)]
        public string JoinTable2 => "join Guest g";
        [Browsable(false)]
        public string JoinCondition2 => "on (v.GuestID=g.GuestID)";
        [Browsable(false)]
        public string SelectColumnsWhere =>"";
        [Browsable(false)]
        public string Where => "";
        [Browsable(false)]
        public string UpdateValues => "";
        [Browsable(false)]
        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> entities = new List<IEntity>();
            while(reader.Read())
            {
                entities.Add(new Visit
                {
                    VisitID = (int)reader["vID"],
                    Resident = new Resident
                    {
                        ResidentID = (int)reader["rID"],
                        ResidentName = (string)reader["rName"],
                        ResidentSurname = (string)reader["rSurname"],
                        RoomNumber = (int)reader["rRoom"]
                    },
                    Guest = new Guest
                    {
                        GuestID = (int)reader["rID"],
                        GuestName = (string)reader["gName"],
                        GuestSurname = (string)reader["gSurname"]
                    },
                    Date = (DateTime)reader["date"]



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
