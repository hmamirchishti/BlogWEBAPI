using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogWEBAPI.EFUtilities
{
    public class blog_comment
    {
        public int id { get; set; }
        public int post_id { get; set; }
        public int is_reply_to_id { get; set; }
        public string comment { get; set; }
        public int user_id { get; set; }
        public Boolean mark_read { get; set; }
        public Boolean enabled { get; set; }
        public DateTime date { get; set; }
        public blog_post blog_post { get; set; }
        public List<blog_user> blog_user { get; set; }
    }
}