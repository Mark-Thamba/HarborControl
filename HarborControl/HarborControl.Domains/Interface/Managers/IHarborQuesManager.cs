using System;
using System.Collections.Generic;
using System.Text;

namespace HarborControl.Domains
{
    public interface IHarborQuesManager
    {
        List<HarborQues> GetActiveHarborQues();
        HarborQues GetHarborQueById(Guid Id);
        
        FeedBack UpdateHarborQue(HarborQues harborQue);

        FeedBack AddHarborQue(HarborQues harborQue);
        FeedBack AddNewBoatToQue();
        FeedBack CheckHarborQue();
    }
}
