using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eyect4rails.IRepository;

namespace eyect4rails.Repositories
{
    class MSSQLTaskRepository:ITaskRepository
    {
        public List<Task> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Task task)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Task task)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
