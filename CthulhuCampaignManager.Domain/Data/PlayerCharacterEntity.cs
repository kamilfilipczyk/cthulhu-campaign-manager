using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CthulhuCampaignManager.Domain.Data
{
    public enum Profession
    {
        Detective,
        PoliceOfficer,
        Archeologist
    }

    [Table("PlayerCharacters")]
    public class PlayerCharacterEntity
    {
        [Key]
        [Column("PlayerCharacterId")]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public int Age { get; set; }
        public Profession Profession { get; set; }

        [Required]
        [MaxLength(500)]
        public string Description { get; set; }
        public Status Status { get; set; }
        public int CampaignId { get; set; }

        //public int PlayerId { get; set; }


        //relation one(campaign) to many(characters)
        public CampaignEntity Campaign { get; set; }
    }
}
