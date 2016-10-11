using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eyect4rails.Classes;

namespace eyect4rails.IRepository
{
    public interface IAddressRepository
    {
        List<Address> GetAll();

        Address GetById(int id);

        bool Insert(Address address);

        void Update(Address address, int id);

        bool Delete(int id);
    }
}
