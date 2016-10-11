using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eyect4rails.Enums
{
    public class Role
    {
        private static int RoleId = 0;

        public int Id { get; private set; }
        public int AuthLevel { get; set; }
        public string RoleName { get; private set; }

        /// <summary>
        /// The CreateRole method fills the empty object with the given parameters. Most importantly it checks if the role is possible to have.
        /// This version of the constructor automatically assigns an ID, used when loading from a database;
        /// </summary>
        /// <param name="id">The ID that this Role will get</param>
        /// <param name="authLevel">The Authorisation level that someone with this role has</param>
        /// <param name="role">The role itself, as a job description</param>
        public Role(int id, int authLevel, string role)
        {
            this.Id = id;
            this.AuthLevel = authLevel;
            SetRoleName(role);
        }

        /// <summary>
        /// Constructor used for local objects, autocreates an ID
        /// </summary>
        /// <param name="authLevel"></param>
        /// <param name="role"></param>
        public Role(int authLevel, string role)
        {
            this.Id = RoleId;
            this.AuthLevel = authLevel;
            SetRoleName(role);

            RoleId++;
        }

        /// <summary>
        /// The SetRoleName method checks if the role is one that's possible
        /// if it is, the rolename is set to the object
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        public bool SetRoleName(string role)
        {
            if (role == "Cleaner" || role == "Mechanic" || role == "Driver" || role == "Parkmanager" || role == "Admin")
            {
                this.RoleName = role;
                return true;
            }
            return false;
        }

    }
}
