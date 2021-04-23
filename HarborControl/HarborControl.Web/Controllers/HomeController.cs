using HarborControl.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using HarborControl.BusinessLogic;
using HarborControl.Domains;
using HarborControl.Web;

namespace HarborControl.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDockedBoatManager _dockingBoatManager;
        private readonly IHarborQuesManager _harborQuesManager;



        public HomeController(
            ILogger<HomeController> logger,
            IBoatStatusManager boatStatusManager,
           IDockedBoatManager dockingBoatManager,
           IBoatTypeManager boatTypeManager,
           IHarborManager harborManager,
           IMesuringUnitManager mesuringUnitManager,
           IHarborQuesManager harborQuesManager)
        {
            _logger = logger;
            _dockingBoatManager = dockingBoatManager;
            _harborQuesManager = harborQuesManager;

        }
        [HttpGet]
        public IActionResult HarborControl()
        {
            HarborControlViewModel harborControlViewModel = new HarborControlViewModel();

            harborControlViewModel.HarborQues= _harborQuesManager.GetActiveHarborQues();
            harborControlViewModel.DockingBoats = _dockingBoatManager.GetDockedBoats(); ;

            return View(harborControlViewModel);
           
        }

      
        public IActionResult CheckHarborQue()
        {
           var feedback=  _harborQuesManager.CheckHarborQue();
            if (feedback.exception == null)
            {
                return Json(feedback);
            }
            else
                return Json(new FeedBack() { Success = false, message = "Error on the system" });
          
        }
    
        
        public IActionResult AddNewBoat()
        {
            
            var feedback = _harborQuesManager.AddNewBoatToQue();

            if (feedback.Success)
            {
                TempData["message"] = "New Boat added";
                return RedirectToAction("HarborControl", "Home", new { area = "" });
            }
            else
            {
                TempData["message"] = "Error Adding New Boat";
                return View();
            }
        }

        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
