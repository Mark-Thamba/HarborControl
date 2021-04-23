using HarborControl.Domains;
using System;
using System.Collections.Generic;
using System.Text;

namespace HarborControl.BusinessLogic
{
    public class DockedBoatManager : IDockedBoatManager
    {
        private readonly IDockedBoatRepository _dockedBoatRepository;

        public DockedBoatManager(IDockedBoatRepository dockedBoatRepository)
        {
            _dockedBoatRepository = dockedBoatRepository;
        }
        public bool AddDockedBoat(DockedBoats dockedBoat)
        {
            try
            {
                return _dockedBoatRepository.AddDockedBoat(dockedBoat);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<DockedBoats> GetDockedBoats()
        {
            try
            {
                return _dockedBoatRepository.GetDockedBoats();
            }
            catch (Exception)
            {
                return null;
            }

        }
    }
}
