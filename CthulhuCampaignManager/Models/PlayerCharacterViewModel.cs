using CthulhuCampaignManager.Data;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CthulhuCampaignManager.Models
{
    public class PlayerCharacterViewModel
    {
        [HiddenInput]
        public int Id { get; set; }

        [Required(ErrorMessage = "A character must have a name!")]
        [StringLength(50, ErrorMessage = "Name is too long!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Age is required!")]
        public int Age { get; set; }
        public Profession Profession { get; set; }

        [Required(ErrorMessage = "Character must have some description!")]
        [StringLength(500, ErrorMessage = "Description is too long!")]
        public string Description { get; set; }
        public string Status { get; set; }
        public int CampaignId { get; set; }
        public int PlayerId { get; set; }
    }
}
