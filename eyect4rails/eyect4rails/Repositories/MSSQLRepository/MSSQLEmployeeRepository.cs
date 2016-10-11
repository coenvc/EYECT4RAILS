using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eyect4rails.Classes;
using eyect4rails.Enums;
using eyect4rails.IRepository;

namespace eyect4rails.Repositories
{
    class MSSQLEmployeeRepository:Database,IEmployeeRepository
    {
        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();
            string query = "select e.id,ac.Username,e.email,ac.RFIDCode,e.name, ac.Password,r.Name,ad.id,ad.StreetName,ad.City,ad.Country,ad.ZIPCode,ad.HouseNumber,d.id,d.Name,d.AuthorisationLevel from Employee e  inner join Address ad on e.AddressID = ad.id inner join Account ac on ac.EmployeeID = e.id inner join Department d on d.ID = e.DepartmentID inner join role r on r.id = e.roleid";
            if (OpenConnection() == true)
            {
                using (SqlCommand command = new SqlCommand(query, Connection))
            {
                    using (SqlDataReader reader = command.ExecuteReader())
                    { 
                        while (reader.Read())
                        {
                            Address address = new Address(Convert.ToInt32(reader["ad.id"]),reader[7].ToString(), reader[8].ToString(),
                                reader[9].ToString(), reader[10].ToString(), reader[11].ToString());
                            Department department = new Department(Convert.ToInt32(reader[12]), reader[13].ToString(),
                                Convert.ToInt32(reader[14]));
                            Employee employee = new Employee(Convert.ToInt32(reader[0]), reader[1].ToString(),
                                reader[2].ToString(), Convert.ToInt32(reader[3]), reader[4].ToString(),
                                reader[5].ToString(), Role.Admin, address, department);
                            employees.Add(employee);
                        }
                    }
                    Connection.Close();
                    return employees; 
                }
               
            }
            else
            {
                return null;
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

        public bool Insert(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void Update(Employee employee, int id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
