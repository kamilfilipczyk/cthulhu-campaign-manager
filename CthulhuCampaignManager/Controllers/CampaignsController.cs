using CthulhuCampaignManager.Domain.Data;
using Microsoft.AspNetCore.Mvc;

namespace CthulhuCampaignManager.Controllers
{
    public class CampaignsController : Controller
    {
        private readonly ApplicationDbContext _dbcontext;
        public CampaignsController(ApplicationDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
