using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPartner.Data.Context;
using TravelPartner.Data.Entities;

namespace TravelPartner.Data.Repository
{
    public class PostsRepository
    {
        TravelPartnerContext context;

        public PostsRepository()
        {
            context = new TravelPartnerContext();
        }
        public bool InsertPost(Post post)
        {
            context.Posts.Add(post);
            context.SaveChanges();
            return true;
        }
        public List<Post> GetPosts()
        {
            return context.Posts.Select(x => x).ToList();
        }
    }
}
