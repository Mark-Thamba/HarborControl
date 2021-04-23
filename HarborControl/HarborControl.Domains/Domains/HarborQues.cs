using System;
using System.Collections.Generic;
using System.Text;

namespace HarborControl.Domains
{
   public partial class HarborQues:EntityBase
    {
        public HarborQues()
        {
           

        }

        public DateTime ArrivalTime { get; set; }
        public DateTime ? DockingTime { get; set; }
        public Guid? HarborsId { get; set; }
        public virtual Harbors Harbors { get; set; }

        public Guid? BoatStatusesId { get; set; }
        public BoatStatuses BoatStatuses { get; set; }

        public Guid BoatTypesId { get; set; }
        public BoatTypes BoatTypes { get; set; }




    }
}
