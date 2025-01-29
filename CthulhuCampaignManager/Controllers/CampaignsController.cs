using CthulhuCampaignManager.Domain.Data;
using CthulhuCampaignManager.Models;
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
        
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddNew()
        {
            return View();
        }
    }
}
