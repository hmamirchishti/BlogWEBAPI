using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlogWEBAPI.EFUtilities
{
    public class blog_comment
    {
        public int id { get; set; }
        public string comment { get; set; }
        public Boolean mark_read { get; set; }
        public Boolean enabled { get; set; }
        public DateTime date { get; set; }
        public blog_user blog_user { get; set; }
        public blog_post blog_post { get; set; }
        [Key, Column(Order = 1)]
        public int blog_userid { get; set; }
        [Key, Column(Order = 2)]
        public int blog_postid { get; set; }
        
    }
}