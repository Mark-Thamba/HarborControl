using System;
using System.Collections.Generic;
using System.Text;

namespace HarborControl.Domains
{
    public interface IDockedBoatManager
    {
        bool AddDockedBoat(DockedBoats dockedBoat);
        List<DockedBoats> GetDockedBoats();
    }
}
