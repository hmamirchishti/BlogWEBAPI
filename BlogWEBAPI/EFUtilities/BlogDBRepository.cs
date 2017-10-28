using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace BlogWEBAPI.EFUtilities
{
    public sealed class BlogDBRepository
    {
        private static BlogDBContext dbcontext = new BlogDBContext();
        private static BlogDBRepository BlogdbRepository = null;
        private BlogDBRepository() {}
        public static BlogDBRepository blogdbRepository
        {
            get
            {
                if (BlogdbRepository == null)
                {
                    return new BlogDBRepository();
                }
                return BlogdbRepository;
            }
        }
        ////////////////////////Methods////////////////////////////////
        public List<blog_post> GetPosts() {
            return dbcontext.blog_post.ToList();
        }
    }
}