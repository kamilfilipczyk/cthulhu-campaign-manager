using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CthulhuCampaignManager.Data
{
    [Table("PlayerCharacters")]
    public class PlayerCharacterEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        public int ProfessionId { get; set; }
        [Required]
        public string Description { get; set; }
        public string Status { get; set; }
        public int CampaignId { get; set; }
        public int PlayerId { get; set; }
    }
}
