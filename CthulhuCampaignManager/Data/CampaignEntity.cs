using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CthulhuCampaignManager.Data
{
    [Table("Campaigns")]
    public class CampaignEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime StartedAt { get; set; } = DateTime.UtcNow;
        public string Status { get; set; } = "Ongoing";
    }
}
