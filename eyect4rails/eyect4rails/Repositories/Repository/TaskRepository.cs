using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eyect4rails.Classes;
using eyect4rails.Enums;
using eyect4rails.IRepository;
using Task = System.Threading.Tasks.Task;

namespace eyect4rails.Repositories
{
        class TaskRepository : ITaskRepository
        {
            private List<Task> Tasklist;
            private List<Task> TasklistFiltered;

            public TaskRepository()
            {
            //Tasklist = new List<Task>
            //{
            //    new CleaningTask(1, false, 1, DateTime.Now, "Small Cleaning Task Performed", DateTime.Today, "Everything seemed alright", CleanTaskType.SmallCleaning),
            //    new RepairTask(2, false, 3, DateTime.Now, "Test1234", DateTime.Today, "Test1234 comment", RepairTaskType.BigRepair, DateTime.MaxValue),
            //    new CleaningTask(3, true, 2, DateTime.Now, "Normale Schoonmaak", DateTime.Today, "schoonmaak goed verlopen", CleanTaskType.RegularCleaning)
            //};
        }

            public List<Task> GetAll()
            {
                return Tasklist;
            }

            public Task GetById(int id)
            {
                foreach (Task task in Tasklist)
                {
                    if (task.Id == id)
                    {
                        return task;
                    }
                }
                return null;
            }

            public bool Insert(Task task)
            {
                int listcount = Tasklist.Count;
                Tasklist.Add(task);
                return listcount + 1 == Tasklist.Count;
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
