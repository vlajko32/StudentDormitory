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

        public List<object> GetWhere(IEntity entity, string cond = "")
        {
            List<object> objects = new List<object>();
            SqlCommand command = connection.CreateCommand();
            command.Transaction = transaction;
            command.CommandText = $"select {entity.SelectColumnsWhere} from {entity.TableName} {entity.TableAlias} {entity.JoinTable2} {entity.JoinCondition2} {cond}";
            SqlDataReader reader = command.ExecuteReader();
            objects = entity.GetObjectsWhere(reader);
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
    }
}
