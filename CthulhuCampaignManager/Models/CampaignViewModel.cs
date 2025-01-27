using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CthulhuCampaignManager.Models
{
    public class CampaignViewModel
    {
        [HiddenInput]
        public int Id { get; set; }
        [Required(ErrorMessage = "Title is missing!")]
        [StringLength(100, ErrorMessage = "Title is too long!")]
        public string Title { get; set; }
        [Required(ErrorMessage = "A campaign must have a description!")]
        [StringLength(500, ErrorMessage = "Description is too long!")]
        public string Description { get; set; }
        public DateTime StartedAt { get; set; } = DateTime.UtcNow;
        public string Status { get; set; } = "Ongoing";
    }
}
