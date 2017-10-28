using System.Data.Entity;

namespace BlogWEBAPI.EFUtilities
{
    public class BlogDBContext: DbContext
    {
        public BlogDBContext() {
            Database.SetInitializer(new BlogDBSeeder());
        }
        public DbSet<blog_auther> blog_auther { get; set; }
        public DbSet<blog_category> blog_cateogry { get; set; }
        public DbSet<blog_comment> blog_comment { get; set; }
        public DbSet<blog_post> blog_post { get; set; }
        public DbSet<blog_related> blog_related { get; set; }
        public DbSet<blog_tag> blog_tag { get; set; }
        public DbSet<blog_user> blog_user { get; set; }

    }
}