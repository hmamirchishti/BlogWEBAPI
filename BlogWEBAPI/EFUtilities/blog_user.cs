using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogWEBAPI.EFUtilities
{
    public class blog_user
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string website { get; set; }
        public IList<blog_comment> blog_comments { get; set; }
    }
}