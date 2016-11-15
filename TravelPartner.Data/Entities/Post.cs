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
        public DateTime FromDate { get; set; } //Jan 10 2016
        public string FromLocation { get; set; } //Londan
        public DateTime ToDate { get; set; } //Jan 20 2016
        public string ToLocation { get; set; } //Hyderabad
        public string Summary { get; set; }
        public string Body { get; set; } // I traveling to hyderabad sexy girls come with me to have fun
        //one to many with Comment Entity.
        public ICollection<Comment> Comments { get; set; }
    }
}
