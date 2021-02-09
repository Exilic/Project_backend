using System;

namespace CommunityPortal.Models
{
    public class Post
    {

        public int Id { get; set; }
        public string Author { get; set; } //Change this to user when user model exists
        public string Body { get; set; }
        public string Title { get; set; }
        public string Status { get; set; } // Published or draft - enum?
        public DateTime Date { get; set; }

        public Post()
        {
        }
    }
}
