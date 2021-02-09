using System;
using System.ComponentModel.DataAnnotations;

namespace CommunityPortal.Models.ViewModels
{
    public class CreatePostViewModel
    {

        public string Author { get; set; } //Change this to user when user model exists

        [Required]
        [StringLength(20000, MinimumLength = 1)]
        public string Body { get; set; }

        [Required]
        [StringLength(500, MinimumLength = 1)]
        public string Title { get; set; }

        //[Display(Name = "Set status")]
        public string Status { get; set; } // Published or draft - enum?

        public DateTime Date { get; set; }

        public CreatePostViewModel()
        {
        }
    }
}
