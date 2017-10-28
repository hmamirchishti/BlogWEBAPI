namespace BlogWEBAPI.EFUtilities
{
    public class blog_tag
    {
        public int id { get; set; }
        public string tag { get; set; }
        public blog_post blog_post { get; set; }
    }
}