using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eyect4rails.Classes
{
    public class Address
    {
        public int Id { get; set; }
        public string Streetname { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public string Housenumber { get; set; }

        public Address(int id, string streetname, string city, string country, string zipcode, string housenumber)
        {
            this.Id = id;
            this.Streetname = streetname;
            this.City = city;
            this.Country = country;
            this.ZipCode = zipcode;
            this.Housenumber = housenumber;
        }
    }
}
