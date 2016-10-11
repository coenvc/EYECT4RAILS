using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eyect4rails.Classes;
using eyect4rails.IRepository;

namespace eyect4rails.Logic
{
    class EmployeeLogic:IEmployeeRepository
    {
        private IEmployeeRepository IemployeeRepository;
        public EmployeeLogic(IEmployeeRepository iemployeerepository)
        {
            this.IemployeeRepository = iemployeerepository;
        }

        /// <summary>
        /// Adds an employee to the EmployeeRepository 
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public bool Insert(Employee employee)
        {
            if (IemployeeRepository.Insert(employee) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Updates an employee in the EmployeeRepository 
        /// </summary>
        /// <param name="employee">The new Instance of the Employee</param> 
        /// <param name="id"
        public void Update(Employee employee, int id)
        {
            IemployeeRepository.Update(employee, id);
        }

        /// <summary>
        /// Deletes an employee in the EmployeeRepository
        /// with the given id
        /// </summary>
        /// <param name="id">The id of the user that will be deleted</param>
        public bool Delete(int id)
        {
            if (IemployeeRepository.Delete(id) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Gets alle employees in the database 
        /// </summary>
        /// <returns>A list of Employees</returns>
        public List<Employee> GetAll()
        {
            List<Employee> allEmployees = IemployeeRepository.GetAll();
            
            return allEmployees;
        }

        /// <summary>
        /// Gets an employee from the repository by the given id 
        /// </summary>
        /// <param name="id">Id of the requested employee</param>
        /// <returns></returns>
        public Employee GetById(int id)
        { 
            Employee returnEmployee = IemployeeRepository.GetById(id);

            return returnEmployee;
        }







    }
}
