﻿using System.ComponentModel.DataAnnotations;

namespace CthulhuCampaignManager.Models
{
    public class SessionViewModel
    {
        public int Id { get; set; }
        public int CampaignId { get; set; }
        public DateOnly Date { get; set; }

        [Required(ErrorMessage = "A session must have some description!")]
        [StringLength(500, ErrorMessage = "Description is too long!")]
        public string Description { get; set; }
    }
}
