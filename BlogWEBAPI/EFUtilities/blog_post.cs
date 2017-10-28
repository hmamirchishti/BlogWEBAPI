using System;
using System.Collections.Generic;

namespace BlogWEBAPI.EFUtilities
{
    public class blog_post
    {
        public int id { get; set; }
        public string title { get; set; }
        public string article { get; set; }
        public string file { get; set; }
        public blog_auther auther { get; set; }
        public DateTime date_published { get; set; }
        public string banner_image { get; set; }
        public Boolean featured { get; set; }
        public Boolean enabled { get; set; }
        public Boolean comments_enabled{ get; set; }
        public int views { get; set; }
        public blog_auther blog_auther { get; set; }
        public IList<blog_comment> blog_comments { get; set; }
        public List<blog_tag> blog_tags { get; set; }
        public List<blog_related> blog_relateds { get; set; }
        public ICollection<blog_category> blog_categories { get; set; }
    }
}