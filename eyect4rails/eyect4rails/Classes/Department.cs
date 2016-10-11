using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eyect4rails.Classes
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AuthLevel { get; set; }



        public Department(int id,string name, int authLevel)
        {
            this.Id = id;
            this.Name = name;
            this.AuthLevel = authLevel;
        }
    }
}
