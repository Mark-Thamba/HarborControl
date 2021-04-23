using System;
using System.Collections.Generic;
using System.Text;
using HarborControl.Domains;

namespace HarborControl.BusinessLogic
{
    public class HarborQuesManager : IHarborQuesManager
    {

        private readonly IHarborQuesRepository _harborQuesRepository;
        private readonly IHarborManager _harborManager;
        private readonly IBoatTypeManager _boatTypeManager;
        private readonly IBoatStatusManager _boatStatusManager;
        private readonly IDockedBoatManager _dockedBoatManager;
        public HarborQuesManager(IHarborQuesRepository harborQuesRepository, IHarborManager harborManager, IBoatTypeManager boatTypeManager, IBoatStatusManager boatStatusManager, IDockedBoatManager dockedBoatManager)
        {
            _harborQuesRepository = harborQuesRepository;
            _harborManager = harborManager;
            _boatTypeManager = boatTypeManager;
            _boatStatusManager = boatStatusManager;
            _dockedBoatManager = dockedBoatManager;
        }
        public List<HarborQues> GetActiveHarborQues()
        {
            try
            {
                return _harborQuesRepository.GetActiveHarborQues();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public FeedBack CheckHarborQue()
        {
            var dockinBoat = _harborQuesRepository.GetHarborQueBoatByStatusCode(
                 _boatStatusManager.GetStatusesCode(
                     Constants.BoatStatusCodeDocking).Id);
            try
            {

                if (dockinBoat != null)
                {
                    var harbor = _harborManager.GetHarborByCode(Constants.HarborCodeDurban);

                    var speed = dockinBoat.BoatTypes.Speed;
                    var harborParamenter = harbor.Parameter;

                    var time = harborParamenter / speed;
                    DateTime dockingTime = (DateTime)dockinBoat.DockingTime;
                    var timeOnMove = dockingTime.AddHours(time);

                    if (timeOnMove < DateTime.Now)
                    {
                        dockinBoat.BoatStatusesId = _boatStatusManager.GetStatusesCode(Constants.BoatStatusCodeDocked).Id;
                        dockinBoat.ModifiedDate = DateTime.Now;
                        dockinBoat.Active = false;
                        if (_harborQuesRepository.UpdateHarborQue(dockinBoat))
                        {
                            _dockedBoatManager.AddDockedBoat(
                                new DockedBoats()
                                {
                                    Active = true,
                                    ArrivalTime = DateTime.Now,
                                    BoatStatusesId = _boatStatusManager.GetStatusesCode(Constants.BoatStatusCodeDocked).Id,
                                    Id = Guid.NewGuid(),
                                    BoatTypesId = dockinBoat.BoatTypesId,
                                    CreatedDate = DateTime.Now,
                                    ModifiedDate = DateTime.Now

                                });
                        }
                        return DockNextBoat();

                    }
                    else
                    {
                        return new FeedBack() { message = $"Boat type {dockinBoat.BoatTypes.BoatType} is currently Docking!" };

                    }

                }
                else
                {
                    return DockNextBoat();
                }
            }
            catch (Exception ex)
            {
                return new FeedBack() { Success = false, exception = ex ,message="error"};
            }

        }

        private FeedBack DockNextBoat()
        {
            try
            {
                var boatQueList = _harborQuesRepository.GetActiveHarborQues();
                if (boatQueList.Count > 0)
                {
                    var nextBoat = boatQueList[0];
                    nextBoat.DockingTime = DateTime.Now;
                    nextBoat.BoatStatusesId = _boatStatusManager.GetStatusesCode(Constants.BoatStatusCodeDocking).Id;
                    nextBoat.ModifiedDate = DateTime.Now;
                    var results = _harborQuesRepository.UpdateHarborQue(nextBoat);
                    return new FeedBack() { Success = true, message = "new boat is docking" };
                }
                return new FeedBack() { Success = false, message = "habor is empty" };

            }
            catch (Exception ex)
            {
                return new FeedBack() { Success = false, exception = ex };
            }

        }

        public HarborQues GetHarborQueById(Guid Id)
        {
            try
            {
                return _harborQuesRepository.GetHarborQueById(Id);
            }
            catch (Exception)
            {
                return null;
            }

        }

        public FeedBack AddNewBoatToQue()
        {

            try
            {
                var activeBoatList = _boatTypeManager.GetActiveBoatTypes();
                Random random = new Random();
                var boatIndex = random.Next(0, activeBoatList.Count - 1);
                var dateNow = DateTime.Now;

                var newBoat = new HarborQues()
                {
                    Id = Guid.NewGuid(),
                    ArrivalTime = dateNow,
                    BoatTypesId = activeBoatList[boatIndex].Id,
                    Active = true,
                    CreatedDate = dateNow,
                    ModifiedDate = dateNow,
                    BoatStatusesId = _boatStatusManager.GetStatusesCode(Constants.BoatStatusCodeOnQueue).Id,
                    HarborsId = _harborManager.GetHarborByCode(Constants.HarborCodeDurban).Id
                };

                return AddHarborQue(newBoat);
            }
            catch (Exception ex)
            {
                return new FeedBack() { Success = false, exception = ex };
            }
        }



        public FeedBack UpdateHarborQue(HarborQues harborQue)
        {
            try
            {

                _harborQuesRepository.UpdateHarborQue(harborQue);
                return new FeedBack() { Success = true };
            }
            catch (Exception ex)
            {
                return new FeedBack() { Success = false, exception = ex };
            }
        }

        public FeedBack AddHarborQue(HarborQues harborQue)
        {
            try
            {
                _harborQuesRepository.AddHarborQue(harborQue);
                return new FeedBack() { Success = true };
            }
            catch (Exception ex)
            {
                return new FeedBack() { Success = false, exception = ex };
            }
        }
    }
}
