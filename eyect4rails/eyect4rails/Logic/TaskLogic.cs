using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eyect4rails.IRepository;

namespace eyect4rails.Logic
{
    class TaskLogic
    {
        private ITaskRepository Repository;

        public TaskLogic(ITaskRepository repository)
        {
            this.Repository = repository;
        }

        public List<Task> GetAll()
        {
            return Repository.GetAll();
        }

        public Task GetById(int id)
        {
            return Repository.GetById(id);
        }

        public bool Insert(Task task)
        {
            return Repository.Insert(task);
        }

        public void Update(int id, Task task)
        {
            Repository.Update(id, task);
        }

        public bool Delete(int id)
        {
            return Repository.Delete(id);
        }

    }
}
