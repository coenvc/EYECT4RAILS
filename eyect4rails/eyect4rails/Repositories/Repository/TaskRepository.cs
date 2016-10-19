using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eyect4rails.Classes;
using eyect4rails.Enums;
using eyect4rails.IRepository;

namespace eyect4rails.Repositories
{
        public class TaskRepository : ITaskRepository
        {
            private List<Task> Tasklist;

            /// <summary>
            /// It's possible to instantiate some listitems in 
            /// this constructor to fill it with a list of files
            /// </summary>
            public TaskRepository()
            {
            Tasklist = new List<Task>();
                {
                    
                };
                //Tasklist.Add(new CleanTask(1, false, 1, DateTime.Now, "Small Cleaning Task Performed", DateTime.Today,
                //    "Everything seemed alright", CleanTaskType.SmallCleaning));
            }

            /// <summary>
            /// What this does is simply returning the whole Tasklist
            /// </summary>
            public List<Task> GetAll()
            {
                return Tasklist;
            }

            /// <summary>
            /// Returns one Task by ID from the Tasklist
            /// <param name="id">The ID of a specific record needs to be found</param>
            /// </summary>
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

            /// <summary>
            /// Inserts one Task object to the Tasklist
            /// <param name="task">The Task that needs to be added</param>
            /// </summary>
            public bool Insert(Task task)
            {
                int listcount = Tasklist.Count;
                Tasklist.Add(task);
                return listcount + 1 == Tasklist.Count;
            }

            /// <summary>
            /// Updates one Task by ID from the Tasklist
            /// with a new updated Task
            /// <param name="id">ID is needed to know which </param>
            /// <param name='task'></param>
            /// </summary>
            public void Update(int id, Task task)
            {
                foreach (Task selectedTask in Tasklist)
                {
                    if (selectedTask.Id == id)
                    {
                        selectedTask.Completed = task.Completed;
                        selectedTask.Employees = task.Employees;
                        selectedTask.Priority = task.Priority;
                        selectedTask.AddedDate = task.AddedDate;
                        selectedTask.Description = task.Description;
                        selectedTask.FinishTime = task.FinishTime;
                        selectedTask.Comment = task.Comment;
                    }
                }
            }

            /// <summary>
            /// What this does is simply deleting one object from Tasklist
            /// <param name ="id"></param>
            /// </summary>
            public bool Delete(int id)
            {
                foreach (Task task in Tasklist)
                {
                    if (task.Id == id)
                    {
                    Tasklist.Remove(task);
                        return true;
                    }
                }
                return false;
            }

        }
    }
