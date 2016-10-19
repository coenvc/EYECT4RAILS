using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eyect4rails.Classes;
using eyect4rails.IRepository;
using System.Data;
using System.Data.SqlClient;

namespace eyect4rails.Repositories
{
    class MSSQLTaskRepository: Database, ITaskRepository
    {
        /// <summary>
        /// Here the method is used with a query to get all existing Tasks from the database.
        /// </summary>
        public List<Task> GetAll()
        {
            //TODO:
            throw new NotImplementedException();
        }

        /// <summary>
        /// Here the method is used with a query to get a Task by it's ID number from the database.
        /// </summary>
        public Task GetById(int id)
        {
            //TODO:
            throw new NotImplementedException();
        }

        /// <summary>
        /// Here the method is used with a query to insert a new Task into the database.
        /// </summary>
        public bool Insert(Task task)
        {
            //TODO:
            throw new NotImplementedException();
        }

        /// <summary>
        /// Here the method is used with a query to update an existing Task into the database.
        /// </summary>
        public void Update(int id, Task task)
        {
            //TODO:
            throw new NotImplementedException();
        }

        /// <summary>
        /// Here the method is used with a query to delete an existing Task from the database.
        /// </summary>
        public bool Delete(int id)
        {
            //TODO:
            throw new NotImplementedException();
        }
    }
}
