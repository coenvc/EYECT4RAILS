using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eyect4rails.Classes
{
    class Remise
    {
        public int Id;
        public string Name;
        public List<Track> Tracklist;
        public Address Address; // change to address later
        public string TelephoneNumber;

        public Remise(int id, string name, Address address, string telephonenumber)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
            this.TelephoneNumber = telephonenumber;
        }
    }
}
