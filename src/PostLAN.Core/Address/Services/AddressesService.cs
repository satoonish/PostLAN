using PostLAN.Core.Address.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PostLAN.Core.Address.Services
{
    public class AddressesService : IAddressesService
    {
        private readonly IAddressRepository _repository;

        //public AddressesService(IAddressRepository repository)
        //{
        //    _repository = repository;
        //}

        public Task<IEnumerable<AddressEntity>> GetAddresses()
        {
            //var addresses = _repository.FindAll();
            //if (addresses == null)
            //{
            //    throw new Exception();
            //}

            //return Task.FromResult(addresses);
            var addresses = new List<AddressEntity>() { new AddressEntity("test",
                IPAddress.Parse("192.168.0.35"), 50000) };
            return Task.FromResult(addresses);
        }
    }
}
