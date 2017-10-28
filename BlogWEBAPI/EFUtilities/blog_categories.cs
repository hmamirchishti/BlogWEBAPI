using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogWEBAPI.EFUtilities
{
    public class blog_category
    {
        public int id { get; set; }
        public string name { get; set; }
        public Boolean enabled { get; set; }
        public DateTime date_created { get; set; }
        public ICollection<blog_post> blog_post { get; set; }
    }
}