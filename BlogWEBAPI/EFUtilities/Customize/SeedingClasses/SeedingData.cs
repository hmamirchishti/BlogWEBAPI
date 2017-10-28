using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogWEBAPI.EFUtilities.Customize.SeedingClasses
{
    public class SeedingData
    {
        public static blog_auther GetAuther(int iteration)
        {
            return new blog_auther()
            {
                display_name = "Amir Sharif" + iteration,
                first_name = "Amir" + iteration,
                last_name = "Sharif" + iteration,
                blog_posts = new List<blog_post>() { }
            };
        }

        public static blog_comment GetComment(int iteration)
        {
            return new blog_comment
            {
                comment = "Comment " + iteration,
                mark_read = true,
                enabled = true,
                date = DateTime.Now
            };
        }
        public static blog_category GetCategory(int iteration) {
            return new blog_category() {
                name = "Category "+ iteration,
                enabled = true,
                date_created = DateTime.Now
            };
        }
        public static blog_related GetRelated(int iteration) {
            return new blog_related() { };
        }
        public static blog_tag GetBlogTag(int i) {
            return new blog_tag() {
                tag ="Tag "+i
            };    
                }
        public static blog_user GetUser(int i) {
            return new blog_user()
            {
                name = "Amir Sharif" + i,
                email = "email" + i + "@gmail.com",
                website = "www.website" + i + ".com",
                blog_comments = new List<blog_comment>()
            };
        }
        public static blog_post GetPost(int i) {
            return new blog_post() {
                title = "Title "+i,
                article = "An article is a word used to modify a noun, which is a person, place, object, or idea. Technically, an article is an adjective, which is any word that modifies a noun. Usually adjectives modify nouns through description, but articles are used instead to point out or refer to nouns. " + i,
                file = "File "+i,
                date_published = DateTime.Now,
                banner_image = "",
                featured = i % 2 == 0 ? true : false,
                enabled = i % 2 == 0 ? false : true,
                comments_enabled = true,
                views = i,
                blog_comments = new List<blog_comment>(),
                blog_tags = new List<blog_tag>(),
                blog_relateds = new List<blog_related>(),
                blog_categories = new List<blog_category>()
            };
        }
    }
}