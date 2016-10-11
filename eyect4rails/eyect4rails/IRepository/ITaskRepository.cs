using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eyect4rails.IRepository
{
    interface ITaskRepository
    {
        List<Task> GetAll();

        Task GetById(int id);

        bool Insert(Task task);

        void Update(int id, Task task);

        bool Delete(int id);

    }
}
