using HarborControl.Domains;
using System;
using System.Collections.Generic;
using System.Text;

namespace HarborControl.BusinessLogic
{
    public class BoatTypeManager : IBoatTypeManager
    {
        private readonly IBoatTypeRepository _boatTypeRepository;

        public BoatTypeManager(IBoatTypeRepository boatTypeRepository)
        {
            _boatTypeRepository = boatTypeRepository;
        }


        public List<BoatTypes> GetActiveBoatTypes()
        {
            try
            {
               return _boatTypeRepository.GetActiveBoatTypes();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

      

        public BoatTypes GetBoatTypeById(Guid Id)
        {
            try
            {
                return _boatTypeRepository.GetBoatTypeById(Id);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
