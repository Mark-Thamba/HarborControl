using HarborControl.Domains;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace HarborControl.Data
{
    public class EFBoatTypeRepository : IBoatTypeRepository
    {
        private readonly HarborControlContext _harborControlContext;
        public EFBoatTypeRepository(HarborControlContext harborControlContext)
        {
            _harborControlContext = harborControlContext;
        }

        public List<BoatTypes> GetActiveBoatTypes()
        {
           return _harborControlContext.BoatTypes
                .Where(c => c.Active == true)
                .ToList();
           
        }

      

        public BoatTypes GetBoatTypeById(Guid Id)
        {
            return _harborControlContext.BoatTypes
                .Where(c => c.Id == Id)
                .FirstOrDefault();

        }
    }
}
