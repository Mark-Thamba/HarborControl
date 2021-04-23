using HarborControl.Domains;
using System;
using System.Collections.Generic;
using System.Text;

namespace HarborControl.BusinessLogic
{
    public class HarborManager : IHarborManager
    {

        private readonly IHarborRepository _harborRepository;

        public HarborManager(IHarborRepository harborRepository)
        {
            _harborRepository = harborRepository;
        }
        public List<Harbors> GetActiveHarbors()
        {
            try
            {
                return _harborRepository.GetActiveHarbors();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Harbors GetHarborByCode(string code)
        {
            try
            {
                return _harborRepository.GetHarborByCode(code);
            }
            catch (Exception)
            {
                return null;
            }

        }
    }
}

