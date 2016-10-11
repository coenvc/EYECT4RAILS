using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eyect4rails.Enums;
using eyect4rails.IRepository;

namespace eyect4rails.Repositories.Repository
{
    class RoleRepository : IRoleRepository
    {
        private List<Role> RoleList = new List<Role>();

        /// <summary>
        /// This constructor fills the list with files
        /// It first makes the empty objects, then assigns values to them
        /// Lastly it adds them to the list.
        /// Please see the Role class for a more in-depth view on this
        /// </summary>
        public RoleRepository()
        {
            // Create the objects
            Role cleaner = new Role(1, "Cleaner");
            Role mechanic = new Role(1, "Mechanic");
            Role driver = new Role(1, "Driver");
            Role parkmanager = new Role(2, "Parkmanager");
            Role admin = new Role(3, "Admin");

            // Add objects to list
            RoleList.Add(cleaner);
            RoleList.Add(mechanic);
            RoleList.Add(driver);
            RoleList.Add(parkmanager);
            RoleList.Add(admin);
        }

        /// <summary>
        /// Simply returns the entire rolelist
        /// </summary>
        /// <returns></returns>
        public List<Role> GetAll()
        {
            return this.RoleList;
        }

        /// <summary>
        /// Scans through RoleList and seaches for a matching ID, then returns the role
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Role GetById(int id)
        {
            foreach (Role role in RoleList)
            {
                if (role.Id == id)
                {
                    return role;
                }
            }
            return null;
        }

        /// <summary>
        /// Scans through Rolelist and searches for a matching rolename, then returns the role
        /// </summary>
        /// <param name="rolename"></param>
        /// <returns></returns>
        public Role GetByRolename(string rolename)
        {
            foreach (Role role in RoleList)
            {
                if (role.RoleName == rolename)
                {
                    return role;
                }
            }
            return null;
        }

        /// <summary>
        /// Adds a new role to the list
        /// </summary>
        /// <param name="role">The role that needs to be added</param>
        /// <returns></returns>
        public bool Insert(Role role)
        {
            int roleListCount = RoleList.Count;
            RoleList.Add(role);
            return (roleListCount + 1) == RoleList.Count;
        }

        /// <summary>
        /// A method used to change an existing entry of Role
        /// </summary>
        /// <param name="id">ID of the object that you want to edit</param>
        /// <param name="role">The Role object with all of the new parameters that you want to assign.
        /// If a parameter is EMPTY it will also be EMPTY in the target</param>
        public void Update(int id, Role role)
        {
            foreach (Role selectedRole in RoleList)
            {
                if (selectedRole.Id == id)
                {
                    selectedRole.AuthLevel = role.AuthLevel;
                    selectedRole.SetRoleName(role.RoleName);
                }
            }
        }

        /// <summary>
        /// Removes a Role with the specified ID. Return True if the remove was succesful.
        /// </summary>
        /// <param name="id">the ID of the object that will be removed</param>
        /// <returns></returns>
        public bool Delete(int id)
        {
            // Count the numbers we Start with
            int roleListCount = RoleList.Count;

            // Search for the role and remove it
            foreach (Role role in RoleList)
            {
                if (role.Id == id)
                {
                    RoleList.Remove(role);
                }
            }

            // Compare what we started with with the current count (check if it worked)
            return (roleListCount - 1) == RoleList.Count;
        }
    }
}
