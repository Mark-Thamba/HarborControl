using System;
using System.Collections.Generic;
using System.Text;

namespace HarborControl.Domains
{
    public interface IBoatStatusRepository
    {
        List<BoatStatuses> GetActiveStatuses();
        BoatStatuses GetStatusesById(Guid Id);

        BoatStatuses GetStatusesCode(string code);

    }
}
