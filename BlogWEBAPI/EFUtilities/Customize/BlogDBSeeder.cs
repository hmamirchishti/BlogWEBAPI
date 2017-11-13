using BlogWEBAPI.EFUtilities.Customize.SeedingClasses;
using System.Data.Entity;

namespace BlogWEBAPI.EFUtilities
{
    public class BlogDBSeeder: DropCreateDatabaseIfModelChanges<BlogDBContext>
    {
        protected override void Seed(BlogDBContext context)
        {
            for (int i = 1; i <= 5; i++) { 
            var auther = SeedingData.GetAuther(i);
            var post = SeedingData.GetPost(i);
            var comment = SeedingData.GetComment(i);
            var user = SeedingData.GetUser(i);
            user.blog_comments.Add(comment);
            var related = SeedingData.GetRelated(i);
            var tag = SeedingData.GetBlogTag(i);
            post.blog_comments.Add(comment);
            post.blog_relateds.Add(related);
            post.blog_tags.Add(tag);
            post.blog_categories.Add(SeedingData.GetCategory(i+2));
            post.blog_relateds.Add(SeedingData.GetRelated(i+2));
            post.blog_tags.Add(SeedingData.GetBlogTag(i+2));
            auther.blog_posts.Add(post);
            context.blog_user.Add(user);
            context.blog_auther.Add(auther);
            }
            base.Seed(context);

        }
    }
}