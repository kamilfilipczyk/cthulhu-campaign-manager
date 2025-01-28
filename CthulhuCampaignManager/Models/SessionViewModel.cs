using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CthulhuCampaignManager.Models
{
    public class SessionViewModel
    {
        [HiddenInput]
        public int Id { get; set; }
        public int CampaignId { get; set; }
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "A session must have some description!")]
        [StringLength(500, ErrorMessage = "Description is too long!")]
        public string Description { get; set; }
    }
}
