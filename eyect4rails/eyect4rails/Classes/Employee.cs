using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eyect4rails.Classes
{
    public class Employee
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public int RFIDCode { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public Enums.Role Role { get; set; }
        public Address Address { get; set; }
        public Department Department { get; set; }


        public Employee(int id, string username, string email, int rfidcode, string password, string name, Enums.Role role, Address address, Department department)
        {
            this.Id = id;
            this.Username = username;
            this.Email = email;
            this.RFIDCode = rfidcode;
            this.Password = password;
            this.Name = name;
            this.Role = role;
            this.Address = address;
            this.Department = department;
        }

        public override string ToString()
        {
            return $"{Id} ";
        }

    }
}
