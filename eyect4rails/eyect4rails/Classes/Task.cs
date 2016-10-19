using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eyect4rails.Classes
{
    public class Task
    { 
        public int Id { get; set; }
	    public bool Completed { get; set; }
        public Employee Employees { get; set; }
        public int Priority { get; set; }
        public DateTime AddedDate { get; set; }
        public string Description { get; set; }
        public DateTime FinishTime { get; set; }
        public string Comment { get; set; }

        /// <summary>
        /// This Constructor is used to get information out of the database, that's why ID is used in this constructor.
        /// </summary>
        public Task(int id,bool completed, Employee employee, int priority, DateTime addeddate, string description, DateTime finishtime, string comment)
        {
            this.Id = id;
            this.Completed = completed;
            this.Employees = employee;
            this.Priority = priority;
            this.AddedDate = addeddate;
            this.Description = description;
            this.FinishTime = finishtime;
            this.Comment = comment;
        }

        /// <summary>
        /// This Constructor is used to insert data into the database, that's why ID is not used in this constructor
        /// Because ID is auto-incremented.
        /// </summary>
        public Task(bool completed, Employee employee, int priority, DateTime addeddate, string description, DateTime finishtime, string comment)
        {
            this.Completed = completed;
            this.Employees = employee;
            this.Priority = priority;
            this.AddedDate = addeddate;
            this.Description = description;
            this.FinishTime = finishtime;
            this.Comment = comment;
        }
    }
}
