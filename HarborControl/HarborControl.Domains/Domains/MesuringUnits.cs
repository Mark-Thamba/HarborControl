using System;
using System.Collections.Generic;
using System.Text;

namespace HarborControl.Domains
{
    public partial class MesuringUnits : LookUpBase
    {
        public MesuringUnits()
        {
            BoatTypes = new HashSet<BoatTypes>();
            Harbors = new HashSet<Harbors>();
        }
        
        public virtual ICollection<BoatTypes> BoatTypes  { get;set;}
        public virtual ICollection<Harbors> Harbors { get; set; }

    }
}
