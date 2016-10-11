using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eyect4rails.Classes;
using eyect4rails.Enums;
using eyect4rails.IRepository;

namespace eyect4rails.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public List<Employee> EmployeesList;

        public EmployeeRepository()
        {
            EmployeesList = new List<Employee>();
            EmployeesList.Add(new Employee(1, "TKorschner", "t.korschner@gmail.com", 72642, "Wachtwoord123",
                "Tom Korschner", Role.Admin, new Address(1,"Visstraat", "Oss", "Nederland", "8175AB", "12b"),
                new Department(1,"SystemManagement", 4)));
            EmployeesList.Add(new Employee(2, "TdeJong", "t.dejong@gmail.com", 53285, "GwimSgsew324", "Thijs de Jong",
                Role.Parkmanager, new Address(2,"Hoevenaarsstraat", "Gilze", "Nederland", "5126GP", "6"),
                new Department(2,"ParkManagement", 3)));
            EmployeesList.Add(new Employee(3, "RvanZoelen", "r.vanzoelen@gmail.com", 95543, "mJinreu32dsfg",
                "Reinoud van Zoelen", Role.Driver, new Address(3,"Oranjestraat", "Oss", "Nederland", "8175GS", "105"),
                new Department(3, "Drivers", 2)));
            EmployeesList.Add(new Employee(4, "CvanCampenhout", "c.vancampenhout.gmail.com", 64643, "23ragSF4sdf",
                "Coen van Campenhout", Role.Cleaner, new Address(4,"Nieuwstraat", "Berkel", "Nederland", "4778PO", "25"),
                new Department(4, "Cleaning", 0)));
            EmployeesList.Add(new Employee(5, "BvandeSande", "b.vandesande@gmail.com", 15336, "mvJHUILUYE77j",
                "Bo van de Sande", Role.Mechanic, new Address(5,"Kerkstraat", "Amsterdam", "Nederland", "1002WE", "80"),
                new Department(5, "Mechanics", 1)));
            EmployeesList.Add(new Employee(6, "MvanGool", "m.vangool@gmail.com", 26437, "twoNUSHJKJEIord32",
                "Marc van Gool", Role.Cleaner, new Address(6,"Meierstraat", "Hilvarenbeek", "Nederland", "6651ER", "2"),
                new Department(4, "Cleaning", 0)));
            EmployeesList.Add(new Employee(7, "CPeijnenburg", "c.peijnenburg@gmail.com", 73553, "YHGB76gyGBUIY",
                "Casper Peijnenburg", Role.Mechanic, new Address(7,"Gatenstraat", "Dongen", "Nederland", "6462", "15a"),
                new Department(5, "Mechanics", 1)));
        }

        public List<Employee> GetAllEmployees()
        {
            return EmployeesList;
        }

        public Employee GetEmployeeById(int id)
        {
            foreach (Employee employee in EmployeesList)
            {
                if (id == employee.Id)
                {
                    return employee;
                }
            }
            return null;
        }

        public bool Insert(Employee employee)
        {
            int aantalemployees = EmployeesList.Count;
            EmployeesList.Add(employee);
            if (aantalemployees != EmployeesList.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Update(Employee employee, int id)
        {
            foreach (Employee person in EmployeesList)
            {
                if (id == person.Id)
                {
                    // Change Address
                    person.Address = employee.Address;
                    // Change Department
                    person.Department = employee.Department;
                    // Change Email
                    person.Email = employee.Email;
                    // Change Name
                    person.Name = employee.Name;
                    // Change Password
                    person.Password = employee.Password;
                    // Change RFIDCode
                    person.RFIDCode = employee.RFIDCode;
                    // Change Role
                    person.Role = employee.Role;
                    // Change Username
                    person.Username = employee.Username;
                }
            }
        }

        public bool Delete(int id)
        {
            int aantalemployees = EmployeesList.Count;
            foreach (Employee employee in EmployeesList)
            {
                if (id == employee.Id)
                {
                    EmployeesList.Remove(employee);
                }
            }
            if (aantalemployees != EmployeesList.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void InsertEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public Employee GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
