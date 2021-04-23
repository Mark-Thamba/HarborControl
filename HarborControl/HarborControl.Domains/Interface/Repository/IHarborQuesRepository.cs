using System;
using System.Collections.Generic;
using System.Text;

namespace HarborControl.Domains
{
 public   interface IHarborQuesRepository
    {
        List<HarborQues> GetActiveHarborQues();
        HarborQues GetHarborQueById(Guid Id);
        bool UpdateHarborQue(HarborQues harborQue);
        bool AddHarborQue(HarborQues harborQue);

        HarborQues GetHarborQueBoatByStatusCode(Guid boatStatusId);
    }
}
