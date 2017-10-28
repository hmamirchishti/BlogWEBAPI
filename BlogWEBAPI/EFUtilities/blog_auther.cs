using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogWEBAPI.EFUtilities
{
    public class blog_auther
    {
        public int id { get; set; }
        public string display_name { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public blog_post blog_post { get; set; }
    }
}