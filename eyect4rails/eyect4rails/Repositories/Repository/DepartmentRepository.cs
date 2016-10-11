using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eyect4rails.Classes;
using eyect4rails.IRepository;

namespace eyect4rails.Repository
{
    class DepartmentRepository : IDepartmentRepository
    {
        public List<Department> DepartmentList;

        public DepartmentRepository()
        {
            // Departments: SystemManagement, ParkManagement, Drivers, Cleaning, Mechanics
            DepartmentList = new List<Department>();
            DepartmentList.Add(new Department(1, "SystemManagement", 3));
            DepartmentList.Add(new Department(2, "ParkManagement", 2));
            DepartmentList.Add(new Department(3, "Drivers", 1));
            DepartmentList.Add(new Department(4, "Cleaning", 1));
            DepartmentList.Add(new Department(5, "Mechanics", 1));
        }

        public List<Department> GetAll()
        {
            return DepartmentList;
        }

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

        public bool Insert(Department department)
        {
            int aantaldepartments = DepartmentList.Count;
            DepartmentList.Add(department);
            if (aantaldepartments != DepartmentList.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Update(Department department, int id)
        {
            foreach (Department departments in DepartmentList)
            {
                if (id == departments.Id)
                {
                    // Change AuthLevel
                    departments.AuthLevel = department.AuthLevel;
                    // Change Name
                    departments.Name = department.Name;
                }
            }
        }

        public bool Delete(int id)
        {
            int aantaldepartments = DepartmentList.Count;
            foreach (Department department in DepartmentList)
            {
                if (id == department.Id)
                {
                    DepartmentList.Remove(department);
                }
            }
            if (aantaldepartments != DepartmentList.Count)
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
