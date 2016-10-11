using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eyect4rails.Classes;
using eyect4rails.IRepository;

namespace eyect4rails.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        public List<Department> DepartmentList;

        /// <summary>
        /// All departments: SystemManagement, ParkManagement, Drivers, Cleaning, Mechanics
        /// Create DepartmentList
        /// Create Departments
        /// Add Departments to DepartmentList
        /// </summary>
        public DepartmentRepository()
        {
            DepartmentList = new List<Department>();
            
            Department department1 = new Department(1, "SystemManagement", 3);
            Department department2 = new Department(2, "ParkManagement", 2);
            Department department3 = new Department(3, "Drivers", 1);
            Department department4 = new Department(4, "Cleaning", 1);
            Department department5 = new Department(5, "Mechanics", 1);
            
            DepartmentList.Add(department1); DepartmentList.Add(department2);
            DepartmentList.Add(department3); DepartmentList.Add(department4);
            DepartmentList.Add(department5);
        }

        /// <summary>
        /// Gets all departments
        /// </summary>
        /// <returns>List of departments</returns>
        public List<Department> GetAll()
        {
            return DepartmentList;
        }

        /// <summary>
        /// Get department by id
        /// Loop through DepartmentList till right department is found
        /// </summary>
        /// <param name="id"></param>
        /// <returns>department object</returns>
        public Department GetById(int id)
        {
            foreach (Department department in DepartmentList)
            {
                if (id == department.Id)
                {
                    return department;
                }
            }
            return null;
        }

        /// <summary>
        /// Insert new department into DepartmentList
        /// Checks if department is added
        /// </summary>
        /// <param name="department"></param>
        /// <returns>true when department added, false when department not added</returns>
        public bool Insert(Department department)
        {
            int countdepartments = DepartmentList.Count;
            DepartmentList.Add(department);
            if (countdepartments != DepartmentList.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Update department with new values
        /// </summary>
        /// <param name="department"></param>
        /// <param name="id"></param>
        public void Update(Department department, int id)
        {
            foreach (Department departments in DepartmentList)
            {
                if (id == departments.Id)
                {
                    departments.AuthLevel = department.AuthLevel;
                    departments.Name = department.Name;
                }
            }
        }

        /// <summary>
        /// Delete department from list by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>true if department deleted, false if department not deleted</returns>
        public bool Delete(int id)
        {
            int countdepartments = DepartmentList.Count;
            foreach (Department department in DepartmentList)
            {
                if (id == department.Id)
                {
                    DepartmentList.Remove(department);
                }
            }
            if (countdepartments != DepartmentList.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
