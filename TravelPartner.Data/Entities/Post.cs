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
        public string Title { get; set; } //Traveling To hyderabad
        public DateTime Timestamp { get; set; }
        public string FromDate { get; set; } //Jan 10 2016
        public string FromLocation { get; set; } 
        public string ToDate { get; set; } //Jan 20 2016
        public string ToLocation { get; set; } //Hyderabad
        public string Summary { get; set; }
        public string Body { get; set; } 
        public ICollection<Comment> Comments { get; set; }
        public Login User { get; set; }
    }
}
