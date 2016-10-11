using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eyect4rails.Classes;
using eyect4rails.IRepository;
using Task = System.Threading.Tasks.Task;

namespace eyect4rails.Logic
{
     public class TaskLogic : ITaskRepository, IEmployeeRepository
    {
        private ITaskRepository TaskRepository;
        private IEmployeeRepository EmployeeRepository;

        /// <summary>
        /// This Constructor is used to make sure this class is using the interfaces that need to be implemented
        /// to be able to work.
        /// </summary>
        public TaskLogic(ITaskRepository taskrepository, IEmployeeRepository employeerepository)
        {
            this.TaskRepository = taskrepository;
            this.EmployeeRepository = employeerepository;
        }

        /// <summary>
        /// All this method does is pass all the list content of Task to the Repository.
        /// </summary>
        public List<Task> GetAll()
        {
            return TaskRepository.GetAll();
        }

        /// <summary>
        /// What this method does is passing the information for 1 task ID to the repository.
        /// </summary>
        public Task GetById(int id)
        {
            return TaskRepository.GetById(id);
        }

        /// <summary>
        /// What this method does is passing the information that is entered for a Task to the repository.
        /// </summary>
        public bool Insert(Task task)
        {
            return TaskRepository.Insert(task);
        }

        /// <summary>
        /// What this method does is passing information that needs to be updated for Task to the repository.
        /// </summary>
        public void Update(int id, Task task)
        {
            TaskRepository.Update(id, task);
        }

        /// <summary>
        /// What this method does is passing information that needs to be deleted for Task to the repository.
        /// </summary>
        public bool Delete(int id)
        {
            return TaskRepository.Delete(id);
        }

        /// <summary>
        /// All this method does is pass all the list content of Employee to the Repository.
        /// </summary>
        public List<Employee> GetAllEmployees()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// What this method does is passing the information that is entered for Employee to the repository.
        /// </summary>
        public void InsertEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// What this method does is passing information that needs to be updated for Employee to the repository.
        /// </summary>
        public void UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// What this method does is passing information that needs to be deleted for Employee to the repository.
        /// </summary>
        public void DeleteEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// All this method does is pass all the list content of Employee to the Repository.
        /// </summary>
        List<Employee> IEmployeeRepository.GetAll()
        {
            return EmployeeRepository.GetAll();
        }

        /// <summary>
        /// What this method does is passing the information for 1 Employee ID to the repository.
        /// </summary>
        Employee IEmployeeRepository.GetById(int id)
        {
            return EmployeeRepository.GetById(id);
        }

        /// <summary>
        /// What this method does is passing the information that is entered for Employee to the repository.
        /// </summary>
        public bool Insert(Employee employee)
        {
            return EmployeeRepository.Insert(employee);
        }

        /// <summary>
        /// What this method does is passing information that needs to be updated for Employee to the repository.
        /// </summary>
        public void Update(Employee employee, int id)
        {
            EmployeeRepository.Update(employee, id);
        }
    }
}
