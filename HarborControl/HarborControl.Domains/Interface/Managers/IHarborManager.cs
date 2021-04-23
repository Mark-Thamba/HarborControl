using System;
using System.Collections.Generic;
using System.Text;

namespace HarborControl.Domains
{
    public interface IHarborManager
    {
        List<Harbors> GetActiveHarbors();
        Harbors GetHarborByCode(string code);
        

    }
}
