using BrokerDB;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Implementation
{
    class GenericRepository : IRepository
    {
        private Broker broker = new Broker();

        public void Delete(IEntity entity, int id)
        {
            throw new NotImplementedException();
        }

        public List<IEntity> GetAll(IEntity entity)
        {
            return broker.GetAll(entity);
        }

        public int GetNewId(IEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Save(IEntity entity)
        {
            throw new NotImplementedException();
        }

        public void SaveMore(List<IEntity> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(IEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
