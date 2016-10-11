using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eyect4rails.Classes;

namespace eyect4rails.IRepository
{
    public interface IDepartmentRepository
    {
        List<Department> GetAll();

        Department GetById(int id);

        bool Insert(Department department);

        void Update(Department department, int id);

        bool Delete(int id);
    }
}
