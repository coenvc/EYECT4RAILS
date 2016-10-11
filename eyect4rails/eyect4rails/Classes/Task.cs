using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eyect4rails.Classes
{
    public abstract class Task
    { 
        public int Id { get; private set; }
	    public bool Completed { get; private set; }
        public List<Employee> Employees = new List<Employee>();
        public int Priority { get; private set; }
        public DateTime AddedDate { get; private set; }
        public string Description { get; private set; }
        public DateTime FinishTime { get; private set; }
        public string Comment { get; private set; }

        public Task(int id,bool completed, Employee employee, int priority, DateTime addeddate, string description, DateTime finishtime, string comment)
        {
            this.Id = id;
            this.Completed = completed;
            this.Priority = priority;
            this.AddedDate = addeddate;
            this.Description = description;
            this.FinishTime = finishtime;
            this.Comment = comment;
        }
    }
}
