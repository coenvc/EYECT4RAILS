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

        /// <summary>
        /// Constructor om Employee gegevens uit de database op te halen
        /// </summary>
        /// <param name="id"></param>
        /// <param name="username"></param>
        /// <param name="email"></param>
        /// <param name="rfidcode"></param>
        /// <param name="password"></param>
        /// <param name="name"></param>
        /// <param name="role"></param>
        /// <param name="address"></param>
        /// <param name="department"></param>
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
        /// <summary>
        /// Constructor om Employee gegevens in de database te zetten
        /// </summary>
        /// <param name="username"></param>
        /// <param name="email"></param>
        /// <param name="rfidcode"></param>
        /// <param name="password"></param>
        /// <param name="name"></param>
        /// <param name="role"></param>
        /// <param name="address"></param>
        /// <param name="department"></param>
        public Employee(string username, string email, int rfidcode, string password, string name, Enums.Role role, Address address, Department department)
        {
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
