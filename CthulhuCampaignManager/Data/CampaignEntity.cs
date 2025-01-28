using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CthulhuCampaignManager.Data
{
    public enum Status
    {
        Ongoing,
        Paused,
        Ended,
        Aborted
    }

    [Table("Campaigns")]
    public class CampaignEntity
    {
        [Key]
        [Column("CampaignId")]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        [MaxLength(500)]
        public string Description { get; set; }

        [Column("Creation_date")]
        public DateTime CreationDate { get; set; } = DateTime.UtcNow;
        public Status Status { get; set; } = Status.Ongoing;


        //relation one(campaign) to many(sessions)
        public ICollection<SessionEntity> Sessions { get; set; }

        //relation one(campaign) to many(characters)
        public ICollection<PlayerCharacterEntity> PlayerCharacters { get; set; }
    }
}
