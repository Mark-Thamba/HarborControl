using System;
using System.Collections.Generic;
using System.Text;

namespace HarborControl.Domains
{
    public partial class Harbors:LookUpBase
    {
        public Harbors()
        {
            
        }

      //  public string HarborName { get; set; }
        public double Parameter { get; set; }

        public Guid MesuringUnitsId { get; set; }
        public MesuringUnits MesuringUnits { get; set; }
    }
}
