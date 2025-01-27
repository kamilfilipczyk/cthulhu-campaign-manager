namespace CthulhuCampaignManager.Models
{
    public class CampaignViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartedAt { get; set; }
        public string Status { get; set; }
    }
}
