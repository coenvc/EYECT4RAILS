using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eyect4rails.Enums;
using eyect4rails.IRepository;

namespace eyect4rails.Logic
{
    class RoleLogic : IRoleRepository
    {
        /// <summary>
        /// The private variable Context will be used for all methods
        /// This can be any repository that has the IRoleRepository inheritance
        /// in our project this will be MSSQLRoleRepository and RoleRepository
        /// </summary>
        private IRoleRepository Context;
        
        /// <summary>
        /// We force the constructor to set the context right away
        /// </summary>
        /// <param name="context">the IRoleRepository that will be used in this instance</param>
        public RoleLogic(IRoleRepository context)
        {
            this.Context = context;
        }

        /// <summary>
        /// Asks the context for a list of all roles
        /// </summary>
        /// <returns></returns>
        public List<Role> GetAll()
        {
            return Context.GetAll();
        }

        /// <summary>
        /// Asks the context to scan through Rolelist and search for a matching ID, then returns the role
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Role GetById(int id)
        {
            return Context.GetById(id);
        }

        /// <summary>
        /// Asks the context to scan through Rolelist and search for a matching rolename, then return the requested role
        /// </summary>
        /// <param name="rolename"></param>
        /// <returns></returns>
        public Role GetByRolename(string rolename)
        {
            return Context.GetByRolename(rolename);
        }


        /// <summary>
        /// Asks the context to add a new role to the list
        /// </summary>
        /// <param name="role">The role that needs to be added</param>
        /// <returns></returns>
        public bool Insert(Role role)
        {
            return Context.Insert(role);
        }

        /// <summary>
        /// Asks the context to update an existing object
        /// </summary>
        /// <param name="id">ID of the object that you want to edit</param>
        /// <param name="role">The Role object with all of the new parameters that you want to assign.
        /// If a parameter is EMPTY it will also be EMPTY in the target</param>
        public void Update(int id, Role role)
        {
            Context.Update(id, role);
        }

        /// <summary>
        /// Asks the context to Delete and return true if it succeeded
        /// </summary>
        /// <param name="id">The role to delete</param>
        /// <returns></returns>
        public bool Delete(int id)
        {
            return Context.Delete(id);
        }
    }
}
