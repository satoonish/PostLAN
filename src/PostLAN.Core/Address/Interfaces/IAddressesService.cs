using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostLAN.Core.Address.Interfaces
{
    public interface IAddressesService
    {
        Task<IEnumerable<AddressEntity>> GetAddresses();
    }
}
