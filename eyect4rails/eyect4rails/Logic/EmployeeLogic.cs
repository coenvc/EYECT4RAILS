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
         IEmployeeRepository IemployeeRepository;
        public EmployeeLogic(IEmployeeRepository iemployeerepository)
        {
            this.IemployeeRepository = iemployeerepository;
        }
        public List<Employee> GetAllEmployees()
        {
            return IemployeeRepository.GetAllEmployees();
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
