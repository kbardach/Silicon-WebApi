﻿using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Models
{
    public class SubscribeViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Prompt = "Your Email")]
        public string Email { get; set; } = null!;

        public bool DailyNewsletter { get; set; }
        public bool AdvertisingUpdates { get; set; }
        public bool WeekinReview { get; set; }
        public bool EventUpdates { get; set; }
        public bool StartupsWeekly { get; set; }
        public bool Podcasts { get; set; }
    }
}