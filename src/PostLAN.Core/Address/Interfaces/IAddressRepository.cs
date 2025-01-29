namespace PostLAN.Core.Address.Interfaces
{
    public interface IAddressRepository
    {
        IEnumerable<AddressEntity> FindAll();
        void Insert(AddressEntity entity);
        void Delete(Guid id);
    }
}
