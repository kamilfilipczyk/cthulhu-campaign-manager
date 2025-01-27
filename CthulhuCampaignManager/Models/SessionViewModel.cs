namespace CthulhuCampaignManager.Models
{
    public class SessionViewModel
    {
        public int Id { get; set; }
        public int CampaignId { get; set; }
        public DateOnly Date { get; set; }
        public string Description { get; set; }
    }
}
