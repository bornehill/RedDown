using System.Collections.Generic;
using RedDown.Data.Entities;

namespace RedDown.Data
{
    public interface IRedDownRepository
    {
        IEnumerable<RegistryDown> GetRedDownRegistrys();
        RegistryDown GetRedDownById(int redDownId);
        void AddEntity(object model);
        void UpdateRegistry(RegistryDown model);
        bool SaveAll();
    }
}
