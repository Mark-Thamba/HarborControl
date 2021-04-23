using System;
using System.Collections.Generic;
using System.Text;
using HarborControl.Domains;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HarborControl.Data
{
    public class EFHarborQuesRepository : IHarborQuesRepository
    {

        private readonly HarborControlContext _harborControlContext;

        public EFHarborQuesRepository(HarborControlContext harborControlContext)
        {
            _harborControlContext = harborControlContext;
        }

        public bool AddHarborQue(HarborQues harborQue)
        {
            _harborControlContext.HarborQues.Add(harborQue);
            return _harborControlContext.SaveChanges() > 0;
        }

        public List<HarborQues> GetActiveHarborQues()
        {
           return _harborControlContext.HarborQues
                .Include(c=>c.Harbors)
                .ThenInclude(c=>c.MesuringUnits)
                .Include(c=>c.BoatTypes)
                .ThenInclude(c=>c.MesuringUnits)
                .Where(c => c.Active == true)
                .OrderByDescending(c=>c.ArrivalTime)
                .Include(c=>c.BoatStatuses)
                .OrderBy(c=>c.ArrivalTime)
                .ToList();
        }

        public HarborQues GetHarborQueBoatByStatusCode(Guid boatStatusId)
        {
            return _harborControlContext.HarborQues
                .Include(c => c.Harbors)
                .ThenInclude(c => c.MesuringUnits)
                .Include(c => c.BoatTypes)
                .ThenInclude(c => c.MesuringUnits)
                .Include(c => c.BoatStatuses)
                .Where(c => c.BoatStatusesId == boatStatusId)
                .OrderBy(c=>c.ArrivalTime)
                .FirstOrDefault();
        }

        public HarborQues GetHarborQueById(Guid Id)
        {
            return _harborControlContext.HarborQues
                .Include(c => c.Harbors)
                .ThenInclude(c => c.MesuringUnits)
                .Include(c => c.BoatTypes)
                .ThenInclude(c => c.MesuringUnits)
                .Include(c=>c.BoatStatuses)
                .Where(c => c.Id == Id)
                .FirstOrDefault();
        }

        public bool UpdateHarborQue(HarborQues harborQue)
        {
            _harborControlContext.HarborQues.Update(harborQue);
            return _harborControlContext.SaveChanges() > 0;
        }
    }
}
