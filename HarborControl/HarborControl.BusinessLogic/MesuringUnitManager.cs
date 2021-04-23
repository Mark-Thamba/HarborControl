using HarborControl.Domains;
using System;
using System.Collections.Generic;
using System.Text;

namespace HarborControl.BusinessLogic
{
    public class MesuringUnitManager : IMesuringUnitManager
    {
        private readonly IMesuringUnitRepository _mesuringUnitRepository;

        public MesuringUnitManager(IMesuringUnitRepository mesuringUnitRepository)
        {
            _mesuringUnitRepository = mesuringUnitRepository;
        }
        public List<MesuringUnits> GetActiveMesuringUnits()
        {
            try
            {
                return _mesuringUnitRepository.GetActiveMesuringUnits();
            }
            catch (Exception)
            {
                return null;
            }

        }
    }
}
