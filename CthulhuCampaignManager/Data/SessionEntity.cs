using System.ComponentModel.DataAnnotations;

namespace CthulhuCampaignManager.Data
{
    public class SessionEntity
    {
        public int Id { get; set; }
        public int CampaignId { get; set; }
        public DateOnly Date { get; set; }
        public string Description { get; set; }
    }
}
