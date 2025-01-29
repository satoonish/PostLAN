using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PostLAN.Core.Address
{
    public class AddressEntity
    {
        public AddressEntity(
            string name,
            IPAddress ip,
            int port)
        {
            ID = Guid.NewGuid();
            Name = name;
            IP = ip;
            Port = port;
        }

        public Guid ID { get; }
        public string Name { get; }
        public IPAddress IP { get; }
        public int Port { get; }
    }
}
