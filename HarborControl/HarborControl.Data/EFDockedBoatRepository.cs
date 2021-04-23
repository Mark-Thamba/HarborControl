using HarborControl.Domains;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HarborControl.Data
{
    public class EFDockedBoatRepository : IDockedBoatRepository
    {
        private readonly HarborControlContext _harborControlContext;

        public EFDockedBoatRepository(HarborControlContext harborControlContext)
        {
            _harborControlContext = harborControlContext;
        }
        public bool AddDockedBoat(DockedBoats dockedBoat)
        {
            _harborControlContext.DockedBoats.Add(dockedBoat) ;
            return _harborControlContext.SaveChanges() > 0;
        }

        public List<DockedBoats> GetDockedBoats()
        {
          return  _harborControlContext.DockedBoats
                .Where(c=>c.Active == true)
                .Include(c=>c.BoatStatuses)
                .Include(c=>c.BoatTypes)
                .ThenInclude(c=>c.MesuringUnits)
                .ToList();
        }
    }
}
