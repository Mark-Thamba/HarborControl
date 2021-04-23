using HarborControl.Domains;
using System;
using System.Collections.Generic;
using System.Text;

using System.Linq;

namespace HarborControl.Data
{
    public class EFHarborRepository : IHarborRepository
    {
        private readonly HarborControlContext _harborControlContext;

        public EFHarborRepository(HarborControlContext harborControlContext)
        {
            _harborControlContext = harborControlContext;
        }
        public List<Harbors> GetActiveHarbors()
        {
           return _harborControlContext.Harbors
                .Where(c => c.Active == true)
                .ToList();
        }

        public Harbors GetHarborByCode(string code)
        {
            return _harborControlContext.Harbors
                .Where(c => c.Code == code)
                .FirstOrDefault();
        }
    }
}
