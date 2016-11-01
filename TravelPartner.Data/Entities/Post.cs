using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPartner.Data.Entities
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public DateTime Timestamp { get; set; }
        public string Summary { get; set; }
        public string Body { get; set; }
        //one to many with Comment Entity.
        public ICollection<Comment> Comments { get; set; }
    }
}
