using LiteDB;
using PostLAN.Core.Address;
using PostLAN.Core.Address.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostLAN.Infrastructure.Data
{
    internal class AddressRepository : IAddressRepository
    {
        private const string ConnectionString = @"C:\Temp\PostLAN.db";
        private const string CollectionName = "addresses";

        public IEnumerable<AddressEntity> FindAll()
        {
            using (var db = new LiteDatabase(ConnectionString))
            {
                var col = db.GetCollection<AddressEntity>(CollectionName);
                var result = col.FindAll();
                return result;
            }
        }

        public void Insert(AddressEntity entity)
        {
            using (var db = new LiteDatabase(ConnectionString))
            {
                var col = db.GetCollection<AddressEntity>(CollectionName);
                col.Insert(entity);
            }
        }

        public void Delete(Guid id)
        {
            using (var db = new LiteDatabase(ConnectionString))
            {
                var col = db.GetCollection<AddressEntity>(CollectionName);
                col.Delete(id);
            }
        }
    }
}
