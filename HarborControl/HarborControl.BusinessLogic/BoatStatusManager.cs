using System;
using System.Collections.Generic;
using System.Text;
using HarborControl.Domains;

namespace HarborControl.BusinessLogic
{
    public class BoatStatusManager : IBoatStatusManager
    {
        private readonly IBoatStatusRepository _boatStatusRepository;


        public BoatStatusManager(IBoatStatusRepository boatStatusRepository)
        {
            _boatStatusRepository = boatStatusRepository;
        }


        public List<BoatStatuses> GetActiveStatuses()
        {
            try
            {
                return _boatStatusRepository.GetActiveStatuses();
            }
            catch (Exception)
            {
                return null;
            }
        }


        public BoatStatuses GetStatusesById(Guid Id)
        {
            try
            {
                return _boatStatusRepository.GetStatusesById(Id);
            }
            catch (Exception)
            {
                return null;
            }

        }

        public BoatStatuses GetStatusesCode(string code)
        {
            try
            {
                return _boatStatusRepository.GetStatusesCode(code);
            }
            catch (Exception)
            {
                return null;
            }

        }
    }
}
