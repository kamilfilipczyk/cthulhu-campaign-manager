using System.ComponentModel.DataAnnotations;

namespace CthulhuCampaignManager.Data
{
    public class PlayerCharacterEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int ProfessionId { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public int CampaignId { get; set; }
        public int PlayerId { get; set; }
    }
}
