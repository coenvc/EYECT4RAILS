using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eyect4rails.Enums;

namespace eyect4rails.IRepository
{
    interface IRoleRepository
    {
        /// <summary>
        /// A method used to get a list of all roles
        /// </summary>
        /// <returns></returns>
        List<Role> GetAll();

        /// <summary>
        /// A method used to get one specific Role by its unique ID
        /// </summary>
        /// <param name="id">ID you are looking for</param>
        /// <returns></returns>
        Role GetById(int id);

        /// <summary>
        /// A method used to get one specific Role by its unique Name
        /// </summary>
        /// <param name="rolename">Role you are looking for</param>
        /// <returns></returns>
        Role GetByRolename(string rolename);

        /// <summary>
        /// A method used to add a new Role to the list of roles. Returns True is the add was succesful.
        /// </summary>
        /// <param name="role">The role you want to insert</param>
        /// <returns></returns>
        bool Insert(Role role);

        /// <summary>
        /// A method used to change an existing entry of Role
        /// </summary>
        /// <param name="id">ID of the object that you want to edit</param>
        /// <param name="role">The Role object with all of the new parameters that you want to assign.
        /// If a parameter is EMPTY it will also be EMPTY in the target</param>
        void Update(int id, Role role);

        /// <summary>
        /// Removes a Role with the specified ID. Return True if the remove was succesful.
        /// </summary>
        /// <param name="id">the ID of the object that will be removed</param>
        /// <returns></returns>
        bool Delete(int id);
    }
}
