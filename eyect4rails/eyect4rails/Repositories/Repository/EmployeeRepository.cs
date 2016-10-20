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
        public List<Employee> EmployeesList = new List<Employee>();

        /// <summary>
        /// Create EmployeesList
        /// Create Employees
        /// Add Employees to EmployeesList
        /// </summary>
        public EmployeeRepository()
        {
            // Create Addresses
            Address addressTom = new Address(1, "Visstraat", "Oss", "Nederland", "8175AB", "12b");
            Address addressThijs = new Address(2, "Hoevenaarsstraat", "Gilze", "Nederland", "5126GP", "6");
            Address addressReinoud = new Address(3, "Oranjestraat", "Oss", "Nederland", "8175GS", "105");
            Address addressCoen = new Address(4, "Nieuwstraat", "Berkel", "Nederland", "4778PO", "25");
            Address addressBo = new Address(5, "Kerkstraat", "Amsterdam", "Nederland", "1002WE", "80");
            Address addressMarc = new Address(6, "Meierstraat", "Hilvarenbeek", "Nederland", "6651ER", "2");
            Address addressCasper = new Address(7, "Gatenstraat", "Dongen", "Nederland", "6462", "15a");

            // Create roles
            Role cleaner = new Role(1, "Cleaner");
            Role mechanic = new Role(1, "Mechanic");
            Role driver = new Role(1, "Driver");
            Role parkmanager = new Role(2, "Parkmanager");
            Role admin = new Role(3, "Admin");

            /*Current problems with the Employee class:
             * Constructors: public Employee(int id, string username, string email, int rfidcode, string password, string name, Enums.Role role, Address address, Department department)
             * There is only 1 constructor (for DB) none for local (without ID) (makes it awkward to make objects, not impossible)
             * RFIDcode is mandatory, shouldnt be (not required)
             * Password has no check (not required)
             * uses Enums.Role role instead of object Role (makes it impossible to create objects)
             * 
             * Because of these reasons I cannot make any Employees, postponed for now
             *
             *Code below can be uncommented as soon as Employee constructor works as intended
             */

            //EmployeesList.Add(tom);
            //EmployeesList.Add(thijs);
            //EmployeesList.Add(reinoud);
            //EmployeesList.Add(coen);
            //EmployeesList.Add(bo);
            //EmployeesList.Add(marc);
            //EmployeesList.Add(casper);
        }


        /// <summary>
        /// Gets all employees
        /// </summary>
        /// <returns>List of employees</returns>
        /// 
        //public List<Employee> GetAllEmployees();

        public List<Employee> GetAll()

        {
            return EmployeesList;
        }

        /// <summary>
        /// Get employee by id
        /// loop through EmployeeList till right employee is found
        /// </summary>
        /// <param name="id"></param>
        /// <returns>employee object</returns>
        /// 
        //public Employee GetEmployeeById(int id);

        public Employee GetById(int id)

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

        /// <summary>
        /// Insert new employee into EmployeeList
        /// Checks if employee is added
        /// </summary>
        /// <param name="employee"></param>
        /// <returns>true when employee added, false when employee not added</returns>
        public bool Insert(Employee employee)
        {
            int countemployees = EmployeesList.Count;
            EmployeesList.Add(employee);
            if (countemployees != EmployeesList.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Update employee with new values
        /// </summary>
        /// <param name="employee"></param>
        /// <param name="id"></param>
        public void Update(Employee employee, int id)
        {
            foreach (Employee person in EmployeesList)
            {
                if (id == person.Id)
                {
                    person.Address = employee.Address;
                    person.Department = employee.Department;
                    person.Email = employee.Email;
                    person.Name = employee.Name;
                    person.Password = employee.Password;
                    person.RFIDCode = employee.RFIDCode;
                    person.Role = employee.Role;
                    person.Username = employee.Username;
                }
            }
        }

        /// <summary>
        /// Delete employee from list by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>true if employee deleted, false if employee not deleted</returns>
        public bool Delete(int id)
        {
            int countemployees = EmployeesList.Count;
            foreach (Employee employee in EmployeesList)
            {
                if (id == employee.Id)
                {
                    EmployeesList.Remove(employee);
                }
            }
            if (countemployees != EmployeesList.Count)
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
