using System;

namespace BlogApp.Entity
{
    public class Tag
    {
        public int TagId { get; set; }
        public string? Text { get; set; }


        // ilişkiler
        public List<Post> Posts {get;set;} = new List<Post>();
    }
}
