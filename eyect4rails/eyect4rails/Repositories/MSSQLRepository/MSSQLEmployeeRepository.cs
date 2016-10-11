using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eyect4rails.Classes;
using eyect4rails.Enums;
using eyect4rails.IRepository;

namespace eyect4rails.Repositories
{
    class MSSQLEmployeeRepository : Database, IEmployeeRepository
    {
        /// <summary>
        /// Gets a list of every employee in the Database
        /// </summary>
        /// <returns>A list of Employees</returns>
        public List<Employee> GetAll()
        {
            
            List<Employee> employees = new List<Employee>();
            string query =
                "select e.id,ac.Username,e.email,ac.RFIDCode,e.name, ac.Password,r.Name,ad.id,ad.StreetName,ad.City,ad.Country,ad.ZIPCode,ad.HouseNumber,d.id,d.Name,d.AuthorisationLevel from Employee e  inner join Address ad on e.AddressID = ad.id inner join Account ac on ac.EmployeeID = e.id inner join Department d on d.ID = e.DepartmentID inner join role r on r.id = e.roleid";
            if (OpenConnection() == true)
            {
                using (SqlCommand command = new SqlCommand(query, Connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Role role = new Role(3, "Admin");
                            //TODO: colomnamen i.p.v nummers vb: Convert.ToInt32(reader["ad.id"]) i.p.v Convert.ToInt32(reader[7])
                            Address address = new Address(Convert.ToInt32(reader["ad.id"]), reader[7].ToString(),
                                reader[8].ToString(),
                                reader[9].ToString(), reader[10].ToString(), reader[11].ToString());
                            Department department = new Department(Convert.ToInt32(reader[12]), reader[13].ToString(),
                                Convert.ToInt32(reader[14]));
                            Employee employee = new Employee(Convert.ToInt32(reader[0]), reader[1].ToString(),
                                reader[2].ToString(), Convert.ToInt32(reader[3]), reader[4].ToString(),
                                reader[5].ToString(), role, address, department);
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

        /// <summary>
        /// Adds an Employee to the database 
        /// </summary>
        /// <param name="employee">The employee you want to add to the database</param>
        public bool Insert(Employee employee)
        {
            string query =
                "INSERT INTO Employee(RoleId,DepartmentID,AddressID,Name,Email) values(@RoleId,@DepartmentID,@AddressID,@Name,@Email)";
            if (OpenConnection() == true)
            {
                using (SqlCommand command = new SqlCommand(query, Connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@RoleId", employee.Role.Id);
                        command.Parameters.AddWithValue("@DepartmentID", employee.Department.Id);
                        command.Parameters.AddWithValue("@AddressID", employee.Address.Id);
                        command.Parameters.AddWithValue("@Name", employee.Name);
                        command.Parameters.AddWithValue("@Email", employee.Email);
                        //TODO: ADD TELEFOONNUMMER TO DB
                        command.ExecuteNonQuery();
                        CloseConnection();
                        return true;
                    }
                    catch (SqlException exception)
                    {
                        MessageBox.Show(exception.Message);
                        CloseConnection();
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// Updates the values of an employee
        /// </summary>
        /// <param name="employee">The new employee</param> 
        /// <param name="id">the id of the employee that needs to be updates</param>
        public void Update(Employee employee, int id)
        {
            string query ="Update Employee SET RoleId = @RoleId, DepartmentID = @DepartmentID ,AddressID = @AddressID ,Name = @Name ,Email = @Email WHERE ID = @Id";

            if (OpenConnection() == true)
            {
                using (SqlCommand command = new SqlCommand(query, Connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@RoleId", employee.Role.Id);
                        command.Parameters.AddWithValue("@DepartmentID", employee.Department.Id);
                        command.Parameters.AddWithValue("@AddressID", employee.Address.Id);
                        command.Parameters.AddWithValue("@Name", employee.Name);
                        command.Parameters.AddWithValue("@Email", employee.Email);
                        command.Parameters.AddWithValue("@Id", id);
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException exception)
                    {
                        MessageBox.Show(exception.Message);
                    }

                }

            }
            CloseConnection();
        }

        /// <summary>
        /// Removes an Employee from the database 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id)
        {
            string query = "Delete FROM TaskExecution where employeeId = @id  Delete FROM account where employeeId = @id  DELETE FROM Employee WHERE id = @Id";
            if (OpenConnection() == true)
            {
                using (SqlCommand command = new SqlCommand(query, Connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        command.ExecuteNonQuery();
                        return true;
                    }
                    catch (SqlException exception)
                    {
                        MessageBox.Show(exception.Message);
                        return false;
                    }

                }

            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Gets an employee from the database
        /// </summary>
        /// <param name="id">The is of the employee you need from the database</param>
        /// <returns></returns>
        public Employee GetById(int id)
        {
            Employee employee = null;
            string query = $"select e.id as empID,ac.Username,e.email,ac.RFIDCode,e.name as empName, ac.Password,r.Name,r.Id,ad.id AS addressID,StreetName,ad.City,ad.Country,ad.ZIPCode,ad.HouseNumber,d.id as deptID,d.Name as deptName,d.AuthorisationLevel from Employee e  inner join Address ad on e.AddressID = ad.id inner join Account ac on ac.EmployeeID = e.id inner join Department d on d.ID = e.DepartmentID inner join role r on r.id = e.roleid where e.id = @myId";
            if (OpenConnection() == true)
            {
                using (SqlCommand command = new SqlCommand(query, Connection))
                {
                    command.Parameters.AddWithValue("@myId", id); 

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        try
                        {
                            while (reader.Read())
                            {
                                Role role = new Role(Convert.ToInt32(reader["r.id"]), reader["r.Name"].ToString());
                                Address address = new Address(Convert.ToInt32(reader["addressID"]), reader["StreetName"].ToString(),reader["City"].ToString(),reader["Country"].ToString(), reader["ZIPCode"].ToString(), reader["HouseNumber"].ToString());
                                Department department = new Department(Convert.ToInt32(reader["deptID"]), reader["deptName"].ToString(),Convert.ToInt32(reader["AuthorisationLevel"]));
                                Employee SelectedEmployee = new Employee(Convert.ToInt32(reader["empID"]), reader["Username"].ToString(), reader["email"].ToString(), Convert.ToInt32(reader["RFIDCode"]), reader[4].ToString(),reader["empName"].ToString(),role ,address, department);
                                employee = SelectedEmployee;
                            }
                        }
                        catch (SqlException exception)
                        {
                            MessageBox.Show(exception.Message);
                        }
                    }
                    Connection.Close();
                    
                }
            }
            return employee;
        }
    }
} 
