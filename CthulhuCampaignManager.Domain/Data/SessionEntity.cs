using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CthulhuCampaignManager.Domain.Data
{
    [Table("Sessions")]
    public class SessionEntity
    {
        [Key]
        [Column("SessionId")]
        public int Id { get; set; }
        public int CampaignId { get; set; }
        public DateTime Date { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }



        //relation one(campaign) to many(sessions)
        public CampaignEntity Campaign { get; set; }
    }
}
