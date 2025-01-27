using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CthulhuCampaignManager.Data
{
    [Table("Sessions")]
    public class SessionEntity
    {
        public int Id { get; set; }
        public int CampaignId { get; set; }
        public DateOnly Date { get; set; }
        public string Description { get; set; }
    }
}
