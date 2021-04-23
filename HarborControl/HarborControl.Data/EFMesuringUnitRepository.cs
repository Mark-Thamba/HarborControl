using HarborControl.Domains;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HarborControl.Data
{
    public class EFMesuringUnitRepository : IMesuringUnitRepository
    {
        private readonly HarborControlContext _harborControlContext;

        public EFMesuringUnitRepository(HarborControlContext harborControlContext)
        {
            _harborControlContext = harborControlContext;
        }
        public List<MesuringUnits> GetActiveMesuringUnits()
        {
           return _harborControlContext.MesuringUnits
                .Where(c => c.Active == true)
                .ToList();
        }
    }
}
