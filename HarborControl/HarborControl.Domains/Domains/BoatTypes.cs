using System;
using System.Collections.Generic;
using System.Text;

namespace HarborControl.Domains
{
    public partial class BoatTypes : EntityBase
    {
        public BoatTypes()
        {
            HarborQues = new HashSet<HarborQues>();
            DockedBoats = new HashSet<DockedBoats>();
        }

        public string BoatType { get; set; }
        public double Speed { get; set; }

        public MesuringUnits MesuringUnits { get; set; }
        public Guid MesuringUnitsId { get; set; }


        public virtual ICollection<HarborQues> HarborQues { get; set; }
        public virtual ICollection<DockedBoats> DockedBoats { get; set; }



    }
}
