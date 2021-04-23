using System;
using System.Collections.Generic;
using System.Text;

namespace HarborControl.Domains
{
    public interface IDockedBoatRepository
    {
        bool AddDockedBoat(DockedBoats dockedBoat);
        List<DockedBoats> GetDockedBoats();
    }
}
