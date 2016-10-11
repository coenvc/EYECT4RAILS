using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eyect4rails.Enums;

namespace eyect4rails.Classes
{
    class CleanTask
    {
        public Enums.CleanTaskType CleanTaskType { get; set; }

        //public CleanTask(int id, bool completed, int priority, DateTime addeddate, string description, DateTime finishedtime, string comment, CleanTaskType cleantasktype):base (id, completed, priority, addeddate, description, finishedtime, comment)
        //{
        //    this.CleanTaskType = cleantasktype;
        //}
    }
}
