using System.ComponentModel.DataAnnotations;

namespace CthulhuCampaignManager.Data
{
    public class CampaignEntity
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartedAt { get; set; } = DateTime.UtcNow;
        public string Status { get; set; } = "Ongoing";
    }
}
