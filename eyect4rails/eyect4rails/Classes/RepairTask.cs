using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eyect4rails.Enums;

namespace eyect4rails.Classes
{
    class RepairTask
    {
        public Enums.RepairTaskType RepairTaskType { get; set; }
        public DateTime EstimatedFinishTime { get; set; }

        //public RepairTask(int id, bool completed, int priority, DateTime addeddate, string description, DateTime finishedtime, string comment, RepairTaskType repairtasktype, DateTime estimatedfinishtime):base(id, completed, priority, addeddate, description, finishedtime, comment)
        //{
        //    this.RepairTaskType = repairtasktype;
        //    this.EstimatedFinishTime = estimatedfinishtime;
        //}

    }
}
