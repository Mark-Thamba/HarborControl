using HarborControl.Domains;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HarborControl.Data
{
    public class EFBoatStatusRepository : IBoatStatusRepository
    {
        private readonly HarborControlContext _harborControlContext;
        public EFBoatStatusRepository(HarborControlContext harborControlContext)
        {
            _harborControlContext = harborControlContext;
        }
        public List<BoatStatuses> GetActiveStatuses()
        {
          return  _harborControlContext.BoatStatuses
                  .Where(c => c.Active == true)
                  .ToList();   
        }

        public BoatStatuses GetStatusesById(Guid Id)
        {
            return _harborControlContext.BoatStatuses
                  .Where(c => c.Id == Id)
                  .FirstOrDefault();
        }

        public BoatStatuses GetStatusesCode(string code)
        {
            return _harborControlContext.BoatStatuses
                  .Where(c => c.Code == code)
                  .FirstOrDefault();
        }
    }
}
