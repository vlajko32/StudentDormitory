using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokerDB
{
    public class Broker
    {
        private SqlConnection connection;
        private SqlTransaction transaction;


        public Broker()
        {
            //connection = new SqlConnection(ConfigurationManager.ConnectionStrings["KlinikaDatabase"].ConnectionString);
            connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentskiDom;
                                Integrated Security=True;Connect Timeout=30;
                                Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                                MultiSubnetFailover=False");

        }



        public void OpenConnection()
        {
            connection.Open();
        }
        public void CloseConnection()
        {
            connection.Close();
        }

        public void Commit()
        {
            transaction.Commit();
        }

        public void Rollback()
        {
            transaction.Rollback();
        }

        public void BeginTransaction()
        {
            transaction = connection.BeginTransaction();

        }

        public List<IEntity> GetWhere(IEntity entity, string cond = "")
        {
            List<IEntity> objects = new List<IEntity>();
            SqlCommand command = connection.CreateCommand();
            command.Transaction = transaction;
            command.CommandText = $"select {entity.SelectColumns} from {entity.TableName} {entity.TableAlias} {entity.JoinTable} {entity.JoinCondition} {entity.JoinTable2} {entity.JoinCondition2} {cond}";
            SqlDataReader reader = command.ExecuteReader();
            objects = entity.GetEntities(reader);
            reader.Close();
            return objects;
        }

        public List<IEntity> GetAll(IEntity entity)
        {
            
            List<IEntity> result = new List<IEntity>();
            SqlCommand command = connection.CreateCommand();
            command.Transaction = transaction;
            command.CommandText = $"select {entity.SelectColumns} from {entity.TableName} {entity.TableAlias}" +
                $" {entity.JoinTable} {entity.JoinCondition} {entity.JoinTable2} {entity.JoinCondition2}";
            SqlDataReader reader = command.ExecuteReader();
            result = entity.GetEntities(reader);
            reader.Close();

            return result;
        }

        public void Save(IEntity entity)
        {
            SqlCommand command = connection.CreateCommand();
            command.Transaction = transaction;
            command.CommandText = $"insert into {entity.TableName} values ({entity.InsertValues})";
            command.ExecuteNonQuery();
        }

        public void Delete(IEntity entity, int id)
        {
            SqlCommand command = connection.CreateCommand();
            command.Transaction = transaction;
            command.CommandText = $"delete from {entity.TableName} where {entity.IdColumn} = {id}";
            command.ExecuteNonQuery();
        }

        public void Update(IEntity entity, List<string> values, int id)
        {
            string updateCommand="";
            List<string> updateColumns = entity.UpdateValues.Split(' ').ToList();
            int counter = 0;
            foreach (var item in updateColumns)
            {
                if(counter>0)
                { updateCommand += ","; }
                updateCommand += " " + item + " = " + values[counter];
                counter++;
                
            }

            SqlCommand command = connection.CreateCommand();
            command.Transaction = transaction;
            command.CommandText = $"update {entity.TableName} set {updateCommand} from {entity.TableName} {entity.TableAlias} {entity.JoinTable} {entity.JoinCondition} {entity.JoinTable2} {entity.JoinCondition2} where {entity.IdColumn} = {id}";
            command.ExecuteNonQuery();
        }
    }
}
