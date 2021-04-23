using System;
using System.Collections.Generic;
using System.Text;

namespace HarborControl.Domains
{
    public interface IMesuringUnitRepository
    {
        List<MesuringUnits> GetActiveMesuringUnits();
    }
}
