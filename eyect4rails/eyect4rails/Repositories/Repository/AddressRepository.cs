using System.Collections.Generic;
using eyect4rails.Classes;
using eyect4rails.IRepository;

namespace eyect4rails.Repository
{
    public class AddressRepository : IAddressRepository
    {
        public List<Address> AddressList;

        /// <summary>
        /// Create AddressList
        /// Create Addresses
        /// Add Addresses to AddressList
        /// </summary>
        public AddressRepository()
        {
            AddressList = new List<Address>();
            
            Address address1 = new Address(1, "Visstraat", "Oss", "Nederland", "8175AB", "12b");
            Address address2 = new Address(2, "Hoevenaarsstraat", "Gilze", "Nederland", "5126GP", "6");
            Address address3 = new Address(3, "Oranjestraat", "Oss", "Nederland", "8175GS", "105");
            Address address4 = new Address(4, "Nieuwstraat", "Berkel", "Nederland", "4778PO", "25");
            Address address5 = new Address(5, "Kerkstraat", "Amsterdam", "Nederland", "1002WE", "80");
            Address address6 = new Address(6, "Meierstraat", "Hilvarenbeek", "Nederland", "6651ER", "2");
            Address address7 = new Address(7, "Gatenstraat", "Dongen", "Nederland", "6462", "15a");
            
            AddressList.Add(address1); AddressList.Add(address2); AddressList.Add(address3);
            AddressList.Add(address4); AddressList.Add(address5); AddressList.Add(address6);
            AddressList.Add(address7);
        }

        /// <summary>
        /// Gets all addresses
        /// </summary>
        /// <returns>List of addresses</returns>
        public List<Address> GetAll()
        {
            return AddressList;
        }

        /// <summary>
        /// Get address by id
        /// Loop through AddressList till right address is found
        /// </summary>
        /// <param name="id"></param>
        /// <returns>address object</returns>
        public Address GetById(int id)
        {
            foreach (Address address in AddressList)
            {
                if (id == address.Id)
                {
                    return address;
                }
            }
            return null;
        }

        /// <summary>
        /// Insert new address into AddressList
        /// Checks if address is added
        /// </summary>
        /// <param name="address"></param>
        /// <returns>true when address added, false when address not added</returns>
        public bool Insert(Address address)
        {
            int countaddresses = AddressList.Count;
            AddressList.Add(address);
            if (countaddresses != AddressList.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Update address with new values
        /// </summary>
        /// <param name="address"></param>
        /// <param name="id"></param>
        public void Update(Address address, int id)
        {
            foreach (Address addresses in AddressList)
            {
                if (id == addresses.Id)
                {
                    addresses.City = address.City;
                    addresses.Country = address.Country;
                    addresses.Housenumber = address.Housenumber;
                    addresses.Streetname = address.Streetname;
                    addresses.ZipCode = address.ZipCode;
                }
            }
        }

        /// <summary>
        /// Delete address from list by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>true if address deleted, false if address not deleted</returns>
        public bool Delete(int id)
        {
            int countaddresses = AddressList.Count;
            foreach (Address address in AddressList)
            {
                if (id == address.Id)
                {
                    AddressList.Remove(address);
                }
            }
            if (countaddresses != AddressList.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}