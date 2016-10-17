using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eyect4rails.Classes
{
    public class Address
    {
        private static int AddressCounter = 0;

        public int Id { get; private set; }
        public string Streetname { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public string Housenumber { get; set; }

        public Address(int id, string streetname, string city, string country, string zipCode, string housenumber)
        {
            Id = id;
            Streetname = streetname;
            City = city;
            Country = country;
            ZipCode = zipCode;
            Housenumber = housenumber;
        }

        public Address(string streetname, string city, string country, string zipCode, string housenumber)
        {
            Id = AddressCounter;
            Streetname = streetname;
            City = city;
            Country = country;
            ZipCode = zipCode;
            Housenumber = housenumber;

            AddressCounter++;
        }
    }
}
