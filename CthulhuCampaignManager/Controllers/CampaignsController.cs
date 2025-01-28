using Microsoft.AspNetCore.Mvc;

namespace CthulhuCampaignManager.Controllers
{
    public class CampaignsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
