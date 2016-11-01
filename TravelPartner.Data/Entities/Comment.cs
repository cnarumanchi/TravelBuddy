using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPartner.Data.Entities
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string CommentString { get; set; }

        public int PostId { get; set; }
        public Post post { get; set; }
    }
}
