using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eyect4rails.Classes;

namespace eyect4rails.IRepository
{
    public interface IEmployeeRepository
    {

        List<Employee> GetAll();

        Employee GetById(int id);

        bool Insert(Employee employee);

        void Update(Employee employee, int id);

        bool Delete(int id);
    }
}
