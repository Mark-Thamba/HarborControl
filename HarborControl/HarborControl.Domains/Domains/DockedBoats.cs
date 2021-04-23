using System;
using System.Collections.Generic;
using System.Text;

namespace HarborControl.Domains
{
    public partial class DockedBoats:EntityBase
    {
        public DockedBoats()
        {
            
        }
        public DateTime ArrivalTime { get; set; }

        public Guid BoatTypesId { get; set; }
        public BoatTypes BoatTypes { get; set; }

        public Guid BoatStatusesId { get; set; }
        public BoatStatuses BoatStatuses { get; set; }
       
    }
}
