using System;
using System.Collections.Generic;
using System.Text;

namespace HarborControl.Domains
{
   public interface IMesuringUnitManager
    {
        List<MesuringUnits> GetActiveMesuringUnits();
    }
}
