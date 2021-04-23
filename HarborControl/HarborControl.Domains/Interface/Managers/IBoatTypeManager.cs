using System;
using System.Collections.Generic;
using System.Text;

namespace HarborControl.Domains
{
    public interface IBoatTypeManager
    {
        List<BoatTypes> GetActiveBoatTypes();
        BoatTypes GetBoatTypeById(Guid Id);
        
    }
}
